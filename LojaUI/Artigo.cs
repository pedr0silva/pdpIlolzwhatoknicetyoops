using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto
{
    public class Artigo
    {
        public int Codigo_de_artigo { get; set; }
        public string Descricao { get; set; }
        public float Preco_unitario { get; set; }
        public int Em_stock { get; set; }
        public int Quantidade { get; set; }

        //usado para criar um artigo novo em stock
        public Artigo(int cod, string desc, float preco_unitario, int stck)
        {
            this.Codigo_de_artigo = cod;
            this.Descricao = desc;
            this.Preco_unitario = preco_unitario;
            this.Em_stock = stck;
        }

        //usado para criar uma lista de compras
        public Artigo(int cod, float preco_unitario, int quantidade)
        {
            this.Codigo_de_artigo = cod;
            this.Preco_unitario = preco_unitario;
            this.Quantidade = quantidade;
        }
    }
}
