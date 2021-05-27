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
            //MessageBox.Show("Abre uma tela de calculo!");
            Form2 f2 = new Form2();
            f2.ShowDialog();
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

        private void btnCapital_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Abre uma Janela de calculo de Capital");
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnCapital_MouseEnter(object sender, EventArgs e)
        {
            btnCapital.ForeColor = Color.Black;
            btnCapital.BackColor = Color.White;
            btnCapital.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnCapital_MouseLeave(object sender, EventArgs e)
        {
            btnCapital.ForeColor = Color.White;
            btnCapital.BackColor = Color.Transparent;
            btnCapital.FlatAppearance.BorderColor = Color.White;
        }

        private void btnTaxa_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Abre uma Janela de Calculo de Taxa");
            Form4 f4 = new Form4();
            f4.ShowDialog();
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

        private void btnTempo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Abre uma Janela de Calculo de Tempo");
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void btnTempo_MouseEnter(object sender, EventArgs e)
        {
            btnTempo.ForeColor = Color.Black;
            btnTempo.BackColor = Color.White;
            btnTempo.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnTempo_MouseLeave(object sender, EventArgs e)
        {
            btnTempo.ForeColor = Color.White;
            btnTempo.BackColor = Color.Transparent;
            btnTempo.FlatAppearance.BorderColor = Color.White;
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            Form6 desconto = new Form6();
            desconto.ShowDialog();
        }
    }
}
