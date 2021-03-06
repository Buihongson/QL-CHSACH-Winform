CREATE TRIGGER trg_ThemHang ON CTHOADON FOR INSERT
AS
	BEGIN
		DECLARE @MaSach nchar(10)
		DECLARE @SoHD nchar(10)
		DECLARE @SoLuong int
		SELECT @MaSach = MaSach , @SoHD = SoHD , @SoLuong = SoLuongMua FROM inserted
		
		-- Tính tiền cho sách vừa thêm vào
		DECLARE @Gia int
		SELECT @Gia = Gia FROM SACH WHERE MaSach = @MaSach
		UPDATE CTHOADON SET ThanhTien = (@Gia*@SoLuong) WHERE SoHD = @SoHD AND MaSach = @MaSach
		
		-- Tính tiền tổng tiền cho hóa đơn
		UPDATE HOADON SET TongTien = (TongTien + (@Gia*@SoLuong)) WHERE SoHD = @SoHD
		
		-- Cập nhập số lượng còn lại
		UPDATE SACH SET SoLuong = (SoLuong - @SoLuong) WHERE MaSach = @MaSach
	END
	
GO

CREATE TRIGGER trg_XoaHang ON CTHOADON FOR DELETE
AS
	BEGIN
		DECLARE @MaSach nchar(10)
		DECLARE @SoHD nchar(10)
		DECLARE @SoLuong int
		SELECT @MaSach = MaSach , @SoHD = SoHD , @SoLuong = SoLuongMua FROM deleted
		
		-- Tính tiền cho sách vừa xóa
		DECLARE  @Gia int
		SELECT @Gia = Gia FROM SACH WHERE MaSach = @MaSach
		
		-- Tính tổng tiền trong hóa đơn
		UPDATE HOADON SET TongTien = (TongTien - (@Gia*@SoLuong)) WHERE SoHD = @SoHD
		
		-- Cập nhập số lượng còn lại
		UPDATE SACH SET SoLuong = (SoLuong + @SoLuong)
	END 
	
INSERT INTO HOADON VALUES ('HD01', GETDATE() , 'NV01')