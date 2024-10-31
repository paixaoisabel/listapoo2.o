using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo tr = new Triangulo();
            Console.Write("Digite a altura do triangulo: ");
            tr.setaltura(int.Parse(Console.ReadLine()));
            Console.Write("Digite o valor da base do triangulo: ");
            tr.setbase(int.Parse(Console.ReadLine()));
            tr.AreaTriangulo();
            Console.WriteLine("A area de um triangulo com a altura de {0}, e uma base de {1} é de: {2}", tr.getaltura(), tr.getbase(), tr.getarea());

        }
    }
}
