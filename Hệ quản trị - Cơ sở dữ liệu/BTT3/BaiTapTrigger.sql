--BT1
--1. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update để tự động cập nhật
--điểm trung bình của học sinh khi thêm mới hay cập nhật bảng điểm
--Điểm trung bình= ((Toán +Văn)*2+Lý+Hóa)/6
create trigger B1_C1 on DIEM after insert, update as
begin
	update DIEM 
	set DIEM.DTB = ((inserted.TOAN + inserted.VAN) * 2 + inserted.LY + inserted.HOA) / 6
	from DIEM
	join inserted
	on DIEM.MAHS = inserted.MAHS
end;

update DIEM set TOAN = 9, LY = 9, HOA = 9, VAN = 9 where MAHS = '00001';
update DIEM set TOAN = 1, LY = 1, HOA = 1, VAN = 1 where MAHS = '00008';
select * from DIEM

drop trigger B1_C1
--2. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update để tự động xếp loại
--học sinh, cách thức xếp loại như sau
--- Nếu Điểm trung bình>=5 là lên lớp, ngược lại là lưu ban
create trigger B1_C2 on DIEM after insert, update as
begin
	update DIEM
	set DIEM.XEPLOAI = IIF(((inserted.TOAN + inserted.VAN) * 2 + inserted.LY + inserted.HOA) / 6 >= 5, N'Lên lớp', N'Lưu ban')
	from DIEM
	join inserted
	on DIEM.MAHS = inserted.MAHS;
end;

update DIEM set TOAN = 9, LY = 9, HOA = 9, VAN = 9 where MAHS = '00001';
update DIEM set TOAN = 1, LY = 1, HOA = 1, VAN = 1 where MAHS = '00008';
select * from DIEM

drop trigger B1_C2

--3. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update để tự động xếp loại
--học sinh, cách thức xếp loại như sau
--- Xét điểm thấp nhất (DTN) của các 4 môn
--- Nếu DTB>=5 và DTN>=4 là “Lên Lớp”, ngược lại là lưu ban
create trigger B1_C3 on DIEM after insert, update as
begin
	update DIEM
	set DIEM.XEPLOAI = IIF
	(
		((inserted.TOAN + inserted.VAN) * 2 + inserted.LY + inserted.HOA) / 6 >= 5
		and inserted.TOAN >= 4 and inserted.VAN >= 4 and inserted.LY >= 4 and inserted.HOA >= 4, 
		N'Lên lớp', N'Lưu ban'
	)
	from DIEM
	join inserted
	on DIEM.MAHS = inserted.MAHS;
end;

update DIEM set TOAN = 8, LY = 8, HOA = 8, VAN = 8 where MAHS = '00013';
update DIEM set TOAN = 2, LY = 8, HOA = 8, VAN = 8 where MAHS = '00014';
select * from DIEM

drop trigger B1_C3;

--4. Viết một trigger xóa tự động bản ghi về điểm học sinh khi xóa dữ liệu học sinh đó trong
--DSHS
create trigger B1_C4 on DSHS after delete as
begin
	delete from DIEM
	where DIEM.MAHS
	in 
	(
		select MAHS from deleted
	);
end;

delete from DSHS where MAHS = '00001' or MAHS = '00008';
select * from DIEM where MAHS = '00001' or MAHS = '00008';

drop trigger B1_C4;

--BT2
--1. Viết truy vấn tạo bảng doanh thu (tDoanhThu)
CREATE TABLE [dbo].[tDoanhThu](
	[MaDK] [nvarchar](3) NOT NULL,
	[LoaiPhong] [nvarchar](2) NULL,
	[SoNgayO] [int] NULL,
	[ThucThu] [bigint] NULL,
	PRIMARY KEY CLUSTERED ([MaDK] ASC)
) 

select * from tDoanhThu

--2. Tạo Trigger tính tiền và điền tự động vào bảng tDoanhThu như sau:
--Các trường lấy thông tin từ các bảng và các thông tin sau:
--Trong đó:
--(a) Số Ngày Ở= Ngày Ra – Ngày Vào
--(b) ThucThu: Tính theo yêu cầu sau:
--Nếu Số Ngày ở <10 Thành tiền = Đơn Giá * Số ngày ở
--Nếu 10 <=Số Ngày ở <30 Thành Tiền = Đơn Giá* Số Ngày ở * 0.95 (Giảm5%)
--Nếu Số ngày ở >= 30 Thành Tiền = Đơn Giá* Số Ngày ở * 0.9 (Giảm10%)
create trigger B2_C2 on tDangKy	for insert, update as
begin
	delete from tDoanhThu 
	where tDoanhThu.MaDK
	in 
	(
		select MaDK from deleted
	);

	insert into tDoanhThu (MaDK, LoaiPhong, SoNgayO, ThucThu)
	select ins.MaDK, ins.LoaiPhong, DATEDIFF(DAY, ins.NgayVao, ins.NgayRa) as SoNgayO,
	(case
		when DATEDIFF(DAY, ins.NgayVao, ins.NgayRa) < 10 then 1
		when DATEDIFF(DAY, ins.NgayVao, ins.NgayRa) between 10 and 30 then 0.95
		when DATEDIFF(DAY, ins.NgayVao, ins.NgayRa) >= 30 then 0.9
	end) * tlp.DonGia * DATEDIFF(DAY, ins.NgayVao, ins.NgayRa) as ThucThu
	from inserted ins 
	join tLoaiPhong tlp
	on ins.LoaiPhong = tlp.LoaiPhong
