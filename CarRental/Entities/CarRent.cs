using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    internal class CarRent
    {
        public DateTime Start {get; set;}
        
        public DateTime End { get; set;}

        public Veichle Veichle { get; set;}

        public Invoice Invoice { get; set; }

        public CarRent (DateTime start, DateTime finish, Veichle veichle)
        {
            Start = start;
            End = finish;
            Veichle = veichle;
            Invoice = null;
        }

    }
}
    