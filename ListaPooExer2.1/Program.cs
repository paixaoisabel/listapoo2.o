using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aresta ar = new Aresta();
            Console.Write("Digite o valor da aresta: ");
            ar.setaresta(int.Parse(Console.ReadLine()));
            ar.ArestaArea();
            Console.WriteLine("O valor da area: {0}",ar.getarea());
        }
    }
}
