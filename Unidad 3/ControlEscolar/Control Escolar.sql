create database ControlEscolar

use ControlEscolar
go

create table Carreras(
	ClaveC int identity(1, 1) primary key,
	NombreC nvarchar(40) not null,
	NumAlumnos int
	)


--executenonquery

select NombreC from Carreras

create table Alumnos(
	NumControl int identity(1817001, 2) primary key,
	NombreAlu nvarchar(20) not null,
	ApellidoP nvarchar(20) not null,
	ApellidoM nvarchar(20) not null,
	Curp nvarchar(18) not null,
	FechaNac date not null,
	Sexo char(1) not null,
	Telefono numeric(10),
	Carrera int foreign key references Carreras(ClaveC),
	Tutor nvarchar(50) not null
	)
select NombreAlu from Alumnos where Curp='DEAC980319HSLLGR06'

insert into Carreras(NombreC, NumAlumnos)
	values ('SISTEMAS', 0)

insert into Alumnos(NombreAlu, ApellidoP, ApellidoM, Curp, FechaNac, Sexo, Telefono, Carrera, Tutor)
	values ('JOSE CARLOS', 'DELGADO', 'AGUIRRE', 'DEAC980319HSLLGR06', '1998/03/19', 'H', 6674878684, 1, 'JULIO DELGADO')

select * from Alumnos

select * from Carreras
update Carreras set NumAlumnos=2 where NombreC='SISTEMAS'

select ActividadId, NombreAct, AlumnosReg, Tutor, Creditos from Actividades

create table Actividades(
	ActividadId int identity (1, 1) primary key,
	NombreAct varchar(30) not null,
	AlumnosReg int,
	Tutor varchar (30) not null,
	Creditos int
	)

select aa.IDActividad, ac.NombreAct, aa.IDAlumno, al.NombreAlu, al.ApellidoP, al.ApellidoM from Actividades ac inner join Actividades_Alumno aa on ac.ActividadId
=aa.IDActividad inner join Alumnos al on aa.IDAlumno= al.NumControl

update Actividades set AlumnosReg=AlumnosReg+1 where NombreAct='3'

select * from Actividades
create table Actividades_Alumno(
	IDActividad int foreign key references Actividades(ActividadId),
	IDAlumno int foreign key references Alumnos(NumControl)
)
select * from Alumnos
select * from Actividades
drop table Actividades
select * from Actividades_Alumno
--drop table ActividadesExtraescolares
--tabla intermedia para saber cuantas actividades realiza el alumno 
insert into Actividades values ('BasketBall',1,'Jesus Cervantes',3)
insert into Actividades_Alumno values(2,1817001)	
--obtiene cuantos creditos tiene el alumno al momento 
select sum(ac.Creditos) as 'creditos en total' from Actividades_Alumno aa inner join Actividades ac on aa.IDActividad = ac.ActividadID inner join Alumnos al
on aa.IDAlumno = al.NumControl where al.NumControl = 1817001


select NombreAlu, ApellidoP, ApellidoM from Alumnos

insert into Actividades_Alumno values((select ActividadID from Actividades where NombreAct like '%futbol%' ),1817005)
select * from Actividades_Alumno


create trigger Actualizar
on Actividades_Alumno
for insert
as
update Actividades set AlumnosReg=AlumnosReg+1
where ActividadId in(select IDActividad from inserted)


create trigger ActualizarCarrera
on Alumnos
for insert
as
update Carreras set NumAlumnos=NumAlumnos+1
where ClaveC in(select Carrera from inserted)


select al.NumControl, al.NombreAlu, al.ApellidoP, al.ApellidoM, al.Curp, al.FechaNac, al.Sexo, al.Telefono, al.Tutor, ca.ClaveC, ca.NombreC from Alumnos al inner join Carreras ca on al.Carrera= ca.ClaveC