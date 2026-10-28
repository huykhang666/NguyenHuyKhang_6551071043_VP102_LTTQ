CREATE DATABASE DuLieu;

CREATE TABLE SinhVien(
	MaSinhVien nvarchar(10) primary key,
	TenSinhVien nText not null,
	DiemTrungBinh nvarchar(8) not null

);

insert into SinhVien(MaSinhVien,TenSinhVien,DiemTrungBinh)
values ('SV001','Nguyễn Văn A',8.5)
insert into SinhVien(MaSinhVien,TenSinhVien,DiemTrungBinh) values ('SV002','Nguyễn Văn B',7.0)
insert into SinhVien(MaSinhVien,TenSinhVien,DiemTrungBinh) values ('SV003','Nguyễn Văn C',9.0)
insert into SinhVien(MaSinhVien,TenSinhVien,DiemTrungBinh) values ('SV004','Nguyễn Văn D',6.5)
insert into SinhVien(MaSinhVien,TenSinhVien,DiemTrungBinh) values ('SV005','Nguyễn Văn E',8.0)
