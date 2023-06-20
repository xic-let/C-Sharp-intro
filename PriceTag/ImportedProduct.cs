using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_descriptive.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }


        public ImportedProduct()
        { }

        public ImportedProduct(string name, double price, double customsfee)
            : base(name, price)
        {
            CustomsFee = customsfee;

        }

        public override string ToString()
        {
            return base.ToString() + $" | Customs Fee: {CustomsFee:C2}";
        }



    }
}
