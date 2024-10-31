using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer7
{
    internal class Distintos
    {
        private int n1;
        private int n2;
        private int maior;

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
        public int verificar()
        {
            while (true)
            {
                if (this.n1 > this.n2)
                {
                    this.maior = this.n1;
                    return this.maior;
                }
                else if (this.n1 < this.n2)
                {
                    this.maior = this.n2;
                    return this.maior;
                }
                else if (this.n2 == this.n1)
                {
                    Console.Write("Os valores tem que ser diferentes, Digite novamente: ");
                    this.n2 = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
