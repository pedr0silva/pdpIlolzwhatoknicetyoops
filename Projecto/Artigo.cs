using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto
{
    public class Artigo
    {
        private int codigo_de_artigo;
        public int Codigo_de_artigo
        {
            get { return codigo_de_artigo; }
            set { codigo_de_artigo = value; }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private float preco_unitario;
        public float Preco_unitario
        {
            get { return preco_unitario; }
            set { preco_unitario = value; }
        }

        private int em_stock;
        public int Em_stock
        {
            get { return em_stock; }
            set { em_stock = value; }
        }

        public Artigo(int cod, string desc, float preco_unitario, int stck)
        {
            this.codigo_de_artigo = cod;
            this.descricao = desc;
            this.preco_unitario = preco_unitario;
            this.em_stock = stck;
        }
    }
}
