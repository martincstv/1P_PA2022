using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * De una empresa de transporte se quiere guardar el nombre de los conductores que tiene, y 
             * los kilómetros que conducen cada día de la semana.
             * Para guardar esta información se van a utilizar dos arreglos:
             * • Nombre: Vector para guardar los nombres de los conductores.
             * • kms: Tabla para guardar los kilómetros que realizan cada día de la semana.
             * Se quiere generar un nuevo vector (“total_kms”) con los kilómetros totales que realza cada 
             * conductor.
             * Al finalizar se muestra la lista con los nombres de conductores y los kilómetros que ha 
             * realizado.
             */
            string[] nombresConductores = new string[] {"Juan","Martin","Roller","Daniel","Isaac"};
            float[,] kms = new float[5,7] {{1,2,3,4,5,6,7},
                                           {1,2,3,4,5,6,7},
                                           {1,2,3,4,5,6,7},
                                           {1,2,3,4,5,6,7},
                                           {1,2,3,4,5,6,7}};
            float[] total_kms = new float[nombresConductores.Length];
            for (int fila = 0; fila < kms.GetLength(0); fila++)
            {
                for (int columna = 0; columna < kms.GetLength(1); columna++)
                {
                    total_kms[fila] += kms[fila,columna];
                }
            }
            for (int i = 0; i < nombresConductores.Length; i++)
            {
                Console.WriteLine(nombresConductores[i] + " - " + total_kms[i] + " Kms");
            }

        }
    }
}
