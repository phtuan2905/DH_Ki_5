--Thủ tục
--1. Tạo thủ tục có đầu vào là mã sách, đầu ra là số lượng sách đó được bán trong năm 2014
create procedure tt_B1 @masach nvarchar(10), @soluongban int output 
as
begin
	select @soluongban = SUM(tChiTietHDB.SLBan)
	from tChiTietHDB, tHoaDonBan
	where tChiTietHDB.SoHDB = tHoaDonBan.SoHDB and YEAR(tHoaDonBan.NgayBan) = 2014 and tChiTietHDB.MaSach = @masach
end;

declare @slb int;
exec tt_B1 'S01', @slb output;
print @slb;
drop procedure tt_B1;

--2. Tạo thủ tục có đầu vào là ngày, đầu ra là số lượng hóa đơn và số lượng tiền bán của sách
--trong ngày đó
create procedure tt_B2 @ngay date, @soluonghd int output, @soluongtienban float output
as
begin
	select @soluonghd = COUNT(SoHDB)
	from tHoaDonBan
	where CAST(tHoaDonBan.NgayBan as DATE) = @ngay;

	select @soluongtienban = SUM(tSach.DonGiaBan * tChiTietHDB.SLBan)
	from tSach, tChiTietHDB, tHoaDonBan
	where CAST(tHoaDonBan.NgayBan as DATE) = @ngay and tChiTietHDB.SoHDB = tHoaDonBan.SoHDB and tChiTietHDB.MaSach = tSach.MaSach;
end;

declare @slhd int, @sltb float;
exec tt_B2 '2014-08-11', @slhd output, @sltb output;
print @slhd;
print @sltb;
drop procedure tt_B2;

--3. Tạo thủ tục có đầu vào là mã nhà cung cấp, đầu ra là số đầu sách và số tiền cửa hàng đã
--nhập của nhà cung cấp đó
create procedure tt_B3 @mancc nvarchar(255), @somasach int output, @sotien float output
as 
begin
	select @somasach = COUNT(tChiTietHDN.MaSach)
	from tHoaDonNhap, tChiTietHDN
	where tHoaDonNhap.MaNCC = @mancc and tHoaDonNhap.SoHDN = tChiTietHDN.SoHDN;

	select @sotien = SUM(tSach.DonGiaNhap * tChiTietHDN.SLNhap)
	from tSach, tChiTietHDN, tHoaDonNhap
	where tHoaDonNhap.MaNCC = @mancc and tHoaDonNhap.SoHDN = tChiTietHDN.SoHDN and tChiTietHDN.MaSach = tSach.MaSach; 
end;

declare @sms int, @st float;
exec tt_B3 'NCC01', @sms output, @st output;
print @sms;
print @st;
drop procedure tt_B3;

--4.Tạo thủ tục có đầu vào là năm, đầu ra là số tiền nhập hàng, số tiền bán hàng của năm đó.
create procedure tt_B4 @nam int, @sotiennhaphang float output, @sotienbanhang float output
as 
begin
	select @sotiennhaphang = SUM(tSach.DonGiaNhap * tChiTietHDN.SLNhap)
	from tSach, tChiTietHDN, tHoaDonNhap
	where YEAR(tHoaDonNhap.NgayNhap) = @nam and tHoaDonNhap.SoHDN = tChiTietHDN.SoHDN and tChiTietHDN.MaSach = tSach.MaSach; 

	select @sotienbanhang = SUM(tSach.DonGiaBan * tChiTietHDB.SLBan)
	from tSach, tChiTietHDB, tHoaDonBan
	where YEAR(tHoaDonBan.NgayBan) = @nam and tChiTietHDB.SoHDB = tHoaDonBan.SoHDB and tChiTietHDB.MaSach = tSach.MaSach;
end;

declare @stnh float, @stbh float;
exec tt_B4 '2014', @stnh output, @stbh output;
print @stnh;
print @stbh;
drop procedure tt_B4;

--5. Tạo thủ tục có đầu vào là mã NXB, đầu ra là số lượng sách tồn của nhà xuất bản đó
create procedure tt_B5 @manxb nvarchar(255), @soluongton int output
as
begin
	select @soluongton = SUM(tSach.SoLuong)
	from tSach
	where tSach.MaNXB = @manxb;
end;

declare @mnxb nvarchar(255);
exec tt_B5 'NXB01', @mnxb output;
print @mnxb;
drop procedure tt_B5;

