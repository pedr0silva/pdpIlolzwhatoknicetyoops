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

        private Dictionary<int,Artigo> dicionario_artigos; //int e Key, sendo codigo de artigo
        public Dictionary<int,Artigo> Dicionario_Artigos
        {
            get { return dicionario_artigos; }
            set { dicionario_artigos = value; }
        }

        private Dictionary<string,Cliente> dicionario_clientes; //string e uma key, neste caso o cc
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
            this.codigo_da_loja = aux;          //NOT SURE IF THIS WORKS THOUGH.
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
                Console.WriteLine((i + 1) + ": "
                    + dicionario_artigos[i].Codigo_de_artigo + "\t"
                    + dicionario_artigos[i].Descricao + "\t"
                    + dicionario_artigos[i].Preco_unitario + "\t"
                    + dicionario_artigos[i].Em_stock + "\n");
            }
            Console.Write("Escolha uma opcao para eliminar (0 para cancelar): ");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 0)
            {
                return;
            }
            dicionario_artigos.Remove(opcao - 1);
        }

        public void ActualizaStock(Compra comp)
        {
            for (int i = 0; i < comp.Artigos_comprados.Count(); i++)
            {
                if (dicionario_artigos.ContainsKey(comp.Artigos_comprados[i].Codigo_de_artigo))
                {
                    dicionario_artigos[comp.Artigos_comprados[i].Codigo_de_artigo].Em_stock -= comp.Artigos_comprados[i].Quantidade;
                }
            }  
        }

        public void CalculaValorCompra(Compra comp)
        {
            for (int i = 0; i < comp.Artigos_comprados.Count(); i++)
            {
                comp.Valor += comp.Artigos_comprados[i].Preco_unitario * comp.Artigos_comprados[i].Quantidade;
            }
        }

        public void AdicionaPontos(Cliente c)
        {
            for (float aux = c.Cartao.Lista_de_compras[c.Cartao.Lista_de_compras.Count() - 1].Valor; aux - 50 > 0; aux -= 50)
            {
                c.Cartao.Pontos += 3;
            }
        }

        public void ConsultarCompras(Cliente c)
        {
            string imprimeartigos = "";
            for (int i = 0; i < c.Cartao.Lista_de_compras.Count(); i++)
            {
                for(int j = 0; j < c.Cartao.Lista_de_compras[i].Artigos_comprados.Count(); i++)
                {
                    Artigo art = c.Cartao.Lista_de_compras[i].Artigos_comprados[j];
                    imprimeartigos += i + 1 + " "
                                   + "CODIGO: " + art.Codigo_de_artigo + " "
                                   + "DESCRICAO: " + art.Descricao + " " 
                                   + "PRECO UNITARIO: " + art.Preco_unitario + " "
                                   + "QUANTIDADE: " + art.Quantidade + "\n";
                        
                }
                Console.WriteLine(imprimeartigos + " " + "VALOR DA COMPRA: " + c.Cartao.Lista_de_compras[i].Valor);
            }
        }

        public void ConsultarSaldo(Cliente c)
        {
            float somatorio = 0.0f;
            for (int i = 0; i < c.Cartao.Lista_de_compras.Count(); i++)
            {
                Compra comp = c.Cartao.Lista_de_compras[i];
                somatorio += comp.Valor;
            }
        Console.WriteLine("VALOR TOTAL GASTO: " + somatorio + " "
            + "PONTOS ACUMULADOS: " + c.Cartao.Pontos);
        }
    }
}
