using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer8
{
    internal class Maior
    {
        private int n1, n2, maior;


        public void setn1(int a)
        {
            this.n1 = a;
        }
        public void setn2(int a)
        {
            this.n2 = a;
        }
        public int getn1()
        {
            return this.n1;
        }
        public int getn2()
        {
            return this.n2;
        }
        public int getmaior()
        {
            return this.maior;
        }
        public void verificar()
        {
            if (this.n1 > this.n2)
            {
                this.maior = this.n1;
                Console.WriteLine("O maior é o primeiro: " + this.maior);
            }
            else if (this.n1 < this.n2)
            {
                this.maior = this.n2;
                Console.WriteLine("O maior é o segundo: " + this.maior);
            }
            else
            {
                Console.WriteLine("Os valores são iguais.");
            }
        }
    }
}