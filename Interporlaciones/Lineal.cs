using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interporlaciones
{
    public partial class Lineal : Form
    {
        public Lineal()
        {
            InitializeComponent();
        }
        double resultado;
        private void button1_Click(object sender, EventArgs e)
        {
            double fx = Convert.ToDouble(txtFX.Text);
            double fx0 = Convert.ToDouble(txtFX0.Text);
            double fx1 = Convert.ToDouble(txtFX1.Text);
            double x = Convert.ToDouble(txtx_.Text);
            double x0 = Convert.ToDouble(txtx_0.Text);
            double x1 = Convert.ToDouble(txtx_1.Text);


            resultado = (fx0) + ((fx1 - fx0) / (x1 - x0)) * (x - x0);

            txtResultado.Text = Convert.ToString(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fx = Convert.ToDouble(txtFX.Text);
            double error;
            error = ((fx - resultado) / (fx)) * 100;
            error = Math.Abs(error);
            error = Math.Round(error, 4);
            txtErrorAbs.Text = Convert.ToString(error);
        }
    }
}
