using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;
using System.Security.Cryptography.X509Certificates;
using PoliStaff;
using System.Xml.Linq;

namespace PoliStaff
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("How many employes do you want to register? ");
            int x = int.Parse(Console.ReadLine());

            List<Staff> lists = new List<Staff>();

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"employee #{i}: ");
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter number of worked hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine(" Enter Value per Hour: ");
                double valueperhour = double.Parse(Console.ReadLine());

                Console.WriteLine(" Is he/she outsourced? S/N ");
                char z = char.Parse(Console.ReadLine());

                if (z == 'S' || z == 's')
                {
                    Console.WriteLine(" How much is the bonus? ");
                    double bonus = double.Parse(Console.ReadLine());

                    substaff payment = new substaff(name, hours, valueperhour, bonus);
                    //payment.Bonus = bonus;
                    payment.Income();
                    lists.Add(payment);

                }
                else if (z == 'N' || z == 'n')
                {
                    Staff payment = new Staff(name, hours, valueperhour);
                    payment.Income();
                    lists.Add(payment);
                }
                else
                {
                    Console.WriteLine("Invalid Answer, please insert S/N.");
                    i--;
                }
            }

               foreach (Staff item in lists)
                {
                    Console.WriteLine("Name: " + item.Name + " " 
                        + "Total of Hours: " + item.Hours + " "
                        + "value per hour: " + item.ValperHour + " "
                        + "Salary: " + item.Payment);
                }
               
               
            }
        }
   }
