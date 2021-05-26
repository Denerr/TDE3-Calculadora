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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_MouseEnter(object sender, EventArgs e)
        {
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.BackColor = Color.White;
            btnVoltar.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            btnVoltar.ForeColor = Color.White;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.FlatAppearance.BorderColor = Color.White;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //t = (log(M / C)) / (log(1+ i))

            double montante, capital, taxa, resultado, log1, log2;

            montante = Double.Parse(txtMontante.Text);
            capital = Double.Parse(txtCapital.Text);
            taxa = Double.Parse(txtTaxa.Text);

            taxa = taxa / 100;
            log1 = Math.Log(montante / capital);
            log2 = Math.Log(1 + taxa);

            resultado = log1 / log2;

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
            txtMontante.Text = "";
            txtCapital.Text = "";
            txtTaxa.Text = "";
            txtResultado.Text = "";

            MessageBox.Show("Tudo Limpo!");
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
