using Colegio.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
            for (int inicio = 0; inicio <= 5; inicio++)
            {
                Console.WriteLine(inicio);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("For con objetos");

            string[] paises = { "Argentina", "Bolivia", "Peru", "Chile", "Colombia" };

            // Se ejecuta 0 o varias veces
            for (int posicion = 0; posicion <= paises.Length - 1; posicion++)
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

            #region Colecciones

            Console.WriteLine("");
            Console.WriteLine("=========================Colecciones==============================");

            Console.WriteLine("-------------------------");
            Console.WriteLine("Dictionary");

            Dictionary<int, string> materias = new Dictionary<int, string>();

            materias.Add(54, "Matematicas");
            materias.Add(48, "Fisica");
            materias.Add(51, "Ingles");
            materias.Add(56, "Calculo");

            foreach (KeyValuePair<int, string> materia in materias)
            {
                Console.WriteLine("La materia " + materia.Key + " tiene el código " + materia.Value);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Listas");

            var listaPaises = new List<string> { "Argentina", "Bolivia", "Peru", "Chile", "Colombia" };
            listaPaises.Add("Brasil");

            foreach (var pais in paises)
            {
                Console.WriteLine(pais);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Listas con objetos complejos");

            List<Profesor> profesores = new List<Profesor>
            {
                new Profesor { Nombre = "Miguel", Apellido = "Peláez" },
                new Profesor { Nombre = "Juan", Apellido = "Perez" },
                new Profesor { Nombre = "Claudia", Apellido = "Jimenez" }
            };

            foreach (var pais in paises)
            {
                Console.WriteLine("El profesor se llama " + profesor.NombreCompleto);
            }

            #endregion Colecciones

            #region Archivos

            string ruta = @"d:\Archivos\Archivo.txt";

            //Crear Archivo
            Console.WriteLine("Creando Archivo....");
            Console.WriteLine("");
            using (StreamWriter escribir = File.CreateText(ruta))
            {
                escribir.WriteLine("Mi nombre  es Miguel");
                escribir.WriteLine("Mi apellido  es Peláez");
            }

            //Si el archivo existe imprimir en consola el contenido.
            Console.WriteLine("Leyendo Archivo....");
            Console.WriteLine("");
            if (File.Exists(ruta))
            {
                using (StreamReader lectura = File.OpenText(ruta))
                {
                    string texto;

                    while ((texto = lectura.ReadLine()) != null)
                    {
                        Console.WriteLine(texto);
                    }
                }

                Console.WriteLine("El total de archivos en la carpeta destino es : "
                  + Directory.GetFiles(@"d:\Archivos").Length);
            }

            //Administrar Directorios y mover archivo
            string origen = ruta;
            string destino = @"D:\Archivos\Destino";

            DirectoryInfo directorioOrigen = new DirectoryInfo(origen);
            DirectoryInfo directorioDestino = new DirectoryInfo(destino);

            try
            {
                if (!directorioDestino.Exists)
                {
                    directorioDestino.Create();
                }

                directorioOrigen.MoveTo(destino + @"\Archivo1.txt");

                FileInfo[] archivos = directorioDestino.GetFiles();

                foreach (FileInfo infoArchivo in archivos)
                {
                    Console.WriteLine(infoArchivo.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            //Clase Path
            if (Path.HasExtension(@"D:\Archivos\Destino\Archivo1.txt"))
            {
                Console.WriteLine("El archivo tiene extensión");
            }

            Console.WriteLine("Ruta temporal " + Path.GetTempPath() + " Archivo temporal" + Path.GetTempFileName());

            Console.WriteLine("Nombre carpeta " + Path.GetDirectoryName(@"D:\Archivos\Destino\Archivo1.txt"));

            #endregion Archivos

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