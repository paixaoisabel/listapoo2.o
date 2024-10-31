using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer11
{
    internal class Program
    {
        static void Main(string[] args)
        { Triangulo tr = new Triangulo();
            Console.Write("Digite o valor do primeiro lado: ");
            tr.setLd1(double.Parse(Console.ReadLine()));
            Console.Write("Digite o valor do segundo lado: ");
            tr.setLd2(double.Parse(Console.ReadLine()));
            Console.Write("Digite o valor do terçeiro lado: ");
            tr.setLd3(double.Parse(Console.ReadLine()));
            tr.QualtipodeTrian();
        }
    }
}
