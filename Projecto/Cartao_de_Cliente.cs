using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto
{
    public class Cartao_de_Cliente
    {
        private Cliente c;
        public Cliente C
        {
            get { return c; }
            set { c = value; }
        }

        private List<Compra> lista_de_compras;
        public List<Compra> Lista_de_compras
        {
            get { return lista_de_compras; }
            set { lista_de_compras = value; }
        }

        private int pontos;
        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }

        public Cartao_de_Cliente(Cliente cliente)
        {
            this.c = cliente;
            this.lista_de_compras = new List<Compra>();
            this.pontos = 0;
        }



    }
}
