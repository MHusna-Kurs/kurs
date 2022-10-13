select * from tb_ogrenci

select ad, soyad from tb_ogrenci

--tb_ogrenci yerine DB_Test.dbo.tb_ogrenci ile tam adını vererek de erişebiliyoruz.
select ID, ad, soyad from tb_ogrenci 

select * from tb_ogrenci where ad = 'Veysel'

select * from tb_ogrenci where ID > 2

--En üstten 2 kayıtı getiriyor.
select top 2 * from tb_ogrenci

select ID, ad, soyad from tb_ogrenci order by ID --asc

select top 3 ID, ad, soyad from tb_ogrenci order by ID desc

--(Nolock) ile veri tabanının kilitlenmesini önleriz.

select * from tb_ogrenci where ID between 2 and 8

select * from tb_ogrenci where ID not between 5 and 7

--select * from tb_ogrenci where ID = 13 or ID = 14
select * from tb_ogrenci where ID in (13, 14)