using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class Secretarios
    {
        public int Id { get; set; }
        public int IdDatosPersonalesSecretario { get; set; }

        public virtual DatosPersonales IdDatosPersonalesSecretarioNavigation { get; set; }
    }
}
