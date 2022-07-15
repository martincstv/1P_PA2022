using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo11_MetodosMultiplesParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promedio = {0}", CalcularPromedioDosCalificaciones(10, 6.7));
            Console.WriteLine("Promedio = {0}", CalcularPromedioTresCalificaciones(10, 6.7, 5));

            Console.WriteLine("Promedio = {0}", CalcularPromedioCalificaciones(10, 6.7));
            Console.WriteLine("Promedio = {0}", CalcularPromedioCalificaciones(10, 6.7, 5));
            Console.WriteLine("Promedio = {0}", CalcularPromedioCalificaciones(10, 6.7, 5, 2.1));
            Console.WriteLine("Promedio = {0}", CalcularPromedioCalificaciones(10, 9, 8, 7, 1));

            Console.ReadKey();
        }
        static double CalcularPromedioCalificaciones(params double[] calificaciones)
        {
            //return calificaciones.Average();
            double promedio = 0;
            for (int i = 0; i < calificaciones.Length; i++)
                promedio += calificaciones[i];
            return promedio / calificaciones.Length;
        }

        static double CalcularPromedioDosCalificaciones(double nota1, double nota2)
        {
            return (nota1 + nota2) / 2;
        }

        static double CalcularPromedioTresCalificaciones(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
