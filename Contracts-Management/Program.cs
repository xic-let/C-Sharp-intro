using contratos.Entities;
using contratos.Entities.Enums;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace contratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Department's name: ");
            string RD = Console.ReadLine();
            Console.WriteLine("Enter Worker Data: ");
            Console.WriteLine("Worker Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("level (Junior / MidLevel / senior: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Please enter base salary: ");
            double basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento departamento = new Departamento(RD);
            Worker worker = new Worker(name, level, basesalary, departamento);

            Console.WriteLine("How Many contratcs does the worker have? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours); // guarda os valores 
                worker.AddContract(contract); // adiciona a lista criada
            }

            Console.WriteLine();
            Console.WriteLine(" Enter Month and year to calculate income(mm/yyyy)");
            string monthyear = Console.ReadLine();

            int month = int.Parse(monthyear.Substring(0,2));
            int year = int.Parse(monthyear.Substring(3));


            Console.WriteLine(" Name: " + worker.Name);
            Console.WriteLine(" Department: " + worker.Departamento.DepName);
            Console.WriteLine(" Income for " + monthyear + ": " + worker.Income(year,month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}