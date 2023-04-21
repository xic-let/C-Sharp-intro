using System;

internal class Program
{

	private static void Main(string[] args)
	{

        /*
		 Impressão de variaveis na consola
		int idade;
		double salario;
		float altura;
		char genero;
		string nome;


		idade = 20;
		salario = 1500;
		altura = 1.70;
		genero = 'F';
		nome = "Alice";

		Console.WriteLine(" A Funcionária " + nome + " do género " + genero+ " tem " + idade+ " anos de idade" + " e ganha " + salario.ToString("F2") + " €");*/

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /* imprimir a area na consola
		double b1, b2, f, area;
		b1 = 6.0;
		b2 = 8.0;
		f = 5.0;
		area = (b1 + b2) / 2 * f;

		Console.WriteLine(area);
		*/

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* imprimir divisão e modulo na consola
		 
		 
		double a;
		int b;
		double res;
		double mod;

		a = 5.0654;
		b = 2;
		res = a / b; 
		mod = a % b;

		Console.WriteLine(mod);
		Console.WriteLine(res);
		*/

        ////////////////////////////////////////////////////////////////////////////////////////////////
        /* pedir dados ao utilizador e imprimir na consola
		double salario1, salario2;
		string nome1, nome2;
		int idade1, idade2;
		char genero1, genero2;


		Console.WriteLine("**********************");
		Console.WriteLine("Insira o nome: ");
		nome1 = Console.ReadLine();
        Console.WriteLine("**********************");
        Console.WriteLine("Insira o salario: ");
        salario1 = double.Parse(Console.ReadLine());
        Console.WriteLine("**********************");
        Console.WriteLine("Insira o genero: ");
        genero1 = char.Parse(Console.ReadLine());
        Console.WriteLine("**********************");
        Console.WriteLine("Insira a  Idade: ");
        idade1 = int.Parse(Console.ReadLine());
        Console.WriteLine("**********************");


        Console.WriteLine("**********************");
        Console.WriteLine("Insira o nome: ");
        nome2 = Console.ReadLine();
        Console.WriteLine("**********************");
        Console.WriteLine("Insira o salario: ");
        salario2 = double.Parse(Console.ReadLine());
        Console.WriteLine("**********************");
        Console.WriteLine("Insira o genero: ");
        genero2 = char.Parse(Console.ReadLine());
        Console.WriteLine("**********************");
        Console.WriteLine("Insira a  Idade: ");
        idade2 = int.Parse(Console.ReadLine());
        Console.WriteLine("**********************");

		Console.WriteLine(nome1 + " tem " + idade1 + " anos de idade" + " é do genero " + genero1 + " e ganha " + salario1.ToString("F2")+ " e!");
        Console.WriteLine(nome2 + " tem " + idade2 + " anos de idade" + " é do genero " + genero2 + " e ganha " + salario2.ToString("F2") + " e!");
		*/

        ///////////////////////////////////////////////////////////////
        /* estrutura condicional if..else
		int hora;

		Console.WriteLine("Indique a hora do dia: ");
		hora = int.Parse(Console.ReadLine());

		if (hora < 12)
		{
			Console.WriteLine(" BOM DIA! ");
		}
		if (hora > 20)
		{
            Console.WriteLine(" Boa noite! ");
        }
		else
		{
			Console.WriteLine (" Boa Tarde! ");
		}
		*/

        ////////////////////////////////////////////////////////////////
        /*ciclo while
		 * 
		int i;
		int x;

		x = 0;

        Console.WriteLine(" insira um valor: ");
        i = int.Parse(Console.ReadLine());
		x = i;

        while (i != 0 )
		{
            Console.WriteLine(" insira um valor: ");
            i = int.Parse(Console.ReadLine());
            x = x + i;
        }
		Console.WriteLine(" A soma do valor inserido é: " + x );

		*/

        int soma;
		int n;
		int x;
		int i;


		x = 0;
		soma = 0;
        Console.WriteLine(" Quantos numeros vai inserir:? ");
        n = int.Parse(Console.ReadLine());
        
		for( i = 0; i < n; i++)
		{
            Console.WriteLine(" insira o numero: ");
            x = int.Parse(Console.ReadLine());
            soma = x + soma;
		}
        Console.WriteLine(" A soma do valor inserido é: " + soma);


    }
}