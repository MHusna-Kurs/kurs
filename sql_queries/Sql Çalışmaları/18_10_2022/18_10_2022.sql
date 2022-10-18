--Categories tablosundaki kayıtları update eden SP'yi yazınız.

alter proc UpdateCategory(@id int, @name nvarchar(15), @desc ntext, @picture image) as
begin
update Categories set CategoryName = @name, Description = @desc, Picture = @picture where CategoryID = @id
select 'Etkilenen satır sayısı: '+STR(@@ROWCOUNT)
end

exec UpdateCategory 20, 'İnşaat Malz', 'İnşaat yapı malzemeleri', 'insaat.png'

--Kaç kategori olduğunu döndüren SP

alter proc SP_CategoryCount(@count int output) as
begin
select @count = COUNT(*) from Categories
end

--SP'den gelen değeri @sayi değişkenine atadık.
declare @sayi int
exec SP_CategoryCount @sayi output

print 'Category tablosundaki kayıt sayısı: '+ str(@sayi)

--Kendisine gönderilen 2 adet sayının toplamını döndüren SP.

create proc SP_Sum (@sayi1 int, @sayi2 int, @toplam int output) as
begin
set @toplam = @sayi1 + @sayi2
end

declare @sonuc int
exec SP_Sum 10, 15, @sonuc output
print 'Toplam: '+str(@sonuc)

alter proc SP_Sum (@sayi1 int, @sayi2 int, @islem int, @sonuc int output) as
begin
if(@islem = 1)
set @sonuc = @sayi1 + @sayi2
if(@islem = 2)
set @sonuc = @sayi1 - @sayi2
if(@islem = 3)
set @sonuc = @sayi1 * @sayi2
if(@islem = 4)
set @sonuc = @sayi1 / @sayi2
end

declare @sonuc int
exec SP_Sum 10, 15, 2, @sonuc output
print 'Sonuc: '+str(@sonuc)