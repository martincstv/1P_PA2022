using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayoresEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ingresar el nombre y edad de N personas
             * Imprimir *quienes* son mayores de edad 
             */
            Console.Write("Ingrese la cantidad de personas limite: ");
            int cantidadPersonas = Convert.ToInt32(Console.ReadLine());
            string[] nombres = new string[cantidadPersonas];
            int[] edades = new int[cantidadPersonas];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese el nombre de la Persona[{0}]: ",(i+1));
                nombres[i] = Console.ReadLine();
                Console.Write("Ingrese la edad de {0}: ",nombres[i]);
                edades[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Mayores de Edad");
            Console.WriteLine("---------------");
            for (int i = 0; i < edades.Length; i++)
            {
                if (edades[i] >= 18)
                {
                    Console.WriteLine(nombres[i]);
                }
            }
        }
    }
}
