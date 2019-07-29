
--Vistas

create view ClientesSaldoPendiente
as
select claveCliente,nombre,paterno,direccion,montomaximo,saldo =(dbo.calcularSaldoPendiente(claveCliente)) from Clientes
where dbo.calcularSaldoPendiente(claveCliente)>0
go

--
create view cargarClientes
as
select claveCliente,nombre,paterno,materno,sexo,direccion,nacimiento,telefono,montomaximo,dbo.calcularSaldoPendiente(claveCliente)as saldo  from Clientes
go



create view clientesConVenta
as
select claveCliente,nombre,paterno,materno,sexo,direccion,nacimiento,telefono,montomaximo,dbo.calcularSaldoPendiente(claveCliente)as saldo  from Clientes 
where claveCliente in(select claveCliente from Ventas)
go

create view clientesConAbono
as
select claveCliente,nombre,paterno,materno,sexo,direccion,nacimiento,telefono,montomaximo,dbo.calcularSaldoPendiente(claveCliente)as saldo  from Clientes 
where claveCliente in(select claveCliente from Abonos )

select claveAbono,monto,fecha from Abonos
where claveCliente =








