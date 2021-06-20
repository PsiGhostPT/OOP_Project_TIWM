using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoFinal
{
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
        }
        private void Show_Load(object sender, EventArgs e)
        {
            {
                StreamReader sr = new StreamReader("Clientes.txt");
                string linha = sr.ReadLine();
                string[] auxLinha;

                while (linha != null)
                {
                    auxLinha = linha.Split(';');

                    listBoxCliente.Items.Add(new Cliente(int.Parse(auxLinha[0]), auxLinha[1], auxLinha[2], auxLinha[3], int.Parse(auxLinha[4]), int.Parse(auxLinha[5]), int.Parse(auxLinha[6])));


                    linha = sr.ReadLine();
                }
                sr.Close();

                toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxCliente_DoubleClick(object sender, EventArgs e)
        {
            listBoxBibloteca.Items.Clear();
            try
            {
                Cliente c = listBoxCliente.SelectedItem as Cliente;
                string path = "bilioteca" + c.GetID() + ".txt";
                StreamReader sr = new StreamReader(path);
                string linha = sr.ReadLine();
                string[] auxLinha;

                while (linha != null)
                {
                    auxLinha = linha.Split('|');

                    listBoxBibloteca.Items.Add(new Games(auxLinha[0], auxLinha[1], double.Parse(auxLinha[2])));

                    linha = sr.ReadLine();
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("O cliente nao possui nenhum produto na sua bibloteca");
            }
        }
    }
}
