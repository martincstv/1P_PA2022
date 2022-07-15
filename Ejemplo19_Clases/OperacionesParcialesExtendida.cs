using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo19_Clases
{
    internal partial class OperacionesParciales
    {
        public double Dividir(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

        public double Potencia(double valor1, double valor2)
        {
            return Math.Pow(valor1, valor2);
        }

        public double Residuo(double valor1, double valor2)
        {
            return valor1 % valor2;
        }
    }
}
