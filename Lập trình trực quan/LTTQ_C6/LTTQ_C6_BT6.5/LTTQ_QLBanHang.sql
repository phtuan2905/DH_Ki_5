    CREATE DATABASE LTTQ_QLBanHang;
GO
USE LTTQ_QLBanHang;
GO

-- Bảng Chất Liệu
CREATE TABLE tblChatlieu (
    MaChatLieu NVARCHAR(10) PRIMARY KEY,
    TenChatLieu NVARCHAR(50) NOT NULL
);

insert into tblChatLieu values ('CL01', N'Vải');

-- Bảng Hàng
CREATE TABLE tblHang (
    MaHang NVARCHAR(10) PRIMARY KEY,
    TenHang NVARCHAR(100) NOT NULL,
    MaChatLieu NVARCHAR(10) NOT NULL,
    SoLuong INT DEFAULT 0,
    DonGiaNhap DECIMAL(18,2),
    DonGiaBan DECIMAL(18,2),
    Anh NVARCHAR(255),  
    GhiChu NVARCHAR(255),
    FOREIGN KEY (MaChatLieu) REFERENCES tblChatlieu(MaChatLieu)
);

-- Bảng Nhân Viên
CREATE TABLE tblNhanvien (
    MaNhanVien NVARCHAR(10) PRIMARY KEY,
    TenNhanVien NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(5),
    DiaChi NVARCHAR(200),
    DienThoai NVARCHAR(20),
    NgaySinh DATE
);

-- Bảng Khách Hàng
CREATE TABLE tblKhach (
    MaKhach NVARCHAR(10) PRIMARY KEY,
    TenKhach NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200),
    DienThoai NVARCHAR(20)
);

-- Bảng Hóa Đơn Bán
CREATE TABLE tblHDBan (
    MaHDBan NVARCHAR(50) PRIMARY KEY,
    MaNhanVien NVARCHAR(10) NOT NULL,
    NgayBan DATE,
    MaKhach NVARCHAR(10),
    TongTien DECIMAL(18,2),
    FOREIGN KEY (MaNhanVien) REFERENCES tblNhanvien(MaNhanVien),
    FOREIGN KEY (MaKhach) REFERENCES tblKhach(MaKhach)
);

-- Bảng Chi Tiết Hóa Đơn Bán
CREATE TABLE tblChiTietHDBan (
    MaHDBan NVARCHAR(50) NOT NULL,
    MaHang NVARCHAR(10) NOT NULL,
    SoLuong INT NOT NULL,
    DonGia DECIMAL(18,2),
    ThanhTien FLOAT,
    PRIMARY KEY (MaHDBan, MaHang),
    FOREIGN KEY (MaHDBan) REFERENCES tblHDBan(MaHDBan),
    FOREIGN KEY (MaHang) REFERENCES tblHang(MaHang)
);

ALTER TABLE tblNhanvien
ADD Passw NVARCHAR(50);

UPDATE tblNhanvien set Passw = '123' where MaNhanVien = 'NV01';

drop table tblChiTietHDBan