using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crear un array de 20 posiciones con valores random que no se repitan
             * Imprimir: promedio, promedio pares, promedio impares, promedio primos
             */
            int[] array = new int[20];
            CargaRandomSinRepeticionArray(array);
            ImprimirArray(array);
            Promedios(array);
        }

        private static void Promedios(int[] array)
        {
            double promedio;
            double contPares = 0, sumaPares = 0, promedioPares;
            double contImpares = 0, sumaImpares = 0, promedioImpares;
            double sumaPrimos = 0, contPrimos = 0, promedioPrimos;
            foreach (var item in array)
            {
                int validador = 0;
                for (int i = 1; i <= item; i++)
                {
                    if (item % i == 0)
                        validador++;
                }
                if (validador == 2)
                {
                    sumaPrimos += item;
                    contPrimos++;
                }
                if (item % 2 == 0)
                {
                    sumaPares += item;
                    contPares++;
                }
                else
                {
                    sumaImpares += item;
                    contImpares++;
                }
            }
            promedio = array.Average();
            promedioPares = sumaPares / contPares;
            promedioImpares = sumaImpares / contImpares;
            promedioPrimos = sumaPrimos / contPrimos;
            Console.WriteLine($"\n\nPromedio: {promedio.ToString("F")}");
            Console.WriteLine($"Promedio Pares: {promedioPares.ToString("F")}");
            Console.WriteLine($"Promedio Impares: {promedioImpares.ToString("F")}");
            Console.WriteLine($"Promedio Primos: {promedioPrimos.ToString("F")}");
        }

        private static void ImprimirArray(int[] array)
        {
            char signo;
            Console.WriteLine("*******ARRAY*******");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                    signo = '-';
                else
                    signo = ' ';
                Console.Write($"{array[i]} {signo} ");
            }
        }

        private static void CargaRandomSinRepeticionArray(int[] array)
        {
            Random rm = new Random();
            int value, i = 0;
            do
            {
                value = rm.Next(41);
                if (!array.Contains(value))
                {
                    array[i] = value;
                    i++;
                }

            } while (i < array.Length);
        }
    }
}
