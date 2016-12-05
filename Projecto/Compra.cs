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

        private float valor;
        public float Valor
        {
            get { return CalculaValorCompra(this); }
            set { valor = value; }
        }

        public Compra(string desc) //em x de ter quantidade na compra, faz mais sentido ter no artigo (perguntar a prof o q ela pretende).
        {
            this.artigos_comprados = new List<Artigo>();
            this.descricao = desc;
        }

        public float CalculaValorCompra(Compra comp)
        {
            for (int i = 0; i < comp.artigos_comprados.Count(); i++)
            {
                comp.valor += comp.artigos_comprados[i].Preco_unitario * comp.artigos_comprados[i].Quantidade;
            }
            return comp.valor;
        }
    }
}
