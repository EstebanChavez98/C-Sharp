--1 InsertarDetalleVenta
create procedure insertarDetalleVenta
@claveVenta int,
@claveArticulo int,
@cantidad int,
@importe money,
@claveSucursal int
as
declare @precio money
select @precio = (select precio from Articulos where claveArticulo =@claveArticulo)
insert into DetalleVenta(claveVenta,claveArticulo,cantidad,precio,importe)
values(@claveVenta,@claveArticulo,@cantidad,@precio,@importe)
update Almacen set existencia-=@cantidad where claveArticulo=@claveArticulo and claveSucursal = @claveSucursal
go

--2 Insertar Venta
create procedure insertarVenta
@tipo varchar(7),
@importe money,
@claveCliente int,
@claveEmpleado int
as
insert into Ventas(tipo,importe,claveCliente,claveEmpleado)
values(@tipo,@importe,@claveCliente,@claveEmpleado)
go

--3 Abonar Cliente
create procedure abonarCliente
@clave int,
@cantidad money
as
insert into Abonos(claveCliente,monto)
values (@clave,@cantidad)
go

--4 Insertar Cliente        <----- Modificar
create procedure insertarCliente
@nombre varchar(35),
@apellido varchar(40),
@direccion varchar(150),
@monto money
as
insert into Clientes(nombre,apellido,direccion,montomaximo)
values (@nombre,@apellido,@direccion,@monto)
go

--5 Actualizar Cliente           <--- Modificar
create procedure actualizarCliente
@clave int,
@nombre varchar(35),
@apellido varchar(40),
@direccion varchar(150),
@monto money 
as 
update Clientes set nombre=@nombre, apellido =@apellido,direccion = @direccion,montomaximo =@monto
where clave = @clave
go

--6. Inserccion Cliente
create procedure insertarCliente
@nombre varchar(35),
@paterno varchar(15),
@materno varchar(15),
@sexo char(1),
@direccion varchar(150),
@nacimiento date,
@telefono numeric(10,0),
@monto money
as
insert into Clientes(nombre,paterno,materno,sexo,direccion,nacimiento,telefono,montomaximo)
values (@nombre,@paterno,@materno,@sexo,@direccion,@nacimiento,@telefono,@monto)
go

--7Actualizar Cliente
create procedure actualizarCliente
@clave int,
@nombre varchar(35),
@paterno varchar(15),
@materno varchar(15),
@direccion varchar(150),
@monto money
as
update Clientes set nombre = @nombre, paterno = @paterno,materno = @materno,direccion = @direccion,montomaximo =@monto
where claveCliente = @clave
go

