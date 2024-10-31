using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diagonal area;
            area = new Diagonal();
            Console.Write("Digite a diagonal de um quadrado: ");
            area.setdiago(int.Parse(Console.ReadLine()));
            area.areadiago();
            Console.WriteLine("A area de um quadrado em relação a sua diagonal {0}, é de {1}",area.getdiago(),area.getresul());
        }
    }
}
