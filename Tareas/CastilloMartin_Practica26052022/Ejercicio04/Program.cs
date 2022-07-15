using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crear una matriz cuatratica y obtener el promedio
             * de la diagonal principal y secundaria
             */
            int length;
            Console.Write("Ingrese la dimensión de la matriz: ");
            length = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[length, length];
            CargaRandomMatriz(matriz);
            MostrarMatriz(matriz);
            PromedioDiagonalPrincipal(matriz);
            PromedioDiagonalSecundaria(matriz);
        }

        private static void PromedioDiagonalSecundaria(int[,] matriz)
        {
            float suma = 0, promedio;
            int j = matriz.GetLength(1) - 1;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                suma += matriz[i, j];
                j--;
            }
            promedio = suma / matriz.GetLength(1);
            Console.WriteLine($"Promedio Dg. Secundaria: {promedio.ToString("F")}");
        }

        private static void PromedioDiagonalPrincipal(int[,] matriz)
        {
            float suma = 0, promedio;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                suma += matriz[i, i];
            }
            promedio = suma / matriz.GetLength(1);
            Console.WriteLine($"Promedio Dg. Principal: {promedio.ToString("F")}");
        }

        private static void MostrarMatriz(int[,] matriz)
        {
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write($"{matriz[fila, columna]}");
                }
                Console.WriteLine();
            }
        }

        private static void CargaRandomMatriz(int[,] matriz)
        {
            Random rm = new Random();
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    matriz[fila, columna] = rm.Next(10);
                }
            }
        }


    }
}
