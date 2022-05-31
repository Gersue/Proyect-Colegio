CREATE DATABASE Colegio
GO

USE Colegio
GO

CREATE TABLE Usuarios(
	idUsuarios INT PRIMARY KEY IDENTITY(1,1),
	nombre_usuario VARCHAR(25) UNIQUE NOT NULL,
	contraseña VARBINARY(MAX) NOT NULL
)
GO

CREATE TABLE Roles(
	idroles INT PRIMARY KEY IDENTITY(1,1),
	nombre_usuario VARCHAR(25) UNIQUE NOT NULL,
)
GO

CREATE TABLE User_Roles(
	idUserRol INT PRIMARY KEY IDENTITY(1,1),
	idroles INT NOT NULL,
	iduser INT NOT NULL,
	CONSTRAINT FK_idroll FOREIGN KEY (idroles) REFERENCES Roles(idroles),
	CONSTRAINT FK_iduser FOREIGN KEY (iduser) REFERENCES Usuarios(idUsuarios)
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
	idDirecciones INT PRIMARY KEY IDENTITY(1,1),
	barrio NVARCHAR(15),
	calle VARCHAR(100)
)
GO

CREATE TABLE DatosPersonales(
	idDatosPersonal INT PRIMARY KEY IDENTITY(1,1),
	nombres VARCHAR(50) NOT NULL,
	apellidos VARCHAR(50) NOT NULL,
	nocedula VARCHAR(25) unique NOT NULL,
	telefono VARCHAR(25) NOT NULL,
	fechaNacimiento DATE NOT NULL,
	edad INT NOT NULL,
	idSexo INT NOT NULL,		---Foreign key
	IdDireccion INT NOT NULL,	---Foreign key
	idRoles INT NOT NULL		---Foreign key
	CONSTRAINT FK_sexo FOREIGN KEY (idSexo) REFERENCES Sexo(idSexo),
	CONSTRAINT FK_Direccion FOREIGN KEY (IdDireccion) REFERENCES Direcciones(idDirecciones),
	CONSTRAINT FK_idRoles FOREIGN KEY (idRoles) REFERENCES Roles(idroles)
)
GO

CREATE TABLE Padres_Tutor(
	idPTutor INT PRIMARY KEY IDENTITY(1,1),
	parentesco VARCHAR(25) NOT NULL,
	IdDatosPersonales INT NOT NULL,
	CONSTRAINT FK_Datospersonales FOREIGN KEY (IdDatosPersonales) REFERENCES DatosPersonales(idDatosPersonal),
)
GO

CREATE TABLE Estudiantes(
	idEstudiantes INT PRIMARY KEY IDENTITY(1,1),
	correo VARCHAR(50) null,
	IdEstados INT NOT NULL,			---Para saber si el estudiante es activo o inactivo
	idgrados INT NULL,				---Foreign key
	idTutor_padres INT NOT NULL,	---Foreign key
	iddatosPersonales INT NOT NULL,	---Foreign key
	CONSTRAINT FK_grados FOREIGN KEY (Idgrados) REFERENCES Grados(idGrados),
	CONSTRAINT FK_PadresTutor FOREIGN KEY (idTutor_padres) REFERENCES Padres_Tutor(idPTutor),
	CONSTRAINT FK_datosPersonale FOREIGN KEY (iddatosPersonales) REFERENCES DatosPersonales(idDatosPersonal)
)
GO

---Centros de Estudio del estudiante
CREATE TABLE Centro_Estudiante(
	id_Centro_studiant INT PRIMARY KEY IDENTITY(1,1),
	idestudiant INT NOT NULL,
	idcentroestudio INT NOT NULL,
	CONSTRAINT FK_idestudiant FOREIGN KEY (idestudiant) REFERENCES Estudiantes(idEstudiantes),
	CONSTRAINT FK_idcentroestudio FOREIGN KEY (idcentroestudio) REFERENCES CentrosEstudios(idCentrosE)
)
GO

---Materias del estudiante
CREATE TABLE Materia_Estudiante(
	id_materia INT PRIMARY KEY IDENTITY(1,1),
	idestudiant INT NOT NULL,
	idmateria INT NOT NULL,
	CONSTRAINT FK_idestudiants FOREIGN KEY (idestudiant) REFERENCES Estudiantes(idEstudiantes),
	CONSTRAINT FK_idmateria FOREIGN KEY (idmateria) REFERENCES Materias(idMaterias)
)
GO

CREATE  TABLE Secretarios(
	id INT PRIMARY KEY IDENTITY(  1 , 1 ), 
	idDatosPersonalesSecretario INT  NOT  NULL ,	---Foreign key
	CONSTRAINT FK_datosPersonalesecretario FOREIGN KEY (idDatosPersonalesSecretario) REFERENCES DatosPersonales(idDatosPersonal)
)
GO

CREATE  TABLE Docentes(
	id INT PRIMARY KEY IDENTITY(1,1), 
	idDatosPersonalesprof INT  NOT  NULL ,	---Foreign key
	especialidad VARCHAR(25) NULL,
	CONSTRAINT FK_datosPersonalesprof FOREIGN KEY (idDatosPersonalesprof) REFERENCES DatosPersonales(idDatosPersonal)
)
GO