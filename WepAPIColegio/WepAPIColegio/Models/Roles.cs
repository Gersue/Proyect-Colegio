using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class Roles
    {
        public Roles()
        {
            DatosPersonales = new HashSet<DatosPersonales>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int Idroles { get; set; }
        public string NombreUsuario { get; set; }

        public virtual ICollection<DatosPersonales> DatosPersonales { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
