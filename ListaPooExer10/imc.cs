using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer10
{
    internal class Imc
    {
        private double peso, altura;

        public String verificar()
        {
            double calcIMC = this.peso / Math.Pow(this.altura, 2);
            if (calcIMC < 20)
            {
                return "Abaixo do peso - IMC " + calcIMC.ToString();
            }
            else if(calcIMC < 25)
            {
                return "Peso ideal - IMC " + calcIMC.ToString();
            } else if (calcIMC >= 25)
            {
                return "Acima do peso - IMC " + calcIMC.ToString();
            }

            return "Sem número inserido!";
        }

        public double getPeso => this.peso;
        public double getAltura => this.altura;

        public void setPeso(double peso) => this.peso = peso;
        public void setAltura(double altura) => this.altura = altura;
    }
}
