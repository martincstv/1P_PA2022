using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo13_BibliotecaClases
{
    public class Operaciones
    {
        public double Sumar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Restar(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
        /// <summary>
        /// Devuelve la potencia entre dos numeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public double Potencia(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }

        public double Residuo(double n1, double n2)
        {
            return n1 % n2;
        }

        public double MayorDeDosNumeros(double numero1, double numero2)
        {
            if (numero1 > numero2)
                return numero1;
            else
                return numero2;
        }
    }
}
