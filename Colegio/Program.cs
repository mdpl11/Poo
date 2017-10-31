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

            Alumno alumno = new Alumno
            {
                Id = 1,
                Nombre = "Miguel",
                Apellido = "Pelaez",
                Grupo = "11C"
            };

            Persona persona = new Persona()
            {
                Id = 1,
                Nombre = "Carlos",
                Apellido = "Sanjuan"
            };

            Console.WriteLine($"El alumno es: {alumno.NombreCompleto}");

            Console.ReadLine();
        }
    }
}