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
	PHONE INT,
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
	NGAYSINH DATE,
	SUMALLTOTAL FLOAT DEFAULT 0,
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

--2 AUTO UPDATE SUM TOTAL FOR KHACHHANG
CREATE TRIGGER UPDATE_SUM_TOTAL
ON HOADON
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM INSERTED WHERE TIMEOU IS NOT NULL AND TIMEIN IS NOT NULL)
    BEGIN
        UPDATE KHACHHANG
        SET SUMALLTOTAL = SUMALLTOTAL + (
            SELECT SUM(CAST(DATEDIFF(MINUTE, TIMEIN, TIMEOU) AS FLOAT) / 60 * PRICE)
            FROM INSERTED I
            JOIN BANBIDA B ON I.MABAN = B.MABAN
            WHERE KHACHHANG.MAKH = I.MAKH
        )
        FROM KHACHHANG
        WHERE MAKH IN (SELECT DISTINCT MAKH FROM INSERTED);
    END
END;			
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
--2 SHOW FULL KHACHHANG THEO TINHTRANG

CREATE PROC SHOW_KHACHHANG_CHITIET
    @TYPE CHAR(1)
AS 
BEGIN
    SELECT KH.MAKH, KH.TENKH, KH.NGAYSINH, HD.MABAN, KH.SUMALLTOTAL, HD.TIMEOU
    FROM KHACHHANG KH
    INNER JOIN HOADON HD ON KH.MAKH = HD.MAKH 
    INNER JOIN BANBIDA BD ON HD.MABAN = BD.MABAN
    WHERE (@TYPE = '0' AND HD.TIMEOU IS NULL)
       OR (@TYPE = '1' AND HD.TIMEOU IS NOT NULL)
       OR (@TYPE = '2');
END
GO

--EXEC 	SHOW_KHACHHANG_CHITIET '2'

--3 XOA NHAN VIEN

CREATE PROC XOA_NHANVIEN @MANV VARCHAR(15)
AS
BEGIN
	DELETE FROM TAIKHOAN WHERE MADANGNHAP LIKE @MANV; 
	DELETE FROM PHUCVU WHERE MANV LIKE @MANV;
	DELETE FROM NHANVIEN WHERE MANV LIKE @MANV;
END
GO

--EXEC XOA_NHANVIEN 'NV002'

--FUNCTION
--1. SHOW HD THEO TENKH

CREATE FUNCTION SHOWHD_THEOTENKH_CTHOADON(@TENKH NVARCHAR(50))
RETURNS TABLE
AS
RETURN (
	SELECT CT.ID, CT.COUNT, CT.MAHD, CT.MABAN, BD.PRICE, HD.MAKH, KH.TENKH, KH.NGAYSINH, HD.TIMEIN, HD.TIMEOU, BD.TRANGTHAI 
	FROM KHACHHANG KH
	INNER JOIN HOADON HD ON HD.MAKH = KH.MAKH
	INNER JOIN CTHOADON CT ON HD.MAHD = CT.MAHD
	INNER JOIN BANBIDA BD ON BD.MABAN = HD.MABAN
	WHERE KH.TENKH LIKE '%' + @TENKH + '%' AND HD.TIMEOU IS NULL
);
GO

--2. Show NV theo ID

CREATE FUNCTION SHOWNV_THEOID(@ID VARCHAR(3))
RETURNS TABLE
AS
RETURN (
	SELECT NV.MANV, NV.HOTEN, NV.CHUCVU, NV.NGAYSINH, PV.MABAN FROM NHANVIEN NV INNER JOIN PHUCVU PV ON NV.MANV = PV.MANV WHERE NV.MANV LIKE '%' + @ID + '%'  
);
GO



-- INSERT VALUES
INSERT INTO TAIKHOAN
VALUES ('AD', 'ADMIN', 'ADMIN');

INSERT INTO BANBIDA
VALUES 
	('BAN1', 0, 1000),
	('BAN2', 0, 1000),
	('BAN3', 0, 10000),
	('BAN4', 0, 10000),
	('BAN5', 0, 1000),
	('BAN6', 0, 1000),
	('BAN7', 0, 10000),
	('BAN8', 0, 10000),
	('BAN9', 0, 10000),
	('BAN10', 0, 10000),
	('BAN11', 0, 1000),
	('BAN12', 0, 1000),
	('BAN2.1', 0, 10000),
	('BAN2.2', 0, 10000),
	('BAN2.3', 0, 10000),
	('BAN2.4', 0, 10000),
	('BAN2.5', 0, 10000),
	('BAN2.6', 0, 10000),
	('BAN2.7', 0, 10000),
	('BAN2.8', 0, 10000),
	('BAN2.9', 0, 10000),
	('BAN2.VIP', 0, 500000);
GO


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
GO

