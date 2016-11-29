using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto
{
    public class Compra
    {
        private List<Artigo> artigos_comprados;
        public List<Artigo> Artigos_comprados
        {
            get { return artigos_comprados; }
            set { artigos_comprados = value; }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        private float valor;
        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Compra(string desc) //TODO: o valor desta compra tem de ser igual ao preco unitario de cada artigo * a quantidade (desse artigo) comprada 
        {
            this.artigos_comprados = new List<Artigo>();
            this.descricao = desc;
            //this.quantidade = ;
            //this.valor = ;
        }




    }
}
