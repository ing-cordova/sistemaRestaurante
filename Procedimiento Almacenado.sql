CREATE PROCEDURE sp_Factura
	@IdVenta int
AS
BEGIN
SELECT dbo.Ventas.idVenta, dbo.Ventas.fechadeVenta, dbo.Ventas.totalPagar,  dbo.DetallesVenta.precioCompra, 
dbo.DetallesVenta.cantidad, dbo.DetallesVenta.totalProducto, dbo.ProductosVenta.nombre
FROM dbo.ProductosVenta 
INNER JOIN dbo.DetallesVenta ON dbo.ProductosVenta.idProductoV = dbo.DetallesVenta.idProductoV 
INNER JOIN dbo.Ventas ON dbo.DetallesVenta.idVenta = dbo.Ventas.idVenta 
where dbo.Ventas.idVenta = @IdVenta
END
GO