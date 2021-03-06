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
    public partial class Form2 : Form
    {
        public Form2()
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
            double capital, taxa, tempo, resultado;

            capital = Double.Parse(txtCapital.Text);
            taxa = Double.Parse(txtTaxa.Text);
            tempo = Double.Parse(txtTempo.Text);

            taxa = taxa / 100;
            double aux = (1 + taxa);
            double poten = Math.Pow(aux , tempo);

            resultado = capital * poten;

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
            txtCapital.Text = "";
            txtTaxa.Text = "";
            txtTempo.Text = "";
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
