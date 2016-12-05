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
            Artigo a = new Artigo(324764, 70.0f, 3);
            Compra comp = new Compra("3 coentros");
            Cliente cli = new Cliente("luis", "434234Z41", 193338421, "rua branca", 912312332, "banana@pessego.com");
            comp.Artigos_comprados.Add(a);
            cli.Cartao.Lista_de_compras.Add(comp);
            Console.WriteLine(cli.Cartao.Lista_de_compras[0].Valor);
            //daqui pra baixo n esta a dar?!?!?!?!?
            loj.AdicionaPontos(cli);
            Console.WriteLine(loj.Nome);
            Console.WriteLine(cli.Cartao.Pontos);
            Console.ReadLine();
        }
    }
}
