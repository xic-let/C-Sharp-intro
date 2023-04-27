using System;
using stocks;

namespace stocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();


            Console.WriteLine(" Digite o nome do Produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine(" Digite o Valor do Produto: ");
            Console.WriteLine("Valor: ");
            p.Valor = double.Parse(Console.ReadLine());

            /*Console.WriteLine(" Digite a Quantidade de Produto em Stock: ");
            Console.WriteLine("Produtos em Stock: ");
            p.QtS = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a Quantidade de Produto vendida: ");
            Console.WriteLine("Produtos Vendidos: ");
            p.QtV = int.Parse(Console.ReadLine());*/

            /*p.Stock = (p.QtS - p.QtV);

            Console.WriteLine("Dados de Produto:" + p.Nome +
                "Preço: " + p.Valor + " Quantidade a adicionar ao Stock:" +
                p.QtS + " Quantidade a remover ao Stock: " +
                p.QtV + ". Quantidade de Stock actualizada: " + p.Stock + ".");*/

            Console.WriteLine("Digite a quantidade de Produto a ser adicionada: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProduto(quantidade);

            Console.WriteLine("Digite a quantidade de Produto a ser removida: ");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProduto(quantidade);

            Console.WriteLine("Dados Actualizados:" + p);
        }
    }
}