select * from SalesLT.Product where Name  between 'A' and 'BZ'

select * from SalesLT.Product where Weight <= 900 order by Weight

select Color , isnull(Color, 'Brown') from SalesLT.Product order by Weight

--3 kolonu birleştirir. En alttaki satır, 3 kolondan biri null ise onu görmezden geliyor.
select Name, Color, ProductNumber, Name+Color+ProductNumber as Ozet
from SalesLT.Product
set Concat_NULL_YIELDS_NULL OFF

select Size, isnull(Size, 0.1) from SalesLT.Product

update SalesLT.Product set Size = '12' where isnull(Size, 0.1) = '0.1'

update SalesLT.Product set Size = NULL where Size = '12'

select Size from SalesLT.Product

select top 5 Size from SalesLT.Product order by Size desc

--Classic join method is same with the inner join method.
--The classic join method
select SOD.productID, p.Name, SOD.* from SalesLT.Product p, SalesLT.SalesOrderDetail SOD
where SOD.ProductID = p.ProductID

--inner join method
select sod.productID, p.Name, sod.* from SalesLT.Product p inner join SalesLT.SalesOrderDetail sod on sod.ProductID = p.ProductID

--left join method
select sod.productID, p.Name, sod.* from SalesLT.Product p left join SalesLT.SalesOrderDetail sod on sod.ProductID = p.ProductID 

--right join method
select sod.productID, p.Name, sod.* from SalesLT.Product p right join SalesLT.SalesOrderDetail sod on sod.ProductID = p.ProductID

--inner join ortak olan kayıtları yani eşleşen kayıtları getirir
--left join soldaki tablonun tüm kayıtlarını ve sağdaki tablonun eşleşen kayıtlarını getirir
--right join sağdaki tablonun tüm kayıtlarını ve soldaki tablonun eşleşen kayıtlarını getirir.

--Full Outer Join: Hem right join, hem left join -> Eşleşsin, eşleşmesin fark etmez iki tablodaki kayıtların hepsini getirir.
select sod.productID, p.Name, sod.* from SalesLT.Product p full join SalesLT.SalesOrderDetail sod on sod.ProductID = p.ProductID

select * from SalesLT.SalesOrderDetail sod where sod.ProductID = 708

create table Kullanicilar
(KullaniciID int not null,
Ad varchar(50),
Soyad varchar(50),
KullaniciAd varchar(20))

--alter: değiştir demek
alter table Kullanicilar add constraint PK_KullaniciID primary key(KullaniciID)

alter table Kullanicilar add Kayittarihi DateTime

--Kullanıcı değer girmezse onun yerine o anki zamanı girecek
alter table Kullanicilar add default(Getdate()) for Kayittarihi

alter table Kullanicilar alter column Kayittarihi SmallDateTime

alter table Kullanicilar add Sehir varchar(20)

alter table Kullanicilar add default('Istanbul') for sehir

select * from Kullanicilar

select min(OrderDate) from SalesLT.SalesOrderHeader

select ShipDate, CustomerID from SalesLT.SalesOrderHeader soh inner join SalesLT.SalesOrderDetail sod on soh.SalesOrderID = sod.SalesOrderID
where OrderDate = (select min(OrderDate) from SalesLT.SalesOrderHeader)

-- LEGEND EXAMPLE
select ShipDate, soh.CustomerID, c.FirstName, c.LastName, p.ProductID, p.Name Urun_Adi, ct.Name Kategori_Adi
from SalesLT.SalesOrderHeader soh inner join SalesLT.SalesOrderDetail sod on soh.SalesOrderID = sod.SalesOrderID
								  inner join SalesLT.Customer c on c.CustomerID = soh.CustomerID
								  inner join SalesLT.Product p on sod.ProductID = p.ProductID
								  inner join SalesLT.ProductCategory ct on ct.ProductCategoryID = p.ProductCategoryID 
where OrderDate = (select min(OrderDate) from SalesLT.SalesOrderHeader)

--Üsttekinin klasik versiyonu
select ShipDate, soh.CustomerID, c.FirstName, c.LastName, p.ProductID, p.Name Urun_Adi, ct.Name Kategori_Adi
from SalesLT.SalesOrderHeader soh,
	 SalesLT.SalesOrderDetail sod,
	 SalesLT.Customer c,
	 SalesLT.Product p,
	 SalesLT.ProductCategory ct
where soh.SalesOrderID = sod.SalesOrderID and
	  c.CustomerID = soh.CustomerID and
	  sod.ProductID = p.ProductID and
	  ct.ProductCategoryID = p.ProductCategoryID and
	  OrderDate = (select min(OrderDate) from SalesLT.SalesOrderHeader)

select * from SalesLT.Product p where exists 
                                      (select sod.ProductID from SalesLT.SalesOrderDetail sod where sod.ProductID = p.ProductID)

select * from SalesLT.SalesOrderDetail where ProductID in ( 707, 708, 711, 712, 714)

select ROW_NUMBER() over(order by ProductID), * from SalesLT.Product p where not exists 
									  (select sod.ProductID from SalesLT.SalesOrderDetail sod where sod.ProductID = p.ProductID)

select * into yeni_product from SalesLT.Product

--temporary table
select * into #gecici_tablo from SalesLT.Product

select * from #gecici_tablo