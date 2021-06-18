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
    public partial class FormC : Form
    {
        public FormC(int tipo)
        {
            InitializeComponent();

        }

        private void FormC_Load(object sender, EventArgs e)
        {

            this.Text = "Adicionar Cliente";
       
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            Cliente c = new Cliente(textBoxNome.Text, textBoxEmail.Text, textBoxCidade.Text, dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
            StreamWriter sw = new StreamWriter("Clientes.txt",true);
            sw.WriteLine(c.TextoFicheiro());
            sw.Close();
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
