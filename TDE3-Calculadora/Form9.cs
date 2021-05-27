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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        double resultado;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //D / (n * (V − D))
            double desconto, nominal, periodo, aux1, aux2;

            desconto = Double.Parse(txtDesconto.Text);
            nominal = Double.Parse(txtNominal.Text);
            periodo = Double.Parse(txtPeriodo.Text);

            aux1 = (nominal - desconto);
            aux2 = (periodo * aux1);

            resultado = desconto / aux2;

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
            txtDesconto.Text = "";
            txtNominal.Text = "";
            txtPeriodo.Text = "";
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

        private void btnPorcento_Click(object sender, EventArgs e)
        {
            resultado = resultado * 100;

            txtResultado.Text = resultado.ToString("0.000") + "%";
        }

        private void btnPorcento_MouseEnter(object sender, EventArgs e)
        {
            btnPorcento.ForeColor = Color.White;
            btnPorcento.BackColor = Color.Transparent;
            btnPorcento.FlatAppearance.BorderColor = Color.White;
        }

        private void btnPorcento_MouseLeave(object sender, EventArgs e)
        {
            btnPorcento.ForeColor = Color.White;
            btnPorcento.BackColor = Color.Transparent;
            btnPorcento.FlatAppearance.BorderColor = Color.White;
        }
    }
}
