using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo14_VectoresSuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el limite del vector: ");
            int limite = Convert.ToInt32(Console.ReadLine());

            int[] numerosA = new int[limite];
            CargarVectorEnteros(numerosA);

            int[] numerosB = new int[limite];
            CargarVectorEnteros(numerosB);

            int[] numerosC = new int[limite];

            for (int i = 0; i < limite; i++)
            {
                numerosC[i] = numerosA[i] + numerosB[i];
            }

            ImprimirVectoresEnteros(numerosC);
        }

        static void ImprimirVectoresEnteros(int[] vector)
        {
            Console.WriteLine("Imprimir Vector");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Valor: {0}", vector[i]);
            }
        }

        private static void CargarVectorEnteros(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Valor[{0}]: = ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
