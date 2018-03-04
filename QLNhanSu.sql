create database QLNhanSu
go
use QLNhanSu
go
create table ChucVu(
MaChucVu char(10) primary key,
TenChucVu nvarchar(50))
go
create table Luong(
BacLuong int primary key,
LuongCoBan money,
HeSoLuong int,
HeSoPhuCap int)
go
create table PhongBan(
MaPB char(10) primary key,
TenPB nvarchar(50),
DiaChi nvarchar(50),
SDT char(11))
go
create table TrinhDoHocVan(
MaTDHV char(10) primary key,
TenTrinhDo nvarchar(50),
ChuyenNganh nvarchar(50))
go
create table NhanVien(
MaNV char(10) primary key,
HoTen nvarchar(50),
DanToc nvarchar(50),
GioiTinh bit,
SDT int,
QueQuan nvarchar(50),
NgaySinh date,
MaTDHV char(10) references TrinhDoHocVan(MaTDHV),
MaPB char(10) references PhongBan(MaPB),
BacLuong int references Luong(BacLuong))
go
create table ThoiGianCongTac(
MaNV char(10) references NhanVien(MaNV),
MaCV char(10) references ChucVu(MaChucVu),
NgayNhanChuc date,
primary key (MaNV,MaCV))
--------- 04/03/2018-------
go
alter table NhanVien
alter column GioiTinh varchar(3)
go
insert into NhanVien(MaNV,HoTen,DanToc,GioiTinh,SDT,QueQuan,NgaySinh)
values ('NV01','Hoàng Thị Minh','kinh','Nu','0976986543','Hà Nội','09-08-1990'),
('NV02','Nguyễn Quang Huy','kinh','Nam','0973686583','Vĩnh Phúc','10-19-1990'),
('NV03','Ngô Hữu Huy','kinh','Nam','0976639201','Hà Nam','03-20-1993'),
('NV04','Bùi Trung Kiên','kinh','Nam','0976863496','Hà Nội','12-08-1992'),
('NV05','Nguyễn Thị Ngọc','kinh','Nu','01647386289','Phú Thọ','02-08-1991'),
('NV0','Lê Bá Lộc','kinh','Nam','0976963984','Ha Noi','01-08-1995')



 