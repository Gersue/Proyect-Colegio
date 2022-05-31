using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class PadresTutor
    {
        public PadresTutor()
        {
            Estudiantes = new HashSet<Estudiantes>();
        }

        public int IdPtutor { get; set; }
        public string Parentesco { get; set; }
        public int IdDatosPersonales { get; set; }

        public virtual DatosPersonales IdDatosPersonalesNavigation { get; set; }
        public virtual ICollection<Estudiantes> Estudiantes { get; set; }
    }
}
