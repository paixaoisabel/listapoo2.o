using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer9
{
    internal class Retangulo
    {
        private int Altura,Base,Resul;
        public void setAltura(int altura)
        {
            this.Altura = altura;
        }
        public void setBase(int Base)
        {
            this.Base = Base;
        }
        public int getAltura()
        {
            return this.Altura;
        }
        public int getBase()
        {
            return this.Base;
        }
        public int getResul()
        {
            return this.Resul;
        }

        public void AreaRet()
        {
            this.Resul = this.Altura*this.Base;

            if (this.Resul > 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
              {
                 Console.WriteLine("Terreno pequeno");
              }

        }
    }
}
