﻿USE PHONGKHAM_DB
GO

-- THÊM NHA SĨ
CREATE OR ALTER PROCEDURE SP_THEMNHASI 
	@HOTEN NVARCHAR(50),
	@NGAYSINH DATE,
	@DIACHI NVARCHAR(200),
	@SDT CHAR(10),
	@GIOITINH NVARCHAR(4),
	@MATKHAU CHAR(8)
AS
BEGIN
	DECLARE @NewID INT
	SELECT @NewID = COUNT(*) + 1 FROM NHASI
	DECLARE @ID VARCHAR(8)
	SET @ID = 'NS' + RIGHT('0000000' + CAST(@NewID AS VARCHAR), 6)

	PRINT(@ID)

	INSERT INTO dbo.NHASI
	(
	    ID,
	    HOTEN,
	    NGAYSINH,
	    DIACHI,
	    SDT,
	    GIOITINH,
	    MATKHAU
	)
	VALUES
	(   @ID,   
	    @HOTEN, 
	    @NGAYSINH, 
	    @DIACHI, 
	    @SDT, 
	    @GIOITINH, 
	    @MATKHAU  
	 )
	 PRINT (N'THÊM NHA SĨ MỚI THÀNH CÔNG')
	 RETURN 0
END
GO

--CẬP NHẬT NHA SĨ
CREATE OR ALTER PROCEDURE SP_CAPNHATNHASI 
	@ID VARCHAR(8),
	@HOTEN NVARCHAR(50),
	@NGAYSINH DATE,
	@DIACHI NVARCHAR(200),
	@SDT CHAR(10),
	@GIOITINH NVARCHAR(4),
	@MATKHAU CHAR(8)
AS
BEGIN
	-- Kiểm tra nha sĩ có tồn tại
	IF EXISTS (SELECT 1 FROM dbo.NHASI WHERE ID = @ID)
	BEGIN
		IF (@HOTEN = '')
		BEGIN 
			PRINT (N'TÊN NHA SĨ KHÔNG ĐƯỢC BỎ TRỐNG')
			RETURN -1
		END
		IF (@HOTEN IS NULL)
		BEGIN 
			PRINT (N'TÊN NHA SĨ KHÔNG ĐƯỢC BỎ TRỐNG')
			RETURN -1
		END

		UPDATE dbo.NHASI 
		SET HOTEN = @HOTEN, NGAYSINH = @NGAYSINH, DIACHI = @DIACHI, SDT = @SDT, GIOITINH = @GIOITINH, MATKHAU = @MATKHAU
		WHERE ID = @ID
		PRINT (N'CẬP NHẬT THÀNH CÔNG')
		RETURN 0

	END
	PRINT (N'KHÔNG TỒN TẠI NHA SĨ')
	RETURN -5
END
GO

-- XÓA NHA SĨ
CREATE OR ALTER PROCEDURE SP_XOANHASI @ID VARCHAR(8)
AS
BEGIN
	-- Nếu nha sĩ không tồn tại 
	IF NOT EXISTS (SELECT 1 FROM dbo.NHASI WHERE ID = @ID)
	BEGIN 
		PRINT (N'KHÔNG TỒN TẠI NHA SĨ')
		RETURN -1
	END

	DELETE FROM dbo.NHASI WHERE ID = @ID
	PRINT (N'XÓA NHA SĨ THÀNH CÔNG')
	RETURN 0
END
GO

-- THÊM NHÂN VIÊN
CREATE OR ALTER PROCEDURE SP_THEMNHANVIEN 
	@HOTEN NVARCHAR(50),
	@NGAYSINH DATE,
	@DIACHI NVARCHAR(200),
	@SDT CHAR(10),
	@GIOITINH NVARCHAR(4),
	@MATKHAU CHAR(8)
AS
BEGIN
	DECLARE @NewID INT
	SELECT @NewID = COUNT(*) + 1 FROM NHANVIEN
	DECLARE @ID VARCHAR(8)
	SET @ID = 'NV' + RIGHT('0000000' + CAST(@NewID AS VARCHAR), 6)

	PRINT(@ID)

	INSERT INTO dbo.NHANVIEN
	(
	    ID,
	    HOTEN,
	    NGAYSINH,
	    DIACHI,
	    SDT,
	    GIOITINH,
	    MATKHAU
	)
	VALUES
	(   @ID,   
	    @HOTEN, 
	    @NGAYSINH, 
	    @DIACHI, 
	    @SDT, 
	    @GIOITINH, 
	    @MATKHAU  
	 )
	 PRINT (N'THÊM NHÂN VIÊN MỚI THÀNH CÔNG')
	 RETURN 0
END
GO

--CẬP NHẬT NHÂN VIÊN
CREATE OR ALTER PROCEDURE SP_CAPNHATNHANVIEN 
	@ID VARCHAR(8),
	@HOTEN NVARCHAR(50),
	@NGAYSINH DATE,
	@DIACHI NVARCHAR(200),
	@SDT CHAR(10),
	@GIOITINH NVARCHAR(4),
	@MATKHAU CHAR(8)
