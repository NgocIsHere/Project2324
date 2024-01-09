USE PHONGKHAM_DB
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

CREATE OR ALTER PROCEDURE XEMLICHLAMVIECTHANG
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    -- Tạo bảng tạm thời
    CREATE TABLE #temp (NHASI CHAR(8), HOTEN NVARCHAR(50), THANG NVARCHAR(MAX), NGAYLAMVIEC NVARCHAR(MAX));

    -- Khởi tạo ngày hiện tại
    DECLARE @CurrentDate DATE = @StartDate;

    -- Lặp qua từng tháng
    WHILE @CurrentDate <= @EndDate
    BEGIN
        -- Tính ngày đầu tiên và cuối cùng của tháng hiện tại
        DECLARE @FirstDayOfMonth DATE = DATEFROMPARTS(YEAR(@CurrentDate), MONTH(@CurrentDate), 1);
        DECLARE @LastDayOfMonth DATE = EOMONTH(@CurrentDate);

        -- Thực hiện truy vấn cho tháng hiện tại và lưu kết quả vào bảng tạm thời
        INSERT INTO #temp
        SELECT a.NHASI, b.HOTEN,
            CONVERT(NVARCHAR, DATEPART(mm, a.NGAY)) + '/' + CONVERT(NVARCHAR, DATEPART(yyyy, a.NGAY)) AS THANG,
            STUFF((SELECT DISTINCT ', ' + CONVERT(NVARCHAR, DATEPART(dd, b.NGAY))
               FROM LICHLAMVIEC b
               WHERE a.NHASI = b.NHASI AND DATEPART(mm, a.NGAY) = DATEPART(mm, b.NGAY) AND DATEPART(yyyy, a.NGAY) = DATEPART(yyyy, b.NGAY)
               AND b.NGAY BETWEEN @FirstDayOfMonth AND @LastDayOfMonth
               GROUP BY DATEPART(dd, b.NGAY)
               FOR XML PATH('')), 1, 2, '') AS NGAYLAMVIEC
        FROM LICHLAMVIEC a
        JOIN NHASI b ON a.NHASI = b.ID
        WHERE a.NGAY BETWEEN @FirstDayOfMonth AND @LastDayOfMonth
        GROUP BY a.NHASI, b.HOTEN, DATEPART(mm, a.NGAY), DATEPART(yyyy, a.NGAY);

        -- Chuyển sang tháng tiếp theo
        SET @CurrentDate = DATEADD(month, 1, @CurrentDate);
    END

    -- Trả về kết quả từ bảng tạm thời
    SELECT * FROM #temp ORDER BY NHASI, THANG;

    -- Xóa bảng tạm thời
    DROP TABLE #temp;
END;
GO


CREATE OR ALTER PROCEDURE XEMLICHLAMVIECTUAN
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT a.NHASI, b.HOTEN,
           CONVERT(NVARCHAR, DATEADD(dd, -(DATEPART(dw, MIN(a.NGAY))%7), MIN(a.NGAY)), 103) 
           + ' - ' + 
           CONVERT(NVARCHAR, DATEADD(dd, 6-(DATEPART(dw, MAX(a.NGAY))%7), MAX(a.NGAY)), 103) AS TUAN,
           STUFF((
               SELECT DISTINCT ', ' + CASE DATEPART(dw, c.NGAY)
                                      WHEN 1 THEN N'Chủ Nhật'
                                      WHEN 2 THEN N'Thứ Hai'
                                      WHEN 3 THEN N'Thứ Ba'
                                      WHEN 4 THEN N'Thứ Tư'
                                      WHEN 5 THEN N'Thứ Năm'
                                      WHEN 6 THEN N'Thứ Sáu'
                                      WHEN 7 THEN N'Thứ Bảy'
                                  END
               FROM LICHLAMVIEC c
               WHERE c.NHASI = a.NHASI 
                   AND DATEPART(wk, c.NGAY) = DATEPART(wk, a.NGAY)
                   AND c.NGAY BETWEEN @StartDate AND @EndDate
               FOR XML PATH('')), 1, 2, '') AS NGAYLAMVIEC
    FROM LICHLAMVIEC a
    JOIN NHASI b ON a.NHASI = b.ID
    WHERE a.NGAY BETWEEN @StartDate AND @EndDate
    GROUP BY a.NHASI, b.HOTEN, DATEPART(wk, a.NGAY)
    ORDER BY a.NHASI, DATEPART(wk, a.NGAY);
END;
GO

CREATE OR ALTER PROCEDURE XEMLICHLAMVIECTUAN
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    -- Tạo bảng tạm thời
    CREATE TABLE #temp (NHASI CHAR(8), HOTEN NVARCHAR(50), TUAN NVARCHAR(MAX), NGAYLAMVIEC NVARCHAR(MAX));

    -- Khởi tạo ngày hiện tại
    DECLARE @CurrentDate DATE = @StartDate;

    -- Lặp qua từng tuần
    WHILE @CurrentDate <= @EndDate
    BEGIN
        -- Tính ngày đầu tiên và cuối cùng của tuần hiện tại
        DECLARE @FirstDayOfWeek DATE = DATEADD(wk, DATEDIFF(wk, 0, @CurrentDate), 0);
        DECLARE @LastDayOfWeek DATE = DATEADD(wk, DATEDIFF(wk, 0, @CurrentDate) + 1, -1);

        -- Thực hiện truy vấn cho tuần hiện tại và lưu kết quả vào bảng tạm thời
        INSERT INTO #temp
        SELECT a.NHASI, b.HOTEN,
               CONVERT(NVARCHAR, @FirstDayOfWeek, 103) 
               + ' - ' + 
               CONVERT(NVARCHAR, @LastDayOfWeek, 103) AS TUAN,
               STUFF((
                   SELECT DISTINCT ', ' + CASE DATEPART(dw, c.NGAY)
                                          WHEN 1 THEN N'Chủ Nhật'
                                          WHEN 2 THEN N'Thứ Hai'
                                          WHEN 3 THEN N'Thứ Ba'
                                          WHEN 4 THEN N'Thứ Tư'
                                          WHEN 5 THEN N'Thứ Năm'
                                          WHEN 6 THEN N'Thứ Sáu'
                                          WHEN 7 THEN N'Thứ Bảy'
                                      END
                   FROM LICHLAMVIEC c
                   WHERE c.NHASI = a.NHASI 
                       AND DATEPART(wk, c.NGAY) = DATEPART(wk, a.NGAY)
                       AND c.NGAY BETWEEN @FirstDayOfWeek AND @LastDayOfWeek
                   FOR XML PATH('')), 1, 2, '') AS NGAYLAMVIEC
        FROM LICHLAMVIEC a
        JOIN NHASI b ON a.NHASI = b.ID
        WHERE a.NGAY BETWEEN @FirstDayOfWeek AND @LastDayOfWeek
        GROUP BY a.NHASI, b.HOTEN, DATEPART(wk, a.NGAY);

        -- Chuyển sang tuần tiếp theo
        SET @CurrentDate = DATEADD(wk, 1, @CurrentDate);
    END

    -- Trả về kết quả từ bảng tạm thời
    SELECT * FROM #temp ORDER BY NHASI, TUAN;

    -- Xóa bảng tạm thời
    DROP TABLE #temp;
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













