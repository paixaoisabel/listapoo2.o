using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer12
{
    internal class Hipotenusa
    {
        private double vl1,vl2,vl3;
        public void setvl1(double vl1)
        {
            this.vl1 = vl1;
        }
        public void setvl2(double vl2)
        {
            this.vl2 = vl2;
        }
        public void setvl3(double vl3)
        {
            this.vl3 = vl3;
        }
        public double getvl1()
        {
            return this.vl1;
        }
        public double getvl2()
        {
            return this.vl2;
        }
        public double getvl3()
        {
            return this.vl3;
        }
        public void TrianguloRet()
        {
            if (this.vl1 > this.vl2 && this.vl1 > this.vl3 && this.vl1 * this.vl1 == this.vl2 * this.vl2 + this.vl3 * this.vl3)
            {
                Console.WriteLine("É um triangulo retangulo");
            }else if (this.vl2 > this.vl1 && this.vl2 > this.vl3 && this.vl2 * this.vl2 == this.vl1 * this.vl1 + this.vl3 * this.vl3)
            {
                Console.WriteLine("É um triangulo retangulo");
            }else if (this.vl3 > this.vl1 && this.vl3 > this.vl2 && this.vl3 * this.vl3 == this.vl1 * this.vl1 + this.vl2 * this.vl2)
            {
                Console.WriteLine("É um triangulo retangulo");
            }else
            {
                Console.WriteLine("Não é um triangulo retangulo");
            }
        }
    }
}
