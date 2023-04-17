using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while(posicao >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                    txtPalavra2.Text.Substring(posicao+txtPalavra1.Text.Length,
                    txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);
            }
        }
    }
}
