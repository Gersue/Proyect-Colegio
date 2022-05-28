CREATE DATABASE Colegio
GO

USE colegio
GO

CREATE TABLE Usuarios(
	idUsuarios INT PRIMARY KEY IDENTITY(1,1),
	rol VARCHAR(25) NOT NULL,
	nombre_usuario VARCHAR(25) UNIQUE NOT NULL,
	contraseña VARBINARY(MAX) NOT NULL
)
GO

CREATE TABLE CentrosEstudios(
	idCentrosE INT PRIMARY KEY IDENTITY(1,1),
	nombreCentro VARCHAR(25) NOT NULL,
	distrito VARCHAR(15) NOT NULL
)
GO

CREATE TABLE Grados(
	idGrados INT PRIMARY KEY IDENTITY(1,1),
	grado VARCHAR(5) NOT NULL,
	descripcion VARCHAR(100) NOT NULL
)
GO

CREATE TABLE Materias(
	idMaterias INT PRIMARY KEY IDENTITY(1,1),
	asignatura VARCHAR(25)
)
GO

CREATE TABLE Sexo(
	idSexo INT PRIMARY KEY IDENTITY(1,1),
	sexo CHAR(1) NOT NULL CHECK (sexo  in ('F' ,'M'))
)
GO

CREATE TABLE Direcciones(
	id INT PRIMARY KEY IDENTITY(1,1),
	barrio NVARCHAR(15),
	calle VARCHAR(100)
)
GO

CREATE TABLE Estados(
	idestado INT PRIMARY KEY IDENTITY(1,1),
	fechaIncial DATETIME NOT NULL,
)
GO

CREATE TABLE DatosPersonales(
	idDatosPersonal INT PRIMARY KEY IDENTITY(1,1),
	nombres VARCHAR(50) NOT NULL,
	apellidos VARCHAR(50) NOT NULL,
	nocedula VARCHAR(25) NOT NULL,
	telefono VARCHAR(25) NOT NULL,
	fechaNacimiento VARCHAR(25) NOT NULL,
	edad INT NOT NULL,
	idSexo INT NOT NULL,
	IdDireccion INT NOT NULL,
)
GO

CREATE TABLE Padres_Tutor(
	idPTutor INT PRIMARY KEY IDENTITY(1,1),
	parentesco VARCHAR(25) NOT NULL,
	IdDatosPersonales INT NOT NULL
)
GO

CREATE TABLE Estudiantes(
	idEstudiantes INT PRIMARY KEY IDENTITY(1,1),
	idgrados INT NULL,
	idTutor_padres INT NOT NULL,
	correo VARCHAR(50) null,
	IdEstados INT NOT NULL,   ---Para saber si el estudiante es activo o inactivo
	IdCentroEstudio INT NOT NULL,
	iddatosPersonales INT NOT NULL
)
GO

CREATE TABLE SECRETARIO(
	id INT PRIMARY KEY IDENTITY(1,1),
	idDatosPersonalesSecretario INT NOT NULL
)
GO