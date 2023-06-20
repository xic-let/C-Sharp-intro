using Banco;
using System;
using System.Drawing;
using System.Globalization;
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
        //Cadastro:
        Console.Write("Digite o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Digite o nome do titular da conta: ");
        string titular = Console.ReadLine();
        Conta conta = new Conta(numero, titular);
        Console.Write("Haverá depósito inicial (s/n)? ");
        char resposta = char.Parse(Console.ReadLine());
        if (conta.HaveraDeposito(resposta))
        {
            Console.Write("Digite o valor do depósito inicial: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new Conta(numero, titular, saldo);
        }

        //Mostrar conta:
        Console.WriteLine();
        Console.WriteLine("Conta criada com sucesso:");
        Console.WriteLine(conta);

        //Depósito:
        Console.WriteLine();
        Console.Write("Digite um valor para depósito: ");
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(valor);
        Console.WriteLine("Conta atualizada:");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Digite um valor para levantamento: ");
        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(valor);
        Console.WriteLine("Conta atualizada:");
        Console.WriteLine(conta);

        Console.ReadLine();
    }
}