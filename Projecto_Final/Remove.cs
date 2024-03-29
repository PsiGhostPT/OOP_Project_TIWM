﻿using System;
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
    public partial class Remove : Form
    {
        public Remove()
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
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

            if (comboBox_Cliente.SelectedItem != null)
            {
                DialogResult perguntaR = MessageBox.Show("Tem a certeza que quere remover este cliente?", "Confirmação", MessageBoxButtons.YesNo);
                StreamReader sr = new StreamReader("Clientes.txt");
                string linha = sr.ReadLine();
                Cliente c = comboBox_Cliente.SelectedItem as Cliente;
                if (perguntaR == DialogResult.Yes)
                {
                    string strLineToDelete = c.GetID().ToString();
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
                    File.WriteAllText("Clientes.txt", n);
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
