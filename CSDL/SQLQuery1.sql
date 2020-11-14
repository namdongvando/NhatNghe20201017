-- Tạo CSDL bán Hang
--create database BanHang
--go
use BanHang
go
-- tao bang
--create table HangHoa
--(
--	MaHH nchar(50) primary key,
--	TenHH nchar(50) ,
--	Gia decimal(18,2) ,
--	SoLuong int ,
--	QuayCachDongGoi nchar(50) 
--)
--go
-- them dong  vao bang

insert into HangHoa( 
MaHH
,TenHH
,Gia
,SoLuong
,QuyCachDongGoi
)values(
	'hh003',
	N'Quan Tay',
	15000,
	10,
	N'Cái'
)

select * from HangHoa

