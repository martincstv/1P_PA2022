using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo19_Clases
{
    public static class OperacionesEstaticas
    {
        public static double Sumar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public static double Restar(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public static double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public static double Dividir(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

        public static double Potencia(double valor1, double valor2)
        {
            return Math.Pow(valor1, valor2);
        }

        public static double Residuo(double valor1, double valor2)
        {
            return valor1 % valor2;
        }
    }
}
