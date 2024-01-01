﻿
USE PHONGKHAM_DB2
GO


CREATE OR ALTER PROCEDURE SP_LAYTENVAIDNHASI
AS
BEGIN
	SELECT HOTEN, ID
	FROM NHASI
END
GO


CREATE OR ALTER PROCEDURE SP_XEMDANHSACHCUOCHEN
	@NGAYHEN DATE
AS
BEGIN
	SELECT CH.ID, CH.NGAYHEN, CH.GIOHEN, HS.HOTEN, NS.HOTEN AS NHASI, CH.PHONG, CH.TRANGTHAI
	FROM CUOCHEN CH JOIN HOSOBENHNHAN HS ON HS.ID = CH.BENHNHAN JOIN NHASI NS ON NS.ID = CH.NHASI
	WHERE CH.NGAYHEN = @NGAYHEN
END
GO




CREATE OR ALTER PROCEDURE SP_THEMCUOCHEN
	@NGAYHEN DATE, 
	@GIOHEN TIME, 
	@NHASI CHAR(8), 
	@BENHNHAN CHAR(8), 
	@GHICHU NVARCHAR(200),
	@TRANGTHAI INT, 
	@PHONG INT
AS
BEGIN 
	IF EXISTS(SELECT 1 FROM CUOCHEN WHERE NGAYHEN = @NGAYHEN AND GIOHEN = @GIOHEN AND NHASI = @NHASI ) 
		BEGIN 
			RAISERROR (N'ĐẶT HẸN TRÙNG LỊCH VỚI 1 NHA SĨ KHÁC', 16, 1); 
			RETURN;
		END
	ELSE
	BEGIN
		INSERT INTO dbo.CUOCHEN(BENHNHAN, NHASI, NGAYHEN, GIOHEN, GHICHU, TRANGTHAI, PHONG)
		VALUES(@BENHNHAN, @NHASI, @NGAYHEN, @GIOHEN, @GHICHU, @TRANGTHAI, @PHONG)
	END

END 
GO

CREATE OR ALTER PROCEDURE SP_CAPNHATCUOCHEN
	@ID INT,
	@NGAYHEN DATE, 
	@GIOHEN TIME, 
	@NHASI CHAR(8), 
	@PHONG INT
AS
BEGIN 
	IF EXISTS(SELECT 1 FROM CUOCHEN WHERE ID = @ID ) 
		BEGIN 
			IF (SELECT COUNT(ID) FROM CUOCHEN WHERE NGAYHEN = @NGAYHEN AND GIOHEN = @GIOHEN AND NHASI = @NHASI ) > 1
				BEGIN 
					RAISERROR (N'ĐẶT HẸN TRÙNG LỊCH VỚI 1 NHA SĨ KHÁC', 16, 1); 
					RETURN;
				END
			ELSE
				BEGIN
					UPDATE dbo.CUOCHEN
					SET NGAYHEN = @NGAYHEN, 
						GIOHEN = @GIOHEN, 
						NHASI = @NHASI, 
						PHONG = @PHONG
					WHERE ID = @ID
				END
		END
	ELSE
		RAISERROR (N'KHÔNG TÌM THẤY CUỘC HẸN CẦN CẬP NHẬT', 16, 1); 
END 
GO

CREATE OR ALTER PROCEDURE SP_XOACUOCHEN
	@ID INT
AS
BEGIN
	IF EXISTS(SELECT 1 FROM CUOCHEN WHERE ID = @ID ) 
		DELETE FROM dbo.CUOCHEN WHERE ID = @ID
	ELSE
		RAISERROR (N'KHÔNG TÌM THẤY CUỘC HẸN CẦN XÓA', 16, 1); 
END 
GO

CREATE OR ALTER PROCEDURE SP_LOCUOCHENTHEOBENHNHAN
	@TENBENHNHAN NVARCHAR(40),
	@NGAYHEN DATE
