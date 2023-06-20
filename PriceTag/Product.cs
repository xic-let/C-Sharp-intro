using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_descriptive.Entities
{
    internal class Product
    {
        public string name { get; set; }
        public double price { get; set; }


        public Product()
        { }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Name: {name} | Price: {price}";
        }



    }
}
