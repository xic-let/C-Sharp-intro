using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Salarios2
{
    internal class CalcSal
    {
        public string NomeFunc;
        public double SalarioBruto;
        public double Imposto;
        public double percentagem;

        

        public double SalarioLiquido() 
        {
            return SalarioBruto - Imposto;
        }

        public double aumentarsalario()
        {
            return SalarioBruto + ((percentagem / 100) * SalarioBruto);
        }
        public override string ToString()
        {
            return "Nome= "
                + NomeFunc
                + Environment.NewLine
                + "Salario Liquido = "
                + SalarioLiquido().ToString("F2")
                + Environment.NewLine
                + "Valor do Salario com o Aumento: "
                + aumentarsalario().ToString("F2");
        }
    }
}
