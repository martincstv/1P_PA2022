using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo19_Clases
{
    internal class Operaciones
    {
        public double Sumar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double Restar(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public double Dividir(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

        public double Potencia(double valor1, double valor2)
        {
            return Math.Pow(valor1,valor2);
        }

        public double Residuo(double valor1, double valor2)
        {
            return valor1 % valor2;
        }
    }
}
