select count(*) from SalesLT.Customer

--Stoktaki ürünlerin toplam tutarı
select SUM(ListPrice) from SalesLT.Product

--Ortalama birim fiyat
--select SUM(ListPrice)/Count(*) from SalesLT.Product
select AVG(ListPrice) from SalesLT.Product

--En düşük birim fiyat
select MIN(ListPrice) from SalesLT.Product

--En yüksek birim fiyata sahip ürünün adını ve fiyatını yazdıran sorgu
select Name, ListPrice from SalesLT.Product where (ListPrice = (select MAX(ListPrice) from SalesLT.Product))

--Müşterileri CustomerID'ye göre sıralı yazın.
select * from SalesLT.Customer order by CustomerID

--Hangi satış temsilcisinin kaç müşterisi var.
select COUNT(*) [Müşteri Sayısı], SalesPerson from SalesLT.Customer group by SalesPerson order by 1 desc

--En az müşteriye sahip satıcı adı ve müşteri sayısı

--80'den fazla müşterisi olan temsilciler ve müşteri sayıları
select [SalesPerson], COUNT(*) from SalesLT.Customer group by [SalesPerson] having COUNT(*) > 80

--Her kategorideki ürünlerin toplam mal değeri
select SUM(p.ListPrice) [Liste Fiyat Toplamı] , pc.Name from 
SalesLT.Product p inner join SalesLT.ProductCategory pc on p.ProductCategoryID = pc.ProductCategoryID
group by pc.Name order by 1

--Her bir üründen kaçar adet sipariş verilmiş
select  p.ProductNumber [Ürün Kodu], p.Name [Ürün Adı], Sum(sod.OrderQty) [Sipariş Miktarı]
from SalesLT.SalesOrderDetail sod inner join SalesLT.Product p on sod.ProductID = p.ProductID
group by p.ProductNumber, p.Name, sod.OrderQty
order by 3 desc

--ek olarak 1998 5. ay ve sonrasındaki siparişleri filtrelesin.
select  p.ProductNumber [Ürün Kodu], p.Name [Ürün Adı], Sum(sod.OrderQty) [Sipariş Miktarı]
from SalesLT.SalesOrderDetail sod inner join SalesLT.Product p on sod.ProductID = p.ProductID
								  inner join SalesLT.SalesOrderHeader soh on soh.SalesOrderID = sod.SalesOrderID
where soh.OrderDate >= '1998-5-01 00:00:00.000'
group by p.ProductNumber, p.Name, sod.OrderQty
order by 3 desc

--CategoryID'si null olan product kayıtların sayısını getir.
select count(*) from salesLT.Product p where p.[ProductCategoryID] is null