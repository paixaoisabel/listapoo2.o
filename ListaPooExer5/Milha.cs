using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer5
{
    internal class Milha
    {
        private double milha;
        private double resultado;
        public void setmilha(double a)
        {
            this.milha = a;
        }

        public double getmilha()
        {
            return this.milha;
        }

        public double getresultado()
        {
            return resultado;
        }

        public void converter()
        {
            this.resultado = this.milha * 1.852;
        }
    }
}
