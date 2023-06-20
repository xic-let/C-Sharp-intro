using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CarRental.Entities
{
    internal class Invoice
    {

        public double BasicPayment { get; set; }

        public double Tax { get; set; }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; } //fazemos get para obter umvalor
        }

        public Invoice (double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString()
        {
            return "Basic Payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotalPayment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
