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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void btnMontante_Click(object sender, EventArgs e)
        {

        }

        private void btnMontante_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnMontante_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
