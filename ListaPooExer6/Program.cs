using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dl = new Dolar();
            Console.Write("Digte o valor em dolar: $");
            dl.setdollar(double.Parse(Console.ReadLine()));
            dl.cabiarPreal();
            Console.WriteLine("O valor de ${0}, em real é R${1}",dl.getdollar(),dl.getcambio());
        }
    }
}
