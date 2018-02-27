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




 