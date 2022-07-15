using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo19_Clases
{
    internal class OperacionesAbstractasHija : OperacionesAbstractas
    {
        public override double Dividir(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

        public override double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
    }
}
