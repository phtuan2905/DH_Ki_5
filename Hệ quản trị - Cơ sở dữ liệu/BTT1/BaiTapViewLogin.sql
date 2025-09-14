--BT1
USE BT2;
GO;
--1. Tạo View danh sách sinh viên, gồm các thông tin sau: Mã sinh viên, Họ sinh viên,
--Tên sinh viên, Học bổng.
create view B1
as
select MaSV, HoSV, TenSV, HocBong
from DSSinhVien;

select * from B1;

--2. Tạo view Liệt kê các sinh viên có học bổng từ 150,000 trở lên và sinh ở Hà Nội, gồm
--các thông tin: Họ tên sinh viên, Mã khoa, Nơi sinh, Học bổng.
create view B2
as
select HoSV + ' ' + TenSV as HoTenSV, MaKhoa, NoiSinh, HocBong
from DSSinhVien
where HocBong >= 150000 and NoiSinh like N'%Hà Nội%';

select * from B2;

--3. Tạo view liệt kê những sinh viên nam của khoa Anh văn và khoa tin học, gồm các thông
--tin: Mã sinh viên, Họ tên sinh viên, tên khoa, Phái.
create view B3
as
select MaSV, HoSV + ' ' + TenSV as HoTenSV, TenKhoa, Phai
from DSSinhVien, DMKhoa 
where Phai = 'Nam' and DSSinhVien.MaKhoa = DMKhoa.MaKhoa and (DMKhoa.TenKhoa = N'Anh văn' or DMKhoa.TenKhoa = N'Tin học');  

select * from B3;

--4. Tạo view gồm những sinh viên có tuổi từ 20 đến 25, thông tin gồm: Họ tên sinh viên,
--Tuổi, Tên khoa.
create view B4
as
select HoSV + ' ' + TenSV as HoTenSV, YEAR(Getdate()) - YEAR(NgaySinh) as Tuoi, TenKhoa
from DSSinhVien, DMKhoa
where YEAR(Getdate()) - YEAR(NgaySinh) between 20 and 25;

select * from B4;

--5. Tạo view cho biết thông tin về mức học bổng của các sinh viên, gồm: Mã sinh viên,
--Phái, Mã khoa, Mức học bổng. Trong đó, mức học bổng sẽ hiển thị là “Học bổng cao”
--nếu giá trị của field học bổng lớn hơn 500,000 và ngược lại hiển thị là “Mức trung bình”
create view B5
as
select MaSV, Phai, MaKhoa, iif(HocBong > 500000, N'Học bổng cao', N'Mức trung bình') as MucHocBong
from DSSinhVien;

select * from B5;

--6. Tạo view đưa ra thông tin những sinh viên có học bổng lớn hơn bất kỳ học bổng của
--sinh viên học khóa anh văn
create view B6
as
select * 
from DSSinhVien
where HocBong > (
	select MAX(HocBong)
	from DSSinhVien, DMKhoa
	where DSSinhVien.MaKhoa = DMKhoa.MaKhoa and TenKhoa = N'Anh văn'
);

select * from B6;

--7. Tạo view đưa ra thông tin những sinh viên đạt điểm cao nhất trong từng môn.
create view B7
as
select DSSinhVien.* 
from DSSinhVien, (
	select MaSV 
	from KetQua ,(
		select MaMH, MAX(Diem) as DiemMax
		from KetQua
		group by MaMH
	) KetQua_DiemMax
	where KetQua.MaMH = KetQua_DiemMax.MaMH and KetQua.Diem = KetQua_DiemMax.DiemMax
) DSMaSV_KetQuaMax
where DSSinhVien.MaSV = DSMaSV_KetQuaMax.MaSV;

select * from B7;

--8. Tạo view đưa ra những sinh viên chưa thi môn cơ sở dữ liệu.
create view B8
as
select * 
from DSSinhVien 
where MaSV not in (select MaSV from KetQua, DMMonHoc where KetQua.MaMH = DMMonHoc.MaMH and TenMH = N'Cơ sở dữ liệu');

select * from B8;

--9. Tạo view đưa ra thông tin những sinh viên không trượt môn nào.
create view B9
as
select * 
from DSSinhVien
where MaSV not in (select MaSV from KetQua where LanThi >= 2);

select * from B9;

--BT2
USE QLHS
GO
--1. Tạo view DSHS10A1 gồm thông tin Mã học sinh, họ tên, giới tính (là “Nữ” nếu Nu=1,
--ngược lại là “Nam”), các điểm Toán, Lý, Hóa, Văn của các học sinh lớp 10A1
create view DSHS10A1
as 
select DSHS.MAHS, HO + ' ' + TEN as HoTen, iif(NU = 1, N'Nữ', 'Nam') as GioiTinh, TOAN, LY, HOA, VAN
from DSHS, DIEM
where DSHS.MAHS = DIEM.MAHS and MALOP = '10A1';

select * from DSHS10A1;

--2. Tạo login TranThanhPhong, tạo user TranThanhPhong cho TranThanhPhong trên CSDL QLHocSinh
--Phân quyền Select trên view DSHS10A1 cho TranThanhPhong
--Đăng nhập TranThanhPhong để kiểm tra
--Tạo login PhamVanNam, tạo PhamVanNam cho PhamVanNam trên CSDL QLHocSinh
--Đăng nhập PhamVanNam để kiểm tra
--Tạo view DSHS10A2 tương tự như câu 1
--Phân quyền Select trên view DSHS10A2 cho PhamVanNam
--Đăng nhập PhamVanNam để kiểm tra
create login TranThanhPhong with password = '123', default_database = QLHS;
create user TranThanhPhong for login TranThanhPhong;

