--Cau 2
create procedure Cau_2 @maclb char(100), @sobanthang int output as
begin
	select @sobanthang = COUNT(TRANDAU_GHIBAN.GhiBanID)
	from CAULACBO
	join TRANDAU_GHIBAN
	on CAULACBO.CauLacBoID = TRANDAU_GHIBAN.CauLacBoID
	where CAULACBO.CauLacBoID = @maclb and VaoLuoiNha is null
end;

declare @sbt int;
exec Cau_2 '101', @sbt output;
print @sbt;

drop procedure Cau_2

--Cau 3
create function Cau_3(@maclb char(20)) 
returns table
as return (
	select ct.CauThuID, ct.HoVaTen, ct.ViTri, ct.QuocTich, CT.SoAo
	from CAUTHU ct
	WHERE ct.CauLacBoID = @maclb 
)

select * from Cau_3('101');

drop function Cau_3;

--Cau 4
select * from CAULACBO
alter table CAULACBO add SoTranDau int null default 0;
update CAULACBO set SoTranDau = 0;

create trigger Cau_4 on TRANDAU after insert, update, delete as
begin 
	update clb
	set clb.SoTranDau = clb.SoTranDau + ins.SoTran
	from CAULACBO clb
	join (
		select inserted.CLBNha as CLBId, COUNT(*) as SoTran
		from inserted
		group by CLBNha
		union all
		select inserted.CLBKhach as CLBId, COUNT(*) as SoTran
		from inserted
		group by CLBKhach
	) ins
	on clb.CauLacBoID = ins.CLBId
	
	update clb
	set clb.SoTranDau = clb.SoTranDau - del.SoTran
	from CAULACBO clb
	join (
		select deleted.CLBNha as CLBId, COUNT(*) as SoTran
		from deleted
		group by CLBNha
		union all
		select deleted.CLBKhach as CLBId, COUNT(*) as SoTran
		from deleted
		group by CLBKhach
	) del
	on clb.CauLacBoID = del.CLBId
end;

insert [dbo].[TRANDAU] ([TranDauID], [NgayThiDau], [CLBKhach], [CLBNha], [SanVanDongID], [Vong], [HiepPhu], [KetQua], [TrangThai], [Anh]) values (N'10000', CAST(N'2012-08-18T15:00:00.000' AS DateTime), N'101', N'102', N'STD15', 1, NULL, N'5-0', 1, N'FBmatch (1).jpg')
select * from CAULACBO;

drop trigger Cau_4;

--Cau 5
create view Cau_5
as
	select clb.CauLacBoID as MaCLB, clb.TenCLB, ct.HoVaTen as TenCauThu, svd.TenSan, td.NgayThiDau, td_gb.ThoiDiemGhiBan 
	from CAULACBO clb
	join CAUTHU ct
	on ct.CauLacBoID = clb.CauLacBoID
	join TRANDAU_GHIBAN td_gb
	on td_gb.CauThuID = ct.CauThuID
	join TRANDAU td
	on td.TranDauID = td_gb.TranDauID
	join SANVANDONG svd
	on svd.SanVanDongID = td.SanVanDongID

select * from Cau_5;

drop view Cau_5;

--Cau 6
create login PhamMinhTuan with password = '123';

use QLGiaiBongDa_PhamMinhTuan_231230946;

create user PhamMinhTuan for login PhamMinhTuan;

grant select on CAUTHU to PhamMinhTuan;

--Cau 7
select * from CAULACBO;
insert into CAULACBO values ('200', 'Manchester United', 'MUN', null, null, '', 0);

create procedure Cau_7
as
begin
	delete from CAULACBO
	where CAULACBO.CauLacBoID not in 
	(
		select CauLacBoID from CAUTHU
	)
end;

exec Cau_7;

drop procedure Cau_7;