select 'Müşteri' as Tip, City as Şehir, c.Country, Concat('Şirket Adı: ', CompanyName) as [Şirket/Yetkili ad] from Customers c
union
select 'Tedarikçi' as Tip, City as Şehir, Country, Concat('Yetkili Adı: ', CompanyName) as [Şirket/Yetkili ad] from Suppliers s

select 'Müşteri' as Tip, City as Şehir, Country from Customers where Country = 'France'
union all
select 'Tedarikçi' as Tip, City as Şehir, Country from Suppliers where Country = 'France'
order by 1,2

--Hangi ülkelerden müşterim var ?

select distinct Country from Customers

--CTE(Common Table Expression) // Geçici tablodur, kayıt edilmez.
with AzKalanUrunler_CTE as (select p.ProductName, p.UnitsInStock, p.CategoryID from Products p where p.UnitsInStock < 50)
select ProductName, UnitsInStock from AzKalanUrunler_CTE

with Sales_CTE as(select [OrderId], year([OrderDate]) as yil from Orders where EmployeeID is not null) 
select * from Sales_CTE

--Satış temsilcisinin ortalama sipariş adetleri
with Sales_CTE as(select EmployeeID, count(*) as SalesCount from Orders where EmployeeID is not null group by EmployeeID )
select EmployeeID, avg(SalesCount) from Sales_CTE group by EmployeeID

--Satış temsilcisinin yıllara göre sipariş adedi
with SALES_CTE (SalesPersonId, SalesYear, SalesOrderId) as (select EmployeeID, year(OrderDate) SalesYear, OrderID
				from Orders where EmployeeID is not null)
select SalesPersonId, SalesYear Yil, count(SalesOrderId) as CountOfOrders from SALES_CTE group by SalesPersonId, SalesYear
order by 1,2

--Hangi sipariş toplam kaç para ?
select OrderID, sum(UnitPrice*Quantity) from [Order Details] group by OrderID order by 2

