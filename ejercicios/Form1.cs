using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnconvertirconversores_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;

            de = cbodeconversores.SelectedIndex;
            a = cboaconversores.SelectedIndex;

            cantidad = double.Parse(txtcantidadconversores.Text);

            double[] monedas = {1, 0.92,7.86, 24.66, 8.75, 36.58, 535.14, 145.47, 0.79, 83.29};

            respuesta = monedas[a] / monedas[de] * cantidad;

            lblrespuestasconversores.Text = "Respuesta: " + Math.Round(  respuesta, 3 );


        }
    }
}
