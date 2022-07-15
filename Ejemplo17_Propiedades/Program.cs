using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo17_Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Id = 1;
            empleado.Nombre = "Anita Vaca";
            empleado.Cedula = "1803333333";
            //empleado.Salario = 425;
            Console.WriteLine("ID - NOMBRE -      CEDULA - SALARIO");
            Console.WriteLine($" {empleado.Id} - {empleado.Nombre} - {empleado.Cedula} - ${empleado.Salario}");

            empleado.ListaActividades.Add(new Actividad("Programar", 2));
            empleado.ListaActividades.Add(new Actividad("Reunion", 1));
            empleado.ListaActividades.Add(new Actividad("Mantenimiento", 3));
            empleado.ListaActividades.Add(new Actividad("Capacitación", 1));

            foreach (var item in empleado.ListaActividades)
            {
                Console.WriteLine($"Actividad: {item.Nombre} -  Horas: {item.HorasActividad}");
            }
            
            Console.ReadKey();
        }
    }

    class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }

        private double _salario;

        public double Salario
        {
            get
            {
                if (_salario == 0)
                {
                    _salario = 400;
                }
                return _salario;
            }
            set { _salario = value; }
        }

        //public List<Actividad> ListaActividades { get; set; }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


    }

    class Actividad
    {
        public string Nombre { get; set; }
        public int HorasActividad{ get; set; }

        public Actividad(string nombre, int horasActividad)
        {
            Nombre = nombre;
            HorasActividad = horasActividad;
        }
    }
}