--6.Tạo thủ tục nhập dữ liệu cho bảng hóa đơn nhập và chi tiết hóa đơn nhập cùng lúc (sử dụng
--transaction)
create procedure tt_B6 @sohdn nvarchar(255), @manv nvarchar(255), @ngaynhap datetime, @mancc nvarchar(255), @masach nvarchar(255), @slnhap int
as 
begin
	begin TRAN
		begin TRY
			insert into tHoaDonNhap
			values (@sohdn, @manv, @ngaynhap, @mancc);

			insert into tChiTietHDN
			values (@sohdn, @masach, @slnhap, NULL);

			commit TRAN;
		end TRY
		begin CATCH
			print 'Error: ' + ERROR_MESSAGE();
			rollback TRAN;
		end CATCH
end;

exec tt_B6 'HDN100', 'NV01', '2014-08-11 00:00:00.000', 'NCC01', 'S01', 100;
select * from tChiTietHDN where SoHDN = 'HDN100';
select * from tHoaDonNhap where SoHDN = 'HDN100';
drop procedure tt_B6;

--7.Tạo thủ tục xóa đồng thời hóa đơn bán và chi tiết hóa đơn bán (dùng transaction)
create procedure tt_B7 @sohdb nvarchar(255)
as
begin
	begin TRAN
		begin TRY
			delete from tHoaDonBan
			where SoHDB = @sohdb; 
			
			delete from tChiTietHDB
			where SoHDB = @sohdb;

			commit TRAN;
		end TRY
		begin CATCH
			print 'Error: ' + ERROR_MESSAGE();
			rollback TRAN;
		end CATCH
end;

exec tt_B7 'HDB100';
select * from tHoaDonBan where SoHDB = 'HDB100';
select * from tChiTietHDB where SoHDB = 'HDB100';
drop procedure tt_B7;

--8.Tạo thủ tục có đầu vào là năm, đầu ra là số lượng sách nhập, sách bán của năm đó
create procedure tt_B8 @nam int, @soluongsachnhap int output, @soluongsachban int output
as
begin
	select @soluongsachnhap = SUM(tChiTietHDN.SLNhap)
	from tChiTietHDN, tHoaDonNhap
	where YEAR(tHoaDonNhap.NgayNhap) = @nam and tHoaDonNhap.SoHDN = tChiTietHDN.SoHDN;
	
	select @soluongsachban = SUM(tChiTietHDB.SLBan)
	from tChiTietHDB, tHoaDonBan
	where YEAR(tHoaDonBan.NgayBan) = @nam and tHoaDonBan.SoHDB = tChiTietHDB.SoHDB;
end;

declare @slsn int, @slsb int;
exec tt_B8 2014, @slsn output, @slsb output;
print @slsn;
print @slsb;
drop procedure tt_B8;

--9. Tạo thủ tục có đầu vào là mã sách, năm, đầu ra số lượng sách nhập, số lượng sách bán
--trong năm đó
create procedure tt_B9  @masach nvarchar(255), @nam int, @soluongsachnhap int output, @soluongsachban int output
as
begin
	select @soluongsachnhap = SUM(tChiTietHDN.SLNhap)
	from tChiTietHDN, tHoaDonNhap
	where YEAR(tHoaDonNhap.NgayNhap) = @nam and tHoaDonNhap.SoHDN = tChiTietHDN.SoHDN and tChiTietHDN.MaSach = @masach;
	
	select @soluongsachban = SUM(tChiTietHDB.SLBan)
	from tChiTietHDB, tHoaDonBan
	where YEAR(tHoaDonBan.NgayBan) = @nam and tHoaDonBan.SoHDB = tChiTietHDB.SoHDB and tChiTietHDB.MaSach = @masach;
end;

declare @slsn int, @slsb int;
exec tt_B9 'S01', 2014, @slsn output, @slsb output;
print @slsn;
print @slsb;
drop procedure tt_B9;

