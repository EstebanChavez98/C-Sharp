use ventasmayoreo
--1.Seleccione el monto Total de Abonos de Cada Cliente
select c.nombre,sum(a.monto)as [Total] from Abonos a
join Clientes c on c.claveCliente = a.claveCliente
group by c.nombre
--2.Cunto nos comprado cada cliente a contado y credito
select Nombre=c.nombre+' '+c.paterno+' '+c.materno,sub.tipo,sub.Total from Clientes c
join (
select c.claveCliente,v.tipo,sum(v.importe) as Total from Ventas v
join Clientes c on c.claveCliente = v.claveCliente
group by v.tipo,c.claveCliente)sub on sub.claveCliente = c.claveCliente
--3
