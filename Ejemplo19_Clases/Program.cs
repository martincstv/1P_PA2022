using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo19_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 16;
            double y = 5;

            Console.WriteLine("---------------------LLAMADO DE CLASE POR INSTANIACION---------------------");
            Operaciones operaciones = new Operaciones();

            Console.WriteLine($"Suma: {operaciones.Sumar(x,y)}");
            Console.WriteLine($"Resta: {operaciones.Restar(x,y)}");
            Console.WriteLine($"Multiplicacion: {operaciones.Multiplicar(x,y)}");
            Console.WriteLine($"Division: {operaciones.Dividir(x,y)}");
            Console.WriteLine($"Potencia: {operaciones.Potencia(x,y)}");
            Console.WriteLine($"Residuo: {operaciones.Residuo(x,y)}");
            Console.WriteLine("---------------------LLAMADO DE CLASE STATICA---------------------");
            Console.WriteLine($"Suma: {OperacionesEstaticas.Sumar(x, y)}");
            Console.WriteLine($"Resta: {OperacionesEstaticas.Restar(x, y)}");
            Console.WriteLine($"Multiplicacion: {OperacionesEstaticas.Multiplicar(x, y)}");
            Console.WriteLine($"Division: {OperacionesEstaticas.Dividir(x, y)}");
            Console.WriteLine($"Potencia: {OperacionesEstaticas.Potencia(x, y)}");
            Console.WriteLine($"Residuo: {OperacionesEstaticas.Residuo(x, y)}");
            Console.WriteLine("---------------------LLAMADO DE CLASE PARTIAL---------------------");
            OperacionesParciales operacionesParciales = new OperacionesParciales();
            Console.WriteLine($"Suma: {operacionesParciales.Sumar(x, y)}");
            Console.WriteLine($"Resta: {operacionesParciales.Restar(x, y)}");
            Console.WriteLine($"Multiplicacion: {operacionesParciales.Multiplicar(x, y)}");
            Console.WriteLine($"Division: {operacionesParciales.Dividir(x, y)}");
            Console.WriteLine($"Potencia: {operacionesParciales.Potencia(x, y)}");
            Console.WriteLine($"Residuo: {operacionesParciales.Residuo(x, y)}");
            Console.WriteLine("---------------------LLAMADO DE CLASE ABSTRACTA---------------------");
            OperacionesAbstractasHija oph = new OperacionesAbstractasHija();
            Console.WriteLine($"Suma: {oph.Sumar(x, y)}");
            Console.WriteLine($"Resta: {oph.Restar(x, y)}");
            Console.WriteLine($"Multiplicacion: {oph.Multiplicar(x, y)}");
            Console.WriteLine($"Division: {oph.Dividir(x, y)}");
            Console.ReadKey();
        }
    }
}
