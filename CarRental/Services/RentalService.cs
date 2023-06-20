using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Entities;

namespace CarRental.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; set; }

        public double PricePerDay { get; private set; }

        public ITaxService PortugalTax;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService portugalTax)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            PortugalTax = portugalTax;
            


        }
        public void ProcessInvoice(CarRent carRent)
        {
            TimeSpan duration = carRent.End.Subtract(carRent.Start);
       
        double basicPayment = 0.0;
            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * duration.TotalHours;
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalHours);
            }
            double tax = PortugalTax.Tax(basicPayment);

            carRent.Invoice = new Invoice(basicPayment, tax);
            
        }
    }
}