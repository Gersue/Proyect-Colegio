using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class CentrosEstudios
    {
        public CentrosEstudios()
        {
            CentroEstudiante = new HashSet<CentroEstudiante>();
        }

        public int IdCentrosE { get; set; }
        public string NombreCentro { get; set; }
        public string Distrito { get; set; }

        public virtual ICollection<CentroEstudiante> CentroEstudiante { get; set; }
    }
}
