using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03_IfAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           * Comentario Multilinea
           * Salario de la persona es >= $500 => entonces el impuesto es de $30
           * Salario de la persona es < $500 => entonces el impuesto es de $20
           */
            float salarioPersona = 0, impuesto = 0;
            Console.Write("Por favor, ingrese su salario: ");
            //salarioPersona = float.Parse(Console.ReadLine());
            salarioPersona = Convert.ToSingle(Console.ReadLine());
            if (salarioPersona >= 500)
                impuesto = 30;
            else
                impuesto = 20;
            //Console.WriteLine("En funcion de su salario de: $ {0} Su impuesto es: $ {1}", salarioPersona, impuesto);
            Console.WriteLine($"En funcion de su salario de: $ {salarioPersona} Su impuesto es: $ {impuesto}");
            Console.ReadKey();
        }
    }
}
