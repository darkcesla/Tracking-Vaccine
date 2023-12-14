CREATE DATABASE TrackingVaccine_05;
USE TrackingVaccine_05;

CREATE TABLE akun(
id_akun INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
username VARCHAR(255) NOT NULL,
PASSWORD VARCHAR(255) NOT NULL,
role int NOT NULL
);

CREATE TABLE akun_pasien(
id_akun INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
nama varchar(25) not null,
nik varchar(30) not null,
username VARCHAR(255) NOT NULL,
password VARCHAR(255) NOT NULL,
role int NOT NULL
);

drop table akun

Create Table role(
id_role INT NOT NULL PRIMARY KEY,
nama_role varchar(10)
);

CREATE TABLE pembelian_vaksin(
id_pembelian INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
id_akun int,
nama VARCHAR(225) NOT NULL,
jumlah VARCHAR(225) NOT NULL
);

CREATE TABLE daftar_vaksin(
id_vaksin INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
id_registrasi varchar(255) not null,
nama_vaksin VARCHAR(225) NOT NULL,
jenis_vaksin VARCHAR(225) NOT NULL,
jumlah VARCHAR(225) NOT NULL,
status_vaksin Varchar(255) default 'Belum Valid'
);

select * from daftar_vaksin

insert into daftar_vaksin(id_registrasi,nama_vaksin,jenis_vaksin,jumlah) values ('REGVC02','Vaksin COCOVID v5','Cairan',10)

drop table daftar_vaksin

insert into role values (3,'produsen'),(4,'rumahsakit'),(5,'pasien');


select * from role

INSERT INTO [dbo].[akun]
           ([username]
           ,[PASSWORD]
           ,[role])
     VALUES
           ('produsen','produsen123',3),('rumahsakit','rumahsakit123',4)
GO

USE [TrackingVaccine_05]
GO

INSERT INTO [dbo].[akun_pasien]
           ([nama]
           ,[nik]
           ,[username]
           ,[password]
           ,[role])
     VALUES
           ('Prima Tambun'
           ,'1211261001002'
           ,'primatbn'
           ,'prima123'
           ,5)
GO

select * from akun

delete from akun where id_akun = 1



alter table akun
add constraint fkakun_role foreign key (role)
references role(id_role)
ON DELETE CASCADE
ON UPDATE CASCADE
;

alter table akun_pasien
add constraint fkakun_role_pasien foreign key (role)
references role(id_role)
ON DELETE CASCADE
ON UPDATE CASCADE
;

alter table pembelian_vaksin
add alamat varchar(255)

select * from role
select * from akun
select * from akun_pasien

delete from akun where id_akun = 8 

alter table pembelian_vaksin
add constraint fkpembelian_akun foreign key (id_akun)
references akun(id_akun)
ON DELETE CASCADE
ON UPDATE CASCADE
;

create table pembelian_rumsak(
id_pembelian_rumsak INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
vaksin_id int not null,
laporan VARCHAR(225) NOT NULL
)

select * from pembelian_rumsak
select * from daftar_vaksin
select * from role
select * from akun_pasien

insert into pembelian_rumsak (vaksin_id,laporan) values (2,'Sudah Dibeli/Diterima') 

alter table pembelian_rumsak
add constraint fkpembelian_rumsak foreign key (vaksin_id)
references daftar_vaksin(id_vaksin)
ON DELETE CASCADE
ON UPDATE CASCADE