using System;
using System.Collections.Generic;
using stocks;


namespace stocks
{
    internal class Produto
    {
        public string Nome;
        public double Valor;
        public int QtS;
        public int QtV;
        public int Stock;


        public double ValorS()
        {
           return Stock * Valor;
        }

        public void AdicionarProduto(int qte)
        {
            Stock = Stock + qte;
        }

        public void RemoverProduto(int qte)
        { 
            Stock = Stock - qte; 
        }

        public override string ToString()
        {
            return Nome
                +"\n"
                + Valor.ToString("F2")
                + " Eur "
                + ", \n"
                +" Stock: "
                + Stock
                + "unidades.\n Total de valor em Stock: "
                + " Eur."
                + ValorS().ToString("F2");
        }
    }
}
