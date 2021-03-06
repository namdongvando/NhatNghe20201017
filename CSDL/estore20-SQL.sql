/****** Script for SelectTopNRows command from SSMS  ******/
-- 10 san pham có doin gia lon nhất
select top(10) *
from HangHoa
order by DonGia desc

-- 10 san pham có doin gia nho nhat nhất
select top(10) *
from HangHoa
order by DonGia asc
-- tim san pham theo ten "chai" 
select *
from HangHoa
where TenHH like 'ch%'
-- tim hang hóa có ma loại 1000
select *
from HangHoa
where MaLoai = 1000 or MaLoai = 1001
or MaLoai = 1002
--cach 2
 select *
from HangHoa
where MaLoai not in(1000,10001,1002)

-- tim hang hoa don gia lon nhat
select * 
from HangHoa
where DonGia =(
 select top(1) DonGia
from HangHoa
order by DonGia desc)

-- tim hang hoa có gia tu 50 - 100
select * 
from HangHoa
where 
--DonGia >= 50 and DonGia <=100 
DonGia between 50 and 100 
-- den so loai san pham trong bang hang hoa
select COUNT(*),MaLoai 
from HangHoa 
group by MaLoai
-- tong so hang hoa theo loai
select COUNT(*) as Tong
from HangHoa
where MaLoai = 1000
-- tong so lan xem
select sum(SoLanXem)
from HangHoa



-- tim san pham có mã là "1029"
select * 
from HangHoa 
where MaHH = 1001 

select a.*,b.TenLoai 
from HangHoa as a,Loai as b
where a.MaLoai = b.MaLoai

select a.*,b.TenLoai,c.TenCongTy
from HangHoa as a,Loai as b, NhaCungCap as c
where a.MaLoai = b.MaLoai and a.MaNCC= c.MaNCC
and c.TenCongTy like '%nokia%' and b.TenLoai like '%seafood%'

select *
from Loai

delete from Loai 
where MaLoai = 1007

