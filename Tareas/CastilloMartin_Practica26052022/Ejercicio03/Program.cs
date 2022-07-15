using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ingresar un array random, ordenarlo de menor a mayor e imprimirlo,
             * reordenarlo de mayor a menor e imprimirlo.
             */
            int length;
            int[] array;
            Random random = new Random();
            Console.Write("Ingrese el tamaño del array: ");
            length = Convert.ToInt32(Console.ReadLine());
            array = new int[length];
            int[] ascendente = new int[array.Length];
            int[] descendente = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, Convert.ToInt32(Math.Pow(length, 2)));
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------");
            ascendente = array.OrderBy(x => x).ToArray();
            foreach (var item in ascendente)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------");
            descendente = array.OrderByDescending(x => x).ToArray();
            foreach (var item in descendente)
            {
                Console.WriteLine(item);
            }
        }
    }
}
