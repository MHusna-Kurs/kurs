--Trigger: Çağrılmaksızın şartlar sağlandığında otomatik çalışan SQL sorguları yazmamızı sağlar.

--After Trigger: Belirli bir sorgu çalışırsa arkasından çalışsın şeklinde tanımladığımız trigger yapısıdır.
--Örnek: Categories tablosuna her insert yapıldığında sorgu otomatik çalışsın.

--instead of trigger: Belirli bir tabloda çalışan bir sorgu çağırıldığında o sorgu çalışmasın, bizim trigger çalışsın.

create trigger TR_BlockDeleteCategory on Categories instead of delete as
begin
declare @catadi nvarchar(50)
select @catadi = CategoryName from deleted --Deleted geçici tablosu silinen kayıtları getirir.
print @catadi + ' silinmeye çalışıldı.'
end

delete from Categories where CategoryID = 8
select * from Categories

--CategoriesBackup isimli bir tablo oluşturun.
--Categories tablosundan veri silmeye çalışıldığında önce silinmeye çalışılan veriyi bu yeni tabloya insert edin, daha sonra silin
--meye çalışan satırı silin.

drop table [CategoriesBackup]

create TABLE [dbo].[CategoriesBackup](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	[Description] [ntext] NULL,
	[Picture] [image] NULL)

create trigger TR_Yedek on Categories instead of delete as
begin
declare @id int
declare @name nvarchar(max)
declare @desc nvarchar(max)
declare @img varbinary(max)

select @id = CategoryID from deleted
select @name = CategoryName from deleted
select @desc = Description from deleted
select @img = Picture from deleted

insert into CategoriesBackup (CategoryId, CategoryName, Description, Picture)
values (@id, @name, @desc, @img)

delete from Categories where CategoryID = @id
end

--------------------------------------------------------------------------------------------------------------
create trigger TR_Yedek on Categories instead of delete as
begin
INSERT INTO [dbo].[CategoriesBackup](
           [CategoryID]
           ,[CategoryName]
           ,[Description]
           ,[Picture])
SELECT 
            [CategoryID]
           ,[CategoryName]
           ,[Description]
           ,[Picture]
FROM DELETED;
DECLARE @id INT;
SELECT @id = CategoryID FROM DELETED;
DELETE FROM Categories WHERE [CategoryID]=@id;

END