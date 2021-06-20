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
    public partial class RemoveProduct : Form
    {
        public RemoveProduct()
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
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

            if (comboBox_Produto.SelectedItem != null)
            {
                DialogResult perguntaR = MessageBox.Show("Tem a certeza que quere remover este produto?", "Confirmação", MessageBoxButtons.YesNo);
                StreamReader sr = new StreamReader("Produtos.txt");
                string linha = sr.ReadLine();
                Games g = comboBox_Produto.SelectedItem as Games;
                if (perguntaR == DialogResult.Yes)
                {
                    string strLineToDelete = g.GetUID().ToString();
                    string strSearchText = strLineToDelete;
                    string strOldText;
                    string n = "";
                    while ((strOldText = linha) != null)
                    {
                        if (!strOldText.StartsWith(strSearchText))
                        {
                            n += strOldText + Environment.NewLine;
                        }
                        linha = sr.ReadLine();
                    }
                    sr.Close();
                    File.WriteAllText("Produtos.txt", n);
                    this.Close();
                }
                else if (perguntaR == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("ERRO: Não ha nenhum Cliente selecionado. Por favor, Selecione um Cliente!");
            }

        }
    }
}
