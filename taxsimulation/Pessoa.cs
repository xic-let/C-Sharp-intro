using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.Entities
{
    internal abstract class Pessoa
    {
        public string nome { get; set; }
        public double annualIncome { get; set; }


        public Pessoa() { }

        public Pessoa(string nome, double annualIncome)
        {
            this.nome = nome;
            this.annualIncome = annualIncome;
        }

        public abstract double Tax();

    }
}
