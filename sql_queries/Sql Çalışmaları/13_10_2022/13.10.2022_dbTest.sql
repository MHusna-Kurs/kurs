create table Kullanicilar(
	KullaniciID int not null,
	Ad varchar(50),
	Soyad varchar(50),
	KullaniciAd varchar(20)
);

alter table Kullanicilar add constraint PK_KullaniciID Primary Key(KullaniciID)

create table Personeller(
	PersonelID int primary key not null identity(1,1), --1'den başlıyor birer birer artıyor demek.
	Ad varchar(50) not null,
	Soyad varchar(50) not null,
	KullaniciID varchar(20) not null,
	Email varchar(50),
	Adres varchar(255),
	Sehir varchar(50)
);

alter table Personeller add constraint UQ_PersonelEmail unique (Email)

alter table Personeller add default(Getdate()) for KayitTarihi