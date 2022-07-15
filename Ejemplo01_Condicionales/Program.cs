using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01_Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Comentario Multilinea
             * Salario de la persona es >= $500 => entonces el impuesto es de $30
             */
            float salarioPersona = 0, impuesto = 0;
            Console.Write("Por favor, ingrese su salario: ");
            //salarioPersona = float.Parse(Console.ReadLine());
            salarioPersona = Convert.ToSingle(Console.ReadLine());
            impuesto = salarioPersona >= 500 ? 30 : 0;
            Console.WriteLine("El valor del impuesto es: $" + impuesto);
            Console.ReadKey();
        }
    }
}
