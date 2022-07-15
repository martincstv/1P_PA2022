using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo04_CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Comentario Multilinea
            * Salario de la persona es >= $500 => entonces el impuesto es de $30
            * Salario de la persona es < $500 y >=$300 => entonces el impuesto es de $20
            * Salario de la persona es < $300 => entonces el impuesto es de $10
            */
            float salarioPersona = 0, impuesto = 0;
            Console.Write("Por favor, ingrese su salario: ");
            //salarioPersona = float.Parse(Console.ReadLine());
            salarioPersona = Convert.ToSingle(Console.ReadLine());
            if (salarioPersona < 0)
            {
                Console.WriteLine("El salario no puede ser negativo");
                return;//me saca del programa
            }
            if (salarioPersona >= 500)
                impuesto = 30;
            else
            {
                if (salarioPersona < 500 && salarioPersona >= 300)
                    impuesto = 20;
                else
                    impuesto = 10;
            }
            //Console.WriteLine("En funcion de su salario de: $ {0} Su impuesto es: $ {1}", salarioPersona, impuesto);
            Console.WriteLine($"En funcion de su salario de: $ {salarioPersona} Su impuesto es: $ {impuesto}");
            Console.ReadKey();
        }
    }
}
