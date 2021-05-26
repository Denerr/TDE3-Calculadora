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
            double nominal, taxa, periodo, aux1, aux2, resultado;

            nominal = Double.Parse(txtNominal.Text);
            taxa = Double.Parse(txtTaxa.Text);
            periodo = Double.Parse(txtPeriodo.Text);

            


        }

        private void btnCalcular_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
