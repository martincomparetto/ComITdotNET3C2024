using ComIT.Comunes.Entities;
using CursosApp.Context;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Internal;

namespace CursosApp.Components.Pages.Profesores
{
    public partial class ProfesorPage
    {
        [Inject]
        public ApplicationDbContext Context { get; set; } = default;

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

        private ProfesorModal modal = default!;

        private void NuevoProfesor()
        {
            var listados = Context.Pruebas.ToList();
            ProfesorModificando = new Profesor();
            modal.Open();
        }

        private void Guardar()
        {
            if (ProfesorModificando.DNI == 0 || ProfesorModificando.Nombre == "" || ProfesorModificando.Apellido == "" || ProfesorModificando.FechaNacimiento == null)
            {
                MensajeError = "No se ingresaron todos los datos del profesor";
            }
            else
            {
                if (!EstamosModificando)
                {
                    Context.Pruebas.Add(new Entities.Prueba() { Nombre = "Prueba" });
                    Context.SaveChanges();
                    ProfesoresList.Add(ProfesorModificando);
                }
                else
                {
                    EstamosModificando = false;
                }

                ProfesorModificando = null;
                MensajeError = "";
                modal.Close();
            }
        }

        private void Modificar(Profesor profesorModificar)
        {
            EstamosModificando = true;
            ProfesorModificando = profesorModificar;

            modal.Open();
        }

        private void Eliminar(Profesor profesorEliminar)
        {
            ProfesoresList.Remove(profesorEliminar);
        }
    }
}

