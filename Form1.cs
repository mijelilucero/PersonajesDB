using ClaseFormsBD.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseFormsBD
{
    public partial class Form1 : Form
    {
        private PersonajeDB personaje;

        // Lista de razas
        private string[] razasDragonBall = {
            "Android",
            "Bio-Android",
            "Humana",
            "Humano",
            "Majin",
            "Namekuseijin",
            "Saiyajin",
            "Saiyajin/Humano",
            "Saiyajin/Saiyajin"
        };


        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajeDB();
        }

   
        private void Form1_Load(object sender, EventArgs e)
        {
            if (personaje.ProbarConexion())
            {
                MessageBox.Show("Simoncito 👍👍👍");
            }
            else
            {
                MessageBox.Show("Nel Pastel 😢😢😢");
            }


            comboBoxRaza.Items.AddRange(razasDragonBall);
        }



        private void buttonCargar_Click(object sender, EventArgs e)
        {
            DataTable dt = personaje.LeerPersonajes();
            DataGridViewPersonajes.DataSource = dt;
        }



        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string raza = comboBoxRaza.Text;
            int nivelPoder = (int)numericUpDownNivelPoder.Value;
            DateTime fechaCreacion = dateTimePickerFecha_creacion.Value;
            string historia = textBoxHistoria.Text;

            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelPoder, fechaCreacion, historia);

            if (respuesta > 0)
            {
                MessageBox.Show("Creado con Exito 👍");
                DataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Algo hiciste mal 😢");
            }

        }



        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            int respuesta;
            int id = Int32.Parse(textBoxID.Text);
            string nombre = textBoxNombre.Text;
            string raza = comboBoxRaza.Text;
            int nivelPoder = (int)numericUpDownNivelPoder.Value;
            DateTime fechaCreacion = dateTimePickerFecha_creacion.Value;
            string historia = textBoxHistoria.Text;


            DialogResult resultado = MessageBox.Show("Estas seguro de que deseas actualizar este registro en la base de datos?", "Confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                respuesta = personaje.ActualizarPersonaje(id, nombre, raza, nivelPoder, fechaCreacion, historia);

                if (respuesta > 0)
                {
                    MessageBox.Show("Actualizado con Exito 👍");
                    DataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
                }
                else
                {
                    MessageBox.Show("Algo hiciste mal 😢");
                }
            }
            else
            {
                MessageBox.Show("Modificaciones no realizadas.");
            }
        }



        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int respuesta;
            int id = Int32.Parse(textBoxID.Text);

            DialogResult resultado = MessageBox.Show("Estas seguro de que deseas eliminar este registro en la base de datos?", "Confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                respuesta = personaje.EliminarPersonaje(id);

                if (respuesta > 0)
                {
                    MessageBox.Show("Eliminado con Exito 👍");
                    DataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
                }
                else
                {
                    MessageBox.Show("Algo hiciste mal 😢");
                }
            }
            else
            {
                MessageBox.Show("Registro no eliminado.");
            }
        }



        private void BuscarPorId()
        {
            int idPersonajeBuscar = int.Parse(textBoxID.Text);
            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeBuscar);
            
            if (personajeEncontrado.Rows.Count > 0)
            {
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                string fechaCreacion = personajeEncontrado.Rows[0]["fecha_creacion"].ToString();
                string historia = personajeEncontrado.Rows[0]["historia"].ToString();

                textBoxNombre.Text = nombre;
                comboBoxRaza.Text = raza;
                numericUpDownNivelPoder.Value = nivelPoder;
                dateTimePickerFecha_creacion.Text = fechaCreacion;
                textBoxHistoria.Text = historia;
            }
            else
            {
                MessageBox.Show("No se encontro codigo.");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            BuscarPorId();
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            BuscarPorId();
        }
    }
}
