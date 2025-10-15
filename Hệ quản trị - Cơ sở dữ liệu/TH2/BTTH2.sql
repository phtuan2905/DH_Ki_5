--1.Tạo view in ra danh sách các sách của nhà xuất bản giáo dục nhập trong năm 2021
create view v_B1 as
select tSach.*
from tSach
join tChiTietHDN
on tSach.MaSach = tChiTietHDN.MaSach
join tHoaDonNhap
on tChiTietHDN.SoHDN = tHoaDonNhap.SoHDN
join tNhaXuatBan
on tNhaXuatBan.MaNXB = tSach.MaNXB
where tNhaXuatBan.TenNXB = N'NXB Giáo Dục' and YEAR(tHoaDonNhap.NgayNhap) = 2021;

select * from v_B1;

drop view v_B1;

--2.Tạo view thống kê các sách không bán được trong năm 2021
create view v_B2 as
select tSach.*
from tSach
where tSach.MaSach not in (
	select tChiTietHDB.MaSach
	from tChiTietHDB
	join tHoaDonBan
	on tChiTietHDB.SoHDB = tHoaDonBan.SoHDB
	where YEAR(tHoaDonBan.NgayBan) = 2021
) 

select * from v_B2;

drop view v_B2;

--3.Tạo view thống kê 10 khách hàng có tổng tiền tiêu dùng cao nhất trong năm 2021
create view v_B3 as
select top 10 tKhachHang.*, dsTieuDung.TongTieuDung
from tKhachHang
join (
	select tKhachHang.MaKH, SUM(tSach.DonGiaBan * tChiTietHDB.SLBan) as TongTieuDung
	from tKhachHang
	join tHoaDonBan
	on tHoaDonBan.MaKH = tKhachHang.MaKH
	join tChiTietHDB
	on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	join tSach
	on tSach.MaSach = tChiTietHDB.MaSach
	where YEAR(tHoaDonBan.NgayBan) = 2014
	group by tKhachHang.MaKH
) dsTieuDung
on tKhachHang.MaKH = dsTieuDung.MaKH
order by dsTieuDung.TongTieuDung DESC;

select * from v_B3;

drop view v_B3;

--4.Tạo view thống kê số lượng sách bán ra trong năm 2021 và số lượng sách nhập trong năm
--2021 và chênh lệch giữa hai số lượng này ứng với mỗi đầu sách
create view v_B4 as
select tSach.*, ds1.TongBan, ds2.TongNhap, (ds2.TongNhap - ds1.TongBan) as ChenhLech
from tSach
join (
	select tSach.MaSach, SUM(tChiTietHDB.SLBan) as TongBan
	from tSach
	join tChiTietHDB
	on tSach.MaSach = tChiTietHDB.MaSach
	join tHoaDonBan
	on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	where YEAR(tHoaDonBan.NgayBan) = 2021
	group by tSach.MaSach
) ds1
on tSach.MaSach = ds1.MaSach
join (
	select tSach.MaSach, SUM(tChiTietHDN.SLNhap) as TongNhap
	from tSach
	join tChiTietHDN
	on tSach.MaSach = tChiTietHDN.MaSach
	join tHoaDonNhap
	on tHoaDonNhap.SoHDN = tChiTietHDN.SoHDN
	where YEAR(tHoaDonNhap.NgayNhap) = 2021
	group by tSach.MaSach
) ds2
on tSach.MaSach = ds2.MaSach

select * from v_B4;

drop view v_B4;

--5.Tạo view đưa ra những thông tin hóa đơn và tổng tiền của hóa đơn đó trong ngày
--16/11/2021
create view v_B5 as
select *
from tHoaDonBan
join (
	select tHoaDonBan.SoHDB, SUM(tChiTietHDB.SLBan * tSach.DonGiaBan) as TongTien
	from tHoaDonBan
	join tChiTietHDB
	on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	join tSach
	on tSach.MaSach = tChiTietHDB.MaSach
	where CAST(tHoaDonBan.NgayBan as DATE) = '2021-11-16'
	group by tHoaDonBan.SoHDB
) tTongTien
on tHoaDonBan.SoHDB = tTongTien.SoHDB

