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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMontante_Click(object sender, EventArgs e)
        {
            //Mensagem de Teste;
            MessageBox.Show("Abre uma tela de calculo!");
        }

        private void btnMontante_MouseEnter(object sender, EventArgs e)
        {
            btnMontante.ForeColor = Color.Black;
            btnMontante.BackColor = Color.White;
            btnMontante.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnMontante_MouseLeave(object sender, EventArgs e)
        {
            btnMontante.ForeColor = Color.White;
            btnMontante.BackColor = Color.Transparent;
            btnMontante.FlatAppearance.BorderColor = Color.White;
        }
    }
}
