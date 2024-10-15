using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.CursosApp.Entities
{
    public abstract class Persona
    {
        public long DNI = 0;
        public string Nombre = string.Empty;
        public string Apellido = string.Empty;
        public DateOnly FechaNacimiento = new();

        public string NombreCompleto
        {
            get
            {
                //System.Console.WriteLine("Me estan pidiendo el valor");
                return $"{Nombre} {Apellido}";
            }
            set
            {
                //System.Console.WriteLine("Me guardaron un valor");
            }
        }

        public Persona(long dni, string nombre, string apellido, DateOnly fechaNacimiento)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public virtual string DevolverNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public abstract string Saludo();

    }
}
