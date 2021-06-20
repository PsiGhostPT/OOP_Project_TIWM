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
    public partial class CreateProduct : Form
    {
        public CreateProduct()
        {
            InitializeComponent();

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Games g = new Games(textBox_UID.Text, textBoxGame.Text, double.Parse(textBoxPrice.Text));
                StreamWriter sw = new StreamWriter("Produtos.txt", true);
                sw.WriteLine(g.TextoGameFile());
                sw.Close();
                this.Close();
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Erro: Campos vazios não são permitidos");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
