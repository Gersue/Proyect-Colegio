using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class Docentes
    {
        public int Id { get; set; }
        public int IdDatosPersonalesprof { get; set; }
        public string Especialidad { get; set; }

        public virtual DatosPersonales IdDatosPersonalesprofNavigation { get; set; }
    }
}
