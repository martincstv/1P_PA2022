using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Calcular la matriz traspuesta
             */
            int filas, columnas;
            Console.Write("Filas: ");
            filas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columnas: ");
            columnas = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];
            CargaMatriz(matriz);
            MatrizTraspuesta(matriz);
        }

        private static void MatrizTraspuesta(int[,] matriz)
        {
            Console.WriteLine("**************MATRIZ TRASPUESTA**************");
            int[,] matrizTraspuesta = new int[matriz.GetLength(1), matriz.GetLength(0)];
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                for (int fila = 0; fila < matriz.GetLength(0); fila++)
                {
                    matrizTraspuesta[columna, fila] = matriz[fila, columna];
                }
            }
            MostrarMatriz(matrizTraspuesta);
        }

        private static void MostrarMatriz(int[,] matriz)
        {
            //Console.WriteLine($"GetLength(0) {matriz.GetLength(0)} - GetLength(1) {matriz.GetLength(1)}");
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write($"{matriz[fila, columna]}  ");
                }
                Console.WriteLine();
            }
        }

        private static void CargaMatriz(int[,] matriz)
        {
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write($"[fila {fila+1},columna {columna+1}]: ");
                    matriz[fila, columna] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("**************MATRIZ**************");
            MostrarMatriz(matriz);
        }
    }
}
