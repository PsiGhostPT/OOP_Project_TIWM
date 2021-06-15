using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinal
{
    class Cliente : Pessoa
    {
        private List<Games> produtosFav;

        public Cliente()
        {
            produtosFav = new List<Games>();
        }
        public Cliente(string nNome, string nEmail, string nCidade, int nDia, int nMes, int nAno)
        {
            SetNome(nNome);
            SetEmail(nEmail);
            SetCidade(nCidade);
            SetDataNasc(nDia,nMes,nAno);
            produtosFav = new List<Games>();
        }

        public List<Games> GetProdutosFav()
        {
            return produtosFav;
        }
        public void AdicionarProdFav(Games p)
        {
            produtosFav.Add(p);
        }

        public string TextoFicheiro()
        {
            return GetNome() + ";" + GetEmail() + ";" + GetCidade() + ";" + GetDataNasc().GetDia().ToString() + ";" + GetDataNasc().GetMes().ToString() + ";" + GetDataNasc().GetAno().ToString();
        }
        public override string ToString()
        {
            return GetNome();
        }
    }
}
