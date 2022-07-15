using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class Triangulo
    {
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }
        public int Lado3 { get; set; }
        public int Perimetro { get; set; }
        public double Area { get; set; }
        public double Angulo1 { get; set; }
        public double Angulo2 { get; set; }
        public double Angulo3 { get; set; }

        public Triangulo(int lado1, int lado2, int lado3, int perimetro, double area, double angulo1, double angulo2, double angulo3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
            Perimetro = perimetro;
            Area = area;
            Angulo1 = angulo1;
            Angulo2 = angulo2;
            Angulo3 = angulo3;
        }
    }
}
