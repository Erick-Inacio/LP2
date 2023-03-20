using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra
{
    public partial class Form1 : Form
    {
        const double pi = 3.1415;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtVolume.Text = ((pi * (double.Parse(txtRaio.Text) * double.Parse(txtRaio.Text))) * double.Parse(txtAltura.Text)).ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
