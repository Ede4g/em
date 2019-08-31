-- El monto de las ordenes desde el 1 de enero al 31 de octubre
select sum(b.Quantity*b.UnitPrice) as 'Monto' from orders a, orderdetails b where a.OrderID=b.OrderID and a.orderdate between '1996-01-01' and '1996-10-31'; 
-- Que el precio unitario de ordenes sea menor al precio unitario de productos
select b.OrderID, b.ProductID from products a, orderdetails b where a.ProductID=b.ProductID and a.UnitPrice<b.UnitPrice;
-- 
select ShipVia, (count(ShipVia) / (select count(OrderID) from orders)) * 100 from orders  group by ShipVia;
-- El mes en que menos se vendio
select format(sum(b.UnitPrice*b.Quantity),2) as 'Monto', monthname(a.OrderDate) as 'Mes' from orders a, orderdetails b where a.OrderID=b.OrderID and year(a.OrderDate)=1998 group by month(a.OrderDate) order by Monto desc limit 1;
-- Mostrar a los clientes que han realizado mas de 10 ordenes
select a.CustomerID, b.CompanyName, count(a.CustomerID) as 'cuenta' from orders a, customers b where a.CustomerID=b.CustomerID group by (a.CustomerID) having cuenta >= 10;
-- 
select dayname(a.OrderDate), round(sum(b.UnitPrice*b.Quantity),2) as 'total'  from orders a, orderdetails b where a.orderid=b.orderid group by dayname(a.OrderDate) order by total desc limit 1;
-- Que categoria de productos consumen mas los clientes de Alemania
select a.categoryid as 'Categoria', count(a.categoryid) as 'Cantidad', d.CategoryName, b.shipcountry as 'Pais' from products a, orders b, orderdetails c, categories d where b.OrderID=c.OrderID and d.CategoryID=a.CategoryID and a.ProductID=c.ProductID and ShipCountry='Germany' group by a.CategoryID order by count(a.CategoryID) desc limit 1;
