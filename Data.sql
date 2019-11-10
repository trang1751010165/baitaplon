create database QuanLiQuanTraSua
go
use QuanLiQuanTraSua
go
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaCTHD] [nchar](5) NOT NULL,
	[MaHD] [nchar](5) NULL,
	[MaSP] [nchar](5) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nchar](5) NOT NULL,
	[MaKH] [nchar](5) NULL,
	[GiaTriHD] [float] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](5) NOT NULL,
	[HoKH] [nvarchar](50) NULL,
	[TenKH] [nvarchar](30) NULL,
	[DienThoai] [nchar](11) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSP] [nchar](5) NOT NULL,
	[TenLoaiSP] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nchar](5) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[MaLoaiSP] [nchar](5) NULL,
	[DonGia] [float] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[TenHienThi] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](1000) NOT NULL CONSTRAINT [DF_TaiKhoan_MatKhau]  DEFAULT (N'Staff'),
	[ChucDanh] [nvarchar](50) NULL,
 CONSTRAINT [PK__TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[MatKhau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [DienThoai]) VALUES (N'KH001', N'Nguyễn ', N'Trí', N'015246582  ')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [DienThoai]) VALUES (N'KH002', N'Lê Thị', N'Đào', N'752787527  ')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [DienThoai]) VALUES (N'KH003', N'Trần Văn', N'Viễn', N'8372728382 ')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [DienThoai]) VALUES (N'KH004', N'Hoàng Thị', N'Dung', N'4251865425 ')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [DienThoai]) VALUES (N'KH005', N'Nguyễn Thùy ', N'Trang', N'5864752156 ')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [DienThoai]) VALUES (N'KH006', N'Nguyễn Hà', N'Ni', N'0123456458 ')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [DienThoai]) VALUES (N'KH007', N'Vũ Văn', N'Việt', N'0123456000 ')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [DienThoai]) VALUES (N'KH008', N'Võ Minh', N'Trí', N'123456789  ')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'DA2  ', N'Đồ ăn')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'TA1  ', N'Trà')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'TP3  ', N'Topping')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoaiSP], [DonGia], [SoLuong]) VALUES (N'BM   ', N'Bánh mỳ chà bông', N'DA2  ', 25000, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoaiSP], [DonGia], [SoLuong]) VALUES (N'CN   ', N'Thạch củ năng', N'TP3  ', 7000, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoaiSP], [DonGia], [SoLuong]) VALUES (N'PM   ', N'thạch phô mai', N'TP3  ', 10000, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoaiSP], [DonGia], [SoLuong]) VALUES (N'TD   ', N'Trà đào', N'TA1  ', 25000, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoaiSP], [DonGia], [SoLuong]) VALUES (N'TR   ', N'Bánh Tramisu', N'DA2  ', 30000, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoaiSP], [DonGia], [SoLuong]) VALUES (N'TT   ', N'Trân trâu trắng', N'TP3  ', 10000, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoaiSP], [DonGia], [SoLuong]) VALUES (N'TV   ', N'Trà vải', N'TA1  ', 25000, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoaiSP], [DonGia], [SoLuong]) VALUES (N'TX   ', N'Trà sữa thái xanh', N'TA1  ', 20000, 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [TenHienThi], [MatKhau], [ChucDanh]) VALUES (N'NguyenNi', N'Hà Ni', N'1', N'Staff')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [TenHienThi], [MatKhau], [ChucDanh]) VALUES (N'nguyentrang', N'Thùy Trang', N'123', N'Admin')
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
CREATE PROC [dbo].[CHANGEPASS]
@USERNAME nvarchar(50),
@PASSWORD nvarchar(100),
@NEWPASSWORD nvarchar(100)
AS 
BEGIN	
		UPDATE TaiKhoan
		SET MatKhau=@NEWPASSWORD
		WHERE TenDangNhap=@USERNAME AND MatKhau=@PASSWORD  
END


GO
CREATE PROC [dbo].[DangNhapTaiKhoan] 
			@TenDangNhap nvarchar(50)
			,@MatKhau nvarchar(1000)
AS
		select *from dbo.TaiKhoan tk 
		where tk.TenDangNhap = @TenDangNhap and tk.MatKhau = @MatKhau


GO
create proc [dbo].[XuatChiTietHDvaHD]
as
	select * from HoaDon, ChiTietHoaDon
	 where HoaDon.MaHD  = ChiTietHoaDon.MaHD


GO
