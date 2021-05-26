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
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void btnMontante_MouseEnter(object sender, EventArgs e)
        {
            btnDesconto.ForeColor = Color.Black;
            btnDesconto.BackColor = Color.White;
            btnDesconto.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnMontante_MouseLeave(object sender, EventArgs e)
        {
            btnDesconto.ForeColor = Color.White;
            btnDesconto.BackColor = Color.Transparent;
            btnDesconto.FlatAppearance.BorderColor = Color.White;
        }

        private void btnNominal_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void btnNominal_MouseEnter(object sender, EventArgs e)
        {
            btnNominal.ForeColor = Color.Black;
            btnNominal.BackColor = Color.White;
            btnNominal.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnNominal_MouseLeave(object sender, EventArgs e)
        {
            btnNominal.ForeColor = Color.White;
            btnNominal.BackColor = Color.Transparent;
            btnNominal.FlatAppearance.BorderColor = Color.White;
        }

        private void btnTaxa_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }

        private void btnTaxa_MouseEnter(object sender, EventArgs e)
        {
            btnTaxa.ForeColor = Color.Black;
            btnTaxa.BackColor = Color.White;
            btnTaxa.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnTaxa_MouseLeave(object sender, EventArgs e)
        {
            btnTaxa.ForeColor = Color.White;
            btnTaxa.BackColor = Color.Transparent;
            btnTaxa.FlatAppearance.BorderColor = Color.White;
        }

        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }

        private void btnPeriodo_MouseEnter(object sender, EventArgs e)
        {
            btnPeriodo.ForeColor = Color.Black;
            btnPeriodo.BackColor = Color.White;
            btnPeriodo.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnPeriodo_MouseLeave(object sender, EventArgs e)
        {
            btnPeriodo.ForeColor = Color.White;
            btnPeriodo.BackColor = Color.Transparent;
            btnPeriodo.FlatAppearance.BorderColor = Color.White;
        }
    }
}
