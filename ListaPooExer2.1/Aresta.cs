using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer2._1
{
    internal class Aresta
    {
        private int aresta;
        private int area;

        public void setaresta(int a)
        {
            this.aresta = a;
        }
        public int getaresta()
        {
            return this.aresta;
        }
        public int getarea()
        {
            return this.area;
        }
        public void ArestaArea()
        {
            this.area = this.aresta*this.aresta;
        }
    }
}
