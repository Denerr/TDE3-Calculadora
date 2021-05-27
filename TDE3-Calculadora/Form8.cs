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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //V = (D x (1+ i x n)) / (i x n)

            double desconto, taxa, periodo, aux1, aux2, resultado;

            desconto = Double.Parse(txtDesconto.Text);
            taxa = Double.Parse(txtTaxa.Text);
            periodo = Double.Parse(txtPeriodo.Text);

            taxa = taxa / 100;
            aux1 = (1 + taxa * periodo);
            aux2 = (taxa * periodo);

            resultado = (desconto * aux1) / aux2;

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
    }
}
