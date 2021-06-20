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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        
        private void Manage_Load(object sender, EventArgs e)
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

                comboBoxClie.Items.Add(new Cliente(int.Parse(auxLinha[0]), auxLinha[1], auxLinha[2], auxLinha[3], int.Parse(auxLinha[4]), int.Parse(auxLinha[5]), int.Parse(auxLinha[6])));

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
            CreateClient f = new CreateClient();
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
            Cliente c = comboBoxClie.SelectedItem as Cliente;

            string path = "bilioteca" + c.GetID() + ".txt";
            if (!File.Exists(path))
            {
                StreamWriter tw = File.CreateText(path);

                foreach (Games g in listBoxCarrinho.Items)
                {
                    string factMessage = "biblioteca" + c.GetID() + ".txt";
                    bool containsSearchResult = factMessage.Contains(g.GetUID());

                    if (containsSearchResult)
                    {
                        MessageBox.Show("Este produto já se encontra na sua biblioteca");
                    }
                    else
                    {
                        tw.WriteLine(g.GetUID() + "|" + g.GetNome() + "|" + g.GetPreco());
                    }
                }
                tw.Close();
            }
            else if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    int numjogos = listBoxCarrinho.Items.Count;

                    foreach (Games g in listBoxCarrinho.Items)
                    {
                        string factMessage = "biblioteca" + c.GetID() + ".txt";
                        bool containsSearchResult = factMessage.Contains(g.GetUID());

                        if (containsSearchResult)
                        {
                            MessageBox.Show("Este produto já se encontra na sua biblioteca");
                        }
                        else
                        {
                            tw.WriteLine(g.GetUID() + "|" + g.GetNome() + "|" + g.GetPreco());
                        }
                    }
                    tw.Close();
                }
                listBoxCarrinho.Items.Clear();
                comboBoxClie.Text = "";
            }

        }

        private void modificarClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify fm = new Modify();
            fm.Show();
        }

        private void removerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove fr = new Remove();
            fr.Show();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            comboBoxClie.Items.Clear();

            StreamReader sr = new StreamReader("Clientes.txt");
            string linha = sr.ReadLine();
            string[] auxLinha;

            while (linha != null)
            {
                auxLinha = linha.Split(';');

                comboBoxClie.Items.Add(new Cliente(int.Parse(auxLinha[0]), auxLinha[1], auxLinha[2], auxLinha[3], int.Parse(auxLinha[4]), int.Parse(auxLinha[5]), int.Parse(auxLinha[6])));
                linha = sr.ReadLine();
            }
            sr.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
