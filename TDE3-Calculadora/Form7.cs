using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDE3_Calculadora
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //D = (V x i x n) / (1+ i x n)
            double nominal, taxa, periodo, aux1, aux2, resultado;

            nominal = Double.Parse(txtNominal.Text);
            taxa = Double.Parse(txtTaxa.Text);
            periodo = Double.Parse(txtPeriodo.Text);

            taxa = taxa / 100;
            aux1 = (nominal * taxa * periodo);
            aux2 = (1 + taxa * periodo);

            resultado = aux1 / aux2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnCalcular_MouseEnter(object sender, EventArgs e)
        {
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.BackColor = Color.White;
            btnCalcular.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnCalcular_MouseLeave(object sender, EventArgs e)
        {
            btnCalcular.ForeColor = Color.White;
            btnCalcular.BackColor = Color.Transparent;
            btnCalcular.FlatAppearance.BorderColor = Color.White;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNominal.Text = "";
            txtTaxa.Text = "";
            txtPeriodo.Text = "";
            txtResultado.Text = "";
        }

        private void btnLimpar_MouseEnter(object sender, EventArgs e)
        {
            btnLimpar.ForeColor = Color.Black;
            btnLimpar.BackColor = Color.White;
            btnLimpar.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnLimpar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpar.ForeColor = Color.White;
            btnLimpar.BackColor = Color.Transparent;
            btnLimpar.FlatAppearance.BorderColor = Color.White;
        }
    }
}
