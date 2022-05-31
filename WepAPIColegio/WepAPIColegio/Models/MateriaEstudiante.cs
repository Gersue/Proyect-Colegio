using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class MateriaEstudiante
    {
        public int IdMateria { get; set; }
        public int Idestudiant { get; set; }
        public int Idmateria1 { get; set; }

        public virtual Estudiantes IdestudiantNavigation { get; set; }
        public virtual Materias Idmateria1Navigation { get; set; }
    }
}
