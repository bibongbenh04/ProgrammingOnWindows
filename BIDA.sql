USE MASTER 
GO

DROP DATABASE BIDA;
GO

CREATE DATABASE BIDA;
GO

USE BIDA;
GO

CREATE TABLE NHANVIEN (
    MANV VARCHAR(15) NOT NULL,
    HOTEN NVARCHAR(50) NOT NULL,
    CHUCVU NVARCHAR(20) NOT NULL,
    NGAYSINH DATE NOT NULL,
    CONSTRAINT PK_NHANVIEN PRIMARY KEY(MANV)
);
GO

CREATE TABLE TAIKHOAN (
	LOAITK CHAR(2),
	MADANGNHAP VARCHAR(15) NOT NULL PRIMARY KEY,
	MATKHAU VARCHAR(15) NOT NULL
)
GO

CREATE TABLE KHACHHANG (
    MAKH VARCHAR(15) NOT NULL,
    TENKH NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_KHACHHANG PRIMARY KEY(MAKH)
);
GO

CREATE TABLE BANBIDA (
    MABAN VARCHAR(10) NOT NULL,
    TRANGTHAI INT DEFAULT 0,
    PRICE FLOAT DEFAULT 0,
    CONSTRAINT PK_BANBIDA PRIMARY KEY(MABAN)
);
GO

CREATE TABLE HOADON (
    MAHD VARCHAR(15) NOT NULL,
    MABAN VARCHAR(10) NOT NULL,
    MAKH VARCHAR(15) NOT NULL,
    TIMEIN DATETIME,
    TIMEOU DATETIME,
    CONSTRAINT PK_HOADON PRIMARY KEY(MAHD),
    CONSTRAINT FK_HOADON_BANBIDA FOREIGN KEY(MABAN) REFERENCES BANBIDA(MABAN),
    CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)
);
GO

CREATE TABLE CTHOADON (
    ID INT IDENTITY PRIMARY KEY,
    MAHD VARCHAR(15) NOT NULL,
    MABAN VARCHAR(10) NOT NULL,
    COUNT INT NOT NULL DEFAULT 0,
    CONSTRAINT FK_CTHOADON_HOADON FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD),
    CONSTRAINT FK_CTHOADON_BANBIDA FOREIGN KEY(MABAN) REFERENCES BANBIDA(MABAN)
);
GO

CREATE TABLE PHUCVU (
    MANV VARCHAR(15) NOT NULL,
    MABAN VARCHAR(10) NOT NULL,
    CONSTRAINT PK_PHUCVU PRIMARY KEY(MANV, MABAN),
    CONSTRAINT FK_PHUCVU_NHANVIEN FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
    CONSTRAINT FK_PHUCVU_BANBIDA FOREIGN KEY(MABAN) REFERENCES BANBIDA(MABAN)
);
GO
--TRIGGER
--1 AUTO UPDATE ACCOUNT NHANVIEN TK: MANV, MK: NGAYSINH FORMAT(DD/MM/YYYY)
CREATE TRIGGER UPDATE_TAIKHOANNV
ON NHANVIEN
AFTER INSERT, UPDATE
AS
BEGIN
	INSERT INTO TAIKHOAN
	SELECT 'NV', MANV, CONVERT(VARCHAR(10),NGAYSINH, 103) FROM INSERTED
END
GO
--PROCEDURE
--1. CHECK LOGIN ACCOUNT NHANVIEN

CREATE PROC CHECK_LOGIN_NV
 @MDN VARCHAR(15), @MK VARCHAR(15)
AS
BEGIN
	SELECT 1 AS 'TRANGTHAI' FROM TAIKHOAN WHERE LOAITK = 'NV' AND MADANGNHAP = @MDN AND MATKHAU = @MK
END
GO

--select * from TAIKHOAN
--EXEC CHECK_LOGIN_NV 'NV000', '29/10/2004'




-- INSERT VALUES
INSERT INTO TAIKHOAN
VALUES ('AD', 'ADMIN', 'ADMIN');

INSERT INTO BANBIDA
VALUES 
	('BAN1', 0, 40001),
	('BAN2', 0, 40002),
	('BAN3', 0, 40003),
	('BAN4', 0, 40004),
	('BAN5', 0, 40005),
	('BAN6', 0, 40006),
	('BAN7', 0, 40007),
	('BAN8', 0, 40008),
	('BAN9', 0, 40009),
	('BAN10', 0, 40010),
	('BAN11', 0, 40011),
	('BAN12', 0, 40012),
	('BAN2.1', 0, 50001),
	('BAN2.2', 0, 50002),
	('BAN2.3', 0, 50003),
	('BAN2.4', 0, 50004),
	('BAN2.5', 0, 50005),
	('BAN2.6', 0, 50006),
	('BAN2.7', 0, 50007),
	('BAN2.8', 0, 50008),
	('BAN2.9', 0, 50009),
	('BAN2.VIP', 0, 100000);


