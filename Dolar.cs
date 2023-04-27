using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoeda
{
    internal class Dolar
    {
        public static double cotacao;
        public static double Quantidade;
        public static double Imposto = 6.0; 

        public static double dolar2euro(double cotacao, double Quantidade)
        {
        
            double conta = Quantidade * cotacao;
            return conta + conta * Imposto / 100.00;
              
        }


    }
}
