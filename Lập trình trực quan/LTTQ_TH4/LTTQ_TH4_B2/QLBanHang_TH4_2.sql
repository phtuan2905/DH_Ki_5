-- Create Database
CREATE DATABASE [QLBanHang_TH4_2];
GO

-- Switch to the new database
USE [QLBanHang_TH4_2];
GO

-- Create tblUser
CREATE TABLE tblUser (
    userName NVARCHAR(50) PRIMARY KEY,  -- unique username
    passWord NVARCHAR(50) NOT NULL      -- password cannot be null
);
GO

-- Create tblHang
CREATE TABLE tblHang (
    MaHang NVARCHAR(50) PRIMARY KEY,    -- product code
    TenHang NVARCHAR(50) NOT NULL,      -- product name
    ChatLieu NVARCHAR(50),              -- material
    SoLuong INT CHECK (SoLuong >= 0),   -- quantity, must be >= 0
    DonGiaNhap FLOAT CHECK (DonGiaNhap >= 0), -- purchase price
    DonGiaBan FLOAT CHECK (DonGiaBan >= 0)    -- selling price
);
GO

INSERT INTO tblUser (userName, passWord)
VALUES (N'User Number 1', N'Password');
