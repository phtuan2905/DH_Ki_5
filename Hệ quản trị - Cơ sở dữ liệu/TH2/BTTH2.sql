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
where tNhaXuatBan.TenNXB = N'NXB giáo dục' and YEAR(tHoaDonNhap.NgayNhap) = 2021;

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
--6. Tạo view đưa ra doanh thu bán hàng của từng tháng trong năm 2014, những tháng không
--có doanh thu thì ghi là 0.
--7. Tạo view đưa ra doanh thu bán hàng theo ngày, và tổng doanh thu cho mỗi tháng (dùng
--roll up)
--8.Tạo view đưa ra danh sách 3 khách hàng có tiền tiêu dùng cao nhất
--9.Tạo view đưa ra 10 đầu sách được tiêu thụ nhiều nhất trong năm 2022 và số lượng tiêu thụ
--mỗi đầu sách.
--10.Tạo view SachGD đưa ra danh sách các sách với các thông tin MaSach,TenSach, tên
--thể loại, tổng số lượng nhập, tổng số lượng bán, số lượng tồn do Nhà xuất bản Giáo Dục
--xuất bản.

--11.Tạo view KhachVip đưa ra khách hàng gồm thông tin MaKH, TenKH, địa chỉ, điện
--thoại cho những khách hàng đã mua hàng với tổng tất cả các trị giá hóa đơn trong năm
--hiện tại lớn hơn 30.000.000
--12.Tạo view đưa ra số hóa đơn, trị giá các hóa đơn và tổng toàn bộ trị giá của các hoa đơn
--do nhân viên có tên “Trần Huy” lập trong tháng hiện tại
--13.Tạo view đưa thông tin các các sách còn tồn
--14.Tạo view đưa ra danh sách các sách không bán được trong năm 2014.
--15.Tạo view đưa ra danh sách các sách của NXB Giáo Dục không bán được trong năm
--2014.
--16.Tạo view đưa ra các thông tin về sách và số lượng từng sách được bán ra trong năm
--2014.
--17.Tạo view đưa ra họ tên khách hàng đã mua hóa đơn có trị giá cao nhất trong năm 2014.
--18.Tạo view đưa ra danh sách những nhân viên (MaKH, TenKH) có doanh số nằm trong 3
--doanh số cao nhất của năm hiện tại.
--19.Tạo view đưa ra danh sách sách và số lượng nhập của mỗi nhà xuất bản trong năm hiện
--tại