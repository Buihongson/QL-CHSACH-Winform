USE [master]
GO
/****** Object:  Database [QLBanSach]    Script Date: 12/09/2018 20:29:33 ******/
CREATE DATABASE [QLBanSach] ON  PRIMARY 
( NAME = N'QLBanSach', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\QLBanSach.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLBanSach_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\QLBanSach_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLBanSach] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBanSach].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBanSach] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLBanSach] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLBanSach] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLBanSach] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLBanSach] SET ARITHABORT OFF
GO
ALTER DATABASE [QLBanSach] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QLBanSach] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLBanSach] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLBanSach] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLBanSach] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLBanSach] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLBanSach] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLBanSach] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLBanSach] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLBanSach] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLBanSach] SET  DISABLE_BROKER
GO
ALTER DATABASE [QLBanSach] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLBanSach] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLBanSach] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLBanSach] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLBanSach] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLBanSach] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLBanSach] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLBanSach] SET  READ_WRITE
GO
ALTER DATABASE [QLBanSach] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLBanSach] SET  MULTI_USER
GO
ALTER DATABASE [QLBanSach] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLBanSach] SET DB_CHAINING OFF
GO
USE [QLBanSach]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [nchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nchar](15) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (N'N001      ', N'Nhà cung cấp số 1', N'Đà Nẵng', N'1234123        ')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (N'N002      ', N'Nhà cung cấp số 2', N'Hà Nội', N'1235122        ')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (N'N003      ', N'Nhà cung cấp số 3', N'Hồ Chí Minh', N'1231111        ')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (N'N004      ', N'Nhà cung cấp số 4', N'Vinh', N'2331123        ')
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[SDT] [nchar](10) NOT NULL,
	[TenKhachHang] [nchar](10) NULL,
	[SoLuongMua] [int] NULL,
	[GhiChu] [nchar](10) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUYEN]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYEN](
	[Quyen_ID] [int] IDENTITY(1,1) NOT NULL,
	[TenQuyen] [nvarchar](50) NULL,
	[MoTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_QUYEN] PRIMARY KEY CLUSTERED 
(
	[Quyen_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[QUYEN] ON
INSERT [dbo].[QUYEN] ([Quyen_ID], [TenQuyen], [MoTa]) VALUES (1, N'Quản trị', N'Quyền cao nhất')
INSERT [dbo].[QUYEN] ([Quyen_ID], [TenQuyen], [MoTa]) VALUES (2, N'Thủ kho', N'Quyền quản lý về sách và nxb, ncc, pn, px')
INSERT [dbo].[QUYEN] ([Quyen_ID], [TenQuyen], [MoTa]) VALUES (3, N'Bán hàng', N'Quyền về hóa đơn, ttkh, thống ke')
SET IDENTITY_INSERT [dbo].[QUYEN] OFF
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MaNXB] [nchar](10) NOT NULL,
	[TenNXB] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nchar](15) NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChi], [DienThoai]) VALUES (N'N003      ', N'NXB Giáo Dục', N'Hà Nội', N'123151         ')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChi], [DienThoai]) VALUES (N'X001      ', N'NXB Kim Đồng', N'Hà Nội', N'123456         ')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChi], [DienThoai]) VALUES (N'X002      ', N'NXB Trẻ', N'Hồ Chí Minh', N'123151         ')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChi], [DienThoai]) VALUES (N'X003      ', N'NXB Đại học Oxford', N'Anh', N'0123512        ')
