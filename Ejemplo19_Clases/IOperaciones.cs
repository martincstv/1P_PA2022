using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo19_Clases
{
    internal interface IOperaciones
    {
        double Sumar(double valor1, double valor2);
        double Restar(double valor1, double valor2);
        double Multiplicar(double valor1, double valor2);
        double Dividir(double valor1, double valor2);
        double Potencia(double valor1, double valor2);
        double Residuo(double valor1, double valor2);

    }
}
