using System;
using System.Collections.Generic;

namespace lista_funcionarios
{ 
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos FUncionários vai inserir?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine(" Colaborador # " + i +";");
                Console.WriteLine("Qual o ID do Colaborador?");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o Nome do Colaborador?");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual o Salário do Colaborador?");
                double sal = double.Parse(Console.ReadLine());
                lista.Add(new Funcionario(nome,id, sal));
            }

            Console.WriteLine("Insira o ID do Colaborador que vai ser aumentado: ");
            int StaffID = int.Parse(Console.ReadLine());

            Funcionario emp = lista.Find(x => x.Id == StaffID);
            if (emp != null)
            {
                Console.WriteLine("Insira a percentagem do Aumento: ");
                double aumento = double.Parse(Console.ReadLine());
                emp.sobesal(aumento);
            }
            else
            {
                Console.WriteLine("ID não Existente!");
            }

            Console.WriteLine("*************");
            Console.WriteLine("Lista de Colaboradores:");
            foreach (Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}