select * from v_B5;

drop view v_B5;

--6. Tạo view đưa ra doanh thu bán hàng của từng tháng trong năm 2014, những tháng không
--có doanh thu thì ghi là 0.
create view v_B6 as
select tThang.value as Thang, 
case
	when tDoanhThu.DoanhThu is NULL then 0
	else (0 + tDoanhThu.DoanhThu) 
end as DoanhThu
from GENERATE_SERIES(1, 12) tThang
left join (
	select MONTH(tHoaDonBan.NgayBan) as Thang, SUM(tChiTietHDB.SLBan * tSach.DonGiaBan) as DoanhThu
	from tHoaDonBan
	join tChiTietHDB
	on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	join tSach
	on tSach.MaSach = tChiTietHDB.MaSach
	where YEAR(tHoaDonBan.NgayBan) = 2014
	group by MONTH(tHoaDonBan.NgayBan)
) tDoanhThu
on tDoanhThu.Thang = tThang.value

select * from v_B6;

drop view v_B6;

--7. Tạo view đưa ra doanh thu bán hàng theo ngày, và tổng doanh thu cho mỗi tháng (dùng
--roll up)
create view v_B7 as
select YEAR(tHoaDonBan.NgayBan) as Nam, MONTH(tHoaDonBan.NgayBan) as Thang, DAY(tHoaDonBan.NgayBan) as Ngay, SUM(tChiTietHDB.SLBan * tSach.DonGiaBan) as DoanhThu
from tHoaDonBan
join tChiTietHDB
on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
join tSach
on tSach.MaSach = tChiTietHDB.MaSach
group by rollup(YEAR(tHoaDonBan.NgayBan), MONTH(tHoaDonBan.NgayBan), DAY(tHoaDonBan.NgayBan));

select * from v_B7;

drop view v_B7;

--8.Tạo view đưa ra danh sách 3 khách hàng có tiền tiêu dùng cao nhất
create view v_B8 as
select top 3 * 
from tKhachHang
join(
	select tKhachHang.MaKH, SUM(tChiTietHDB.SLBan * tSach.DonGiaBan) as TienTieuDung
	from tKhachHang
	join tHoaDonBan
	on tKhachHang.MaKH = tHoaDonBan.MaKH
	join tChiTietHDB
	on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	join tSach
	on tSach.MaSach = tChiTietHDB.MaSach
	group by tKhachHang.MaKH
) tTieuDung
on tKhachHang.MaKH = tTieuDung.MaKH
order by tTieuDung.TienTieuDung DESC;

select * from v_B8;

drop view v_B8;

--9.Tạo view đưa ra 10 đầu sách được tiêu thụ nhiều nhất trong năm 2022 và số lượng tiêu thụ
--mỗi đầu sách.
create view v_B9 as
select top 3 *
from tSach
join
(
	select tSach.MaSach, SUM(tChiTietHDB.SLBan) as SoLuongTieuThu
	from tSach
	join tChiTietHDB
	on tSach.MaSach = tChiTietHDB.MaSach
	join tHoaDonBan
	on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	where YEAR(tHoaDonBan.NgayBan) = 2022
	group by tSach.MaSach
) tSoLuong
on tSach.MaSach = tSoLuong.MaSach
order by tSoLuong.SoLuongTieuThu;

select * from v_B9;

