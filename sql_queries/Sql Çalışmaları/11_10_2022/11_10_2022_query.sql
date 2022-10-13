---------------------------------------------------------------------------------------------------------
------------------------------------------- 11.10.2022 --------------------------------------------------
---------------------------------------------------------------------------------------------------------

select * from SalesLT.Customer

select distinct FirstName from SalesLT.Customer

--Tekrarlanmadan getiriyor. Distinct: benzersiz demektir.
select distinct SalesPerson from SalesLT.Customer 

--3 farklı kolonda yazdırır.
select FirstName, MiddleName, LastName from SalesLT.Customer 

--Tek kolonda 3 isimi de yazdırır. 
-- as keywordu ile kolon ismi verdik. 
--IsNull ile kontrol ediyoruz ve null yerine yazmasını istediğimiz değeri giriyoruz.
select IsNull(FirstName,'') + ' ' + IsNull(MiddleName, '') + ' ' + IsNull(LastName, '') as 'Ad Soyad' from SalesLT.Customer 

select * from SalesLT.Customer where Firstname = 'imtiaz'

select distinct FirstName, LastName, ( IsNull(FirstName,'') + ' ' + IsNull(MiddleName, '') + ' ' + IsNull(LastName, '')) as 'Ad Soyad' 
from SalesLT.Customer
order by FirstName, LastName

select * from SalesLT.Customer
where FirstName = 'Henry'

-- order by 2 ile LastName'e göre sırala demek istiyoruz.
select distinct FirstName, LastName, ( IsNull(FirstName,'') + ' ' + IsNull(MiddleName, '') + ' ' + IsNull(LastName, '')) as 'Ad Soyad' 
from SalesLT.Customer
order by 2

-- c ve SOH alias isimleri oldular.
select c.CustomerID from SalesLT.Customer c
union all
select SOH.CustomerID from SalesLT.SalesOrderHeader SOH

-- SalesLT.Product tablosundaki ProductID ile SalesLT.SalesOrderDetail tablosundaki ProductID'leri birleştirdik.
select sp.ProductID from SalesLT.Product sp
union
select sod.ProductID from SalesLT.SalesOrderDetail sod

select distinct Grup.UrunKodu from(
select sp.ProductID UrunKodu from SalesLT.Product sp
union
select sod.ProductID from SalesLT.SalesOrderDetail sod) Grup

select * from SalesLT.Product
where Color in ('black', 'white')

select * from SalesLT.Product
where ProductNumber in(
'FR-R92B-58',
'FR-R92R-58',
'HL-U509-R',
'HL-U509',
'SO-B909-M')
and Color in ('black', 'white')

select * from SalesLT.Product d
where d.ProductCategoryID in (6, 27)

select * from SalesLT.Product d
where Name like '%Bike Socks%'or Name like '%motor'

--Product tablosundaki Size alanının benzersiz değeri
select distinct Size from SalesLT.Product p

select * from SalesLT.Product
where Name = 'HL Bottom Bracket'
and  ProductID = 707
and Color = 'Black'

select MIN(p.ProductID) as productid from SalesLT.Product p
where ProductID > 700

-- 700'den büyük en küçük product id
select * from SalesLT.Product
where ProductID=(select MIN(p.ProductID) as productid from SalesLT.Product p
where ProductID > 700)

-- 700'den küçük en büyük product id
select * from SalesLT.Product
where ProductID=(select MAX(p.ProductID) as productid from SalesLT.Product p
where ProductID < 700)

-- Karşılaştırma Operatörleri
-- < > <= >= != <> LIKE

select * from SalesLT.Product where ProductID < 700

select len(Name) as Uzunluk, Name from SalesLT.Product order by 1 desc

select * from SalesLT.Product where Name = 'Mountain Bike Socks, L'

select * from SalesLT.Product where Name LIKE '%Bike%'

-- Tüm ürünleri renge göre azalan ve product id azalan sırada getiriniz.
									--  4              1     de yazılabilirdi.
select * from SalesLT.Product order by Color desc, ProductID desc

select * from SalesLT.Product where ProductModelID between 18 and 33

select * from SalesLT.Customer where MiddleName IS NULL

select * from SalesLT.Customer where MiddleName IS NOT NULL

--Size'ı null olanlara 2 atıyor.
select isnull(Size, 2) Size1, Size YeniSize from SalesLT.Product


----------------------------------------------------------------------------

select top 5 percent * from SalesLT.Customer

--INNER JOIN
select SOD.ProductID, P.Name, SOD.*
from SalesLT.Product P inner join SalesLT.SalesOrderDetail SOD
on SOD.ProductID = P.ProductID

--LEFT JOIN: Soldaki tablodan tüm kayıtları, sağdaki tablodan eşleşen kayıtları alıyor.
select SOD.ProductID, P.Name, SOD.* 
from SalesLT.Product P left join SalesLT.SalesOrderDetail SOD
on SOD.ProductID = P.ProductID

select count(*) from SalesLT.Product

select SOD.ProductID, P.Name, SOD.* 
from SalesLT.Product P right join SalesLT.SalesOrderDetail SOD
on SOD.ProductID = P.ProductID