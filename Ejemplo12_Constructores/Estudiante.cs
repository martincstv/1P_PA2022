using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo12_Constructores
{
    internal class Estudiante
    {
        //Upper camel case para las propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public int Edad { get; set; }
        /// <summary>
        /// Primer constructor sin parametros
        /// </summary>
        public Estudiante()
        {

        }
        /// <summary>
        /// Segundo constructor con todos los parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="cedula"></param>
        /// <param name="edad"></param>
        public Estudiante(int id, string nombre, string cedula, int edad)
        {
            Id = id;
            Nombre = nombre;
            Cedula = cedula;
            Edad = edad;
        }
        /// <summary>
        /// Tercer constructor con parametros Id y Cedula
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cedula"></param>
        public Estudiante(int identificador, string numerocedula)
        {
            Id = identificador;
            Cedula = numerocedula;
        }
    }
}
