using BancoCesae.Entities;

namespace BancoCesae
{
	internal class Program
	{
		static void Main(string[] args)
		{
		   Account acc = new Account(1001, "Jose", 500);

		   BusinessAccount bacc = new BusinessAccount(1006, "SWDeveloper", 0, 50000);

			//Upcasting
			Account acc1 = bacc; // conversão de BA para uma account
			Console.WriteLine(acc1.Holder); // ao fazer a conversão por Upcast, os campos que estão a mais na classe herdada não serão importados.
											//Apenas os campos comuns serãp importados.

			Account acc2 = new BusinessAccount(10,"Maria", 4000, 10000); // instanciar uma nova conta business a ser convertida para account

			Account acc3 = new SavingsAccount(520, "Antonio", 15000, 0.02);

			//Console.WriteLine(acc3.Balance);

			//Downcasting

			BusinessAccount acc4 = (BusinessAccount)acc2;

			//ou

			//BusinessAccount acc5 = acc4 as BusinessAccount;

			acc4.Loan(100);
			Console.WriteLine(acc4.Holder + acc4.LoanLimit);

			acc.Withdraw(10);
			Console.WriteLine(acc.Balance);

		   
		}

        
    }
}