/****** Object:  Table [dbo].[VAITRO]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VAITRO](
	[MaVT] [nchar](10) NOT NULL,
	[TenVT] [nvarchar](50) NULL,
 CONSTRAINT [PK_VAITRO] PRIMARY KEY CLUSTERED 
(
	[MaVT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[VAITRO] ([MaVT], [TenVT]) VALUES (N'1         ', N'Chủ')
INSERT [dbo].[VAITRO] ([MaVT], [TenVT]) VALUES (N'2         ', N'Nhân viên')
/****** Object:  Table [dbo].[THELOAI]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTL] [nchar](20) NOT NULL,
	[TenTL] [nvarchar](50) NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL01                ', N'Khoa học tự nhiên')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL02                ', N'Văn học')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL03                ', N'Toán học')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL04                ', N'Công nghệ thông tin')
/****** Object:  Table [dbo].[CHITIETQUYEN]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETQUYEN](
	[QuyenCT_ID] [int] IDENTITY(1,1) NOT NULL,
	[ChucNang] [nvarchar](50) NULL,
	[MaChucNang] [nchar](20) NULL,
	[Quyen_ID] [int] NOT NULL,
 CONSTRAINT [PK_CHITIETQUYEN] PRIMARY KEY CLUSTERED 
(
	[QuyenCT_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CHITIETQUYEN] ON
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (1, N'Quản lý thông tin nhân viên', N'QLTTNV              ', 1)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (2, N'Quản lý sách của admin', N'QLS_A               ', 1)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (4, N'Quản lý thông tin khách hàng của admin', N'QLTTKH_A            ', 1)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (6, N'Quản lý nhà cung cấp của admin', N'QLNCC_A             ', 1)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (7, N'Quản lý nhà xuất bản của admin', N'QLNXB_A             ', 1)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (8, N'Quản lý lập phiếu nhập của admin', N'QLPN_A              ', 1)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (10, N'Quản lý lập phiếu xuất của admin', N'QLPX_A              ', 1)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (11, N'Tính tiền của admin', N'TT_A                ', 1)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (12, N'Quản lý sách của thủ kho', N'QLS_TK              ', 2)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (13, N'Quản lý nhà cung cấp của thủ kho', N'QLNCC_TK            ', 2)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (14, N'Quảng lý nhà xuất bản của thủ kho', N'QLNXB_TK            ', 2)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (15, N'Quản lý lập phiếu nhập của thủ kho', N'QLPN_TK             ', 2)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (17, N'Quản lý lập phiếu xuất của thủ kho', N'QLPX_TK             ', 2)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (18, N'Quản lý thông khách hàng của nv bán hàng', N'QLTTKH_BH           ', 3)
INSERT [dbo].[CHITIETQUYEN] ([QuyenCT_ID], [ChucNang], [MaChucNang], [Quyen_ID]) VALUES (19, N'Tính tiền của nv bàn hàng ', N'TT_BH               ', 3)
SET IDENTITY_INSERT [dbo].[CHITIETQUYEN] OFF
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDT] [nchar](20) NULL,
	[MaVT] [nchar](10) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [DiaChi], [SoDT], [MaVT]) VALUES (N'C01                                               ', N'Bùi Hồng Sơn', N'Đà Nẵng', N'01694345102         ', N'1         ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [DiaChi], [SoDT], [MaVT]) VALUES (N'NV01                                              ', N'Yama', N'Hà Nội', N'12312425            ', N'2         ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [DiaChi], [SoDT], [MaVT]) VALUES (N'NV02                                              ', N'Tevy', N'Hồ Chí Minh', N'1235113             ', N'2         ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [DiaChi], [SoDT], [MaVT]) VALUES (N'NV03                                              ', N'Kai', N'Huế', N'12314512            ', N'2         ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [DiaChi], [SoDT], [MaVT]) VALUES (N'NV04                                              ', N'Hera', N'Hà Nội', N'12312412            ', N'2         ')
/****** Object:  Table [dbo].[SACH]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [nchar](20) NOT NULL,
	[MaTL] [nchar](20) NULL,
	[TenSach] [nvarchar](100) NULL,
	[TacGia] [nvarchar](50) NULL,
	[NXB] [nchar](10) NULL,
	[SoLuong] [int] NULL,
	[Gia] [int] NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SACH] ([MaSach], [MaTL], [TenSach], [TacGia], [NXB], [SoLuong], [Gia]) VALUES (N'MS01                ', N'TL01                ', N'Tắt đèn', N'Ngô Tất Tố', N'N003      ', 47, 20000)
INSERT [dbo].[SACH] ([MaSach], [MaTL], [TenSach], [TacGia], [NXB], [SoLuong], [Gia]) VALUES (N'MS02                ', N'TL03                ', N'Toán lớp 1', N'Sơn', N'N003      ', 45, 50000)
INSERT [dbo].[SACH] ([MaSach], [MaTL], [TenSach], [TacGia], [NXB], [SoLuong], [Gia]) VALUES (N'MS03                ', N'TL01                ', N'Khám phá aaa', N'Is me', N'N003      ', 122, 12000)
INSERT [dbo].[SACH] ([MaSach], [MaTL], [TenSach], [TacGia], [NXB], [SoLuong], [Gia]) VALUES (N'MS04                ', N'TL04                ', N'Lập trình C#', N'Sơn', N'X002      ', 20, 20000)
INSERT [dbo].[SACH] ([MaSach], [MaTL], [TenSach], [TacGia], [NXB], [SoLuong], [Gia]) VALUES (N'MS05                ', N'TL01                ', N'Vùng trời mới', N'Hồng Sơn', N'X001      ', 50, 30000)
INSERT [dbo].[SACH] ([MaSach], [MaTL], [TenSach], [TacGia], [NXB], [SoLuong], [Gia]) VALUES (N'MS06                ', N'TL01                ', N'aaa', N'sơn', N'N003      ', 12, 10000)
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TaiKhoan_ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nchar](20) NULL,
	[MatKhau] [nchar](10) NULL,
	[MaNV] [nchar](50) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TAIKHOAN] ON
INSERT [dbo].[TAIKHOAN] ([TaiKhoan_ID], [TenDangNhap], [MatKhau], [MaNV]) VALUES (1, N'admin               ', N'admin     ', N'C01                                               ')
INSERT [dbo].[TAIKHOAN] ([TaiKhoan_ID], [TenDangNhap], [MatKhau], [MaNV]) VALUES (2, N'thukho              ', N'thukho    ', N'NV01                                              ')
INSERT [dbo].[TAIKHOAN] ([TaiKhoan_ID], [TenDangNhap], [MatKhau], [MaNV]) VALUES (3, N'banhang             ', N'banhang   ', N'NV02                                              ')
SET IDENTITY_INSERT [dbo].[TAIKHOAN] OFF
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[SoHD] [nchar](10) NOT NULL,
	[NgayLap] [datetime] NULL,
	[MaNV] [nchar](50) NULL,
	[TongTien] [int] NULL,
	[SDT] [nchar](10) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HOADON] ([SoHD], [NgayLap], [MaNV], [TongTien], [SDT]) VALUES (N'001       ', CAST(0x0000A99500000000 AS DateTime), N'NV01                                              ', 40000, NULL)
INSERT [dbo].[HOADON] ([SoHD], [NgayLap], [MaNV], [TongTien], [SDT]) VALUES (N'002       ', CAST(0x0000A99500000000 AS DateTime), N'NV01                                              ', 50000, NULL)
INSERT [dbo].[HOADON] ([SoHD], [NgayLap], [MaNV], [TongTien], [SDT]) VALUES (N'004       ', CAST(0x0000A97500000000 AS DateTime), N'NV03                                              ', 70000, NULL)
INSERT [dbo].[HOADON] ([SoHD], [NgayLap], [MaNV], [TongTien], [SDT]) VALUES (N'005       ', CAST(0x0000A99500000000 AS DateTime), N'NV01                                              ', 150000, NULL)
INSERT [dbo].[HOADON] ([SoHD], [NgayLap], [MaNV], [TongTien], [SDT]) VALUES (N'006       ', CAST(0x0000A99500000000 AS DateTime), N'NV04                                              ', 350000, NULL)
INSERT [dbo].[HOADON] ([SoHD], [NgayLap], [MaNV], [TongTien], [SDT]) VALUES (N'03        ', CAST(0x0000A9A000000000 AS DateTime), N'NV01                                              ', 70000, NULL)
/****** Object:  Table [dbo].[TAIKHOAN_QUYEN]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN_QUYEN](
	[TK_Q_ID] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan_ID] [int] NOT NULL,
	[Quyen_ID] [int] NOT NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TAIKHOAN_QUYEN] PRIMARY KEY CLUSTERED 
(
	[TK_Q_ID] ASC,
	[TaiKhoan_ID] ASC,
	[Quyen_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TAIKHOAN_QUYEN] ON
INSERT [dbo].[TAIKHOAN_QUYEN] ([TK_Q_ID], [TaiKhoan_ID], [Quyen_ID], [TrangThai]) VALUES (1, 1, 1, N'False')
INSERT [dbo].[TAIKHOAN_QUYEN] ([TK_Q_ID], [TaiKhoan_ID], [Quyen_ID], [TrangThai]) VALUES (2, 2, 2, N'False')
INSERT [dbo].[TAIKHOAN_QUYEN] ([TK_Q_ID], [TaiKhoan_ID], [Quyen_ID], [TrangThai]) VALUES (3, 3, 3, N'False')
SET IDENTITY_INSERT [dbo].[TAIKHOAN_QUYEN] OFF
/****** Object:  Table [dbo].[CTHOADON]    Script Date: 12/09/2018 20:29:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHOADON](
	[SoHD] [nchar](10) NOT NULL,
	[MaSach] [nchar](20) NOT NULL,
	[SoLuongMua] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_CTHOADON] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTHOADON] ([SoHD], [MaSach], [SoLuongMua], [ThanhTien]) VALUES (N'001       ', N'MS01                ', 2, 40000)
INSERT [dbo].[CTHOADON] ([SoHD], [MaSach], [SoLuongMua], [ThanhTien]) VALUES (N'002       ', N'MS02                ', 1, 50000)
INSERT [dbo].[CTHOADON] ([SoHD], [MaSach], [SoLuongMua], [ThanhTien]) VALUES (N'004       ', N'MS01                ', 1, 20000)
INSERT [dbo].[CTHOADON] ([SoHD], [MaSach], [SoLuongMua], [ThanhTien]) VALUES (N'004       ', N'MS02                ', 1, 50000)
INSERT [dbo].[CTHOADON] ([SoHD], [MaSach], [SoLuongMua], [ThanhTien]) VALUES (N'005       ', N'MS01                ', 5, 100000)
INSERT [dbo].[CTHOADON] ([SoHD], [MaSach], [SoLuongMua], [ThanhTien]) VALUES (N'005       ', N'MS02                ', 1, 50000)
INSERT [dbo].[CTHOADON] ([SoHD], [MaSach], [SoLuongMua], [ThanhTien]) VALUES (N'006       ', N'MS01                ', 15, 300000)
INSERT [dbo].[CTHOADON] ([SoHD], [MaSach], [SoLuongMua], [ThanhTien]) VALUES (N'006       ', N'MS02                ', 1, 50000)
INSERT [dbo].[CTHOADON] ([SoHD], [MaSach], [SoLuongMua], [ThanhTien]) VALUES (N'03        ', N'MS01                ', 1, 20000)
INSERT [dbo].[CTHOADON] ([SoHD], [MaSach], [SoLuongMua], [ThanhTien]) VALUES (N'03        ', N'MS02                ', 1, 50000)
/****** Object:  Default [DF_TongTien]    Script Date: 12/09/2018 20:29:35 ******/
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [DF_TongTien]  DEFAULT ((0)) FOR [TongTien]
GO
/****** Object:  ForeignKey [FK_CHITIETQUYEN_QUYEN]    Script Date: 12/09/2018 20:29:35 ******/
ALTER TABLE [dbo].[CHITIETQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETQUYEN_QUYEN] FOREIGN KEY([Quyen_ID])
REFERENCES [dbo].[QUYEN] ([Quyen_ID])
GO
ALTER TABLE [dbo].[CHITIETQUYEN] CHECK CONSTRAINT [FK_CHITIETQUYEN_QUYEN]
GO
/****** Object:  ForeignKey [FK_NHANVIEN_VAITRO]    Script Date: 12/09/2018 20:29:35 ******/
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_VAITRO] FOREIGN KEY([MaVT])
REFERENCES [dbo].[VAITRO] ([MaVT])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_VAITRO]
GO
/****** Object:  ForeignKey [FK_SACH_NHAXUATBAN]    Script Date: 12/09/2018 20:29:35 ******/
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHAXUATBAN] FOREIGN KEY([NXB])
REFERENCES [dbo].[NHAXUATBAN] ([MaNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHAXUATBAN]
GO
/****** Object:  ForeignKey [FK_SACH_THELOAI]    Script Date: 12/09/2018 20:29:35 ******/
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_THELOAI] FOREIGN KEY([MaTL])
REFERENCES [dbo].[THELOAI] ([MaTL])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_THELOAI]
GO
/****** Object:  ForeignKey [FK_TAIKHOAN_NHANVIEN]    Script Date: 12/09/2018 20:29:35 ******/
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_HOADON_KHACHHANG]    Script Date: 12/09/2018 20:29:35 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([SDT])
REFERENCES [dbo].[KHACHHANG] ([SDT])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_HOADON_NHANVIEN]    Script Date: 12/09/2018 20:29:35 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
/****** Object:  ForeignKey [FK_TAIKHOAN_QUYEN_QUYEN]    Script Date: 12/09/2018 20:29:35 ******/
ALTER TABLE [dbo].[TAIKHOAN_QUYEN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_QUYEN_QUYEN] FOREIGN KEY([Quyen_ID])
REFERENCES [dbo].[QUYEN] ([Quyen_ID])
GO
ALTER TABLE [dbo].[TAIKHOAN_QUYEN] CHECK CONSTRAINT [FK_TAIKHOAN_QUYEN_QUYEN]
GO
/****** Object:  ForeignKey [FK_TAIKHOAN_QUYEN_TAIKHOAN]    Script Date: 12/09/2018 20:29:35 ******/
ALTER TABLE [dbo].[TAIKHOAN_QUYEN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_QUYEN_TAIKHOAN] FOREIGN KEY([TaiKhoan_ID])
REFERENCES [dbo].[TAIKHOAN] ([TaiKhoan_ID])
GO
ALTER TABLE [dbo].[TAIKHOAN_QUYEN] CHECK CONSTRAINT [FK_TAIKHOAN_QUYEN_TAIKHOAN]
GO
/****** Object:  ForeignKey [FK_CTHOADON_HOADON]    Script Date: 12/09/2018 20:29:35 ******/
ALTER TABLE [dbo].[CTHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CTHOADON_HOADON] FOREIGN KEY([SoHD])
REFERENCES [dbo].[HOADON] ([SoHD])
GO
ALTER TABLE [dbo].[CTHOADON] CHECK CONSTRAINT [FK_CTHOADON_HOADON]
GO
/****** Object:  ForeignKey [FK_CTHOADON_SACH]    Script Date: 12/09/2018 20:29:35 ******/
ALTER TABLE [dbo].[CTHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CTHOADON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CTHOADON] CHECK CONSTRAINT [FK_CTHOADON_SACH]
GO
