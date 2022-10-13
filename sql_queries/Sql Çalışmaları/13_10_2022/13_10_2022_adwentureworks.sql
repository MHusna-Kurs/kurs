select MIN(OrderDate) from SalesLT.SalesOrderHeader

select distinct soh.OrderDate as SiparisTarihi,
				sod.ProductID as UrunNo, OrderDate
from SalesLT.SalesOrderHeader soh
inner join SalesLT.SalesOrderDetail sod on soh.SalesOrderID = sod.SalesOrderID
where OrderDate in (select OrderDate from SalesLT.SalesOrderHeader)

select soh1.CustomerID,
	   soh1.SalesOrderID,
	   soh1.OrderDate
from SalesLT.SalesOrderHeader soh1 where soh1.OrderDate = (select MIN(soh2.OrderDate) 
														   from SalesLT.SalesOrderHeader soh2
														   where soh1.CustomerID = soh2.CustomerID)

select distinct OrderDate as [Siparis Tarihi], sod.ProductID as [Urun Kodu]
								  from SalesLT.SalesOrderHeader soh inner join SalesLT. SalesOrderDetail sod 
								  on soh.SalesOrderID = sod.SalesOrderID
								  where OrderDate = '2004-06-01'

select distinct soh.OrderDate as [Siparis Tarihi], sod.ProductID as [Urun Kodu], ROUND(sod.UnitPrice, 2) as Fiyat
								  from SalesLT.SalesOrderHeader soh inner join SalesLT. SalesOrderDetail sod 
								  on soh.SalesOrderID = sod.SalesOrderID
								  where OrderDate = '2004-06-01'