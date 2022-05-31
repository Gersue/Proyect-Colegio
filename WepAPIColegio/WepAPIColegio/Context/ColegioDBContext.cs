using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WepAPIColegio.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WepAPIColegio.Context
{
    public partial class ColegioDBContext : DbContext
    {
        public ColegioDBContext()
        {
        }

        public ColegioDBContext(DbContextOptions<ColegioDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CentroEstudiante> CentroEstudiante { get; set; }
        public virtual DbSet<CentrosEstudios> CentrosEstudios { get; set; }
        public virtual DbSet<DatosPersonales> DatosPersonales { get; set; }
        public virtual DbSet<Direcciones> Direcciones { get; set; }
        public virtual DbSet<Docentes> Docentes { get; set; }
        public virtual DbSet<Estudiantes> Estudiantes { get; set; }
        public virtual DbSet<Grados> Grados { get; set; }
        public virtual DbSet<MateriaEstudiante> MateriaEstudiante { get; set; }
        public virtual DbSet<Materias> Materias { get; set; }
        public virtual DbSet<PadresTutor> PadresTutor { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Secretarios> Secretarios { get; set; }
        public virtual DbSet<Sexo> Sexo { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=H4_PC12\\SA;Database=Colegio;Trusted_Connection=False; User Id=sa; Password=isi2022/*");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CentroEstudiante>(entity =>
            {
                entity.HasKey(e => e.IdCentroStudiant)
                    .HasName("PK__Centro_E__D46FFEE97CC6FF16");

                entity.ToTable("Centro_Estudiante");

                entity.Property(e => e.IdCentroStudiant).HasColumnName("id_Centro_studiant");

                entity.Property(e => e.Idcentroestudio).HasColumnName("idcentroestudio");

                entity.Property(e => e.Idestudiant).HasColumnName("idestudiant");

                entity.HasOne(d => d.IdcentroestudioNavigation)
                    .WithMany(p => p.CentroEstudiante)
                    .HasForeignKey(d => d.Idcentroestudio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_idcentroestudio");

                entity.HasOne(d => d.IdestudiantNavigation)
                    .WithMany(p => p.CentroEstudiante)
                    .HasForeignKey(d => d.Idestudiant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_idestudiant");
            });

            modelBuilder.Entity<CentrosEstudios>(entity =>
            {
                entity.HasKey(e => e.IdCentrosE)
                    .HasName("PK__CentrosE__FF58EEF16C5C40AA");

                entity.Property(e => e.IdCentrosE).HasColumnName("idCentrosE");

                entity.Property(e => e.Distrito)
                    .IsRequired()
                    .HasColumnName("distrito")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCentro)
                    .IsRequired()
                    .HasColumnName("nombreCentro")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosPersonales>(entity =>
            {
                entity.HasKey(e => e.IdDatosPersonal)
                    .HasName("PK__DatosPer__843D11D18416B8D4");

                entity.HasIndex(e => e.Nocedula)
                    .HasName("UQ__DatosPer__F806BFFE1100AC91")
                    .IsUnique();

                entity.Property(e => e.IdDatosPersonal).HasColumnName("idDatosPersonal");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fechaNacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.IdRoles).HasColumnName("idRoles");

                entity.Property(e => e.IdSexo).HasColumnName("idSexo");

                entity.Property(e => e.Nocedula)
                    .IsRequired()
                    .HasColumnName("nocedula")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnName("nombres")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDireccionNavigation)
                    .WithMany(p => p.DatosPersonales)
                    .HasForeignKey(d => d.IdDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Direccion");

                entity.HasOne(d => d.IdRolesNavigation)
                    .WithMany(p => p.DatosPersonales)
                    .HasForeignKey(d => d.IdRoles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_idRoles");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.DatosPersonales)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sexo");
            });

            modelBuilder.Entity<Direcciones>(entity =>
            {
                entity.HasKey(e => e.IdDirecciones)
                    .HasName("PK__Direccio__25D6A77459F34CD2");

                entity.Property(e => e.IdDirecciones).HasColumnName("idDirecciones");

                entity.Property(e => e.Barrio)
                    .HasColumnName("barrio")
                    .HasMaxLength(15);

                entity.Property(e => e.Calle)
                    .HasColumnName("calle")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Docentes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Especialidad)
                    .HasColumnName("especialidad")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdDatosPersonalesprof).HasColumnName("idDatosPersonalesprof");

                entity.HasOne(d => d.IdDatosPersonalesprofNavigation)
                    .WithMany(p => p.Docentes)
                    .HasForeignKey(d => d.IdDatosPersonalesprof)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_datosPersonalesprof");
            });

            modelBuilder.Entity<Estudiantes>(entity =>
            {
                entity.HasKey(e => e.IdEstudiantes)
                    .HasName("PK__Estudian__A466542173A246C4");

                entity.Property(e => e.IdEstudiantes).HasColumnName("idEstudiantes");

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTutorPadres).HasColumnName("idTutor_padres");

                entity.Property(e => e.IddatosPersonales).HasColumnName("iddatosPersonales");

                entity.Property(e => e.Idgrados).HasColumnName("idgrados");

                entity.HasOne(d => d.IdTutorPadresNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.IdTutorPadres)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PadresTutor");

                entity.HasOne(d => d.IddatosPersonalesNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.IddatosPersonales)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_datosPersonale");

                entity.HasOne(d => d.IdgradosNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.Idgrados)
                    .HasConstraintName("FK_grados");
            });

            modelBuilder.Entity<Grados>(entity =>
            {
                entity.HasKey(e => e.IdGrados)
                    .HasName("PK__Grados__427CD3DB33FC2D7B");

                entity.Property(e => e.IdGrados).HasColumnName("idGrados");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Grado)
                    .IsRequired()
                    .HasColumnName("grado")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MateriaEstudiante>(entity =>
            {
                entity.HasKey(e => e.IdMateria)
                    .HasName("PK__Materia___7E03FD39F69AE16B");

                entity.ToTable("Materia_Estudiante");

                entity.Property(e => e.IdMateria).HasColumnName("id_materia");

                entity.Property(e => e.Idestudiant).HasColumnName("idestudiant");

                entity.Property(e => e.Idmateria1).HasColumnName("idmateria");

                entity.HasOne(d => d.IdestudiantNavigation)
                    .WithMany(p => p.MateriaEstudiante)
                    .HasForeignKey(d => d.Idestudiant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_idestudiants");

                entity.HasOne(d => d.Idmateria1Navigation)
                    .WithMany(p => p.MateriaEstudiante)
                    .HasForeignKey(d => d.Idmateria1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_idmateria");
            });

            modelBuilder.Entity<Materias>(entity =>
            {
                entity.HasKey(e => e.IdMaterias)
                    .HasName("PK__Materias__6AC7E3ECD7A17F48");

                entity.Property(e => e.IdMaterias).HasColumnName("idMaterias");

                entity.Property(e => e.Asignatura)
                    .HasColumnName("asignatura")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PadresTutor>(entity =>
            {
                entity.HasKey(e => e.IdPtutor)
                    .HasName("PK__Padres_T__7A58BF6768F4B2CF");

                entity.ToTable("Padres_Tutor");

                entity.Property(e => e.IdPtutor).HasColumnName("idPTutor");

                entity.Property(e => e.Parentesco)
                    .IsRequired()
                    .HasColumnName("parentesco")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDatosPersonalesNavigation)
                    .WithMany(p => p.PadresTutor)
                    .HasForeignKey(d => d.IdDatosPersonales)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Datospersonales");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.Idroles)
                    .HasName("PK__Roles__3544366357B6E39F");

                entity.HasIndex(e => e.NombreUsuario)
                    .HasName("UQ__Roles__D4D22D7460143A3B")
                    .IsUnique();

                entity.Property(e => e.Idroles).HasColumnName("idroles");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasColumnName("nombre_usuario")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Secretarios>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdDatosPersonalesSecretario).HasColumnName("idDatosPersonalesSecretario");

                entity.HasOne(d => d.IdDatosPersonalesSecretarioNavigation)
                    .WithMany(p => p.Secretarios)
                    .HasForeignKey(d => d.IdDatosPersonalesSecretario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_datosPersonalesecretario");
            });

            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.HasKey(e => e.IdSexo)
                    .HasName("PK__Sexo__C5AFCD4D53EC8B06");

                entity.Property(e => e.IdSexo).HasColumnName("idSexo");

                entity.Property(e => e.Sexo1)
                    .IsRequired()
                    .HasColumnName("sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.IdUserRol)
                    .HasName("PK__User_Rol__F7759BB76359B656");

                entity.ToTable("User_Roles");

                entity.Property(e => e.IdUserRol).HasColumnName("idUserRol");

                entity.Property(e => e.Idroles).HasColumnName("idroles");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.HasOne(d => d.IdrolesNavigation)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.Idroles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_idroll");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_iduser");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuarios)
                    .HasName("PK__Usuarios__3940559A7E43E459");

                entity.HasIndex(e => e.NombreUsuario)
                    .HasName("UQ__Usuarios__D4D22D742B537801")
                    .IsUnique();

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnName("contraseña");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasColumnName("nombre_usuario")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
