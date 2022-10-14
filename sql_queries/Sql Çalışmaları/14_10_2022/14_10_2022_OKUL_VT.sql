create table tb_Ogrenci(
	numara int,
	ad varchar(50),
	soyad varchar(50),
	dogumYili smallint,
	sinif varchar(5)
)

alter table tb_Ogrenci alter column numara varchar(50) not null
alter table tb_Ogrenci alter column ad varchar(50) not null
alter table tb_Ogrenci alter column soyad varchar(50) not null
alter table tb_Ogrenci alter column dogumYili smallint not null
alter table tb_Ogrenci alter column sinif varchar(5) not null

alter table tb_Ogrenci add constraint PK_Tb_Ogrenci
primary key clustered(numara)

select * from tb_Ogrenci

alter table tb_Ogrenci drop constraint PK_Tb_Ogrenci
alter table tb_Ogrenci drop column numara

alter table tb_Ogrenci add numara int not null identity(1,1) primary key

insert into tb_ogrenci (ad, soyad, dogumYili, sinif, numara)
values ('Kemal', 'Çelik', 1980, 'D203', 10)