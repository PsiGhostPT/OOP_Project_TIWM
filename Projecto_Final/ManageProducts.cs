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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        
        private void ManageProducts_Load(object sender, EventArgs e)
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

            toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
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

        private void adcionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateProduct FromCP = new CreateProduct();
            FromCP.Show();
        }

        private void modificarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyProduct FromMP = new ModifyProduct();
            FromMP.Show();
        }

        private void removerProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveProduct FromRP = new RemoveProduct();
            FromRP.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            listBoxProdutos.Items.Clear();
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
        }
    }
}
