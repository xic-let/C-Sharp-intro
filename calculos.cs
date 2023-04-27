using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retangulo
{
    internal class calculos
    {
        public double larg, alt;

        public double area()
        {
            return larg * alt;
        }
        public double perimetro()
        {
            return (2 * larg) + (2 * alt);
        }
        public double diagonal()
        {
            return Math.Sqrt(larg * larg) + (alt * alt);
        }

        public override string ToString()
        {
            return "AREA = "
                + area().ToString("F2")
                + Environment.NewLine
                + "PERIMETRO = "
                + perimetro().ToString("F2")
                + Environment.NewLine
                + "DIAGONAL = "
                + diagonal().ToString("F2");
        }
    }
}
