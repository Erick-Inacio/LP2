using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("1º Semestre");
            listBox1.Items.Add("2ºSemestre");
            listBox1.Items.Add("3ºSemestre");
            listBox1.Items.Add("4ºSemestre");
            listBox1.Items.Add("5ºSemestre");
            listBox1.Items.Add("6ºSemestre");
            listBox1.Items.Add("7ºSemestre");
            listBox1.Items.Add("8ºSemestre");

            listBox1.SelectedIndex= 0; //deixa o primeiro pre-selecionado

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") // if (texteBox1.text==String.Empty
                MessageBox.Show("Nome vazio!","Teste",
                    MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);


            //if (checkbox1.checked)
            //    messagebox.show("turno manhã");
            //else
            //    messagebox.show("turno noite");

            if (checkBox1.CheckState==CheckState.Checked)
                MessageBox.Show("Matutino");
            else if (checkBox1.CheckState==CheckState.Indeterminate)
                MessageBox.Show("Turno Indeterminado");
            else
                MessageBox.Show("Turno Noite");

            if(comboBox1.SelectedIndex==-1)
                MessageBox.Show("Selecionar o Curso!");
            else
                MessageBox.Show("Curso:" + comboBox1.SelectedItem);

            DateTime dtTeste;

            if (DateTime.TryParse(maskedTextBox1.Text,out dtTeste))
                MessageBox.Show("Data: " + dtTeste.ToString("dd/MM/yyyy"));
            else
                MessageBox.Show("Data Inválida");

            if (radioButton2.Checked)
                    MessageBox.Show("Veio Transferido");
            else
                MessageBox.Show("Não veio Transferido");

            //for (var x=0;x < checkedListBox1.CheckedItems.Count;x++)
            //    MessageBox.Show(checkedListBox1.CheckedItems[x].ToString());


            string stringona = "";
            for (var x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                stringona = stringona + "\n" +checkedListBox1.CheckedItems[x].ToString();

            MessageBox.Show(stringona);
        }
    }
}
