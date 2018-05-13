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
    public partial class Cuadratica : Form
    {
        public Cuadratica()
        {
            InitializeComponent();
        }

        double b0= 0.0, b1= 0.0, b2= 0.0, x= 0.0, x0= 0.0, x1=0.0, x2=0.0, fx=0.0, fx0=0.0, fx1=0.0, fx2 = 0.0;

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtx.Text);
            fx0 = Convert.ToDouble(txtfx0.Text);
            fx1 = Convert.ToDouble(txtfx1.Text);
            fx2 = Convert.ToDouble(txtfx2.Text);
            x0 = Convert.ToDouble(txtx0.Text);
            x1 = Convert.ToDouble(txtx1.Text);
            x2 = Convert.ToDouble(txtx2.Text);

            b0 = Convert.ToDouble(txtfx0.Text);
            b1 = (fx1-fx0)/(x1-x0);
            b2 = (((fx2 - fx1) / (x2 - x1)) - b1) / (x2 - x0);
            fx = b0 + b1*(x-x0)+ b2*((x-x0)*(x-x1));

            txtb0.Text = Convert.ToString(b0);
            txtb1.Text = Convert.ToString(b1);
            txtb2.Text = Convert.ToString(b2);
            txtFx.Text = Convert.ToString(fx);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double exacto = Convert.ToDouble(txtValorExacto.Text);
            double error = ((exacto - fx) / exacto)*100;
            error = Math.Round(error, 4);
            error = Math.Abs(error);
            textBox5.Text = error.ToString();
        }
    }
}
