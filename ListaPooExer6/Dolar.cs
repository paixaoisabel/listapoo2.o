using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer6
{
    internal class Dolar
    {
        private double dollar;
        private double cambio;
        public void setdollar(double a)
        {
            this.dollar = a;
        }
        public double getdollar()
        {
            return this.dollar;
        }
        public double getcambio()
        {
            return this.cambio;
        }
        public void cabiarPreal()
        {
            this.cambio = this.dollar * 5.71;
        }
    }
}
