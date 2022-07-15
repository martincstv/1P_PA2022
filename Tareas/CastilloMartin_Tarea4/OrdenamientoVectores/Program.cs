using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ordenamiento vectores != metodo burbuja
            //Metodo de ordenación por inserción o indice
            int[] vector = { 5, 3, 14, 20, 8, 9, 1 };
            int datoTemporal;
            foreach (int dato in vector)
                Console.Write("{0} ", dato);
            Console.WriteLine();
            for (int i = 1; i < vector.Length; i++)
            {
                int j = i - 1;
                while ((j >= 0) && (vector[j] > vector[j + 1]))
                {
                    datoTemporal = vector[j];
                    vector[j] = vector[j + 1];
                    vector[j + 1] = datoTemporal;
                    j--;
                }
            }
            Console.Write("Ordenado por indice:");
            foreach (int dato in vector)
                Console.Write("{0} ", dato);
            Console.WriteLine();
        }
    }
}