INSERT INTO NHANVIEN (MANV, HOTEN, CHUCVU, NGAYSINH)
VALUES
    ('NV000', N'Lê Hồng Quân', N'Nhân viên', '2004-10-29'),
    ('NV001', N'Nguyễn Văn A', N'Nhân viên', '1990-05-15'),
    ('NV002', N'Trần Thị B', N'Quản lý', '1985-09-20'),
    ('NV003', N'Lê Minh C', N'Nhân viên', '1995-02-10'),
    ('NV004', N'Phạm Thanh D', N'Nhân viên', '1992-11-28'),
    ('NV005', N'Hoàng Xuân E', N'Quản lý', '1988-07-03'),
    ('NV006', N'Đỗ Hữu F', N'Nhân viên', '1997-04-16'),
    ('NV007', N'Nguyễn Thị G', N'Nhân viên', '1993-08-11'),
    ('NV008', N'Vũ Quang H', N'Quản lý', '1983-12-09'),
    ('NV009', N'Trần Văn I', N'Nhân viên', '1991-06-22'),
    ('NV010', N'Hoàng Thị K', N'Nhân viên', '1994-03-07');

INSERT INTO KHACHHANG (MAKH, TENKH)
VALUES
    ('KH001', N'Nguyễn Văn Khách'),
    ('KH002', N'Trần Thị Khách'),
    ('KH003', N'Lê Minh Khách'),
    ('KH004', N'Phạm Thanh Khách'),
    ('KH005', N'Hoàng Xuân Khách'),
    ('KH006', N'Đỗ Hữu Khách'),
    ('KH007', N'Nguyễn Thị Khách'),
    ('KH008', N'Vũ Quang Khách'),
    ('KH009', N'Trần Văn Khách'),
    ('KH010', N'Hoàng Thị Khách');

INSERT INTO HOADON (MAHD, MABAN, MAKH, TIMEIN, TIMEOU)
VALUES
    ('HD001', 'BAN1', 'KH001', '2023-08-20 10:30', '2023-08-20 12:45'),
    ('HD002', 'BAN3', 'KH002', '2023-08-20 11:15', '2023-08-20 13:30'),
    ('HD003', 'BAN2', 'KH003', '2023-08-20 12:00', '2023-08-20 14:15'),
    ('HD004', 'BAN5', 'KH004', '2023-08-20 12:45', '2023-08-20 15:00'),
    ('HD005', 'BAN4', 'KH005', '2023-08-20 13:30', '2023-08-20 16:45'),
    ('HD006', 'BAN6', 'KH006', '2023-08-20 14:15', '2023-08-20 17:30'),
    ('HD007', 'BAN7', 'KH007', '2023-08-20 15:00', '2023-08-20 18:15'),
    ('HD008', 'BAN9', 'KH008', '2023-08-20 15:45', '2023-08-20 19:00'),
    ('HD009', 'BAN8', 'KH009', '2023-08-20 16:30', '2023-08-20 20:45'),
    ('HD010', 'BAN10', 'KH010', '2023-08-20 17:15', '2023-08-20 21:30');

INSERT INTO CTHOADON (MAHD, MABAN, COUNT)
VALUES
    ('HD001', 'BAN1', 3),
    ('HD002', 'BAN3', 2),
    ('HD003', 'BAN2', 4),
    ('HD004', 'BAN5', 5),
    ('HD005', 'BAN4', 2),
    ('HD006', 'BAN6', 6),
    ('HD007', 'BAN7', 3),
    ('HD008', 'BAN9', 4),
    ('HD009', 'BAN8', 1),
    ('HD010', 'BAN10', 2);

INSERT INTO PHUCVU (MANV, MABAN)
VALUES
    ('NV001', 'BAN1'),
    ('NV002', 'BAN2'),
    ('NV003', 'BAN3'),
    ('NV004', 'BAN4'),
    ('NV005', 'BAN5'),
    ('NV006', 'BAN6'),
    ('NV007', 'BAN7'),
    ('NV008', 'BAN8'),
    ('NV009', 'BAN9'),
    ('NV010', 'BAN10');