grant select on DSHS10A1 to TranThanhPhong;

--Đăng nhập Login TranThanhPhong và kiểm tra
select * from DSHS10A1;

create login PhamVanNam with password = '123', default_database = QLHS;
create user PhamVanNam for login PhamVanNam;

create view DSHS10A2
as 
select DSHS.MAHS, HO + ' ' + TEN as HoTen, iif(NU = 1, N'Nữ', 'Nam') as GioiTinh, TOAN, LY, HOA, VAN
from DSHS, DIEM
where DSHS.MAHS = DIEM.MAHS and MALOP = '10A2';

grant select on DSHS10A2 to PhamVanNam;

--Đăng nhập Login PhamVanNam và kiểm tra
select * from DSHS10A2;

--3. Tạo view báo cáo Kết thúc năm học gồm các thông tin: Mã học sinh, Họ và tên, Ngày sinh,
--Giới tính, Điểm Toán, Lý, Hóa, Văn, Điểm Trung bình, Xếp loại, Sắp xếp theo xếp loại (chọn
--1000 bản ghi đầu). Trong đó:
--Điểm trung bình (DTB) = ((Toán + Văn)*2 + Lý + Hóa)/6)
--Cách thức xếp loại như sau:
--- Xét điểm thấp nhất (DTN) của các 4 môn
--- Nếu DTB>5 và DTN>4 là “Lên Lớp”, ngược lại là lưu ban
create view BaoCao
as
select top 1000
DSHS.MAHS, HO + ' ' + TEN as HOTEN, NGAYSINH, iif(NU = 1, N'Nữ', 'Nam') as GIOITINH, TOAN, LY, HOA, VAN, ((TOAN + VAN) * 2 + LY + HOA) / 6 as DTB, iif(((TOAN + VAN) * 2 + LY + HOA) / 6 > 5 and TOAN > 4 and LY > 4 and HOA > 4 and VAN > 4, N'Lên lớp', 'Lưu ban') as XEPLOAI
from DSHS, DIEM
where DSHS.MAHS = DIEM.MAHS
order by XEPLOAI;

select * from BaoCao;

--4. Tạo view danh sách HOC SINH XUAT SAC bao gồm các học sinh có DTB>=8.5 và
--DTN>=8 với các trường: Lop, Mahs, Hoten, Namsinh (năm sinh), Nu, Toan, Ly, Hoa, Van,
--DTN, DTB
create view HocSinhXuatSac 
as
select MALOP, DSHS.MAHS, HO + ' ' + TEN as HOTEN, YEAR(NGAYSINH) as NAMSINH, NU, TOAN, LY, HOA, VAN,
	CASE 
        WHEN TOAN <= VAN AND TOAN <= LY AND TOAN <= HOA THEN TOAN
        WHEN VAN <= TOAN AND VAN <= LY AND VAN <= HOA THEN VAN
        WHEN LY <= TOAN AND LY <= VAN AND LY <= HOA THEN LY
        ELSE HOA
    END AS DTN,
	((TOAN + VAN) * 2 + LY + HOA) / 6 as DTB
from DSHS, DIEM
where 
	DSHS.MAHS = DIEM.MAHS 
	and CASE 
        WHEN TOAN <= VAN AND TOAN <= LY AND TOAN <= HOA THEN TOAN
        WHEN VAN <= TOAN AND VAN <= LY AND VAN <= HOA THEN VAN
        WHEN LY <= TOAN AND LY <= VAN AND LY <= HOA THEN LY
        ELSE HOA
    END >= 8 
	and ((TOAN + VAN) * 2 + LY + HOA) / 6 >= 8.5;

select * from HocSinhXuatSac;

--5. Tạo view danh sách HOC SINH DAT THU KHOA KY THI bao gồm các học sinh xuất
--sắc có DTB lớn nhất với các trường: Lop, Mahs, Hoten, Namsinh, Nu, Toan, Ly, Hoa, Van,
--DTB
create view HocSinhDatThuKhoaKyThi
as
select MALOP as Lop, DSHS.MAHS as Mahs, HO + ' ' + TEN as Hoten, YEAR(NGAYSINH) as Namsinh, NU as Nu, TOAN as Toan, LY as Ly, HOA as Hoa, VAN as Van, ((TOAN + VAN) * 2 + LY + HOA) / 6 as DTB
from DSHS, DIEM
where DSHS.MAHS = DIEM.MAHS and ((TOAN + VAN) * 2 + LY + HOA) / 6 = (select MAX(((TOAN + VAN) * 2 + LY + HOA) / 6) as DTB from DIEM)

select * from HocSinhDatThuKhoaKyThi

--BT3
use BT2
go
--1. Tạo login Login1, tạo User1 cho Login1.
create login Login1 with password = '', default_database = BT2;
create user User1 for login Login1;

--2. Phân quyền Select trên bảng DSSinhVien cho User1.
grant select on DSSinhVien to User1;

--3. Đăng nhập để kiểm tra.
select * from DSSinhVien;

--4. Tạo login Login2, tạo User2 cho Login2.
create login Login2 with password = '';
create user User2 for login Login2;

--5. Phân quyền Update trên bảng DSSinhVien cho User2, người này có thể cho phép người khác sử dụng quyền này.
grant update on DSSinhVien to User2 with grant option;

--6. Đăng nhập dưới Login2 và trao quyền Update trên bảng DSSinhVien cho User 1.
grant update on DSSinhVien to User1;

--7. Đăng nhập Login 1 để kiểm tra.
update DSSinhVien set Phai = N'Nữ' where MaSV = 'A01';

select * from DSSinhVien where MaSV = 'A01';
