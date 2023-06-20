using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCesae.Entities
{
    internal class BusinessAccount : Account
    {

        //Propriedades
        //BA herda as propriedades deAccount
        //por isso aqui nao se repete as propriedades criadas anteriormente
        public double LoanLimit { get; set; }

        //os contrutores tem de ser criados pois nãosao herdados da superclasse.

        public BusinessAccount() {}

        public BusinessAccount(int number, string holder, double balance, double loanlimit)
            :base(number, holder, balance) // com o :base podemos ir buscar os argumentos da classe mae e já nao precisamos de inserir as atribuições da classe mae
        {
            LoanLimit = loanlimit;
        }

        //metodos
        //BA jáextende osmetodos basede account que são os levantamentos e o deposito.
        public void Loan (double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
