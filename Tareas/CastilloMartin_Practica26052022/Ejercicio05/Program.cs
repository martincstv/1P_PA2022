using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Genere n triangulos con lados aleatorios
             * Calcular: perimetro, area, angulos internos
             */
            List<Triangulo> triangulos = new List<Triangulo>();
            Random rm = new Random();
            int cantidadTriangulos, lado1, lado2, lado3, perimetro;
            double heron, area, radianes1, angulo1, radianes2, angulo2, radianes3, angulo3;
            Console.Write("Cantidad de triangulos: ");
            cantidadTriangulos = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidadTriangulos; i++)
            {
                lado1 = rm.Next(1,11);
                lado2 = rm.Next(1, 11);
                lado3 = rm.Next(1, 11);
                perimetro = lado1 + lado2 + lado3;
                heron = perimetro / 2;
                area = Math.Sqrt(heron * (heron - lado1) * (heron - lado2) * (heron - lado3));
                radianes1 = Math.Acos((Math.Pow(lado2, 2) + Math.Pow(lado3, 2) - Math.Pow(lado1, 2)) / (2 * lado2 * lado3));
                angulo1 = radianes1 * (180 / Math.PI);
                radianes2 = Math.Acos((Math.Pow(lado1, 2) + Math.Pow(lado3, 2) - Math.Pow(lado2, 2)) / (2 * lado1 * lado3));
                angulo2 = radianes2 * (180 / Math.PI);
                radianes3 = Math.Acos((Math.Pow(lado1, 2) + Math.Pow(lado2, 2) - Math.Pow(lado3, 2)) / (2 * lado1 * lado2));
                angulo3 = radianes3 * (180 / Math.PI);
                triangulos.Add(new Triangulo(lado1, lado2, lado3,perimetro,area,angulo1,angulo2,angulo3));
            }
            foreach (var item in triangulos)
            {
                Console.WriteLine("*******TRIANGULO*******");
                Console.WriteLine($"Lado 1: {item.Lado1}");
                Console.WriteLine($"Lado 2: {item.Lado2}");
                Console.WriteLine($"Lado 3: {item.Lado3}");
                Console.WriteLine($"Perimetro: {item.Perimetro}");
                Console.WriteLine($"Area: {item.Area.ToString("F")}");
                Console.WriteLine($"Angulo 1: {item.Angulo1.ToString("F")}");
                Console.WriteLine($"Angulo 2: {item.Angulo2.ToString("F")}");
                Console.WriteLine($"Angulo 3: {item.Angulo3.ToString("F")}");

            }
        }
    }
}
