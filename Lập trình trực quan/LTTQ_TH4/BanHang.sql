CREATE DATABASE LTTQ_BanHang;

CREATE TABLE tblMatHang
(
    MaSP    NCHAR(5)        NOT NULL PRIMARY KEY,  
    TenSP   NVARCHAR(30)    NOT NULL,            
    NgaySX  DATE            NOT NULL,        
    NgayHH  DATE            NOT NULL,      
    DonVi   NVARCHAR(10)    NOT NULL,  
    DonGia  FLOAT           NOT NULL CHECK (DonGia >= 0),
    GhiChu  NVARCHAR(200)   NULL             
);