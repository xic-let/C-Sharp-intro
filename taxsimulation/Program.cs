using Financas.Entities;
using System;
using System.Collections.Generic;



namespace Financas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Welcome to the tax simulator! ");
            Console.WriteLine(" How Many Simultions will you do? ");
            int x = int.Parse(Console.ReadLine());

            //Criação da Lista Shape vazia
            List<Pessoa> list = new List<Pessoa>();

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("simlation #{i}: ");
                Console.WriteLine("Enter Name: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Hello " + nome +" , please insert annual income: ");
                double earning = double.Parse(Console.ReadLine());
                Console.WriteLine(nome +" are you a company or an individual? (i/c) ");
                char res = char.Parse(Console.ReadLine());

                if (res ==  'I' || res == 'i')
                {
                    
                    Console.Write("Enter total of Health Expenses: ");
                    double healthExpenses = double.Parse(Console.ReadLine());
                    list.Add(new Individual(nome, earning, healthExpenses));

                }
                else
                {
                    Console.Write("Enter Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(nome, earning, numberOfEmployees));
                }

                Console.WriteLine("+++++++++++++++++++++++++++++++++++");
                Console.WriteLine("TAXES PAID: ");

                foreach (Pessoa item in list)
                {
                    Console.WriteLine(item);
                }
                    Console.WriteLine("---------------------------------");

                double sum = 0;

                foreach (Pessoa item in list) //vai somar o saldo de todas as contas
                {
                    sum += item.Tax();
                }
                Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2"));
                Console.WriteLine("+++++++++++++++++++++++++++++++++++");





            }

        }

    }
}