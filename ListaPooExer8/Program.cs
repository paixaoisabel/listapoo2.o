using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maior mr = new Maior();
            Console.Write("Digite o primeiro valor: ");
            mr.setn1(int.Parse(Console.ReadLine()));
            Console.Write("Digite o segundo valor: ");
            mr.setn2(int.Parse(Console.ReadLine()));
            mr.verificar();

        }
    }
}