--10. Tạo thủ tục có đầu vào là mã khách hàng, năm, đầu ra là số lượng sách đã mua và số
--lượng tiền tiêu dùng của khách hàng đó trong năm nhập vào.
create procedure tt_B10 @makh nvarchar(255), @nam int, @soluongsachmua int output, @soluongtientieu float output
as
begin
	select @soluongsachmua = SUM(tChiTietHDB.SLBan)
	from tChiTietHDB, tHoaDonBan
	where YEAR(tHoaDonBan.NgayBan) = @nam and tHoaDonBan.MaKH = @makh and tHoaDonBan.SoHDB = tChiTietHDB.SoHDB;
	
	select @soluongtientieu = SUM(tChiTietHDB.SLBan * tSach.DonGiaBan)
	from tChiTietHDB, tHoaDonBan, tSach
	where YEAR(tHoaDonBan.NgayBan) = @nam and tHoaDonBan.MaKH = @makh and tHoaDonBan.SoHDB = tChiTietHDB.SoHDB and tSach.MaSach = tChiTietHDB.MaSach;
end;

declare @slsm int, @sltt float;
exec tt_B10 'KH01', 2014, @slsm output, @sltt output;
print @slsm;
print @sltt;
drop procedure tt_B10;

--11.Tạo thủ tục có đầu vào là mã khách hàng, năm, đầu ra là số lượng hóa đơn đã mua và số
--lượng tiền tiêu dùng của khách hàng đó trong năm đó.
create procedure tt_B11 @makh nvarchar(255), @nam int, @soluonghoadon int output, @soluongtientieu float output
as
begin
	select @soluonghoadon = COUNT(tHoaDonBan.SoHDB)
	from tHoaDonBan
	where YEAR(tHoaDonBan.NgayBan) = @nam and tHoaDonBan.MaKH = @makh;
	
	select @soluongtientieu = SUM(tChiTietHDB.SLBan * tSach.DonGiaBan)
	from tChiTietHDB, tHoaDonBan, tSach
	where YEAR(tHoaDonBan.NgayBan) = @nam and tHoaDonBan.MaKH = @makh and tHoaDonBan.SoHDB = tChiTietHDB.SoHDB and tSach.MaSach = tChiTietHDB.MaSach;
end;

declare @slhd int, @sltt float;
exec tt_B11 'KH01', 2014, @slhd output, @sltt output;
print @slhd;
print @sltt;
drop procedure tt_B11;

--Hàm
--1. Tạo hàm đưa ra tổng số tiền đã nhập sách trong một năm với tham số đầu vào là năm
create function h_B1 (@nam int)
returns float
as
begin
	declare @tongsotien float;

	select @tongsotien = SUM(tSach.DonGiaNhap * tChiTietHDN.SLNhap)
	from tSach
	join tChiTietHDN
	on tSach.MaSach = tChiTietHDN.MaSach
	join tHoaDonNhap
	on tChiTietHDN.SoHDN = tHoaDonNhap.SoHDN
	where YEAR(tHoaDonNhap.NgayNhap) = @nam

	return @tongsotien;
end;

declare @returnVal float;
set @returnVal = dbo.h_B1(2014);
print @returnVal;
drop function h_B1;

--2. Tạo hàm đưa ra danh sách 5 đầu sách bán chạy nhất trong tháng nào đó (tháng là tham số
--đầu vào)
create function h_B2(@thang int)
returns table
as
return (
	select top 5 tSach.* 
	from tSach
	join(
		select tChiTietHDB.MaSach, SUM(tChiTietHDB.SLBan) as SoLuongSachBan
		from tChiTietHDB
		join tHoaDonBan
		on tChiTietHDB.SoHDB = tHoaDonBan.SoHDB
		where MONTH(tHoaDonBan.NgayBan) = @thang
		group by tChiTietHDB.MaSach
	) as DsBan
	on tSach.MaSach = DsBan.MaSach
	order by SoLuongSachBan
);

select * from h_B2(1);
drop function h_B2;

--3. Tạo hàm đưa ra danh sách n nhân viên có doanh thu cao nhất trong một năm với n và năm
--là tham số đầu vào
create function h_B3(@nam int, @n int)
returns table
as
return(
	select top (@n) tNhanVien.* 
	from tNhanVien
	join (
		select tHoaDonBan.MaNV, SUM(tChiTietHDB.SLBan * tSach.DonGiaBan) as SoTienBan
		from tHoaDonBan
		join tChiTietHDB
		on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
		join tSach
		on tChiTietHDB.MaSach = tSach.MaSach
		where YEAR(tHoaDonBan.NgayBan) = @nam
		group by tHoaDonBan.MaNV
	) as DsBan
	on tNhanVien.MaNV = DsBan.MaNV
	order by SoTienBan
);

