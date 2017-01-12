using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaUI
{
    [Serializable]
    public class Loja
    {
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Localidade { get; set; }
        public int Codigo_da_Loja { get; set; }
        public Dictionary<int, Artigo> Dicionario_Artigos { get; set; }         //KEY = CODIGO
        public Dictionary<string, Cliente> Dicionario_Clientes { get; set; }    //KEY = CC DO CLIENTE
        public Dictionary<string, Compra> Dicionario_Compras { get; set; }      //KEY = 
        public Credencial Credencias { get; set; }

        private static int numero_de_lojas = 1;

        public Loja(string morada, string local)
        {
            this.Nome = "SuperDume " + local;
            this.Morada = morada;
            this.Codigo_da_Loja = numero_de_lojas;
            this.Dicionario_Artigos = new Dictionary<int, Artigo>();
            this.Dicionario_Clientes = new Dictionary<string, Cliente>();
            this.Dicionario_Compras = new Dictionary<string, Compra>();
            numero_de_lojas++;
            this.Credencias = new Credencial();
        }

        public void ActualizaStock(Compra comp)
        {
            for (int i = 0; i < comp.Artigos_comprados.Count(); i++)
            {
                if (Dicionario_Artigos.ContainsKey(comp.Artigos_comprados[i].Codigo_de_artigo))
                {
                    Dicionario_Artigos[comp.Artigos_comprados[i].Codigo_de_artigo].Em_stock -= comp.Artigos_comprados[i].Quantidade;    //Nesta situaçao o i é igual ao codigo de artigo, nao? (nao e dicionario though)
                }
            }
        }
        public void AdicionaArtigo(Artigo a)
        {
            if (Dicionario_Artigos.ContainsKey(a.Codigo_de_artigo))
            {
                throw new Exception("Artigo ja existente");
            }
            else
            {
                Dicionario_Artigos.Add(a.Codigo_de_artigo, a);
            }
        }
        public void AdicionaPontos(Cliente c)       //Nao devia estar na classe cliente?
        {
            for (float aux = c.Cartao.Lista_de_compras[c.Cartao.Lista_de_compras.Count() - 1].Valor; aux - 50 > 0; aux -= 50)   //pq count() - 1? Isto so trabalha 1 compra de cada vez certo?
            {
                c.Cartao.Pontos += 3;
            }
        }
        public void CalculaValorCompra(Compra comp)     //Nao devia estar na classe compra?
        {
            for (int i = 0; i < comp.Artigos_comprados.Count(); i++)
            {
                comp.Valor += comp.Artigos_comprados[i].Preco_unitario * comp.Artigos_comprados[i].Quantidade;
            }
        }
        public void ConsultarCompras(Cliente c)
        {
            string imprimeArtigos = "";
            for (int i = 0; i < c.Cartao.Lista_de_compras.Count(); i++)
            {
                for (int j = 0; j < c.Cartao.Lista_de_compras[i].Artigos_comprados.Count(); j++)
                {
                    Artigo art = c.Cartao.Lista_de_compras[i].Artigos_comprados[j];
                    imprimeArtigos += (i + 1)
                                   + " CODIGO: " + art.Codigo_de_artigo
                                   + " DESCRICAO: " + art.Descricao
                                   + " PRECO UNITARIO: " + art.Preco_unitario
                                   + " QUANTIDADE: " + art.Quantidade + "\n";

                }
                Console.WriteLine(imprimeArtigos + " VALOR DA COMPRA: " + c.Cartao.Lista_de_compras[i].Valor);
                imprimeArtigos = "";
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
            Console.WriteLine("VALOR TOTAL GASTO: " + somatorio + " PONTOS ACUMULADOS: " + c.Cartao.Pontos);
        }
        public void EliminaArtigo()
        {
            int i, opcao;
            for (i = 0; i < Dicionario_Artigos.Count(); i++)
            {
                Console.WriteLine((i + 1) + ": "
                    + Dicionario_Artigos[i].Codigo_de_artigo + "\t"
                    + Dicionario_Artigos[i].Descricao + "\t"
                    + Dicionario_Artigos[i].Preco_unitario + "\t"
                    + Dicionario_Artigos[i].Em_stock + "\n");
            }
            Console.Write("Escolha uma opcao para eliminar (0 para cancelar): ");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 0)
            {
                return;
            }
            Dicionario_Artigos.Remove(opcao - 1);
        }

        //Funcoes para forms 
        public void CriarCompraForm(Compra comp)
        {
            if(!Dicionario_Compras.ContainsKey(comp.Codigo_Compra))
            {
                Dicionario_Compras.Add(comp.Codigo_Compra, comp);
            }
            else
            {
                throw new Exception("Compra ja existe");
            }
        }
        public void EliminaCompraForm(string s)
        {
            if (Dicionario_Compras.ContainsKey(s))
            {
                Dicionario_Compras.Remove(s);
            }
            else
            {
                throw new Exception("Compra nao existe.");
            }
        }
        public void EliminaArtigoForm(string s)
        {
            if (Dicionario_Artigos.ContainsKey(int.Parse(s)))
            {
                Dicionario_Artigos.Remove(int.Parse(s));
            }
            else
            {
                throw new Exception("Artigo nao existe.");
            }
        }
        public void EliminaClienteForm(string s)
        {
            if (Dicionario_Clientes.ContainsKey(s))
            {
                Dicionario_Clientes.Remove(s);
            }
            else
            {
                throw new Exception("Cliente nao existe.");
            }
        }

    }
    [Serializable]
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

        public override string ToString()
        {
            return Descricao + ", " + Preco_unitario + "."; 
        }
    }
    [Serializable]
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
    [Serializable]
    public class Cliente
    {
        public string Nome { get; set; }
        public string CC { get; set; }
        public int Nif { get; set; }
        public string Morada { get; set; }
        public int Telemovel { get; set; }
        public string Email { get; set; }
        public Cartao_de_Cliente Cartao { get; set; }



        public Cliente(string nome, string cc, int NIF, string morada, int tlm, string email)
        {
            this.Nome = nome;
            this.CC = cc;
            this.Nif = NIF;
            this.Morada = morada;
            this.Telemovel = tlm;
            this.Email = email;
            this.Cartao = new Cartao_de_Cliente();
        }
    }
    [Serializable]
    public class Credencial
    {
        public bool CorrectPassword;
        public bool rememberMe;
        public string user;
        public string password;
        public Dictionary<string, string> userPass;

        public Credencial()
        {

        }

        public void FazUmaX()
        {
            userPass = new Dictionary<string, string>();
            userPass.Add("admin", "admin");
            userPass.Add("Daniela", "paradigmas");
        }
    }
    [Serializable]
    public class Compra
    {
        public string Codigo_Compra { get; set; }
        public Cliente OCliente { get; set; }
        public List<Artigo> Artigos_comprados { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }

        public Compra(string codigo, Cliente c, string desc) //em x de ter quantidade na compra, faz mais sentido ter no artigo (perguntar a prof o q ela pretende).
        {
            this.Artigos_comprados = new List<Artigo>();
            this.Descricao = desc;
            this.Valor = 0.0f;
            this.Codigo_Compra = codigo;
            this.OCliente = c;
        }
        public Compra()
        {
            Artigos_comprados = new List<Artigo>();
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
