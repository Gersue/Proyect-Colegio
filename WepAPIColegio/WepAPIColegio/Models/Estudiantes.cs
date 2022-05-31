using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class Estudiantes
    {
        public Estudiantes()
        {
            CentroEstudiante = new HashSet<CentroEstudiante>();
            MateriaEstudiante = new HashSet<MateriaEstudiante>();
        }

        public int IdEstudiantes { get; set; }
        public string Correo { get; set; }
        public int IdEstados { get; set; }
        public int? Idgrados { get; set; }
        public int IdTutorPadres { get; set; }
        public int IddatosPersonales { get; set; }

        public virtual PadresTutor IdTutorPadresNavigation { get; set; }
        public virtual DatosPersonales IddatosPersonalesNavigation { get; set; }
        public virtual Grados IdgradosNavigation { get; set; }
        public virtual ICollection<CentroEstudiante> CentroEstudiante { get; set; }
        public virtual ICollection<MateriaEstudiante> MateriaEstudiante { get; set; }
    }
}
