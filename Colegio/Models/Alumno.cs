using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Models
{
    public class Alumno : Persona
    {
        public string Grupo { get; set; }

        public Alumno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string CrearResumen()
        {
            return $"{NombreCompleto} - {Grupo}";
        }

        public override string NombreCompleto =>
            "El Alumno es: " + base.NombreCompleto.ToUpper();
    }
}