AS
BEGIN 
	SELECT  CH.ID, CH.NGAYHEN, CH.GIOHEN, HS.HOTEN, NS.HOTEN AS NHASI, NS.HOTEN AS TROKHAM, CH.PHONG, CH.TRANGTHAI
	FROM CUOCHEN CH JOIN BENHAN BA ON BA.ID = CH.BENHNHAN JOIN NHASI NS ON NS.ID = CH.NHASI JOIN HOSOBENHNHAN HS ON HS.ID = BA.BENHNHAN
	WHERE HS.HOTEN = @TENBENHNHAN AND CH.NGAYHEN = @NGAYHEN
END 
GO


CREATE OR ALTER PROCEDURE SP_LOCUOCHENTHEOPHONGKHAM
	@PHONG INT, 
	@NGAYHEN DATE
AS
BEGIN 
	SELECT  CH.ID, CH.NGAYHEN, CH.GIOHEN, HS.HOTEN, NS.HOTEN AS NHASI, NS.HOTEN AS TROKHAM, CH.PHONG, CH.TRANGTHAI
	FROM CUOCHEN CH JOIN BENHAN BA ON BA.ID = CH.BENHNHAN JOIN NHASI NS ON NS.ID = CH.NHASI JOIN HOSOBENHNHAN HS ON HS.ID = BA.BENHNHAN
	WHERE CH.PHONG = @PHONG AND NGAYHEN = @NGAYHEN
END 
GO

CREATE OR ALTER PROCEDURE SP_LOCCUOCHENTHEONHASI
	@TENNHASI NVARCHAR(40), 
	@NGAYHEN DATE
AS
BEGIN 
	SELECT  CH.ID, CH.NGAYHEN, CH.GIOHEN, HS.HOTEN, NS.HOTEN AS NHASI, NS.HOTEN AS TROKHAM, CH.PHONG, CH.TRANGTHAI
	FROM CUOCHEN CH JOIN BENHAN BA ON BA.ID = CH.BENHNHAN JOIN NHASI NS ON NS.ID = CH.NHASI JOIN HOSOBENHNHAN HS ON HS.ID = BA.BENHNHAN
	WHERE CH.NHASI = @TENNHASI AND NGAYHEN = @NGAYHEN
END 
GO



CREATE OR ALTER PROCEDURE SP_TIMBENHNHAN
	@ID CHAR(8)
AS 
BEGIN
	IF EXISTS(
		SELECT 1
		FROM HOSOBENHNHAN
		WHERE ID = @ID)
		BEGIN 
			SELECT HOTEN, SDT, DIACHI, EMAIL, NGAYSINH
			FROM HOSOBENHNHAN
			WHERE ID = @ID
		END 
	ELSE
		BEGIN
			RAISERROR (N'KHÔNG TÌM THẤY BỆNH NHÂN', 16, 1); 
		END

END 
GO 

CREATE OR ALTER PROCEDURE SP_XEMYEUCAUHEN
	@NGAYHEN DATE
AS
BEGIN 
	SELECT HS.HOTEN, CH.NGAYHEN, CH.GHICHU, CH.GIOHEN
	FROM CUOCHEN CH JOIN HOSOBENHNHAN HS ON CH.BENHNHAN = HS.ID
	WHERE CH.NGAYHEN = @NGAYHEN
END 
GO


EXEC SP_TIMBENHNHAN 'BN000001'


--EXEC dbo.SP_THEMCUOCHEN '2024-01-01', '10:30:00', 'NS000002', 'BN000001', N'CÓ TIỀN SỬ UNG THƯ', 1, 2

/*SELECT * FROM CUOCHEN
SELECT * FROM NHASI
EXEC dbo.SP_XEMDANHSACHCUOCHEN '2024-02-01'
EXEC dbo.SP_THEMCUOCHEN '2024-02-01', '09:30:00', 'NS000002', 'BN000002', N'CÓ TIỀN SỬ NGHIỆN MA TÚY', 1, 3
EXEC DBO.SP_CAPNHATCUOCHEN 2, '2024-02-01', '6:30:00', 'NS000001', 4
EXEC dbo.SP_XOACUOCHEN 2
*/

--EXEC dbo.SP_LOCUOCHENTHEOBENHNHAN 'Nguyen van A'
--EXEC dbo.SP_LOCUOCHENTHEOPHONGKHAM 3


