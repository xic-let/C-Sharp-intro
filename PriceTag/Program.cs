using Product_descriptive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_descriptive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Products will be inserted?");
            int quantProd = int.Parse(Console.ReadLine());

            List<Product> Products = new List<Product>();

            for (int i = 1; i <= quantProd; i++) 
            {
                Console.WriteLine($"\n Product #{i}");

                Console.WriteLine("Insert Product Name: ");
                string name = Console.ReadLine();

                Console.WriteLine(" Insert price of sale: ");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("Type of Product:");
                Console.WriteLine("1 - Regular Product");
                Console.WriteLine("2 - Imported Product");
                Console.WriteLine("3 - Used Product");

                Console.WriteLine("Choose an Option: ");
                int tipeprod = int.Parse(Console.ReadLine());

                switch (tipeprod)
                {
                    case 1:
                        Products.Add(new Product(name, price));
                        break;
                    case 2:
                        Console.Write("Customs Fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        Products.Add(new ImportedProduct(name ,price, customsFee));
                        break;
                    case 3:
                        Console.Write("Manufature Date (dd/mm/aaaa): ");
                        DateTime ManDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Products.Add(new UsedProduct(name, price, ManDate));
                        break;
                    default:
                        Console.WriteLine("Invalid option! Product will be treated as Regular");
                        Products.Add(new Product(name, price));
                        break;
                }

            }
            Console.WriteLine("\n Product Price Tag: ");
            foreach (Product inventory in Products)
            {
                Console.WriteLine(inventory);
            }
        }
    }
}