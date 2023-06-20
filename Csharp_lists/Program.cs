using System.Collections;
using System.Collections.Generic;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declaração e instanciação de listas

        List<string> list = new List<string>();
        List<string> list2 = new List<string> { "Maria", "Carlos", "José" };

        list2.Add("Joana");
        list2.Add("Joaquim");
        list2.Add("Inês");

        list2.AddRange(new string[] { "Ana", "Max", "Liliana" });

        list.AddRange(list2.GetRange(0, 1));
        list.AddRange(list2.GetRange(4, 1));

        foreach (string nome in list2)
        {
            Console.Write($"{nome}, ");
        }
        Console.WriteLine(list2.Count);
        foreach (string nome in list)  //enumeraa lista
        {
            Console.Write($"{nome}, ");
            Console.WriteLine();
        }
        Console.WriteLine(list.Count);
        //conta o nr de Items na lista
        Console.WriteLine();

        List<int> valores = new List<int>();
        valores.Add(16);
        valores.Add(18);
        valores.Add(23);
        valores.Add(12);

        foreach (int item in valores)  //enumeraa lista
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("A lista tem " + valores.Count() + " itens.");
        Console.WriteLine();

        valores.Sort(); //organiza por ordem ascendente

        foreach (int g in valores)
        {

            // Display sorted list
            Console.WriteLine(g);
            Console.WriteLine();
        }

        List<string> list1 = new List<string>();

        // list elements
        list1.Add("A");
        list1.Add("I");
        list1.Add("G");
        list1.Add("B");
        list1.Add("E");
        list1.Add("H");
        list1.Add("F");
        list1.Add("C");
        list1.Add("D");

        Console.WriteLine("Original List");

        // Display Original List
        Display(list1);

        Console.WriteLine("\nSorted List");

        // use of List.Sort() method
        list1.Sort();

        // Display sorted List
        Display(list1);
        Console.WriteLine();
    }

    // Display function
    public static void Display(List<string> list) // sortir por ordem alfabetica
    {
        foreach (string g in list)
        {
            Console.Write(g + " ");
        }

        Console.WriteLine();
        ArrayList authorsArray = new ArrayList(); //listade array
        authorsArray.Add("Mahesh Chand");
        authorsArray.Add("Praveen Kumar");
        authorsArray.Add("Raj Kumar");
        authorsArray.Add("Dinesh Beniwal");
        authorsArray.Add("David McCarter");
        Console.WriteLine("Count: " + authorsArray.Count);
        Console.WriteLine("Capacity: " + authorsArray.Capacity);
        Console.WriteLine();

        foreach (string g in authorsArray) // mostra contuedo da lista
        {
            Console.Write(g + " ");
            Console.WriteLine();
        }

        int idx = authorsArray.IndexOf("Naveen Sharma"); //procura pelo elemento enunciado
        if (idx > 0)
            Console.WriteLine($"Item index in List is: {idx}");
        else
            Console.WriteLine("Item not found");
        Console.WriteLine();

        authorsArray.Insert(3, "Naveen Sharma"); //insere o elemento enunciado

        foreach (string g in authorsArray)
        {
            Console.Write(g + " ");
            Console.WriteLine();

        }
        

        int idx2 = authorsArray.IndexOf("Naveen Sharma");
        if (idx2 > 0)
            Console.WriteLine($"Item index in List is: {idx}");
        else
            Console.WriteLine("Item not found");
        Console.WriteLine();

        authorsArray.RemoveAt(3); //remove elemento na posição enunciada
        foreach (string g in authorsArray)
        {
            Console.Write(g + " ");
            Console.WriteLine();

        }
        Console.WriteLine();

        // List of string
        List<string> authors = new List<string>(5);
        authors.Add("Mahesh Chand");
        authors.Add("Chris Love");
        authors.Add("Allen O'neill");
        authors.Add("Naveen Sharma");
        authors.Add("Mahesh Chand");
        authors.Add("Monica Rathbun");
        authors.Add("David McCarter");
        Console.WriteLine("Original List items");
        Console.WriteLine("===============");
        // Print original order
        foreach (string a in authors)
            Console.WriteLine(a);
        // Reverse list items
        authors.Reverse();
        Console.WriteLine();
        Console.WriteLine("Sorted List items");
        Console.WriteLine("===============");
        // Print reversed items
        foreach (string a in authors)
            Console.WriteLine(a);

    }
}


        