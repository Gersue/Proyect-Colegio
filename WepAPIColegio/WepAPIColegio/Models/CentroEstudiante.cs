using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class CentroEstudiante
    {
        public int IdCentroStudiant { get; set; }
        public int Idestudiant { get; set; }
        public int Idcentroestudio { get; set; }

        public virtual CentrosEstudios IdcentroestudioNavigation { get; set; }
        public virtual Estudiantes IdestudiantNavigation { get; set; }
    }
}
