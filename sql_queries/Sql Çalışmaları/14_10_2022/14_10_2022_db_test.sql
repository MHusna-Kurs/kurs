update tb_alan set ad = 'Elektrik & Elektronik' where ad = 'Elektronik'

--idsi 4 olan öğretmenin telefonunu '05231112233', alanını da elek eltrnk yap

update tb_Ogretmen set alan = 5, telefon = '05231112233' where ID = 4

begin transaction
delete from tb_Ogretmen where ID = 4
commit

select ogrenci.ad [Öğrenci Ad], ogrenci.soyad [Öğrenci soyad], 
	   ogretmen.ad [Öğretmen Ad], ogretmen.soyad [Öğretmen Soyad],
	   alan.ad [Alan], 
	   sinif.ad [Sınıf]
from tb_ogrenci ogrenci inner join tb_Ogretmen ogretmen on ogrenci.ogretmenID = ogretmen.ID
				  inner join tb_alan alan on ogretmen.alan = alan.ID
	              inner join tb_sinif sinif on ogrenci.sinifID = sinif.ID

create view OgrenciOgretmen as 
select o.ad+ ' '+ o.soyad as Öğrenci, og.ad+' '+ og.soyad as Öğretmen
from tb_ogrenci o inner join tb_Ogretmen og on o.ogretmenID = og.ID

select * from OgrenciOgretmen