using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer11
{
    internal class Triangulo
    {
        private double Ld1, Ld2, Ld3;
        public void setLd1(double Ld1)
        {
            this.Ld1 = Ld1;
        }
        public void setLd2(double Ld2)
        {
            this.Ld2 = Ld2;
        }
        public void setLd3(double Ld3)
        {
            this.Ld3 = Ld3;
        }
        public double getLd1()
        {
            return this.Ld1;
        }
        public double getLd2()
        {
            return this.Ld2;
        }
        public double getLd3()
        {
            return this.Ld3;
        }
        public void QualtipodeTrian()
        {
            if (this.Ld1 + this.Ld2 > this.Ld3)
            {

                if (this.Ld1 + this.Ld3 > this.Ld2)
                {

                    if (this.Ld2 + this.Ld3 > this.Ld1)
                    {

                        if (this.Ld1 == this.Ld2)
                        {

                            if (this.Ld1 == this.Ld3)
                            {

                                Console.WriteLine("Equilátero");
                            }
                            else
                                Console.WriteLine("Isósceles");
                        }
                        else
                            if (this.Ld2 == this.Ld3)
                        {

                            Console.WriteLine("Isósceles");
                        }
                        else
                                  if (this.Ld1 == this.Ld3)
                        {

                            Console.WriteLine("Isósceles");
                        }
                        else
                            Console.WriteLine("Escaleno");
                    }
                    else
                        Console.WriteLine("Não forma triângulo");
                }
                else
                    Console.WriteLine("Não forma triângulo");
            }
            else
                Console.WriteLine("Não forma triângulo");
        }
    }
}
