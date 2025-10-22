--De so 11
--Cau 1
--Cau 2
create procedure Cau_2 @maphong nvarchar(10), @nam int, @doanhthu float output
as 
begin
	select @doanhthu = (LOAIPHONG.Dongiaphong * tbTgianThuePhong.Thoigianthue)
	from PHONG
	join (
		select Maphong, SUM(IIF(DATEDIFF(DAY, Thoigiancheckin, Thoigiancheckout) = 0, 1, DATEDIFF(DAY, Thoigiancheckin, Thoigiancheckout))) as Thoigianthue
		from PHIEUTHUE
		where YEAR(Thoigiancheckout) = @nam and Maphong = @maphong
		group by Maphong
	) tbTgianThuePhong
	on PHONG.Maphong = tbTgianThuePhong.Maphong
	join LOAIPHONG
	on LOAIPHONG.MaLP = PHONG.MaLP
end;

declare @dt float;
exec Cau_2 'P101', 2022, @dt output;
print @dt;
drop procedure Cau_2;

--Cau 3
create function Cau_3 (@makhachhang nvarchar(20), @thang int, @nam int)
returns table
as return (
	select pt.MaPT as N'Mã phiếu thuê', pt.Maphong as N'Mã phòng', pt.MaBooking as N'Mã booking', pt.Thoigiancheckin as N'Thời gian check in', pt.Thoigiancheckout as N'Thời gian check out', lp.Kieuphong as N'Kiểu phòng', lp.Dongiaphong as N'Đơn giá phòng'
	from PHIEUTHUE pt
	join PHONG p
	on pt.Maphong = p.Maphong
	join LOAIPHONG lp
	on lp.MaLP = p.MaLP
	join PHIEUDAT pd
	on pd.MaBooking = pt.MaBooking
	where pd.MaKH = @makhachhang and MONTH(pt.Thoigiancheckin) = @thang and YEAR(pt.Thoigiancheckin) = @nam
)

select * from Cau_3('KH0006', 12, 2022);
drop function Cau_3;

--Cau 4
alter table PHIEUDAT ADD SoLuongPhongThue int default 0;

create trigger Cau_4 on PHIEUTHUE after insert, delete, update as
begin
    update pd
    set SoLuongPhongThue = SoLuongPhongThue + t.soluongthem
    from PHIEUDAT pd
    join (
        select MaBooking, count(MaBooking) as soluongthem
        from inserted
        group by MaBooking
    ) as t 
	on pd.MaBooking = t.MaBooking;

    update pd
    set SoLuongPhongThue = SoLuongPhongThue - t.soluonggiam
    from PHIEUDAT pd
    join (
        select MaBooking, count(MaBooking) as soluonggiam
        from deleted
        group by MaBooking
    ) as t 
	on pd.MaBooking = t.MaBooking;
end;

insert into PHIEUTHUE values('PT0100', 'PD0001', '2022-01-09 00:00:00.000', '2022-01-09 00:00:00.000', '2022-01-12 00:00:00.000', 0, 'P304')
select * from PHIEUDAT where MaBooking = 'PD0001';
delete from PHIEUTHUE where MaPT = 'PT0100';

drop trigger Cau_4

--Cau 5
create view Cau_5 
as
	select kh.MaKH, kh.TenKH, pd.MaBooking, pd.NgayDenDukien, pd.NgayDiDuKien, hdtt.MaHDTT, hdtt.NgayLapHD, hdtt.NgayTT, hdtt.PhuongthucTT
	from PHIEUDAT pd
	join KHACHHANG kh
	on kh.MaKH = pd.MaKH
	join HOADONTT hdtt
	on hdtt.MaBooking = pd.MaBooking
	where pd.NgayDenDukien between '2022-12-12' and '2022-12-19'

select * from Cau_5;
drop view Cau_5;

--Cau 6
create login BuiNgocTien with password = '123';

use QLKhachSan_PhamMinhTuan_231230946;

create user BuiNgocTien for login BuiNgocTien;

grant select, insert, update on LOAIPHONG to BuiNgocTien with grant option;

create login TranVanTrung with password = '123';

create user TranVanTrung for login TranVanTrung;

--Dang nhap bang BuiNgocTien 
grant select, update on LOAIPHONG to TranVanTrung;