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
    public partial class Lagrange : Form
    {
        public Lagrange()
        {
            InitializeComponent();
        }

        double x0 = 0.0, x1 = 0.0, x2 = 0.0, fx0 = 0.0;
        double fx1 = 0.0, fx2 = 0.0, x = 0.0;
        double relativo = 0.0, resultado = 0.0, resultado2 = 0.0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                x = Convert.ToDouble(txtx.Text);
                x1 = Convert.ToDouble(txtx1.Text);
                x0 = Convert.ToDouble(txtx0.Text);
                fx0 = Convert.ToDouble(txtfx0.Text);
                fx1 = Convert.ToDouble(txtfx1.Text);
                resultado = ((((x - x1) / (x0 - x1)) * fx0) + (((x - x0) / (x1 - x0)) * fx1));
                resultado = Math.Round(resultado, 4);
                txtf1x.Text = Convert.ToString(resultado);
            }
            else
            {
                x = Convert.ToDouble(txtx.Text);
                x1 = Convert.ToDouble(txtx1.Text);
                x0 = Convert.ToDouble(txtx0.Text);
                fx0 = Convert.ToDouble(txtfx0.Text);
                fx1 = Convert.ToDouble(txtfx1.Text);
                x2 = Convert.ToDouble(txtx2.Text);
                fx2 = Convert.ToDouble(txtfx2.Text);
                resultado = ((((x - x1) / (x0 - x1)) * ((x - x2) / (x0 - x2))) * fx0) + ((((x - x0) / (x1 - x0)) * ((x - x2) / (x1 - x2))) * fx1) + ((((x - x0) / (x2 - x0)) * ((x - x1) / (x2 - x1))) * fx2);
                resultado = Math.Round(resultado, 4);
                txtf2x.Text = Convert.ToString(resultado);
            }
            resultado = 0.0;
        }

        private void Lagrange_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double exacto = Convert.ToDouble(txtValorExacto.Text);
            if (radioButton1.Checked)
                relativo = Convert.ToDouble(txtf1x.Text);
            else
                relativo = Convert.ToDouble(txtf2x.Text);
            resultado2 = ((exacto - relativo) / exacto)*100;
            resultado2 = Math.Abs(resultado2);
            resultado2 = Math.Round(resultado2, 4);
            txtError.Text = resultado2.ToString() + "%";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblf2x.Enabled = true;
            lblfx2.Enabled = true;
            lblx2.Enabled = true;
            txtf2x.Enabled = true;
            txtfx2.Enabled = true;
            txtx2.Enabled = true;
            txtf1x.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblf2x.Enabled = false;
            lblfx2.Enabled = false;
            lblx2.Enabled = false;
            txtf2x.Enabled = false;
            txtfx2.Enabled = false;
            txtx2.Enabled = false;
        }
    }
}