AS
BEGIN
	-- Kiểm tra nhân viên có tồn tại
	IF EXISTS (SELECT 1 FROM dbo.NHANVIEN WHERE ID = @ID)
	BEGIN
		IF (@HOTEN = '')
		BEGIN 
			PRINT (N'TÊN NHÂN VIÊN KHÔNG ĐƯỢC BỎ TRỐNG')
			RETURN -1
		END
		IF (@HOTEN IS NULL)
		BEGIN 
			PRINT (N'TÊN NHÂN VIÊN KHÔNG ĐƯỢC BỎ TRỐNG')
			RETURN -1
		END

		UPDATE dbo.NHANVIEN 
		SET HOTEN = @HOTEN, NGAYSINH = @NGAYSINH, DIACHI = @DIACHI, SDT = @SDT, GIOITINH = @GIOITINH, MATKHAU = @MATKHAU
		WHERE ID = @ID
		PRINT (N'CẬP NHẬT THÀNH CÔNG')
		RETURN 0

	END
	PRINT (N'KHÔNG TỒN TẠI NHÂN VIÊN')
	RETURN -5
END
GO

-- XÓA NHÂN VIÊN
CREATE OR ALTER PROCEDURE SP_XOANHANVIEN @ID VARCHAR(8)
AS
BEGIN
	-- Nếu nhân viên không tồn tại 
	IF NOT EXISTS (SELECT 1 FROM dbo.NHANVIEN WHERE ID = @ID)
	BEGIN 
		PRINT (N'KHÔNG TỒN TẠI NHÂN VIÊN')
		RETURN -1
	END

	DELETE FROM dbo.NHANVIEN WHERE ID = @ID
	PRINT (N'XÓA NHÂN VIÊN THÀNH CÔNG')
	RETURN 0
END
GO

CREATE PROCEDURE XEMLICHLAMVIEC
AS
BEGIN
    DECLARE @result TABLE (NHASI CHAR(8), HOTEN NVARCHAR(50), THANG NVARCHAR(MAX), NGAYLAMVIEC NVARCHAR(MAX));
    DECLARE @NHASI CHAR(8), @HOTEN NVARCHAR(50), @THANG NVARCHAR(MAX), @NGAYLAMVIEC NVARCHAR(MAX);

    DECLARE cur CURSOR FOR
    SELECT a.NHASI, b.HOTEN,
           CONVERT(NVARCHAR, DATEPART(mm, a.NGAY)) + '/' + CONVERT(NVARCHAR, DATEPART(yyyy, a.NGAY)) AS THANG,
           STUFF((SELECT DISTINCT ', ' + CONVERT(NVARCHAR, DATEPART(dd, b.NGAY))
               FROM LICHLAMVIEC b
               WHERE a.NHASI = b.NHASI AND DATEPART(mm, a.NGAY) = DATEPART(mm, b.NGAY)
               GROUP BY DATEPART(dd, b.NGAY)
               FOR XML PATH('')), 1, 2, '') AS NGAYLAMVIEC
    FROM LICHLAMVIEC a
    JOIN NHASI b ON a.NHASI = b.ID
    GROUP BY a.NHASI, b.HOTEN, DATEPART(mm, a.NGAY), DATEPART(yyyy, a.NGAY);

    OPEN cur;

    FETCH NEXT FROM cur INTO @NHASI, @HOTEN, @THANG, @NGAYLAMVIEC;
    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT INTO @result (NHASI, HOTEN, THANG, NGAYLAMVIEC) VALUES (@NHASI, @HOTEN, @THANG, @NGAYLAMVIEC);
        FETCH NEXT FROM cur INTO @NHASI, @HOTEN, @THANG, @NGAYLAMVIEC;
    END;

    CLOSE cur;
    DEALLOCATE cur;

    SELECT * FROM @result ORDER BY NHASI, THANG;
END;
GO


CREATE PROCEDURE THEMLICHLAMVIEC
    @NHASI CHAR(8),
    @NGAY DATE,
    @THOIGIAN TIME
AS
BEGIN
    -- Kiểm tra xem nha sĩ có tồn tại trong bảng NHASI không
    IF NOT EXISTS (SELECT 1 FROM NHASI WHERE ID = @NHASI)
    BEGIN
        RAISERROR ('Nha sĩ không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra xem lịch làm việc đã tồn tại chưa
    IF EXISTS (SELECT 1 FROM LICHLAMVIEC WHERE NHASI = @NHASI AND NGAY = @NGAY AND THOIGIAN = @THOIGIAN)
    BEGIN
        RAISERROR ('Lịch làm việc đã tồn tại.', 16, 1);
        RETURN;
    END;

    -- Thêm lịch làm việc
    INSERT INTO LICHLAMVIEC (NHASI, NGAY, THOIGIAN)
    VALUES (@NHASI, @NGAY, @THOIGIAN);
END;
GO













