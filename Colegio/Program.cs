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

            #region Encapsulamiento

            Console.WriteLine("");
            Console.WriteLine("=========================ENCAPSULAMIENTO==============================");
            Alumno alumno = new Alumno("Miguel", "Pelaez")
            {
                Id = 1,
                //Nombre = "Miguel",
                //Apellido = "Pelaez",
                Grupo = "11C",
                SegundoApellido = "Lopez"
            };

            Console.WriteLine($"El alumno es: {alumno.NombreCompleto}");

            //Persona persona = new Persona
            //{
            //    Id = 1,
            //    Nombre = "Carlos",
            //    Apellido = "Sanjuan"
            //};

            #endregion Encapsulamiento

            #region Conversiones

            Console.WriteLine("");
            Console.WriteLine("=========================CONVERSIONES==============================");

            Persona persona1 = alumno;

            //No permitido
            //Alumno alumno1 = persona;

            Console.WriteLine($"La persona es de tipo {persona1.GetType()} ");
            Console.WriteLine("");

            #endregion Conversiones

            Profesor profesor = new Profesor
            {
                Id = 1,
                Nombre = "Miguel",
                Apellido = "Pelaez",
                Catedra = ".NET Básico"
            };

            #region Polimorfismo

            Console.WriteLine("");
            Console.WriteLine("=========================POLIMORFISMO==============================");

            string informacionAlumno = ObtenerInformacionAlumno(alumno.Nombre);
            string informacionAlumno2 = ObtenerInformacionAlumno(alumno.Nombre, alumno.Apellido);
            string informacionAlumno3 = ObtenerInformacionAlumno(alumno.Nombre, alumno.Apellido, alumno.SegundoApellido);

            Console.WriteLine(informacionAlumno);
            Console.WriteLine(informacionAlumno2);
            Console.WriteLine(informacionAlumno3);

            #endregion Polimorfismo

            #region Clases Abstractas

            Console.WriteLine("");
            Console.WriteLine("=========================CLASES ABSTRACTAS==============================");

            Console.WriteLine($"Resumen Alumno: {alumno.CrearResumen()}");
            Console.WriteLine($"Resumen Profesor: {profesor.CrearResumen()}");

            //Imprimir multiples resúmenes
            List<Persona> personas = new List<Persona>
            {
                new Alumno("Miguel", "Pelaez") { Id = 1, Grupo= "11C" },
                new Alumno("Carlos", "Restrepo") { Id = 2, Grupo = "11C" },
                new Alumno("Cristiva", "Jaramillo") { Id=3, Grupo ="11B"  },
                new Profesor { Id = 4, Nombre = "Carlos", Apellido ="Sanjuan", Catedra =".NET Básico"  },
                new Profesor { Id= 5, Nombre="Juan", Apellido="Gonzalez", Catedra = "Java Básico" }
            };

            Console.WriteLine("");
            Console.WriteLine($"Resumenes de Personas:");
            foreach (Persona persona in personas)
            {
                Console.WriteLine("");
                Console.WriteLine(persona.GetType());
                Console.WriteLine(persona.CrearResumen());
            }

            #endregion Clases Abstractas

            #region Ciclos

            Console.WriteLine("");
            Console.WriteLine("=========================Ciclos==============================");

            Console.WriteLine("-------------------------");
            Console.WriteLine("do - While");

            int valorInicial = 0;
            int valorFinal = 5;

            // Se ejecuta 1 o varias veces
            do
            {
                Console.WriteLine(valorInicial);
                valorInicial++;
            } while (valorInicial < valorFinal);

            Console.WriteLine("-------------------------");
            Console.WriteLine("While");

            valorInicial = 0;
            valorFinal = 5;

            // Se ejecuta 0 o varias veces
            while (valorInicial < valorFinal)
            {
                Console.WriteLine(valorInicial);
                valorInicial++;
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("For");

            // Se ejecuta 0 o varias veces
            for (int inicio = 0; valorInicial <= 5; valorInicial++)
            {
                Console.WriteLine(inicio);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("For con objetos");

            string[] paises = { "Argentina", "Bolivia", "Peru", "Chile", "Colombia" };

            // Se ejecuta 0 o varias veces
            for (int posicion = 0; posicion <= paises.Length; posicion++)
            {
                Console.WriteLine(paises[posicion]);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Foreach");

            // Se ejecuta 0 o varias veces
            foreach (string pais in paises)
            {
                Console.WriteLine(pais);
            }

            #endregion Ciclos

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