using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_descriptive.Entities
{
    internal class UsedProduct : Product 
    {
        public DateTime ManDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime ManDate)
        :base (name,price)
        {
            this.ManDate = ManDate;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Manufacture Date: {ManDate.ToShortDateString()}";
        }
    }
}
