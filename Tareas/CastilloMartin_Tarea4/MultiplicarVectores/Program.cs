using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicarVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiplicar vectores

            Console.Write("Ingresar el limite: ");
            int limite = Convert.ToInt32(Console.ReadLine());
            int[] vectorA = new int[limite];
            CargarVectorEnteros(vectorA);
            int[] vectorB = new int[limite];
            CargarVectorEnteros(vectorB);
            int[] vectorC = new int[limite];
            for (int i = 0; i < limite; i++)
            {
                vectorC[i] = vectorA[i] * vectorB[i];
            }
            for (int i = 0; i < vectorC.Length; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",vectorA[i], vectorB[i], vectorC[i]);
            }
        }

        private static void CargarVectorEnteros(int[] vector)
        {
            Console.WriteLine("CARGAR VECTOR");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Valor[{0}]: = ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
