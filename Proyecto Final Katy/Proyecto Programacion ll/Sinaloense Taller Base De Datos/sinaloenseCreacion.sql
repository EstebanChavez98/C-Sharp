create database VentasMayoreo
use VentasMayoreo
go

create table Clientes
(
claveCliente int identity(1,1) not null,
nombre varchar(35) not null,
paterno varchar(15)not null,
materno varchar(15) not null,
sexo char(1) not null,
direccion varchar(150) not null,
nacimiento date not null,
telefono numeric(10,0) not null,
montomaximo money not null,
primary key(claveCliente)
)

create table Abonos
(
claveAbono int identity(1,1) not null,
claveCliente int not null,
monto money not null,
fecha date default getdate() not null,
primary key(claveAbono),
foreign key(claveCliente) references Clientes(claveCliente)
)

create table Sucursales
(
claveSucursal int identity (1,1) not null,
nombre varchar(50) not null,
direccion varchar (150) not null,
telefono numeric (10,0) not null,
primary key (claveSucursal)
) 

create table Empleados
(
claveEmpleado int identity (1,1) not null,
claveSucursal int not null,
nombre varchar (35) not null,
paterno varchar(15) not null,
materno varchar(15) not null,
sexo char(1) not null,
direccion varchar(150) not null,
telefono  numeric (10,0) not null,
primary key(claveEmpleado),
foreign key(claveSucursal) references Sucursales(claveSucursal)
)
drop table Empleados
drop table Ventas
drop table DetalleVenta

create table Ventas
(
claveVenta int identity(1,1) not null,
tipo char(7)  not null,
importe money not null,
fecha date default getdate() not null,
claveCliente int not null,
claveEmpleado int not null,
primary key(claveVenta) ,
foreign key(claveCliente) references Clientes(claveCliente),
foreign key(claveEmpleado) references Empleados(claveEmpleado)
)

create table Categorias
(
claveCategoria int identity(1,1) not null,
nombre varchar (35) not null,
primary key(claveCategoria)
)
create table Articulos
(
claveArticulo int identity(1,1) not null,
descripcion varchar(50) not null,
precio money not null,
claveCategoria int not null,
primary key(claveArticulo),
foreign key (claveCategoria) references Categorias(claveCategoria)
)

create table DetalleVenta
(
claveVenta int not null,
claveArticulo int not null,
cantidad int not null,
precio money not null,
importe money not null
primary key(claveVenta,ClaveArticulo),
foreign key(claveVenta) references Ventas (claveVenta),
foreign key(claveArticulo) references Articulos (claveArticulo)
)

create table Almacen
(
claveSucursal int not null,
claveArticulo int not null,
existencia int not null,
primary key(claveSucursal,claveArticulo),
foreign key(claveSucursal) references Sucursales(claveSucursal),
foreign key(claveArticulo) references Articulos(claveArticulo)
)


select IDENT_CURRENT('Ventas')
