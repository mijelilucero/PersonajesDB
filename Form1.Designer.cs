﻿namespace ClaseFormsBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrueba = new System.Windows.Forms.Button();
            this.DataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.numericUpDownNivelPoder = new System.Windows.Forms.NumericUpDown();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.Location = new System.Drawing.Point(860, 545);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(212, 51);
            this.buttonPrueba.TabIndex = 0;
            this.buttonPrueba.Text = "Prueba de conexion";
            this.buttonPrueba.UseVisualStyleBackColor = true;
            this.buttonPrueba.Click += new System.EventHandler(this.buttonPrueba_Click);
            // 
            // DataGridViewPersonajes
            // 
            this.DataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPersonajes.Location = new System.Drawing.Point(31, 408);
            this.DataGridViewPersonajes.Name = "DataGridViewPersonajes";
            this.DataGridViewPersonajes.RowHeadersWidth = 62;
            this.DataGridViewPersonajes.RowTemplate.Height = 28;
            this.DataGridViewPersonajes.Size = new System.Drawing.Size(743, 253);
            this.DataGridViewPersonajes.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(860, 462);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(212, 52);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar datos";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Power:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(248, 44);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(208, 26);
            this.textBoxID.TabIndex = 7;
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(248, 112);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(208, 26);
            this.textBoxNombre.TabIndex = 8;
            // 
            // numericUpDownNivelPoder
            // 
            this.numericUpDownNivelPoder.Location = new System.Drawing.Point(248, 241);
            this.numericUpDownNivelPoder.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownNivelPoder.Name = "numericUpDownNivelPoder";
            this.numericUpDownNivelPoder.Size = new System.Drawing.Size(208, 26);
            this.numericUpDownNivelPoder.TabIndex = 10;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(170, 328);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(123, 38);
            this.buttonCrear.TabIndex = 11;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(248, 181);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(207, 28);
            this.comboBoxRaza.TabIndex = 12;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(519, 40);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(115, 34);
            this.buttonBuscar.TabIndex = 13;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 702);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.numericUpDownNivelPoder);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.DataGridViewPersonajes);
            this.Controls.Add(this.buttonPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrueba;
        private System.Windows.Forms.DataGridView DataGridViewPersonajes;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.NumericUpDown numericUpDownNivelPoder;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.Button buttonBuscar;
    }
}

