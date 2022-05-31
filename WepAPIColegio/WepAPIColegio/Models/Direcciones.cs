using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class Direcciones
    {
        public Direcciones()
        {
            DatosPersonales = new HashSet<DatosPersonales>();
        }

        public int IdDirecciones { get; set; }
        public string Barrio { get; set; }
        public string Calle { get; set; }

        public virtual ICollection<DatosPersonales> DatosPersonales { get; set; }
    }
}
