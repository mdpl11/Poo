﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Models
{
    public class Profesor : Persona
    {
        public string Catedra { get; set; }

        public override string CrearResumen()
        {
            return $"{NombreCompleto} - {Catedra}";
        }
    }
}