--BT1
--1. Tạo hàm có đầu vào là lộ trình, đầu ra là số xe, mã trọng tải, số lượng vận tải, ngày đi, ngày
--đến (SoXe, MaTrongTai, SoLuongVT, NgayDi, NgayDen.)
create function B1 (@malt nvarchar(255)) 
returns table
as
	return (
		select SoXe, MaTrongTai, SoLuongVT, NgayDi, NgayDen
		from ChiTietVanTai
		where MaLoTrinh = @malt
	);

select * from B1('PK');
--2. Thiết lập hàm có đầu vào là số xe, đầu ra là thông tin về lộ trình
create function B2 (@soxe nvarchar(255))
returns table
as
	return (
		select LoTrinh.* 
		from LoTrinh, ChiTietVanTai
		where ChiTietVanTai.SoXe = @soxe and LoTrinh.MaLoTrinh = ChiTietVanTai.MaLoTrinh
	);

select * from B2('333');
--3.Tạo hàm có đầu vào là trọng tải, đầu ra là các số xe có trọng tải quy định lớn hơn hoặc bằng
--trọng tải đó
create function B3 (@matt nvarchar(255))
returns table as
	return (
		select ChiTietVanTai.SoXe
		from ChiTietVanTai, TrongTai
		where @matt = TrongTai.MaTrongTai and @matt = ChiTietVanTai.MaTrongTai and TrongTai.TrongTaiQD >= ChiTietVanTai.SoLuongVT
	);

select * from B3('50');
--4. Tạo hàm có đầu vào là trọng tải và mã lộ trình, đầu ra là số lượng xe có trọng tải quy định
--lớn hơn hoặc bằng trọng tải đó và thuộc lộ trình đó.
create function B4 (@matt nvarchar(255), @malt nvarchar(255))
returns table as
	return (
		select COUNT(SoXe) as SoLuongXe
		from ChiTietVanTai, TrongTai
		where @matt = TrongTai.MaTrongTai and @matt = ChiTietVanTai.MaTrongTai and TrongTai.TrongTaiQD >= ChiTietVanTai.SoLuongVT
			and @malt = ChiTietVanTai.MaLoTrinh
	);

select * from B4('50', 'HN');
--5. Tạo thủ tục có đầu vào Mã lộ trình đầu ra là số lượng xe thuộc lộ trình đó.
create procedure B5 @malt nvarchar(255), @soluongxe int output
as 
	begin
		select @soluongxe = COUNT(SoXe) 
		from ChiTietVanTai
		where @malt = ChiTietVanTai.MaLoTrinh
	end;

declare @slx int;
exec B5 'HN', @slx output;
print @slx;
--6. Tạo thủ tục có đầu vào là mã lộ trình, năm vận tải, đầu ra là số tiền theo mã lộ trình và năm
--vận tải đó
create procedure B6 @malt nvarchar(255), @namvt int, @sotien int output
as
	begin 
		select @sotien = SUM(lt.DonGia)
		from ChiTietVanTai ctvt, LoTrinh lt
		where @malt = ctvt.MaLoTrinh
				and @malt = lt.MaLoTrinh
				and @namvt = YEAR(ctvt.NgayDi)
				and lt.ThoiGianQD >= DATEDIFF(DAY, ctvt.NgayDi, ctvt.NgayDen)
	end;

declare @st int;
exec B6 'NT', 2014, @st output;
print @st;

--7. Tạo thủ tục có đầu vào là số xe, năm vận tải, đầu ra là số tiền theo số xe và năm vận tải đó
--đó
create procedure B7 @soxe nvarchar(255), @namvt int, @sotien int output
as
begin 
	select @sotien = SUM(DonGia)
	from ChiTietVanTai ctvt, LoTrinh lt
	where @soxe = ctvt.SoXe
		and @namvt = YEAR(ctvt.NgayDi)
		and ctvt.MaLoTrinh = lt.MaLoTrinh
		and lt.ThoiGianQD >= DATEDIFF(DAY, ctvt.NgayDi, ctvt.NgayDen)
end;

declare @st int;
exec B7 '333', 2014, @st output;
print @st;

--8. Tạo thủ tục có đầu vào là mã trọng tải, đầu ra là số lượng xe vượt quá trọng tải quy định
--của mã trọng tải đó.
create procedure B8 @matt nvarchar(255), @soluongxe int output
as
begin 
	select @soluongxe = COUNT(SoXe)
	from ChiTietVanTai ctvt, TrongTai tt
	where @matt = ctvt.MaTrongTai
		and @matt = tt.MaTrongTai
		and ctvt.SoLuongVT > tt.TrongTaiQD
end;

declare @slx int;
exec B8 '50', @slx output;
print @slx;

--BT2
--1. Tạo hàm với đầu vào là năm, đầu ra là danh sách nhân viên sinh vào năm đó
select * from tNhanVien;
create function BT2_B1 (@nam int)
returns table
as 
	return (
		
	);


--2. Tạo hàm với đầu vào là số thâm niên (số năm làm việc) đầu ra là danh sách nhân viên có
--thâm niên đó
--3. Tạo hàm đầu vào là chức vụ đầu ra là những nhân viên cùng chức vụ đó
--4. Tạo hàm đưa ra thông tin về nhân viên được tăng lương của ngày hôm nay (giả sử 3 năm
--lên lương 1 lần)
--5. Tạo Hàm xây dựng bảng lương của nhân viên gồm các thông tin sau:
--- Lương = lương cơ bản * HSLuong + Phụ cấp (Giả sử lương cơ bản=1490000vnd (1.49tr))
--- BHXH: 8%*lương (bảo hiểm xã hội)
--- BHYT: 1,5% * lương (bảo hiểm y tế)
--- BHTN: 1%* lương (Bảo hiểm thất nghiệp)
--- Thuế TNCN
--Trong đó: TN= Lương - BHXH - BHYT - BHTN - 11tr (mức chịu thuế) - GTGC*4.4tr (Giảm
--trừ gia cảnh)
--- Phụ cấp: Mức độ công việc là A thì phụ cấp 10tr, mức độ B là 8tr, mức độ C là 5tr
--- Thực lĩnh: Lương – (BHXH+BHYT+BHTN + Thuế TNCN)
--6. Tạo thủ tục có đầu vào là mã phòng, đầu ra là số nhân viên của phòng đó và tên trưởng
--phòng
--7. Tạo thủ tục có đầu vào là mã phòng, tháng, năm, đầu ra là số tiền lương của phòng đó