drop view v_B9;
--10.Tạo view SachGD đưa ra danh sách các sách với các thông tin MaSach,TenSach, tên
--thể loại, tổng số lượng nhập, tổng số lượng bán, số lượng tồn do Nhà xuất bản Giáo Dục
--xuất bản.
create view SachGD as
select tSach.MaSach, tSach.TenSach, tTongNhap.SoLuong as SoLuongNhap, tTongBan.SoLuong as SoLuongBan, (tTongNhap.SoLuong - tTongBan.SoLuong) as ChenhLech
from tSach
join tNhaXuatBan
on tSach.MaNXB = tNhaXuatBan.MaNXB and tNhaXuatBan.TenNXB =	N'NXB Giáo Dục'
left join (
	select tSach.MaSach, SUM(tChiTietHDB.SLBan) as SoLuong
	from tSach
	join tChiTietHDB
	on tSach.MaSach = tChiTietHDB.MaSach
	join tNhaXuatBan
	on tSach.MaNXB = tNhaXuatBan.MaNXB and tNhaXuatBan.TenNXB = N'NXB Giáo Dục'
	group by tSach.MaSach
) tTongBan
on tTongBan.MaSach = tSach.MaSach
left join (
	select tSach.MaSach, SUM(tChiTietHDN.SLNhap) as SoLuong
	from tSach
	join tChiTietHDN
	on tSach.MaSach = tChiTietHDN.MaSach
	join tNhaXuatBan
	on tSach.MaNXB = tNhaXuatBan.MaNXB and tNhaXuatBan.TenNXB = N'NXB Giáo Dục'
	group by tSach.MaSach
) tTongNhap
on tTongNhap.MaSach = tSach.MaSach

select * from SachGD

drop view SachGD

--11.Tạo view KhachVip đưa ra khách hàng gồm thông tin MaKH, TenKH, địa chỉ, điện
--thoại cho những khách hàng đã mua hàng với tổng tất cả các trị giá hóa đơn trong năm
--hiện tại lớn hơn 30.000.000
create view KhachVip as
select tKhachHang.MaKH, tKhachHang.TenKH, tKhachHang.DiaChi, tKhachHang.DienThoai
from tKhachHang
join (
	select tKhachHang.MaKH, SUM(tChiTietHDB.SLBan * tSach.DonGiaBan) as TieuDung
	from tKhachHang
	join tHoaDonBan
	on tKhachHang.MaKH = tHoaDonBan.MaKH
	join tChiTietHDB
	on tChiTietHDB.SoHDB = tHoaDonBan.SoHDB
	join tSach
	on tSach.MaSach = tChiTietHDB.MaSach
	where YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE())
	group by tKhachHang.MaKH
	having SUM(tChiTietHDB.SLBan * tSach.DonGiaBan) > 30000000
) tTieuDung
on tKhachHang.MaKH = tTieuDung.MaKH

select * from KhachVip

drop view KhachVip

--12.Tạo view đưa ra số hóa đơn, trị giá các hóa đơn và tổng toàn bộ trị giá của các hoa đơn
--do nhân viên có tên “Trần Huy” lập trong tháng hiện tại
create view v_B12_1 as
select tHoaDonBan.SoHDB as SoHD, SUM(tSach.DonGiaBan * tChiTietHDB.SLBan) as TriGia
from tHoaDonBan
join tChiTietHDB
on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
join tSach
on tSach.MaSach = tChiTietHDB.MaSach
join tNhanVien
on tNhanVien.MaNV = tHoaDonBan.MaNV and tNhanVien.TenNV = N'Trần Huy'
where YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE()) and MONTH(tHoaDonBan.NgayBan) = MONTH(GETDATE())
group by tHoaDonBan.SoHDB
union all
select tHoaDonNhap.SoHDN as SoHD, SUM(tSach.DonGiaNhap * tChiTietHDN.SLNhap) as TriGia
from tHoaDonNhap
join tChiTietHDN
on tHoaDonNhap.SoHDN = tChiTietHDN.SoHDN
join tSach
on tSach.MaSach = tChiTietHDN.MaSach
join tNhanVien
on tNhanVien.MaNV = tHoaDonNhap.MaNV and tNhanVien.TenNV = N'Trần Huy'
where YEAR(tHoaDonNhap.NgayNhap) = YEAR(GETDATE())  and MONTH(tHoaDonNhap.NgayNhap) = MONTH(GETDATE())
group by tHoaDonNhap.SoHDN

create view v_B12_2 as
select *
from v_B12_1
union all
select NULL as SoHD, SUM(tHoaDon.TriGia) as TriGia
from v_B12_1 tHoaDon

select * from v_B12_2

drop view v_B12_1
drop view v_B12_2

--13.Tạo view đưa thông tin các các sách còn tồn
create view v_B13 as
select *
from tSach
where SoLuong > 0

select * from v_B13

drop view v_B13

