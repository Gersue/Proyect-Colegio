using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class Grados
    {
        public Grados()
        {
            Estudiantes = new HashSet<Estudiantes>();
        }

        public int IdGrados { get; set; }
        public string Grado { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Estudiantes> Estudiantes { get; set; }
    }
}
