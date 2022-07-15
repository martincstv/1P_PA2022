using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo09_ForEach
{
    class Mascota
    {
        public string Tipo { get; set; }
        public int Edad { get; set; }
        public bool Esterilizado { get; set; }
        public Mascota()
        {

        }

        public Mascota(string tipo, int edad, bool esterilizado)
        {
            Tipo = tipo;
            Edad = edad;
            Esterilizado = esterilizado;
        }
    }
    class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public Persona()
        {

        }
        public Persona(string cedula, string nombre) //Acciones Rapidas y Refactorizantes
        {
            Cedula = cedula;
            Nombre = nombre;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //IQuerable
            //IList
            //List
            //Generic
            List<int> listaNumerosPares = new List<int>() { 2, 4, 6, 8, 10 };
            List<float> listaNumerosFloat = new List<float>() { 3.14F, 2.71F, 5.89F };
            List<string> listaEstudiantes = new List<string>() { "Hugo", "Paco", "Luis" };
            List<Persona> listaPersonas = new List<Persona>();

            Persona persona1 = new Persona();
            persona1.Cedula = "1111111111";
            persona1.Nombre = "Andres";
            Persona persona2 = new Persona("2222222222", "Anita");
            Persona persona3 = new Persona("3333333333", "Carla");
            listaPersonas.Add(persona1);
            listaPersonas.Add(persona2);
            listaPersonas.Add(persona3);
            listaPersonas.Add(new Persona("4444444444", "Silvia"));
            listaPersonas.Add(new Persona("5555555555", "Monserrath"));
            listaPersonas.Add(new Persona("6666666666", "Mateo"));

            //foreach (var elemento in listaEstudiantes)
            //{
            //    Console.WriteLine("Valor: {0}", elemento);
            //}

            foreach (var elemento in listaPersonas)
            {
                Console.WriteLine("Nombre: {0} - Cedula: {1}", elemento.Nombre, elemento.Cedula);
            }

            List<Mascota> listaMascota = new List<Mascota>();
            listaMascota.Add(new Mascota("Gato", 10, true));
            listaMascota.Add(new Mascota("Perro", 2, false));
            listaMascota.Add(new Mascota("Leon", 4, true));
            listaMascota.Add(new Mascota("Pez", 1, false));
            listaMascota.Add(new Mascota("Jirafa", 3, false));
            listaMascota.Add(new Mascota("Salamandra", 2, false));
            Console.WriteLine("Tipo     Edad        Esterilizado");
            foreach (var item in listaMascota)
            {
                Console.WriteLine(item.Tipo + "     " + item.Edad + "       " + item.Esterilizado);
            }
        }
    }
}
