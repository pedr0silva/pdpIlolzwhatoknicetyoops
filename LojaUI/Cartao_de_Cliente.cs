using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto
{
    public class Cartao_de_Cliente
    {
        public List<Compra> Lista_de_compras { get; set; }
        public int Pontos { get; set; }

        public Cartao_de_Cliente()
        {
            this.Lista_de_compras = new List<Compra>();
            this.Pontos = 0;
        }
    }
}
