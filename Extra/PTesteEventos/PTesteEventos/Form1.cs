using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }

        }

        private void txtEndereco_Validated(object sender, EventArgs e)
        {
            if((txtEndereco.Text == "") || (txtEndereco.Text.Length < 20)){
                MessageBox.Show("Nome Inválido");
                txtEndereco.Focus();
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(txtEmail.Text == "")
            {
                MessageBox.Show("E-mail vazio!");
                e.Cancel = true;
            }
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Celular perdeu o foco");
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("CPF: ganhou o foco");
        }
    }
}
