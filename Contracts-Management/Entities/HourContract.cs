using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contratos.Entities
{
    internal class HourContract
    {
        //propriedades
        public DateTime Date { get; set; }
        public Double Valueperhour { get; set; }
        public int Hours { get; set; }


        //construtor padrao que serve para criar o objecto, ainda que nao passe argumentos,e aconselhavel criar sempre um
        public HourContract()
        {
        
        }

        public HourContract(DateTime date, double valueperhour, int hours)
        {
            Date = date;
            Valueperhour = valueperhour;
            Hours = hours;
        }

        //secção de metodos
        public double TotalValue()
        {
            return Valueperhour * Hours;
        }
    }
}
