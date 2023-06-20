using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.Entities
{
    internal class Company : Pessoa

    {
        public int numberOfEmpoyees { get; set; }

        public Company() { }

        public Company(string nome, double annualincome, int numberofemployees):base(nome, annualincome)
        {
            this.numberOfEmpoyees = numberofemployees;
        }

        public override double Tax()
        {
            double calc;
            if (numberOfEmpoyees < 10)
            {
                return calc = annualIncome * 0.16;

            }
            else
            {
                return calc = annualIncome * 0.14;
            }
        }
    }
}
