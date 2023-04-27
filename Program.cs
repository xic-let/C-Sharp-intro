using System;

namespace Salarios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcSal s1 = new CalcSal();


            Console.WriteLine(" Digite o nome do Funcionário: ");
            Console.WriteLine(" Nome: ");
            s1.NomeFunc = Console.ReadLine();
            Console.WriteLine(" Digite o salário bruto da pessoa: ");
            Console.WriteLine(" Salario Bruto: ");
            s1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o valor do Imposto: ");
            Console.WriteLine(" Imposto: ");
            s1.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite a percentagem de aumento: ");
            s1.percentagem = double.Parse(Console.ReadLine());
            

            Console.WriteLine(s1);



        }
    }
}