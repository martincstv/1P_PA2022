using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo15_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Forma - Longitud Fija
            int[,] edades = new int[4, 3];

            //2) Forma - Asignar los valores al momento de la declaracion
            int[,] matriz2 = new int[,] {
            {1,2,3 },

            {4,5,6},
            {7,8,9},
            {10,11,12}
            
            };

            //3) Forma - Bajo Demanda
            int[,] matriz3;
            int fila = 4, columna = 3;
            matriz3 = new int[fila, columna];


            //Recorrer matriz por filas el primero y segundo para columnas
            //fila columna horizontal columna fila vertical
            for (int i = 0; i < matriz2.Length; i++)
            {
                for (int j = 0; j < matriz2.Length; i++)
                {

                }
            }

        }
    }
}
