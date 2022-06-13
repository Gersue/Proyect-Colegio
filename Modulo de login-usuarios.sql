Create database BDLogin;
go

Use BDLogin;
go

create table Permisos(
	 idPermiso int primary key identity(1,1),
	 de_permiso varchar(25) not null
)
go

create table Roles(
	idRol int primary key identity(1,1),
	de_rol varchar(25) not null
)
go

create table Usuarios(
  idUsuario int primary key identity(1,1),
  Username nvarchar(50) unique not null,
  Password varbinary(max) not null,
)
go