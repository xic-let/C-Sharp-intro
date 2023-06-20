using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    internal class Veichle
    {
        public string MakeModel { get; set; }

        public Veichle() { }

        public Veichle(string model)
        {
            MakeModel = model;
        }
    }
}
