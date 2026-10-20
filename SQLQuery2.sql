-- 1. Encabezados de ventas: cliente, usuario y total.
SELECT
    v.id AS VentaId,
    v.Fecha,
    c.Nombre AS Cliente,
    u.NombreUsuario AS Usuario,
    v.Total
FROM Ventas AS v
INNER JOIN Clientes AS c ON c.Id = v.ClienteId
INNER JOIN Usuarios AS u ON u.Id = v.UsuarioId
ORDER BY v.id DESC;


-- 2. Productos incluidos en cada venta.
SELECT
    d.VentaId,
    p.Nombre AS Producto,
    d.Cantidad,
    d.PrecioUnitario,
    d.Subtotal
FROM DetallesVenta AS d
INNER JOIN Productos AS p ON p.Id = d.ProductoId
ORDER BY d.VentaId DESC, d.Id;


-- 3. Precio y existencias actuales de los productos.
SELECT
    Id,
    Nombre,
    PrecioUnitario,
    Stock,
    Activo
FROM Productos
ORDER BY Id;


SELECT COUNT(*) AS CantidadVentas
FROM Ventas;

SELECT COUNT(*) AS CantidadDetalles
FROM DetallesVenta;