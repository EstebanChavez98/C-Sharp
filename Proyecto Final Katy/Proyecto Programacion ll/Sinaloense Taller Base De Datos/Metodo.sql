create function calcularSaldoPendiente
(@clave int)
returns money 
as
begin
declare @resultado money
select  @resultado = (select coalesce(sum(importe),0) from Ventas where claveCliente = @clave and tipo = 'CREDITO')
select @resultado-= (select coalesce(sum(monto),0) from Abonos where claveCliente = @clave)
return @resultado
end