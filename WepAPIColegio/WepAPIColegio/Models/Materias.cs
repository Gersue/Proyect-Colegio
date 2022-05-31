using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Models
{
    public partial class Materias
    {
        public Materias()
        {
            MateriaEstudiante = new HashSet<MateriaEstudiante>();
        }

        public int IdMaterias { get; set; }
        public string Asignatura { get; set; }

        public virtual ICollection<MateriaEstudiante> MateriaEstudiante { get; set; }
    }
}
