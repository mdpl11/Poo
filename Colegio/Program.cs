using Colegio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Gestión del Colegio");

            Alumno alumno = new Alumno("Miguel", "Pelaez")
            {
                Id = 1,
                //Nombre = "Miguel",
                //Apellido = "Pelaez",
                Grupo = "11C",
                SegundoApellido = "Lopez"
            };

            Console.WriteLine($"El alumno es: {alumno.NombreCompleto}");

            Persona persona = new Persona
            {
                Id = 1,
                Nombre = "Carlos",
                Apellido = "Sanjuan"
            };

            #region Conversiones

            Persona persona1 = alumno;

            //No permitido
            //Alumno alumno1 = persona;

            Console.WriteLine($"La persona es de tipo {persona1.GetType()} ");

            #endregion Conversiones

            Profesor profesor = new Profesor
            {
                Id = 1,
                Nombre = "Miguel",
                Apellido = "Pelaez",
                Catedra = ".NET Básico"
            };

            #region Polimorfismo

            string informacionAlumno = ObtenerInformacionAlumno(alumno.Nombre);
            string informacionAlumno2 = ObtenerInformacionAlumno(alumno.Nombre, alumno.Apellido);
            string informacionAlumno3 = ObtenerInformacionAlumno(alumno.Nombre, alumno.Apellido, alumno.SegundoApellido);

            Console.WriteLine(informacionAlumno);
            Console.WriteLine(informacionAlumno2);
            Console.WriteLine(informacionAlumno3);

            #endregion Polimorfismo

            Console.ReadLine();
        }

        public static string ObtenerInformacionAlumno(string nombre)
        {
            return $"Nombre: {nombre}";
        }

        public static string ObtenerInformacionAlumno(string nombre, string apellido)
        {
            return $"Nombre: {nombre} - Apellido: {apellido}";
        }

        public static string ObtenerInformacionAlumno(string nombre, string apellido, string segundoApellido)
        {
            return $"Nombre: {nombre} - Apellido: {apellido} - Segundo Apellido {segundoApellido} ";
        }
    }
}