select * from h_B3(2014, 10);
drop function h_B3;

--4. Tạo hàm đưa ra thông tin Nhân viên sinh nhật trong ngày là tham số nhập vào
create function h_B4(@ngay datetime)
returns table
as
return (
	select * 
	from tNhanVien
	where tNhanVien.NgaySinh = @ngay
);

select * from h_B4('1990-09-11 00:00:00.000');
drop function h_B4;

--5. Tạo hàm đưa ra danh sách tồn trong kho quá 2 năm (nhập nhưng không bán hết trong hai
--năm)
create function h_B5()
returns table
as
return (
	select cthdn.MaSach
	from tChiTietHDN cthdn
	join tHoaDonNhap hdn
	on cthdn.SoHDN = hdn.SoHDN
	where cthdn.SLNhap > 
	(
		(
			select SUM(hdb1.SLBan) 
			from (
				select tHoaDonBan.NgayBan, tChiTietHDB.SLBan, tChiTietHDB.MaSach
				from tHoaDonBan
				join tChiTietHDB
				on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
			) as hdb1
			where cthdn.MaSach = hdb1.MaSach and YEAR(hdb1.NgayBan) = YEAR(hdn.NgayNhap) + 1
		)
		+
		(
			select SUM(hdb2.SLBan) 
			from (
				select tHoaDonBan.NgayBan, tChiTietHDB.SLBan, tChiTietHDB.MaSach
				from tHoaDonBan
				join tChiTietHDB
				on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
			) as hdb2
			where cthdn.MaSach = hdb2.MaSach and YEAR(hdb2.NgayBan) = YEAR(hdn.NgayNhap) + 2
		)
	)
);

select * from h_B5();
drop function h_B5;

--6. Tạo hàm với đầu vào là ngày, đầu ra là thông tin các hóa đơn và trị giá của hóa đơn trong
--ngày đó
create function h_B6(@ngay datetime)
returns table
as
return (
	select tHoaDonBan.*, (tChiTietHDB.SLBan * tSach.DonGiaBan) as GiaTri
	from tHoaDonBan
	join tChiTietHDB
	on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	join tSach
	on tChiTietHDB.MaSach = tSach.MaSach
	where tHoaDonBan.NgayBan = @ngay
);

select * from h_B6('2014-08-11 00:00:00.000');
drop function h_B6;

--7. Tạo hàm có đầu vào là năm đầu ra là thống kê doanh thu theo từng tháng và cả năm (dùng
--roll up)
create function h_B7(@nam int) 
returns table
as
return(
	select MONTH(tHoaDonBan.NgayBan) as Thang, SUM(tChiTietHDB.SLBan * tSach.DonGiaBan) as DoanhThu
	from tHoaDonBan
	join tChiTietHDB
	on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	join tSach
	on tSach.MaSach = tChiTietHDB.MaSach
	where YEAR(tHoaDonBan.NgayBan) = @nam
	group by rollup(MONTH(tHoaDonBan.NgayBan))
);

select * from h_B7(2014);
drop function h_B7;

--8. Tạo hàm có đầu vào là mã sách, đầu ra là số lượng tồn của sách
create function h_B8(@masach nvarchar(255))
returns int
as
begin
	declare @soluong int;
	select @soluong = SoLuong
	from tSach
	where tSach.MaSach = @masach
	return @soluong;
end;

declare @returnVal1 int;
set @returnVal1 = dbo.h_B8('S01');
print @returnVal1;
drop function h_B8;

--9. Tạo hàm có đầu vào là mã thể loại, đầu ra là thông tin sách, số lượng sách nhập, số lượng
--sách bán của mỗi sách thuộc mã loại đó
create function h_B9(@matl nvarchar(255)) 
returns table
as
return(
	select tSach.*, dssl.SoLuongNhap, dssl.SoLuongBan
	from tSach
	join (
		select tSach.MaSach, SUM(tChiTietHDN.SLNhap) as SoLuongNhap, SUM(tChiTietHDB.SLBan) as SoLuongBan
		from tSach
		join tChiTietHDN
		on tSach.MaSach = tChiTietHDN.MaSach
		join tChiTietHDB
		on tSach.MaSach = tChiTietHDB.MaSach
		where tSach.MaTheLoai = @matl
		group by tSach.MaSach
	) as dssl
	on dssl.MaSach = tSach.MaSach
);

select * from h_B9('TL01');
drop function h_B9;