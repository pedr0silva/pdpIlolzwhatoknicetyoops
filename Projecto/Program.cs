using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                        // De Seguida Apresento-vos o "Menu" Para Duros !

                        int opcao = 0;

                        do
                        {
                            Console.WriteLine("1 - Gestão de Artigos Alimentares");
                            Console.WriteLine("2 - Cartão de Pontos");
                            Console.WriteLine("3 - Guardar Ficheiro (artigos e clientes)");
                            Console.WriteLine("4 - Carregar Ficheiro (artigos e clientes)");
                            Console.WriteLine("0 - Sair");

                            opcao = int.Parse(Console.ReadLine());

                            switch (opcao)
                            {
                                case 1:                        
                                    break;
                                case 2:                        
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    break;
                                default:
                                    break;
                            }

                        } while (opcao != 0);

                        // De Seguida Apresento-vos Como "Adicionar Novo Artigo" Para Duros!

                        Console.WriteLine("Código do artigo:");
                        int codigo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Descrição:");
                        string descricao = Console.ReadLine();

                        Console.WriteLine("Preço Unitário:");
                        float preco_unitario = float.Parse(Console.ReadLine());

                        Console.WriteLine("Quantidade em stock:");
                        int em_stock = int.Parse(Console.ReadLine());

                        Artigo A = new Artigo(codigo, descricao, preco_unitario, em_stock);
                        */

            
            Loja loj = new Loja("rua calhau", "Barcelos");
            Artigo a2 = new Artigo(324764, "cenas", 70.0f, 15);
            Artigo a = new Artigo(324764, 70.0f, 3);
            Compra comp = new Compra("3 coentros");
            Cliente cli = new Cliente("luis", "434234Z41", 193338421, "rua branca", 912312332, "banana@pessego.com");
            loj.Dicionario_Artigos.Add(a2.Codigo_de_artigo, a2);
            comp.Artigos_comprados.Add(a);
            loj.Dicionario_Clientes.Add(cli.CC, cli);
            cli.Cartao.Lista_de_compras.Add(comp);
            loj.CalculaValorCompra(comp);
            Console.WriteLine(cli.Cartao.Lista_de_compras[0].Valor);
            loj.AdicionaPontos(cli);
            Console.WriteLine(loj.Nome);
            Console.WriteLine(cli.Cartao.Pontos);
            loj.ActualizaStock(comp);
            Console.WriteLine(loj.Dicionario_Artigos[a2.Codigo_de_artigo].Em_stock);
            Console.ReadLine();
        }
    }
}

////-------------------------------DUVIDAS------------------------------////
////                                                                    ////
////Atualizar o stock.Dado o codigo de um artigo e a quantidade vendida,////
////pretende-se atualizar a quantidade em stock                         ////
////                                                                    ////
////____TEM DE RECEBER OBRIGATORIAMENTE UM ARTIGO E UMA QUANTIDADE??____////
////--------------------------------------------------------------------////
////                                                                    ////
////Cada compra efectuada por um cliente e registada no respectivo      ////
////cartao. Uma comprae identificada por um codigo de artigo, descricao,////
////quantidade e valor da compra;                                       ////
////                                                                    ////
////____OBRIGATORIO?? A NOSSA RESOLUCAO FAZ MAIS SENTIDO!? (OU NAO?)____////
////--------------------------------------------------------------------////
