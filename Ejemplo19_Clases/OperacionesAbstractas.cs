using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo19_Clases
{
    internal abstract class OperacionesAbstractas
    {
        public double Sumar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double Restar(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public abstract double Multiplicar(double valor1, double valor2);
        public abstract double Dividir(double valor1, double valor2);

    }
}
