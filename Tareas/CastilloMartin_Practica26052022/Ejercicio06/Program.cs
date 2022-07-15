using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ingrese 2 rectas
             * Calcular los angulos formados entre ellas
             */
            Console.Write("X1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("X2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double radianes = Math.Acos((x1*x2+y1*y2)/(Math.Abs(Math.Sqrt(Math.Pow(x1,2)+Math.Pow(y1,2)))*Math.Abs(Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)))));
            double teta = radianes * (180 / Math.PI);
            double alfa = 180 - teta;
            Console.WriteLine($"Angulo teta: {teta}");
            Console.WriteLine($"Angulo alfa: {alfa}");
        }
    }
}
