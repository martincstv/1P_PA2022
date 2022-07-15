using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sumar todos los numeros pares generados en los
             * 1000 primeros numeros Fibonacci
             */
            int length = 1000;
            BigInteger suma = 0;
            foreach (var item in SerieFibonacci(length))
            {
                if (item % 2 == 0)
                    suma += item;
            }
            Console.WriteLine($"Suma de pares de los 1000 primeros numeros Fibonacci: {suma}");

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
