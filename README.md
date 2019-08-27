# Semana3ejercicio2
use Neptuno
-------------- imput fechas de filtro--------------
go
create proc usp_FechaFecha
@fec1 datetime,
@fec2 datetime
as
Select IdPedido, IdCliente, FechaEnvio
From Pedidos
where FechaPedido between @fec1 and @fec2
-----------prueba de procedure---------------------
exec usp_FechaFecha '04/08/1990','04/08/2018'



--------------Detalles del producto----------------
go
create proc usp_Detalle
@Idpedido int
as
select d.IdProducto, NombreProducto, d.PrecioUnidad, d.Cantidad, d.PrecioUnidad * d.Cantidad as Monto
from detallesdepedidos d inner join Productos p
on d.IdProducto = p.IdProducto
where IdPedido = @Idpedido
---------------prueba de procedure-----------------
exec usp_Detalle 10248




--------------Detalles del producto----------------
go
create proc usp_Total
@pedido int,
@Total money output
as
select @Total = sum(PrecioUnidad*Cantidad)
from detallesdepedidos
where IdPedido = @pedido
----------------------------------------------------
declare @x money
exec usp_Total 10248, @x output
select @x




--------------Lista de Anos----------------
go
create proc usp_ListaAnos
as
select DISTINCT DATEPART(year, FechaPedido) as ano
from Pedidos
order by ano asc
----------------------------------------------------
exec usp_ListaAnos 



--------------Lista de Meses----------------
go
create proc usp_ListaMeses
@ano int
as
select DISTINCT DATEPART(month, FechaPedido) as mes
from Pedidos
where DATEPART(year, FechaPedido) = @ano
order by mes asc
----------------------------------------------------
exec usp_ListaMeses 1994



--------------Lista de Empleados----------------
go
create proc usp_ListaEmpleado
@ano int,
@mes int
as
select DISTINCT Empleados.IdEmpleado, Empleados.Apellidos + ' ' + Empleados.Nombre AS empleado
from Pedidos
INNER JOIN Empleados
ON Pedidos.IdEmpleado=Empleados.IdEmpleado
where DATEPART(year, Pedidos.FechaPedido) = @ano
And DATEPART(MONTH, Pedidos.FechaPedido) = @mes
----------------------------------------------------
exec usp_ListaEmpleado 1994, 8




--------------Clientes----------------
go
create proc usp_Clientes
@idAno int,
@idMes int,
@idEmp int
as
select Clientes.IdCliente, Clientes.NombreContacto
from Pedidos
Inner Join Clientes
on Pedidos.IdCliente = Clientes.IdCliente
where DATEPART(year, Pedidos.FechaPedido) = @idAno
and DATEPART(MONTH, Pedidos.FechaPedido) = @idMes
And Pedidos.IdEmpleado = @idEmp
---------------prueba de procedure-----------------
exec usp_Clientes 1994, 8, 1



--------------Pedido----------------
go
create proc usp_PedidoporCliente
@idclie nvarchar(5),
@Ano int,
@Mes int,
@Emp int
as
select Pedidos.IdPedido as NroPedido, Clientes.NombreContacto, Pedidos.FechaEntrega, Pedidos.Destinatario
from Pedidos
Inner Join Clientes
on Pedidos.IdCliente = Clientes.IdCliente
where Clientes.IdCliente LIKE @idclie
And DATEPART(year, Pedidos.FechaPedido) = @Ano
And DATEPART(MONTH, Pedidos.FechaPedido) = @Mes
And Pedidos.IdEmpleado = @Emp
---------------prueba de procedure-----------------
exec usp_PedidoporCliente 'ERNSH', 1994, 8, 1



--------------Pedido----------------
go
create proc usp_PedidoporDetalle
@idclie nvarchar(5),
@Ano int,
@Mes int,
@Emp int
as
select Pedidos.IdPedido as Codigo, Productos.NombreProducto, detallesdepedidos.PrecioUnidad, detallesdepedidos.Cantidad, SUM(detallesdepedidos.PrecioUnidad*detallesdepedidos.Cantidad) AS Monto
from detallesdepedidos
Inner Join Pedidos
on detallesdepedidos.IdPedido = Pedidos.IdPedido
INNER JOIN Productos
on detallesdepedidos.IdProducto = Productos.IdProducto
Inner Join Clientes
on Pedidos.IdCliente = Clientes.IdCliente
Inner Join Empleados
on Pedidos.IdEmpleado = Empleados.IdEmpleado
where Clientes.IdCliente LIKE @idclie
And DATEPART(year, Pedidos.FechaPedido) = @Ano
And DATEPART(MONTH, Pedidos.FechaPedido) = @Mes
And Pedidos.IdEmpleado = @Emp
group by Pedidos.IdPedido, Productos.NombreProducto, detallesdepedidos.PrecioUnidad, Cantidad, Pedidos.FechaPedido, Empleados.IdEmpleado, Empleados.Apellidos, Empleados.Nombre
---------------prueba de procedure-----------------
exec usp_PedidoporDetalle 'ernsh', 1994, 8, 1
