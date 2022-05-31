using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class DatosPersonales
    {
        public DatosPersonales()
        {
            Docentes = new HashSet<Docentes>();
            Estudiantes = new HashSet<Estudiantes>();
            PadresTutor = new HashSet<PadresTutor>();
            Secretarios = new HashSet<Secretarios>();
        }

        public int IdDatosPersonal { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Nocedula { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public int IdSexo { get; set; }
        public int IdDireccion { get; set; }
        public int IdRoles { get; set; }

        public virtual Direcciones IdDireccionNavigation { get; set; }
        public virtual Roles IdRolesNavigation { get; set; }
        public virtual Sexo IdSexoNavigation { get; set; }
        public virtual ICollection<Docentes> Docentes { get; set; }
        public virtual ICollection<Estudiantes> Estudiantes { get; set; }
        public virtual ICollection<PadresTutor> PadresTutor { get; set; }
        public virtual ICollection<Secretarios> Secretarios { get; set; }
    }
}
