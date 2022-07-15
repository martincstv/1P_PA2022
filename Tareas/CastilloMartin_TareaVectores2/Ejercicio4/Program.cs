using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Programa que declare un vector de diez elementos enteros y pida números para rellenarlo
             * hasta que se llene el vector o se introduzca un número negativo. Entonces se debe imprimir
             * el vector (sólo los elementos introducidos).
             */
            Funcion fun = new Funcion();
            int[] vectorEnteros = new int[10];
            int numero, contador = 0;
            for (int i = 0; i < vectorEnteros.Length; i++)
            {
                Console.Write("Ingrese un número[{0}]: ", i + 1);
                numero = int.Parse(Console.ReadLine());
                if (numero >= 0)
                {
                    vectorEnteros[i] = numero;
                    contador++;
                }
                else
                    break;
            }
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(vectorEnteros[i]);
            }
        }
    }
}
