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

            Console.ReadLine();
        }
    }
}