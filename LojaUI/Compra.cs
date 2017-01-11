using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto
{
    public class Compra
    {
        public List<Artigo> Artigos_comprados { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }

        public Compra(string desc) //em x de ter quantidade na compra, faz mais sentido ter no artigo (perguntar a prof o q ela pretende).
        {
            this.Artigos_comprados = new List<Artigo>();
            this.Descricao = desc;
            this.Valor = 0.0f;
        }

        public float CalculaValorCompra(Compra comp)
        {
            for (int i = 0; i < comp.Artigos_comprados.Count(); i++)
            {
                comp.Valor += comp.Artigos_comprados[i].Preco_unitario * comp.Artigos_comprados[i].Quantidade;
            }
            return comp.Valor;
        }
    }
}
