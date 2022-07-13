﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CotizadorQuark.Controladores;

namespace CotizadorQuark
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelHistorialCotizaciones_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                Controller2 controller2 = new Controller2();
                controller2.MostrarCotizaciones(controller2.GetVendedor(), this);
                controller2.MostrarDatos(this);
            }
            catch (Exception)
            {
                MessageBox.Show("No existen comiciones que mostrar");
            }
        }
    }
}
