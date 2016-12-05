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
