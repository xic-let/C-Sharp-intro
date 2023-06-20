using System;
using System.Collections.Generic;

namespace lista_funcionarios
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Sal { get; private set; }
       

        public Funcionario(string nome, int id, double sal)
        {
            Name = nome;
            Id = id;
            Sal = sal;
        }

        public void sobesal(double aumento)
        {
            Sal += Sal * aumento / 100.0;
        }

        public override string ToString()
        {
            return Id
                + " + "
                + Name
                + " , "
                +Sal.ToString("F2");
        }
    }
}
