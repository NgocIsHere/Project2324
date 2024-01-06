﻿USE MASTER
USE PHONGKHAM_DB2
GO

CREATE OR ALTER PROCEDURE SP_LAYTENVAIDNHASI
	@NGAYHEN DATE
AS
BEGIN
	
	BEGIN 
		SELECT NS.HOTEN, NS.ID
		FROM NHASI NS JOIN LICHLAMVIEC LLV ON LLV.NHASI = NS.ID
		WHERE LLV.NGAY = @NGAYHEN
	END

END
GO

CREATE OR ALTER PROCEDURE SP_TIMNHASIMACDINH
	@BENHNHAN INT
AS
BEGIN
	SELECT TOP 1 NS.ID
	FROM NHASI NS JOIN CUOCHEN CH ON NS.ID = CH.NHASI
	WHERE @BENHNHAN = CH.BENHNHAN
	ORDER BY CH.NGAYHEN DESC
END
GO


CREATE OR ALTER PROCEDURE SP_XEMDANHSACHCUOCHEN
AS
BEGIN
	SELECT CH.ID, CH.NGAYHEN, CH.GIOHEN, BA.HOTEN, NS.HOTEN AS NHASI, CH.PHONG, CH.TRANGTHAI
	FROM CUOCHEN CH JOIN BENHAN BA ON CH.BENHNHAN = BA.ID JOIN NHASI NS ON NS.ID = CH.NHASI
END
GO


CREATE OR ALTER PROCEDURE SP_THEMCUOCHEN
	@NGAYHEN DATE, 
	@GIOHEN TIME, 
	@NHASI CHAR(8), 
	@BENHNHAN INT, 
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
	@TENBENHNHAN NVARCHAR(40)
AS
BEGIN 
	SELECT CH.ID, CH.NGAYHEN, CH.GIOHEN, BA.HOTEN, NS.HOTEN AS NHASI, NS.HOTEN AS TROKHAM, CH.PHONG, CH.TRANGTHAI
	FROM CUOCHEN CH JOIN BENHAN BA ON CH.BENHNHAN = BA.ID JOIN NHASI NS ON NS.ID = CH.NHASI
	WHERE BA.HOTEN = @TENBENHNHAN 
END 
GO

CREATE OR ALTER PROCEDURE SP_LOCUOCHENTHEOPHONGKHAM
	@PHONG INT
AS
BEGIN 
	SELECT CH.ID, CH.NGAYHEN, CH.GIOHEN, BA.HOTEN, NS.HOTEN AS NHASI, NS.HOTEN AS TROKHAM, CH.PHONG, CH.TRANGTHAI
	FROM CUOCHEN CH JOIN BENHAN BA ON CH.BENHNHAN = BA.ID JOIN NHASI NS ON NS.ID = CH.NHASI
	WHERE CH.PHONG = @PHONG 
END 
GO

CREATE OR ALTER PROCEDURE SP_LOCCUOCHENTHEONHASI
	@TENNHASI NVARCHAR(8)
AS
BEGIN 
	SELECT CH.ID, CH.NGAYHEN, CH.GIOHEN, BA.HOTEN, NS.HOTEN AS NHASI, NS.HOTEN AS TROKHAM, CH.PHONG, CH.TRANGTHAI
	FROM CUOCHEN CH JOIN BENHAN BA ON CH.BENHNHAN = BA.ID JOIN NHASI NS ON NS.ID = CH.NHASI
	WHERE NS.HOTEN = @TENNHASI 
END 
GO



CREATE OR ALTER PROCEDURE SP_TIMBENHNHAN
	@ID INT
AS 
BEGIN
	IF EXISTS(
		SELECT 1
		FROM BENHAN 
		WHERE ID = @ID)
		BEGIN 
			SELECT HOTEN, SDT, DIACHI, EMAIL, NGAYSINH
			FROM BENHAN
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
	SELECT BA.HOTEN, CH.NGAYHEN, CH.GHICHU, CH.GIOHEN
	FROM CUOCHEN CH JOIN BENHAN BA ON CH.BENHNHAN = BA.ID
	WHERE CH.NGAYHEN = @NGAYHEN
END 
GO


CREATE OR ALTER PROCEDURE SP_THEMBENHNHAN
	@HOTEN nvarchar(50),
	@NGAYSINH date,
	@DIACHI nvarchar(200),
	@SDT char(10),
	@EMAIL VARCHAR(100)
AS
BEGIN
	INSERT INTO BENHAN (HOTEN, NGAYSINH,DIACHI,SDT,EMAIL)
	VALUES (@HOTEN, @NGAYSINH, @DIACHI, @SDT, @EMAIL)
END
GO



CREATE OR ALTER  PROCEDURE SP_TIMLICHLAMVIECGANNHATCUANHASI
	@NHASI CHAR(8)
AS
BEGIN
	SELECT TOP 1 LLV.NGAY , LLV.THOIGIAN
	FROM LICHLAMVIEC LLV join NHASI NS ON LLV.NHASI = NS.ID
	WHERE LLV.NHASI = @NHASI AND LLV.NGAY >= GETDATE()
	ORDER BY LLV.NGAY ASC
END
GO

CREATE OR ALTER PROCEDURE SP_XEMTAIKHAM
	@BENHNHAN INT
AS
BEGIN
	SELECT CH.ID, CH.NGAYHEN, CH.GHICHU
	FROM CUOCHEN CH
	WHERE CH.TRANGTHAI = 1 AND CH.BENHNHAN = @BENHNHAN
END
GO


	
--select * from LICHLAMVIEC
--INSERT INTO LICHLAMVIEC(NHASI, NGAY, THOIGIAN, TRANGTHAI) VALUES ('NS000002', '2024-01-10', '08:00:00', 1)
--EXEC dbo.SP_THEMCUOCHEN '2024-05-01', '10:30:00', 'NS000001', 1, N'CÓ TIỀN SỬ UNG THƯ', 1, 2

/*SELECT * FROM CUOCHEN
SELECT * FROM NHASI
EXEC dbo.SP_XEMDANHSACHCUOCHEN '2024-02-01'
EXEC dbo.SP_THEMCUOCHEN '2024-02-01', '09:30:00', 'NS000002', 'BN000002', N'CÓ TIỀN SỬ NGHIỆN MA TÚY', 1, 3
EXEC DBO.SP_CAPNHATCUOCHEN 1, '2024-02-01', '6:30:00', 'NS000001', 4
EXEC dbo.SP_XOACUOCHEN 2
*/

--EXEC dbo.SP_LOCUOCHENTHEOBENHNHAN 'Nguyen van A'
--EXEC dbo.SP_LOCUOCHENTHEOPHONGKHAM 3


