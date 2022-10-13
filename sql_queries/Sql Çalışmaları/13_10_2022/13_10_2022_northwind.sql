--İşlemi Başlatıyoruz
begin transaction

update Customers set ContactName = 'Alfred Schmidt', City = 'Frankfurt' where CustomerID = 'BLAUS'

--Geri almak için
RollBack

--Onaylamak için
Commit

begin transaction
update Customers set ContactName = 'Ali Kaynak', City = 'İstanbul' where CustomerID = 'BLAUS'
select * from Customers where CustomerID = 'BLAUS'
rollback

begin transaction
update Customers set ContactName='Juan' where Country='Mexico'
select * from Customers
commit

--delete from table where condition
--begin transaction
--delete from Customers where ContactName='Juan'

begin transaction
delete from [Order Details] where OrderID in (select OrderID from Orders where CustomerID in (select CustomerID from Customers where ContactName = 'Juan'))
delete from Orders where OrderID in (select OrderID from Orders where CustomerID in (select CustomerID from Customers where ContactName = 'Juan'))
delete from Customers where ContactName = 'Juan'
commit

select * from Customers where ContactName = 'Juan'

--select column_name(s) from table_name where condition group by column_name(s) order by column_name(s)

--Her bir ülkedeki müşteri sayılarını dökünüz.

--2. kolona göre sıralama yapıyor.
select Country, count(*) [Number of Customers] from Customers group by Country order by 2 desc

--Orders tablosundaki ShipCountry başına 50'den az sipariş gelen ülkeleri, sipariş adedine göre büyükten
--küçüğe sıralaryıp yazan query.

--having, where gibidir fakat group by ile kullanılır.
select ShipCountry, count(*) [Sipariş Adedi] from Orders group by ShipCountry having  (count(*) < 50)
order by 2 desc 

--bir tablodan diğer tabloya tüm kolonları kopyala:
--insert into table2 select * from table1 where condition

--bir tablodan diğer tabloya bazı kolonları kopyala:
--insert into table2(column1, column2, ...) select (column1, column2, ...) from table1 where condition

--supplier tablosundan customer tablosuna kayıt kopyalama
--Data aktarılmayan kolonlar null kalır.

insert into Customers (CustomerID, ContactName, CompanyName, City, Country) 
select SupplierID, ContactName, CompanyName, City, Country from Suppliers

select * from Customers where ContactName = 'Charlotte Cooper'

create table Persons(
	PersonID int identity(1, 1) primary key,
	FirstName varchar(255),
	LastName varchar(255),
	Age int)

create index IX_FirstLastName on Persons(Firstname, Lastname)

create unique index UQ_Age on Persons(Age)

drop index Persons.UQ_Age

set concat_null_yields_null off select c.CompanyName, Address + ',' + PostalCode +','+City + ','+ Country as Adres
from Customers c

select GetDate() 'GetDate',
FORMAT (GetDate(), 'd', 'tr-TR') as Turkce,
FORMAT (GetDate(), 'd', 'en-US') as Amerikan,
FORMAT (GetDate(), 'd', 'en-GB') as İngiliz

select c.CompanyName, o.OrderID, p.ProductName, cat.CategoryName from 
Orders o inner join Customers c on o.CustomerID = c.CustomerID
inner join [Order Details] d on d.OrderID = o.OrderID
inner join Products p on p.ProductID = d.ProductID
inner join Categories cat on p.CategoryID = cat.CategoryID

exec sp_who2
kill 56