using ComIT.Comunes.Entities;

namespace CursosApp.Components.Pages.Profesores
{
    public partial class ProfesorPage
    {
        private string MensajeError = "";
        private bool EstamosModificando = false;
        private Profesor? ProfesorModificando;

        private long DNI = 0;
        private string Nombre = "";
        private string Apellido = "";
        private DateOnly? FechaNacimiento;
        private int AñosExperiencia = 0;
        private string Materia = "";
        private List<Profesor> ProfesoresList = new();

        private void NuevoProfesor()
        { }

        private void Agregar()
        {
            if (DNI == 0 || Nombre == "" || Apellido == "" || FechaNacimiento == null)
            {
                MensajeError = "No se ingresaron todos los datos del profesor";
            }
            else
            {
                ProfesoresList.Add(new Profesor(DNI, Nombre, Apellido, (DateOnly)FechaNacimiento, AñosExperiencia, Materia));

                DNI = 0;
                Nombre = "";
                Apellido = "";
                FechaNacimiento = null;
                AñosExperiencia = 0;
                Materia = "";

                MensajeError = "";
            }
        }

        private void Modificar(Profesor profesorModificar)
        {
            EstamosModificando = true;
            ProfesorModificando = profesorModificar;

            DNI = profesorModificar.DNI;
            Nombre = profesorModificar.Nombre;
            Apellido = profesorModificar.Apellido;
            FechaNacimiento = profesorModificar.FechaNacimiento;
            AñosExperiencia = profesorModificar.AñosExperiencia;
            Materia = profesorModificar.Materia;
        }

        private void GuardarCambios()
        {
            if (DNI == 0 || Nombre == "" || Apellido == "" || FechaNacimiento == null)
            {
                MensajeError = "No se ingresaron todos los datos del profesor";
            }
            else
            {
                ProfesorModificando.DNI = DNI;
                ProfesorModificando.Nombre = Nombre;
                ProfesorModificando.Apellido = Apellido;
                ProfesorModificando.FechaNacimiento = (DateOnly)FechaNacimiento;
                ProfesorModificando.AñosExperiencia = AñosExperiencia;
                ProfesorModificando.Materia = Materia;

                DNI = 0;
                Nombre = "";
                Apellido = "";
                FechaNacimiento = null;
                AñosExperiencia = 0;
                Materia = "";

                EstamosModificando = false;
                ProfesorModificando = null;
            }
        }

        private void Eliminar(Profesor profesorEliminar)
        {
            ProfesoresList.Remove(profesorEliminar);
        }
    }
}

