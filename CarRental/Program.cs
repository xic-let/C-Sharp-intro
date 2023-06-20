using CarRental.Entities;
using CarRental.Services;
using System;
using System.Globalization;



namespace CarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rental Data");
            Console.WriteLine("Car model: ");
            String model = Console.ReadLine();
            Console.WriteLine("Pickup Date: (dd/mm/yyyy hh:mm):");
            DateTime Start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return Date: (dd/mm/yyyy hh:mm):");
            DateTime Finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter Price Per Hour: ");
            double hour = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price Per  Hour: ");
            double day = double.Parse(Console.ReadLine());

            CarRent carRent = new CarRent(Start, Finish, new Veichle(model));

            RentalService rentalService = new RentalService(hour, day, new PortugalTax());

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRent.Invoice);
        }
    }
}