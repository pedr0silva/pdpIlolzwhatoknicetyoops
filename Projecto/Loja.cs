using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto
{
    public class Loja
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string morada;
        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        private string localidade;
        public string Localidade
        {
            get { return localidade; }
            set { localidade = value; }
        }

        private int codigo_da_loja;
        public int Codigo_da_Loja
        {
            get { return codigo_da_loja; }
            set { codigo_da_loja = value; }
        }


        private Dictionary<int,Artigo> dicionario_artigos;
        public Dictionary<int,Artigo> Dicionario_Artigos
        {
            get { return dicionario_artigos; }
            set { dicionario_artigos = value; }
        }

        private Dictionary<string,Cliente> dicionario_clientes;
        public Dictionary<string,Cliente> Dicionario_Clientes
        {
            get { return dicionario_clientes; }
            set { dicionario_clientes = value; }
        }

        int aux = 1;
        public Loja(string morada, string local)
        {
            this.nome = "SuperDume " + local;
            this.morada = morada;
            this.codigo_da_loja = aux;
            this.dicionario_artigos = new Dictionary<int, Artigo>();
            this.dicionario_clientes = new Dictionary<string, Cliente>();
            aux++;
        }
    }
}
