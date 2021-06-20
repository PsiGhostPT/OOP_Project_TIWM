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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        private void Menu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void gerirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage FormCMange = new Manage();
            FormCMange.Show();
        }

        private void criarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateClient FormCP = new CreateClient();
            FormCP.Show();
        }

        private void modificarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modify FormMC = new Modify();
            FormMC.Show();
        }

        private void removerClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Remove FormRC = new Remove();
            FormRC.Show();
        }

        private void gerirProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProducts FormPMange = new ManageProducts();
            FormPMange.Show();
        }

        private void criarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateProduct FormPC = new CreateProduct();
            FormPC.Show();
        }

        private void modificarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyProduct FormPM = new ModifyProduct();
            FormPM.Show();
        }

        private void removerProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveProduct FormPR = new RemoveProduct();
            FormPR.Show();
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show FromS = new Show();
            FromS.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_GerirCliente_Click(object sender, EventArgs e)
        {
            Manage FromBMC = new Manage();
            FromBMC.Show();
        }

        private void buttonManageProducts_Click(object sender, EventArgs e)
        {
            ManageProducts FromBMP = new ManageProducts();
            FromBMP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show FromBS = new Show();
            FromBS.Show();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
