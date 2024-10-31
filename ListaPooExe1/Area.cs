using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExe1
{
    internal class Area
    {
        private int altura;
        private int Base;
        private int area;

        public void setaltura(int a)
        {
            this.altura = a;
        }
        public void setBase(int a)
        {
            this.Base = a;
        }
        public int getaltura()
        {
            return this.altura;
        }
        public int getBase()
        {
            return Base;
        }
        public int getArea()
        {
            return area;
        }
        public void AreaRet()
        {
            this.area = this.altura * this.Base;
        }

    }
}
