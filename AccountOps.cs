using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class AccountOps
    {
        public int NrConta;
        public string Titular;
        public double Saldo;
        public double Vdep;
        public double Vlev;
        public static double Imposto = 5.00;

        public AccountOps()
        {
          
        }

        public AccountOps (int Nr, string Nome, double Valor)
        {
            NrConta = Nr;
            Titular = Nome;
            Saldo = Valor;
        }

        public void depositoabertura()
        {
             Console.WriteLine(" Entre o valor do Depósito Inicial: ");
             Console.WriteLine(" Valor ");
             Saldo = double.Parse(Console.ReadLine());
        }
           
        public void  levantamento()
        {
            Console.WriteLine(" Entre o valor a levantar: ");
            Console.WriteLine(" Valor ");
            Vlev = double.Parse(Console.ReadLine());
            Saldo = Saldo - Vlev - Imposto;
        }
        public void deposito()
        {
            Console.WriteLine(" Entre o valor a depositar: ");
            Console.WriteLine(" Valor ");
            Vdep = double.Parse(Console.ReadLine());
            Saldo = Saldo + Vdep;
        }

        public override string ToString()
        {
            return Titular.ToString()
                +" Conta: "
                + NrConta.ToString()
                + " Saldo Actualizado: "
                + Saldo.ToString("F2")
                + " EUR.";
        }
    }
}
