using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class UserRoles
    {
        public int IdUserRol { get; set; }
        public int Idroles { get; set; }
        public int Iduser { get; set; }

        public virtual Roles IdrolesNavigation { get; set; }
        public virtual Usuarios IduserNavigation { get; set; }
    }
}
