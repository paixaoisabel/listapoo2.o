using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imc imc = new Imc();
            Console.Write("Insira o peso: ");
            imc.setPeso(double.Parse(Console.ReadLine()));

            Console.Write("Insira a altura: ");
            imc.setAltura(double.Parse(Console.ReadLine()));

            Console.WriteLine(imc.verificar());
        }
    }
}
