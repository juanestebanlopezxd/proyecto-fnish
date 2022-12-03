 CREATE DATABASE Proyecto	
USE Proyecto

	

CREATE TABLE Docente(
Id INT PRIMARY KEY,
Nombre VARCHAR(50),
Telefono VARCHAR(50)
)
CREATE TABLE Estudiante(
Id INT PRIMARY KEY,
Nombre VARCHAR(50),
Telefono VARCHAR(50)
)
CREATE TABLE Materia(
Id INT PRIMARY KEY,
Nombre VARCHAR(50),
Creditos VARCHAR(50)
)
CREATE TABLE Salon(
Id INT PRIMARY KEY,
Numsalon VARCHAR(50),
Bloque VARCHAR(50)
)


CREATE TABLE Grupo(
Id INT PRIMARY KEY,
Nombre VARCHAR(50),
Horario VARCHAR(50),
Diasemana VARCHAR(50),
salon_id INT REFERENCES Salon(Id),
docente_id INT REFERENCES Docente(Id),
materia_id INT REFERENCES Materia(Id)
)

CREATE TABLE Estudiante_Grupo(
Grupo_id INT REFERENCES Grupo(Id),
Estudi_id INT REFERENCES Estudiante(Id),
)

SELECT * FROM Materia
SELECT * FROM SALON
SELECT * FROM Docente
SELECT * FROM Grupo
select * from estudiante
SELECT * FROM Estudiante_Grupo