end;

update tDangKy set SoPhong = SoPhong;
select * from tDoanhThu;

drop trigger B2_C2

--3. Thêm trường DonGia vào bảng tDangKy, tạo trigger cập nhật tự động cho trường này.
alter table tDangKy add DonGia FLOAT default 0;

create trigger B2_C3 on tDangKy for insert, update as
begin
	update tdk
	set tdk.DonGia = tlp.DonGia
	from tDangKy tdk
	join inserted ins
	on ins.MaDK = tdk.MaDK
	join tLoaiPhong tlp
	on ins.LoaiPhong = tlp.LoaiPhong;
end;

update tDangKy set MaDK = MaDK;
select * from tDangKy;

drop trigger B2_C3;

--4. Thêm trường tổng tiêu dùng (TongTieuDung) và bảng khách hàng và tính tự động tổng
--tiền khách hàng đã trả cho khách sạn mỗi khi thêm, sửa, xóa bản tDangKy
alter table tKhachHang add TongTieuDung FLOAT default 0;

update tKhachHang set TongTieuDung = 0;

create trigger B2_C4 on tDangKy for insert, update, delete as
begin
	update tkh
	set tkh.TongTieuDung = tkh.TongTieuDung - tTru.TongTru
	from tKhachHang tkh
	join
	(
		select tChiTietKH.LoaiKH , SUM(tdt.ThucThu) as TongTru
		from deleted del
		join tChiTietKH
		on del.MaDK = tChiTietKH.MaDK
		join tDoanhThu tdt
		on del.MaDK = tdt.MaDK
		group by tChiTietKH.LoaiKH 
	) as tTru
	on tkh.LoaiKH = tTru.LoaiKH

	delete from tDoanhThu 
	where tDoanhThu.MaDK
	in 
	(
		select MaDK from deleted
	);

	insert into tDoanhThu (MaDK, LoaiPhong, SoNgayO, ThucThu)
	select ins.MaDK, ins.LoaiPhong, DATEDIFF(DAY, ins.NgayVao, ins.NgayRa) as SoNgayO,
	(case
		when DATEDIFF(DAY, ins.NgayVao, ins.NgayRa) < 10 then 1
		when DATEDIFF(DAY, ins.NgayVao, ins.NgayRa) between 10 and 30 then 0.95
		when DATEDIFF(DAY, ins.NgayVao, ins.NgayRa) >= 30 then 0.9
	end) * tlp.DonGia * DATEDIFF(DAY, ins.NgayVao, ins.NgayRa) as ThucThu
	from inserted ins 
	join tLoaiPhong tlp
	on ins.LoaiPhong = tlp.LoaiPhong

	update tkh
	set tkh.TongTieuDung = tkh.TongTieuDung + tCong.TongCong
	from tKhachHang tkh
	join
	(
		select tChiTietKH.LoaiKH , SUM(tdt.ThucThu) as TongCong
		from inserted ins
		join tChiTietKH
		on ins.MaDK = tChiTietKH.MaDK
		join tDoanhThu tdt
		on ins.MaDK = tdt.MaDK
		group by tChiTietKH.LoaiKH 
	) as tCong
	on tkh.LoaiKH = tCong.LoaiKH
end;

insert into tChiTietKH(MaDK, LoaiKH, Phai) values('016', '1', 1);
insert into tDangKy(MaDK, LoaiPhong, NgayVao, NgayRa) values ('016', 'A', '2025-1-1', '2025-1-3');
select * from tKhachHang;

select * from tDangKy;
select * from tChiTietKH;
select * from tDoanhThu;

delete from tDangKy where MaDK = '016' or MaDK = '017'
delete from tChiTietKH where MaDK = '016' or MaDK = '017'
delete from tDoanhThu where MaDK = '016' or MaDK = '017'

select tkh.TongTieuDung + tCong.TongCong
from tKhachHang tkh
	join
	(
		select tChiTietKH.LoaiKH , SUM(tdt.ThucThu) as TongCong
		from tDangKy ins
		join tChiTietKH
		on ins.MaDK = tChiTietKH.MaDK
		join tDoanhThu tdt
		on ins.MaDK = tdt.MaDK
		group by tChiTietKH.LoaiKH 
	) as tCong
	on tkh.LoaiKH = tCong.LoaiKH

drop trigger B2_C4;