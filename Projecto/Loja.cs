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

        public void AdicionaArtigo(Artigo a)
        {
            if(dicionario_artigos.ContainsKey(a.Codigo_de_artigo))
            {
                throw new Exception("Artigo ja existente");
            }
            else
            {
                dicionario_artigos.Add(a.Codigo_de_artigo, a);
            }
        }

        public void EliminaArtigo()
        {
            int i, opcao;
            for (i = 0; i < dicionario_artigos.Count(); i++)
            {
                Console.WriteLine((i + 1) + ": " + dicionario_artigos[i].Codigo_de_artigo + "\t" + dicionario_artigos[i].Descricao + "\t" + dicionario_artigos[i].Preco_unitario + "\t" + dicionario_artigos[i].Em_stock);
            }
            Console.Write("Escolha uma opcao para eliminar (0 para cancelar): ");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 0)
            {
                return;
            }
            dicionario_artigos.Remove(opcao - 1);
        }

        public void AdicionaPontos(Cliente c)
        {
            for (int i = 1;  c.Cartao.Lista_de_compras[c.Cartao.Lista_de_compras.Count() - 1].Valor - 50 > 0; i++)
            {
                c.Cartao.Pontos += i * 3;
            }
        }

    }
}
