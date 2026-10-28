create database DuLieu_NhanSu;
go
use DuLieu_NhanSu;
go

create table NhanVien(
	MaNhanVien nvarchar(10) primary key,
	TenNhanVien nText not null,
	LuongCoBan nvarchar(12) not null
);