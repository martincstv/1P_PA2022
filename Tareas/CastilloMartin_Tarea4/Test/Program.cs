using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        { //1)Forma
            int[] edades = new int[2];
            string[] diasSemana = new string[7];
            edades[0] = 20;
            edades[1] = 30;

            //2)Forma
            int[] temperaturas = new int[] { 2, 3, 5, 3, 4, 7, 6, 7, 3, 4 };
            string[] alumnos = new string[] { "Hugo", "Paco", "Luis" };

            int[] temperaturas2 = { 2, 3, 5, 3, 4, 7, 6, 7, 3, 4 };
            string[] alumnos2 = { "Hugo", "Paco", "Luis" };

            //3)Forma - Bajo Demanda
            double[] sismos;//declaro
            int numeroSismos = 5;
            sismos = new double[numeroSismos];
            sismos[0] = 2.3F;
            sismos[1] = 3.3F;
            sismos[2] = 4.3F;
            sismos[3] = 5.3F;
            sismos[4] = 7.3F;

            object[] elementos = new object[] { 1, "Hola", true };

            ImprimirVectoresEnteros(edades);
            Console.WriteLine("----------------");
            ImprimirVectoresEnteros(temperaturas);
            Console.WriteLine("----------------");
            ImprimirVectoresDoubles(sismos);
            Console.WriteLine("----------------");
            ImprimirVectores(elementos);


            Console.ReadKey();

        }

        #region Impresion de Vectores
        static void ImprimirVectoresEnteros(int[] vector)
        {
            Console.WriteLine("Imprimir Vector");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Valor: {0}", vector[i]);
            }
        }

        static void ImprimirVectoresDoubles(double[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Valor: {0}", vector[i].ToString("F"));
            }
        }

        static void ImprimirVectores(object[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Valor: {0}", vector[i]);
            }
        }
        #endregion
    }
}
