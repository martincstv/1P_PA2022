using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crear la serie de Fibonacci en un array de n posiciones
             */
            int length;
            Console.Write("Cantidad de posiciones: ");
            length = Convert.ToInt32(Console.ReadLine());
            foreach (var item in SerieFibonacci(length))
            {
                Console.WriteLine(item);
            }
        }

        private static BigInteger[] SerieFibonacci(int length)
        {
            BigInteger[] serie = new BigInteger[length];
            serie[0] = 0;
            serie[1] = 1;
            BigInteger sucesor = 1, antecesor = 0;
            for (int i = 2; i < serie.Length; i++)
            {
                BigInteger fibonacci = antecesor + sucesor;
                antecesor = sucesor;
                sucesor = fibonacci;
                serie[i] = fibonacci;
            }
            return serie;
        }
    }
}
