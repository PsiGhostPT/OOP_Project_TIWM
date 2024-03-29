﻿using System;
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
        public Cliente(int nID,string nNome, string nEmail, string nCidade, int nDia, int nMes, int nAno)
        {
            SetID(nID);
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
        public void AdicionarProdFav(Games g)
        {
            produtosFav.Add(g);
        }

        public string TextoFicheiro()
        {
            return GetID() + ";" + GetNome() + ";" + GetEmail() + ";" + GetCidade() + ";" + GetDataNasc().GetDia().ToString() + ";" + GetDataNasc().GetMes().ToString() + ";" + GetDataNasc().GetAno().ToString();
        }
        public override string ToString()
        {
            return GetID() + " - " + GetNome();
        }
    }
}
