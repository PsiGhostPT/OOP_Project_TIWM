using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Games
    {
        private string UID;
        private string nome;
        private double preco;

        public Games()
        {
            UID = "";
            nome = "";
            preco = 0;
        }
        public Games(string nUID,string nNome, double nPreco)
        {
            UID = nUID;
            nome = nNome;
            preco = nPreco;
        }

        public void SetUID(string nUID)
        {
            UID = nUID;
        }
        public string GetUID()
        {
            return UID;
        }

        public void SetNome(string nNome)
        {
            nome = nNome;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetPreco(double nPreco)
        {
            preco = nPreco;
        }

        public void SetPreco(string nPreco)
        {
            preco = double.Parse(nPreco);
        }

        public double GetPreco()
        {
            return preco;
        }

        public string TextoGameFile()
        {
            return UID + "|" + nome + "|" + preco;
        }
        public override string ToString()
        {
            return UID + "-" + nome + " - " + preco + " €";
        }
    }
}
