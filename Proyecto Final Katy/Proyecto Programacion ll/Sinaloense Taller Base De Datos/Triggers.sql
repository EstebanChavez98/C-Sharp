create trigger eliminarClienteDeuda
on Clientes
instead of delete 
as
declare @cantidad money
declare @clave int 
select @clave = claveCliente from deleted

select @cantidad = dbo.calcularSaldoPendiente(@clave)

if(@cantidad>0)
begin 
	--print 'El Cliente Aun Nos Debe Lana'
	raiserror('IMPOSIBLE ELIMINAR, El CLIENTE AUN NOS DEBE DINERO',16,1)
	rollback transaction
end
else
begin
	declare @venta int
	declare cliente cursor for
	select v.claveVenta from deleted d
	join Ventas v on d.claveCliente = v.claveCliente
	open cliente
	Fetch next from cliente into @venta
	WHILE @@fetch_status = 0
	BEGIN
	    delete from DetalleVenta where claveVenta = @venta
		delete from Ventas where claveVenta = @venta
	    FETCH NEXT FROM cliente INTO @venta
	END
	CLOSE cliente
	DEALLOCATE cliente
	delete from Abonos where claveCliente = @clave
	delete from Clientes where claveCliente = @clave
 print 'se Borro Correctamente el Cliente' 
 end
 go

-- drop trigger eliminarClienteDeuda