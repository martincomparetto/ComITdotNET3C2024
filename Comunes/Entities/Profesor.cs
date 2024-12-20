﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Comunes.Entities
{
    public class Profesor : Persona
    {
        public int AñosExperiencia = 0;
        public string Materia = "";

        public Profesor() : base()
        { }

        public Profesor(long dni, string nombre, string apellido, DateOnly fechaNacimiento, int añosExperiencia, string materia) 
            : base(dni, nombre, apellido, fechaNacimiento)
        {
            AñosExperiencia = añosExperiencia;
            Materia = materia;
        }

        public override string DevolverNombreCompleto()
        {
            return $"Profesor: {base.DevolverNombreCompleto()}";
        }

        public override string Saludo()
        {
            return "Buenos días Alumnos";
        }
    }
}
