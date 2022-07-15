using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class Funcion
    {
        Random rm = new Random();

        public enum DiasSemana
        {
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado,
            Domingo
        }

        public enum Meses : int
        {
            Enero = 1,
            Febrero = 2,
            Marzo = 3,
            Abril = 4,
            Mayo = 5,
            Junio = 6,
            Julio = 7,
            Agosto = 8,
            Septiembre = 9,
            Octubre = 10,
            Noviembre = 11,
            Diciembre = 12
        }

        public int[] CargarVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Valor[{i + 1}]: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            return vector;
        }

        public float[] CargarVector(float[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Valor[{i + 1}]: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            return vector;
        }

        public double[] CargarVector(double[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Valor[{i + 1}]: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            return vector;
        }

        public string[] CargarVector(string[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Cadena[{i + 1}]: ");
                vector[i] = Console.ReadLine();
            }
            return vector;
        }

        public int[] CargarVectorRandom(int[] array, int minValue, int maxValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rm.Next(minValue, maxValue+1);
            }
            return array;
        }

        public int[] CargarVectorRandom(int[] array, int maxValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rm.Next(maxValue + 1);
            }
            return array;
        }

        public void ImprimirVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Valor[{i + 1}]: {vector[i]}");
            }
        }

        public void ImprimirVector(float[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Valor[{i + 1}]: {vector[i]}");
            }
        }

        public void ImprimirVector(double[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Valor[{i + 1}]: {vector[i]}");
            }
        }

        public void ImprimirVector(string[] vector)
        {
            foreach (var item in vector)
            {
                Console.WriteLine(" * {0}", item);
            }
        }

        public void ImprimirMatrizBidimensional(int[,] matriz)
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

        public void ImprimirMatrizBidimensional(byte[,] matriz)
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

        public int LecturaEntero(string leyenda)
        {
            Console.Write($"{leyenda}: ");
            int value = Convert.ToInt32(Console.ReadLine());
            return value;
        }

        public float LecturaFlotante(string leyenda)
        {
            Console.Write($"{leyenda}: ");
            float value = Convert.ToSingle(Console.ReadLine());
            return value;
        }

        public double LecturaDoble(string leyenda)
        {
            Console.Write($"{leyenda}: ");
            double value = Convert.ToDouble(Console.ReadLine());
            return value;
        }

        public string LecturaCadena(string leyenda)
        {
            Console.Write($"{leyenda}: ");
            string value = Console.ReadLine();
            return value;
        }


    }
}
