using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            UserRoles = new HashSet<UserRoles>();
        }

        public int IdUsuarios { get; set; }
        public string NombreUsuario { get; set; }
        public byte[] Contraseña { get; set; }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
