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
    public partial class ModifyProduct : Form
    {
        public ModifyProduct()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("Produtos.txt");
            string linha = sr.ReadLine();
            string[] auxLinha;

            while (linha != null)
            {
                auxLinha = linha.Split('|');

                comboBox_Produto.Items.Add(new Games(auxLinha[0], auxLinha[1], double.Parse(auxLinha[2])));

                linha = sr.ReadLine();
            }
            sr.Close();

            buttonGuardar.Hide();
            buttonCancelar.Hide();
            textBoxUID.Hide();
            textBoxNome.Hide();
            textBoxPreco.Hide();
            label1.Hide();
            label2.Hide();
            label6.Hide();

        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            Games g = comboBox_Produto.SelectedItem as Games;
            textBoxUID.Text = g.GetUID().ToString();
            textBoxNome.Text = g.GetNome();
            textBoxPreco.Text = g.GetPreco().ToString();
            buttonGuardar.Show();
            buttonCancelar.Show();
            textBoxUID.Show();
            textBoxNome.Show();
            textBoxPreco.Show();
            label1.Show();
            label2.Show();
            label5.Show();
            label6.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
            Games g = comboBox_Produto.SelectedItem as Games;
            string fileName = "Produtos.txt";
            File.WriteAllText(fileName, File.ReadAllText(fileName).Replace(g.GetUID() + "|" + g.GetNome() + "|" + g.GetPreco(), g.GetUID() + "|" + textBoxNome.Text + "|" + textBoxPreco.Text));
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
