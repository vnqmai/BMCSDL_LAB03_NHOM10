/*----------------------------------------------------------
MASV: 42.01.104.242	
HO TEN: VO NGOC QUYNH MAI
LAB: 03
NGAY: 19/3/2019
----------------------------------------------------------*/
--CAC CAU LENH TAO TABLE
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
	MANV VARCHAR(20),
	CONSTRAINT FK_LOP_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
		ON UPDATE CASCADE
		ON DELETE CASCADE
)
CREATE TABLE SINHVIEN(
	MASV NVARCHAR(20) NOT NULL PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(200),
	MALOP VARCHAR(20),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(MAX) NOT NULL,
	CONSTRAINT FK_SINHVIEN_LOP FOREIGN KEY (MALOP) REFERENCES LOP(MALOP)
		ON UPDATE CASCADE
		ON DELETE CASCADE
)

CREATE TABLE HOCPHAN(
	MAHP VARCHAR(20) NOT NULL PRIMARY KEY,
	TENHP NVARCHAR(100) NOT NULL,
	SOTC INT
)

CREATE TABLE BANGDIEM(
	MASV NVARCHAR(20) NOT NULL,
	MAHP VARCHAR(20) NOT NULL,
	DIEMTHI VARBINARY(MAX),
	CONSTRAINT PK_BANGDIEM_MASVMAHP PRIMARY KEY (MASV,MAHP),
	CONSTRAINT FK_BANGDIEM_SINHVIEN FOREIGN KEY (MASV) REFERENCES SINHVIEN(MASV)
		ON UPDATE CASCADE
		ON DELETE CASCADE,
	CONSTRAINT FK_BANGDIEM_HOCPHAN FOREIGN KEY (MAHP) REFERENCES HOCPHAN(MAHP)
		ON UPDATE CASCADE
		ON DELETE CASCADE
)
