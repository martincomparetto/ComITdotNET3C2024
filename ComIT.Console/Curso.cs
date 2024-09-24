using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Console
{
    public class Curso
    {
        public string Nombre = "";
        public int CantidadMaximaAlumnos = 0;
        public Profesor Profesor;
        public Alumno[] Alumnos;

        public Curso(string nombreCurso, int cantidadMaximaAlumnos, Profesor profesor)
        {
            Nombre = nombreCurso;
            CantidadMaximaAlumnos = cantidadMaximaAlumnos;
            Profesor = profesor;
            Alumnos = new Alumno[CantidadMaximaAlumnos];
        }
    }
}
