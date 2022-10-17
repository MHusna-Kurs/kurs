--Stored Procedure: SQL dilinde yazılımdaki metotlara karşılık gelir.
--Kısaltması SP'dir. Parametreli ve parametresiz olabilir. Aldığı parametreleri sorgularda kullanabilir.
--Geriye değer döndürebilir(output)
--Belirli işleri yapan sorguları SP'ler ile bir defa yazarak sürekli kullanırız.

--SP Oluşturma
create procedure GetCategories as
begin select * from Categories end

--SP Çağırılması
execute Northwind.dbo.GetCategories
exec GetCategories

---------------------------------------------

create procedure GetOrders as
begin select * from Orders end

exec GetOrders

---------------------------------------------

create proc SearchCategories (@name nvarchar(50)) as
begin declare @sayi int
select @sayi = COUNT(*) from Categories where CategoryName = @name;
if(@sayi>0)
begin
	select * from Categories where CategoryName = @name;
	select STR(@sayi) + ' adet kayıt bulund'
end
else
begin
	print 'Herhangi bir kayıt bulunamadı.'
end
end

exec SearchCategories 'Elma'

--Order details tablosundan unit price ve quantity alt sınırına göre sorgu çekecek SP'yi yazınız.
--Örnek: GetOrderDetails 10,15

create proc GetOrderDetails(@unitprice int, @quantity int) as
begin
select * from [Order Details] where UnitPrice >= @unitprice and Quantity >= @quantity
end

exec GetOrderDetails 10, 15

--Categories tablosuna kayıt eklemesi yapan SP'yi yazınız.
--Parametreler: categoryname description picture

create proc AddCategory(@categoryname nvarchar(15), @description ntext, @picture image) as
begin
insert into Categories (CategoryName, [Description], Picture) values (@categoryname, @description, @picture)
end

exec AddCategory 'tesisat', 'nalburiye malzemeleri', 'adasdasda'

--Categories tablosundan silme işlemi yapan SP.
--ID'yi alır, silmeden önce ve sonra tüm kayıtları gösterir.

create proc RemoveCategory (@categoryid int)as
begin
select * from Categories
delete from Categories where CategoryID = @categoryid
select * from Categories
end

exec RemoveCategory 19

--Category tablosundaki kayıtları update yapan sp yazınız.
create proc UpdateCategory (@categoryid int, @categoryname nvarchar(15), @description ntext, @picture image)as
begin
update Categories set CategoryName = @categoryname, Description = @description, Picture = @picture where CategoryID = @categoryid
select 'Etkilenen satır sayısı: '+STR(@@rowcount)
end

exec UpdateCategory 20, 'İnşaat Yapı Malz.', 'İnşaat Malzemeleri', 'insaat.png'
