using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Distintos dt = new Distintos();

            Console.Write("Digite o primeiro valor: ");
            dt.setn1(int.Parse(Console.ReadLine()));
            Console.Write("Digite o segundo valor: ");
            dt.setn2(int.Parse(Console.ReadLine()));
            dt.verificar();
            Console.WriteLine("O maior valor é: {0}",dt.getmaior());
        }
    }
}
