using Banco;
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
/*Num banco, para se criar uma conta bancária, 
é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta.
Este valor de depósito inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro
a depositar no momento de abrir sua conta, o depósito inicial não será feito e o saldo
inicial da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. 
Já o nome do titular pode ser alterado (pois uma pessoa pode mudar de sobrenome por ocasião de casamento, por exemplo).
Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso. 
O saldo só aumenta por meio de depósitos, e só diminui por meio de levantamentos. Para cada levantamento realizado,
o banco cobra uma taxa de 5.00 euros. 
Nota: a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o levantamento e/ou pagar a taxa.
Você deve fazer um programa que realize a criação de uma conta, dando opção para que seja ou não
informado o valor de depósito inicial. Em seguida, realizar um depósito
e depois um levantamento, e mostrar sempre os dados da conta após cada operação.*/


internal class Program
{
    private static void Main(string[] args)
    {
        char x;
        int y;
        
        AccountOps conta = new AccountOps();

        Console.WriteLine(" Entre o Numero de Conta: ");
        Console.WriteLine(" Conta Numero: ");
        conta.NrConta = int.Parse(Console.ReadLine());
        Console.WriteLine(" Entre o Titular  da Conta: ");
        Console.WriteLine(" Nome: ");
        conta.Titular = Console.ReadLine();
        Console.WriteLine(" Haverá depósito inicial? s/n ");
        Console.WriteLine(" Resposta: ");
        x = char.Parse(Console.ReadLine());
        {
            if (x == 's')
            {
                conta.depositoabertura();
            }
            else
                conta.Saldo = 0;
        }
        Console.WriteLine(" Para mais operações seleccione: ");
        Console.WriteLine(" 1 - Levantamento");
        Console.WriteLine(" 2 - Depósito ");
        Console.WriteLine(" 3 - Terminar operação");
        Console.WriteLine(" Resposta: ");
        y= int.Parse(Console.ReadLine());
        {
            if (y == 1)
            {
                conta.levantamento();
            }
            if (y == 2)
            {
                conta.deposito();
            }
            else
            {
                Console.WriteLine("Obrigado e Volte Sempre!");
            }
        }


        //AccountOps conta = new AccountOps(int Nr, string Nome, double Valor);

        Console.WriteLine(" Dados de Conta: " + conta);
        Console.WriteLine(" +++++++++++++++++++++++++");



    }
}