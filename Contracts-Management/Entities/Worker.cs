using contratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contratos.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } // vai buscar a classe enum para dar o atributo ao objecto worker

        public double BaseSalary { get; set; }

        public Departamento Departamento { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
            //instanciar a lista para a memoria perceber que está ja disponivel para receber dados
        
        public Worker() 
        {
        
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departamento departamento)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departamento = departamento; 
            //não se usam listas nos construtores
        }

        //criação de metodos

        public void AddContract (HourContract contract) 
        {
            Contracts.Add(contract);        
        }

        public void RemoveContract (HourContract contract) 
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double soma = BaseSalary;
            foreach (HourContract contract in Contracts) 
            {

                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    soma += contract.TotalValue();
                }
            }
            return soma;
        }
    }
}
