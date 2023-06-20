using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCesae.Entities
{
    internal class Account
    {

        //Secção das propriedades
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }

        //Construtores

        public Account()
        {
            double x = Balance;
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //métodos 
        //metodo para levantamentos
        public virtual void Withdraw(double amount) // a palavra chave virtual vai converter este metodo para quepossa ser utilizado por outras classes
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