--14.Tạo view đưa ra danh sách các sách không bán được trong năm 2014.
create view v_B14 as
select tSach.*
from tSach
where MaSach not in (
	select tSach.MaSach
	from tSach
	join tChiTietHDB
	on tSach.MaSach = tChiTietHDB.MaSach
	join tHoaDonBan
	on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	where YEAR(tHoaDonBan.NgayBan) = 2014
)

select * from v_B14

drop view v_B14

--15.Tạo view đưa ra danh sách các sách của NXB Giáo Dục không bán được trong năm
--2014.
create view v_B15 as
select tSach.*
from tSach
join tNhaXuatBan
on tNhaXuatBan.MaNXB = tSach.MaNXB and tNhaXuatBan.TenNXB = N'NXB Giáo Dục' 
where MaSach not in (
	select tSach.MaSach
	from tSach
	join tChiTietHDB
	on tSach.MaSach = tChiTietHDB.MaSach
	join tHoaDonBan
	on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	where YEAR(tHoaDonBan.NgayBan) = 2014
)

select * from v_B15

drop view v_B15

--16.Tạo view đưa ra các thông tin về sách và số lượng từng sách được bán ra trong năm
--2014.
create view v_B16 as
select *
from tSach
join (
	select tSach.MaSach, SUM(tChiTietHDB.SLBan) as SLBan
	from tSach
	join tChiTietHDB
	on tSach.MaSach = tChiTietHDB.MaSach
	join tHoaDonBan
	on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	where YEAR(tHoaDonBan.NgayBan) = 2014
	group by tSach.MaSach
) tBan
on tBan.MaSach = tSach.MaSach

select * from v_B16

drop view v_B16

--17.Tạo view đưa ra họ tên khách hàng đã mua hóa đơn có trị giá cao nhất trong năm 2014.
create view v_B17 as
select top 1 tKhachHang.*
from tKhachHang
join (
	select tHoaDonBan.MaKH, SUM(tChiTietHDB.SLBan * tSach.DonGiaBan) as GiaTri
	from tChiTietHDB
	join tSach
	on tSach.MaSach = tChiTietHDB.MaSach
	join tHoaDonBan
	on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	where YEAR(tHoaDonBan.NgayBan) = 2014
	group by tHoaDonBan.MaKH
) tGiaTri
on tKhachHang.MaKH = tGiaTri.MaKH
order by tGiaTri.GiaTri DESC

select * from v_B17

drop view v_B17

--18.Tạo view đưa ra danh sách những nhân viên (MaKH, TenKH) có doanh số nằm trong 3
--doanh số cao nhất của năm hiện tại.
create view v_B18 as
select top 3 tNhanVien.MaNV, tNhanVien.TenNV
from tNhanVien
join (
	select tNhanVien.MaNV, SUM(tChiTietHDB.SLBan * tSach.DonGiaBan) as DoanhSo
	from tNhanVien
	join tHoaDonBan
	on tNhanVien.MaNV = tHoaDonBan.MaNV
	join tChiTietHDB
	on tChiTietHDB.SoHDB = tHoaDonBan.SoHDB
	join tSach
	on tSach.MaSach = tChiTietHDB.MaSach
	where YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE())
	group by tNhanVien.MaNV
) tDoanhSo
on tNhanVien.MaNV = tDoanhSo.MaNV
order by tDoanhSo.DoanhSo DESC

select * from v_B18

drop view v_B18

--19.Tạo view đưa ra danh sách sách và số lượng nhập của mỗi nhà xuất bản trong năm hiện
--tại
create view v_B19 as
select tNhaXuatBan.TenNXB, tSach.*, tNhap.SLNhap
from tNhaXuatBan
join tSach
on tNhaXuatBan.MaNXB = tSach.MaNXB
join (
	select MaSach, SUM(SLNhap) as SLNhap
	from tChiTietHDN
	join tHoaDonNhap
	on tHoaDonNhap.SoHDN = tChiTietHDN.SoHDN
	where YEAR(tHoaDonNhap.NgayNhap) = YEAR(GETDATE())
	group by MaSach
) tNhap
on tSach.MaSach = tNhap.MaSach

select * from v_B19

drop view v_B19