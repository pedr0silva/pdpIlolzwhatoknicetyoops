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

        }
    }
}
