using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo rt = new Retangulo();
            Console.Write("Digite a altura do retangulo: ");
            rt.setAltura(int.Parse(Console.ReadLine()));
            Console.Write("Digite a base do retangulo: ");
            rt.setBase(int.Parse(Console.ReadLine()));
            rt.AreaRet();
        }
    }
}
