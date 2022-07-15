using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo12_Constructores
{
    internal class Program
    {
        //si en la clase que creo no hay ningun constructor me va a paermitir instanciar la clase sun parametros
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();
            estudiante1.Id = 1;
            estudiante1.Nombre = "Diana";
            estudiante1.Cedula = "1111111111";
            estudiante1.Edad = 30;
            Estudiante estudiante2 = new Estudiante(2, "Juanito", "2222222222", 22);
            Estudiante estudiante3 = new Estudiante(3, "3333333333");
            estudiante3.Edad = 21;
            estudiante3.Nombre = "Anita";
            Console.Read();
        }
    }
}
