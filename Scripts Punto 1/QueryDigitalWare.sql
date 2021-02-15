--Obtener la lista de precios de todos los productos
select * from Producto

--Obtener la lista de productos cuya existencia en el inventario haya llegado al mínimo permitido (5 unidades)
select * from Producto Where Cantidad >= 5

--Obtener una lista de clientes no mayores de 35 años que hayan realizado compras entre el 1 de febrero de 2000 y el 25 de mayo de 2000
select 
	Factura.Id,
	Factura.ClienteId,
	Cliente.Nombre,
	Cliente.Edad,
	Factura.ValorTotal,
	Factura.Fecha

From Factura (NoLock)
	Inner Join Cliente (NoLock) On Cliente.Id = Factura.ClienteId
	Where (Cliente.Edad<=35) and Fecha between '2000/02/01' and '2000/05/25'

-- Obtener el valor total vendido por cada producto en el año 2000

select DISTINCT 
	Producto.Id,
	Producto.Nombre,
	Producto.Costo,
	Producto.FechaActualizacion,
	(
		select SUM(FacturaProducto.ValorTotal)
		From FacturaProducto Where ProductoId = Producto.Id
	) as TotalVendidos
From Producto (NoLock)
	Inner Join FacturaProducto (NoLock) On FacturaProducto.ProductoId = Producto.Id
	Inner Join Factura (NoLock) On Factura.Id = FacturaProducto.FacturaId
	Where Factura.Fecha between '2000/01/01' and '2000/12/31'

-- Obtener la última fecha de compra de un cliente y según su frecuencia de compra estimar en qué fecha podría volver a comprar.
DECLARE @ClienteId as int = 1  -- ClienteId
DECLARE @TablaDiferencia as int = 0
DECLARE @ConteoFechas as int = 0
DECLARE @Promedio as float
Declare @Fecha as Date
BEGIN
SELECT
 @TablaDiferencia = ISNULL(DATEDIFF(D,lag(Fecha) over (order by Fecha), Fecha),0) + @TablaDiferencia,
 @ConteoFechas = @ConteoFechas +1,
 @Fecha = Factura.Fecha
FROM Factura Where ClienteId=@ClienteId
select @Promedio = @TablaDiferencia/(@ConteoFechas-1) 
select *,
	DATEADD(D,@Promedio,@Fecha) as FechaPosibleCompra
from Cliente Where Id = @ClienteId
END

