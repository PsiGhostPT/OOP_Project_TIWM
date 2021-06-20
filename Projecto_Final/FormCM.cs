using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectoFinal
{
    public partial class FormCM : Form
    {
        public FormCM()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("Clientes.txt");
            string linha = sr.ReadLine();
            string[] auxLinha;

            while (linha != null)
            {
                auxLinha = linha.Split(';');

                comboBox_Cliente.Items.Add(new Cliente(int.Parse(auxLinha[0]), auxLinha[1], auxLinha[2], auxLinha[3], int.Parse(auxLinha[4]), int.Parse(auxLinha[5]), int.Parse(auxLinha[6])));

                linha = sr.ReadLine();
            }
            sr.Close();

            buttonGuardar.Hide();
            buttonCancelar.Hide();
            textBoxID.Hide();
            textBoxNome.Hide();
            textBoxEmail.Hide();
            textBoxCidade.Hide();
            dateTimePicker1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label6.Hide();

        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            Cliente c = comboBox_Cliente.SelectedItem as Cliente;
            textBoxID.Text = c.GetID().ToString();
            textBoxNome.Text = c.GetNome();
            textBoxEmail.Text = c.GetEmail();
            textBoxCidade.Text = c.GetCidade();
            dateTimePicker1.Text = c.GetDataNasc().ToString();
            buttonGuardar.Show();
            buttonCancelar.Show();
            textBoxID.Show();
            textBoxNome.Show();
            textBoxEmail.Show();
            textBoxCidade.Show();
            dateTimePicker1.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Clientes.txt");
            string linha = sr.ReadLine();
            string[] auxLinha;

            while (linha != null)
            {
                auxLinha = linha.Split(';');
                if(textBoxID.Text == auxLinha[0])
                {
                    linha.Replace(auxLinha[1], textBoxNome.Text);
                    sr.Close();
                    StreamWriter sw = new StreamWriter("Clientes.txt", true);
                    sw.WriteLine()
                }
                linha = sr.ReadLine();
            }
            sr.Close();


            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
