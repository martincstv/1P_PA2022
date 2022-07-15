using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Diseñar el algoritmo correspondiente a un programa, que:
             * • Crea una tabla bidimensional de longitud 5x5 y nombre ‘matriz’.
             * • Carga la tabla con valores numéricos enteros.
             * • Suma todos los elementos de cada fila y todos los elementos de cada columna 
             * visualizando los resultados en pantalla.
             */
            int[,] matriz = new int[5,5] { { 1, 2, 3, 4, 5 },
                                         { 6, 7, 8, 9, 10 },
                                         { 1, 2, 3, 4, 5 },
                                         { 6, 7, 8, 9, 10 },
                                         { 1, 2, 3, 4, 5 }};
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write($"m[{fila},{columna}]: {matriz[fila,columna]}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
