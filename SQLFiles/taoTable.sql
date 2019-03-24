/*----------------------------------------------------------
MASV: 42.01.104.242	
HO TEN: VO NGOC QUYNH MAI
LAB: 03
NGAY: 19/3/2019
----------------------------------------------------------*/
--CAC CAU LENH TAO TABLE

CREATE TABLE SINHVIEN(
	MASV NVARCHAR(20) NOT NULL PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(200),
	MALOP VARCHAR(20),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(MAX) NOT NULL
)

CREATE TABLE NHANVIEN(
	MANV VARCHAR(20) NOT NULL PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	EMAIL VARCHAR(20),
	LUONG VARBINARY(MAX),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(MAX) NOT NULL
)

CREATE TABLE LOP(
	MALOP VARCHAR(20) NOT NULL PRIMARY KEY,
	TENLOP NVARCHAR(100) NOT NULL,
	MANV VARCHAR(20)
)