INSERT INTO KHACHHANG (MAKH, TENKH, NGAYSINH)
VALUES
	('KH001', N'Nguyễn Văn Khách', '1990-01-15'),
    ('KH002', N'Trần Thị Khách', '1987-05-02'),
    ('KH003', N'Lê Minh Khách', '1995-12-10'),
    ('KH004', N'Phạm Thanh Khách', '1982-03-25'),
    ('KH005', N'Hoàng Xuân Khách', '1998-07-18'),
    ('KH006', N'Đỗ Hữu Khách', '1993-09-30'),
    ('KH007', N'Nguyễn Thị Khách', '2000-11-08'),
    ('KH008', N'Vũ Quang Khách', '1979-06-14'),
    ('KH009', N'Trần Văn Khách', '1986-04-29'),
    ('KH010', N'Hoàng Thị Khách', '1991-08-07'),
    ('KH011', N'Nguyễn Văn Khách 2', '1992-03-18'),
    ('KH012', N'Trần Thị Khách 2', '1985-09-10'),
    ('KH013', N'Lê Minh Khách 2', '1997-06-25'),
    ('KH014', N'Phạm Thanh Khách 2', '1980-11-07'),
    ('KH015', N'Hoàng Xuân Khách 2', '1995-04-30'),
    ('KH016', N'Đỗ Hữu Khách 2', '1991-08-21'),
    ('KH017', N'Nguyễn Thị Khách 2', '1988-12-15'),
    ('KH018', N'Vũ Quang Khách 2', '1977-02-05'),
    ('KH019', N'Trần Văn Khách 2', '1983-10-12'),
    ('KH020', N'Hoàng Thị Khách 2', '1996-07-28'),
    ('KH021', N'Nguyễn Văn Khách 3', '1994-01-23'),
    ('KH022', N'Trần Thị Khách 3', '1989-05-16'),
    ('KH023', N'Lê Minh Khách 3', '2001-09-11'),
    ('KH024', N'Phạm Thanh Khách 3', '1984-11-04'),
    ('KH025', N'Hoàng Xuân Khách 3', '1999-03-17'),
    ('KH026', N'Đỗ Hữu Khách 3', '1990-12-20'),
    ('KH027', N'Nguyễn Thị Khách 3', '1993-08-03'),
    ('KH028', N'Vũ Quang Khách 3', '1981-06-08'),
    ('KH029', N'Trần Văn Khách 3', '1987-04-13'),
    ('KH030', N'Hoàng Thị Khách 3', '1992-02-26'),
    ('KH031', N'Nguyễn Văn Khách 4', '1995-07-09'),
    ('KH032', N'Trần Thị Khách 4', '1986-10-22'),
    ('KH033', N'Lê Minh Khách 4', '2000-04-14'),
    ('KH034', N'Phạm Thanh Khách 4', '1989-01-02'),
    ('KH035', N'Hoàng Xuân Khách 4', '1994-06-28'),
    ('KH036', N'Đỗ Hữu Khách 4', '1997-09-15'),
    ('KH037', N'Nguyễn Thị Khách 4', '1988-03-01'),
    ('KH038', N'Vũ Quang Khách 4', '1980-12-10'),
    ('KH039', N'Trần Văn Khách 4', '1983-05-18'),
    ('KH040', N'Hoàng Thị Khách 4', '1991-08-07');
GO

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
    ('HD010', 'BAN10', 'KH010', '2023-08-20 17:15', '2023-08-20 21:30'),
	('HD011', 'BAN1', 'KH011', '2023-08-20 10:30', '2023-08-20 12:45'),
    ('HD012', 'BAN3', 'KH012', '2023-08-20 11:15', '2023-08-20 13:30'),
    ('HD013', 'BAN2', 'KH013', '2023-08-20 12:00', '2023-08-20 14:15'),
    ('HD014', 'BAN5', 'KH014', '2023-08-20 12:45', '2023-08-20 15:00'),
    ('HD015', 'BAN4', 'KH015', '2023-08-20 13:30', '2023-08-20 16:45'),
    ('HD016', 'BAN6', 'KH016', '2023-08-20 14:15', '2023-08-20 17:30'),
    ('HD017', 'BAN7', 'KH017', '2023-08-20 15:00', '2023-08-20 18:15'),
    ('HD018', 'BAN9', 'KH018', '2023-08-20 15:45', '2023-08-20 19:00'),
    ('HD019', 'BAN8', 'KH019', '2023-08-20 16:30', '2023-08-20 20:45'),
    ('HD020', 'BAN10', 'KH020', '2023-08-20 17:15', '2023-08-20 21:30'),
    -- Add more HOADON records here
    ('HD021', 'BAN2', 'KH021', '2023-08-21 09:00', NULL),
    ('HD022', 'BAN4', 'KH022', '2023-08-21 10:15', NULL),
    ('HD023', 'BAN6', 'KH023', '2023-08-21 11:30', NULL),
    ('HD024', 'BAN8', 'KH024', '2023-08-21 12:45', NULL),
    ('HD025', 'BAN10', 'KH025', '2023-08-21 14:00', NULL),
    ('HD026', 'BAN2', 'KH026', '2023-08-21 15:15', NULL),
    ('HD027', 'BAN4', 'KH027', '2023-08-21 16:30', NULL),
    ('HD028', 'BAN6', 'KH028', '2023-08-21 17:45', NULL),
    ('HD029', 'BAN8', 'KH029', '2023-08-21 19:00', NULL),
    ('HD030', 'BAN10', 'KH030', '2023-08-21 20:15', NULL);
GO

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
    ('HD010', 'BAN10', 2),
	('HD011', 'BAN1', 3),
    ('HD012', 'BAN3', 2),
    ('HD013', 'BAN2', 4),
    ('HD014', 'BAN5', 5),
    ('HD015', 'BAN4', 2),
    ('HD016', 'BAN6', 6),
    ('HD017', 'BAN7', 3),
    ('HD018', 'BAN9', 4),
    ('HD019', 'BAN8', 1),
    ('HD020', 'BAN10', 2),
    -- Add more CTHOADON records here
    ('HD021', 'BAN2', 4),
    ('HD022', 'BAN4', 3),
    ('HD023', 'BAN6', 5),
    ('HD024', 'BAN8', 2),
    ('HD025', 'BAN10', 3),
    ('HD026', 'BAN2', 6),
    ('HD027', 'BAN4', 4),
    ('HD028', 'BAN6', 3),
    ('HD029', 'BAN8', 2),
    ('HD030', 'BAN10', 5);
GO

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
GO
