using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.Entities
{
    internal class Individual : Pessoa
    {
        public double healthExpenses { get; set; }

        public Individual() {}

        public Individual(string nome, double annualincome, double healthExpenses) :base (nome, annualincome)
        {
            this.healthExpenses = healthExpenses;
        }

        public override double Tax()
        {
            if (annualIncome < 20000)
            {
                double calc = annualIncome * 0.15;
                double deduct = calc - (healthExpenses / 2);
                return deduct;
            }
            else
            {
                double calc = annualIncome * 0.25;
                double deduct = calc - (healthExpenses / 2);
                return deduct;
            }

        }

    }


}
