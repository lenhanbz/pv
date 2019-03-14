--create database ab
--use ab


CREATE TABLE Lop(
	MaLop int not null,
	TenLop NVARCHAR(30) not null,
	MSSV int,
	PRIMARY KEY (MaLop),
	)
create table SinhVien(
	MSSV int not null,
	HoTen Nvarchar(50) not null,
	NgaySinh Datetime,
	GioiTinh bit,
	MaLop int,
	FOREIGN KEY (MaLop) REFERENCES Lop(MaLop),
	PRIMARY KEY (MSSV),
	)
create table MonHoc(
	MaMon int not null,
	TenMon Nvarchar(30) not null,
	MSSV int,
	FOREIGN KEY (MSSV) REFERENCES SinhVien(MSSV),
	PRIMARY KEY (MaMon),

)

create table KetQuaThi(
	MSSV int,
	DiemThi int,
	MaMon int,
	FOREIGN KEY (MaMon) REFERENCES MonHoc(MaMon),
	)
insert into Lop(MaLop,TenLop,MSSV)
values (333,'Sinh hoc',123)

insert into SinhVien(MSSV,HoTen,NgaySinh,GioiTinh,MaLop)
values (12373, 'NAm nguyen','2019/2/23',1,333),
		(12433, 'NAm nguyen','2019/2/23',1,333),
		(14233, 'NAm nguyen','2019/2/23',1,333)