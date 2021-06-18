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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Produtos.txt");
            string linha = sr.ReadLine();
            string[] auxLinha;
            
            while (linha != null)
            {
                auxLinha = linha.Split('|');

                listBoxProdutos.Items.Add(new Games(auxLinha[0], auxLinha[1], double.Parse(auxLinha[2])));

                linha = sr.ReadLine();
            }
            sr.Close();

            sr = new StreamReader("Clientes.txt");
            linha = sr.ReadLine();

            while (linha != null)
            {
                auxLinha = linha.Split(';');

                comboBoxClie.Items.Add(new Cliente(auxLinha[0], auxLinha[1], auxLinha[2], int.Parse(auxLinha[3]), int.Parse(auxLinha[4]), int.Parse(auxLinha[5], auxLinha[6])));

                linha = sr.ReadLine();
            }
            sr.Close();

            toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void listBoxProdutos_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxProdutos.SelectedItem != null)
            {
                Games gSelect = listBoxProdutos.SelectedItem as Games;

                listBoxCarrinho.Items.Add(gSelect);
                AtualizarValorCarrinho();
            }
        }

        private void adicionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormC f = new FormC(1);
            f.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void AtualizarValorCarrinho()
        {
            double valor = 0;
            double valorDeconto = 0;

            panelCBCliente.BackColor = Color.Transparent;

            foreach (Games g in listBoxCarrinho.Items)
            {
                valor += g.GetPreco();
            }
            
            if(comboBoxClie.SelectedItem != null)
            {
                labelValor.Text = "Total: " + valor + "€";
            }
            else
            {
                labelValor.Text = "Inserir cliente para calcular o total.";
                panelCBCliente.BackColor = Color.Red;
            }
        }

        private void comboBoxClie_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValorCarrinho();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxCarrinho.Items.Clear();
            labelValor.Text = "Total: ";
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBoxCarrinho.SelectedIndex >= 0)
            {
                listBoxCarrinho.Items.RemoveAt(listBoxCarrinho.SelectedIndex);
            }
        }

        private void listBoxCarrinho_MouseDown(object sender, MouseEventArgs e)
        {
            listBoxCarrinho.SelectedIndex = listBoxCarrinho.IndexFromPoint(e.Location);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listBoxCarrinho.SelectedIndex < 0)
            {
                e.Cancel = true;
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {  


        }
    }
}
