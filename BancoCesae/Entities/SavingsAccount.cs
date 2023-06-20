using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCesae.Entities
{
    internal class SavingsAccount : Account // se a classe for selada depois não será possivel tornar-se em superclasse.
        //sela-se a classe a colocar a palavra chave sealed em x do internal.
    {
        //propriedades
        public double InterestRate { get; set; }

        //construtores

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            :base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance(double balance)
        {
            balance += balance * InterestRate;
        }

        public override void Withdraw(double amount) //chamada do metodo withdraw criado na classe account
        {
            base.Withdraw(amount); // base chama as implementaçõesda classe mae
            Balance -= 2.0; // e neste caso acrescentamos a restante função para se adequar ao pretendido
        }

       /* public sealed override void Withdraw(double amount) 
        * para impedir a sobreposição de um metodo que já foi sobreposto, selamos o metodo acrescentando palavra chave sealed
        {
            base.Withdraw(amount); 
            Balance -= 2.0; 
        }*/
    }
}
