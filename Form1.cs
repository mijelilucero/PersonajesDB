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

        private void buttonPrueba_Click(object sender, EventArgs e)
        {

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
            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelPoder);
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

        private void BuscarPorId()
        {
            int idPersonajeBuscar = int.Parse(textBoxID.Text);
            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeBuscar);
            if (personajeEncontrado.Rows.Count > 0)
            {
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                
                textBoxNombre.Text = nombre;
                comboBoxRaza.Text = raza;
                numericUpDownNivelPoder.Value = nivelPoder;
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
