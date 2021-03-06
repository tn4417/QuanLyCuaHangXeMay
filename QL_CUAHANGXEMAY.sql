GO
USE MASTER
GO
IF EXISTS (SELECT * FROM SYSDATABASES WHERE NAME = N'QL_CUAHANGXEMAY') DROP DATABASE [QL_CUAHANGXEMAY]
GO
CREATE DATABASE QL_CUAHANGXEMAY
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_CUAHANGXEMAY].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET  MULTI_USER 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_CUAHANGXEMAY', N'ON'
GO
USE [QL_CUAHANGXEMAY]
GO
/****** Object:  Table [dbo].[Bao_Hanh]    Script Date: 28/11/2020 23:34:45 ******/
SET ANSI_NULLS ON
GO
SET DATEFORMAT DMY
GO
SET QUOTED_IDENTIFIER ON
GO



-----------------------------------------------------------------------------------------
CREATE TABLE [dbo].[Bao_Hanh](
[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaBH] [nvarchar](50) not null,
	[MaKH] [nvarchar](50) not NULL,
	[SoKhung] [nvarchar](50) NULL,
	[SoMay] [nvarchar](50) NULL,
	 primary key ([MaBH])--,[MaKH]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dang_Nhap]    Script Date: 28/11/2020 23:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dang_Nhap](
[STT] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50)  primary key not null,
	[PassWord] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hoa_Don_Ban_Xe]    Script Date: 28/11/2020 23:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoa_Don_Ban_Xe](
[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [nvarchar](50)  not null,
	[MaKH] [nvarchar](50) not NULL,
	[MaNX] [nvarchar](50) not NULL,
	[MaNV] [nvarchar](50) not NULL,
	[SoKhung] [nvarchar](50) NULL,
	[SoMay] [nvarchar](50) NULL,
	[Mauxe] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
	[TongTien] [int] NULL,
	[NgayLap] [datetime] NULL,
	primary key ([MaHD])--,[MaKH],[MaNX],[MaNV]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hoa_Don_Thanh_Toan]    Script Date: 28/11/2020 23:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoa_Don_Thanh_Toan](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaTT] [nvarchar](50) not null,
	[MaNCC] [nvarchar](50) not NULL,
	[TongTien] [nvarchar](50) NULL,
	[NgayLap] [datetime] NULL,
	primary key ([MaTT])--,[MaNCC]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khach_Hang]    Script Date: 28/11/2020 23:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach_Hang](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [nvarchar](50)  primary key not null,
	[HoTenKH] [nvarchar](50) NULL,
	[DiaChiKH] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[SoCMT] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nha_Cung_Cap]    Script Date: 28/11/2020 23:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nha_Cung_Cap](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [nvarchar](50)  primary key not null,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[Email] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhan_Vien]    Script Date: 28/11/2020 23:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhan_Vien](
[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nvarchar](50) primary key not null,
	[HoTenNV] [nvarchar](50) NULL,
	[SoCMT] [int] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[ChuyenMon] [nvarchar](50) NULL,
	[Luong] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhom_Xe]    Script Date: 28/11/2020 23:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhom_Xe](
[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaNX] [nvarchar](50)  primary key not null,
	[HangSX] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phieu_Nhap]    Script Date: 28/11/2020 23:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieu_Nhap](
[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaPN] [nvarchar](50)   not null,
	[MaNV] [nvarchar](50) not NULL,
	[MaNCC] [nvarchar](50) not NULL,
	[MaNX] [nvarchar](50) not NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
	[NgayLap] [datetime] NULL,
	primary key ([MaPN])--,[MaNV],[MaNCC],[MaNX]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Xe]    Script Date: 28/11/2020 23:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaNX] [nvarchar](50) not null,
	[SoKhung] [nvarchar](50) not NULL,
	[SoMay] [nvarchar](50) NULL,
	[MauSac] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	primary key ([MaNX],[SoKhung])
) ON [PRIMARY]


---------------------------------------------------------------------------
GO
INSERT [dbo].[Bao_Hanh] ([MaBH], [MaKH], [SoKhung], [SoMay]) VALUES (N'BH001', N'KH001', N'SK001', N'SM001')
INSERT [dbo].[Bao_Hanh] ([MaBH], [MaKH], [SoKhung], [SoMay]) VALUES (N'BH002', N'KH002', N'SK002', N'SM002')
INSERT [dbo].[Bao_Hanh] ([MaBH], [MaKH], [SoKhung], [SoMay]) VALUES (N'BH003', N'KH003', N'SK003', N'SM003')
INSERT [dbo].[Dang_Nhap] ([UserName], [PassWord]) VALUES (N'TrungNguyen', N'nguyen')
INSERT [dbo].[Dang_Nhap] ([UserName], [PassWord]) VALUES (N'NgocLinh', N'linh')
INSERT [dbo].[Dang_Nhap] ([UserName], [PassWord]) VALUES (N'admin', N'admin')
INSERT [dbo].[Hoa_Don_Ban_Xe] ([MaHD], [MaKH], [MaNX], [MaNV], [SoKhung], [SoMay], [Mauxe], [DonGia], [SoLuong], [TongTien], [NgayLap]) VALUES (N'HD001', N'KH001', N'Wave S', N'NV001', N'SK001', N'SM001', N'Den', 16000000, 1, 16000000, '15/10/2020')
INSERT [dbo].[Hoa_Don_Ban_Xe] ([MaHD], [MaKH], [MaNX], [MaNV], [SoKhung], [SoMay], [Mauxe], [DonGia], [SoLuong], [TongTien], [NgayLap]) VALUES (N'HD002', N'KH002', N'Wave RSX', N'NV002', N'SK002', N'SM002', N'Trang', 20000000, 1, 20000000, '15/10/2020')
INSERT [dbo].[Hoa_Don_Ban_Xe] ([MaHD], [MaKH], [MaNX], [MaNV], [SoKhung], [SoMay], [Mauxe], [DonGia], [SoLuong], [TongTien], [NgayLap]) VALUES (N'HD003', N'KH003', N'Sirius', N'NV001', N'SK003', N'SM003', N'Vang', 18000000, 1, 18000000, '15/10/2020')
INSERT [dbo].[Hoa_Don_Thanh_Toan] ([MaTT], [MaNCC], [TongTien], [NgayLap]) VALUES (N'TT001', N'NCC001', N'2345000000', '30/10/2020')
INSERT [dbo].[Hoa_Don_Thanh_Toan] ([MaTT], [MaNCC], [TongTien], [NgayLap]) VALUES (N'TT002', N'NCC002', N'3456000000', '30/10/2020')
INSERT [dbo].[Hoa_Don_Thanh_Toan] ([MaTT], [MaNCC], [TongTien], [NgayLap]) VALUES (N'TT003', N'NCC003', N'5670000000', '30/10/2020')
INSERT [dbo].[Khach_Hang] ([MaKH], [HoTenKH], [DiaChiKH], [SDT], [SoCMT]) VALUES (N'KH001', N'Nguyen Hoa', N'HCM', 908980989, 123123123)
INSERT [dbo].[Khach_Hang] ([MaKH], [HoTenKH], [DiaChiKH], [SDT], [SoCMT]) VALUES (N'Kh002', N'Nguyen Tra', N'HCM', 987098709, 134512345)
INSERT [dbo].[Khach_Hang] ([MaKH], [HoTenKH], [DiaChiKH], [SDT], [SoCMT]) VALUES (N'KH003', N'Nguyen Minh', N'HCM', 1223223223, 134234233)
INSERT [dbo].[Nha_Cung_Cap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (N'NCC001', N'Honda', N'HCM', 439879876, N'honda.com.vn')
INSERT [dbo].[Nha_Cung_Cap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (N'NCC002', N'Yamaha', N'HCM', 433343343, N'yamaha.com.vn')
INSERT [dbo].[Nha_Cung_Cap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (N'NCC003', N'Suzuki', N'HCM', 435675677, N'suzuki.com.vn')
INSERT [dbo].[Nha_Cung_Cap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email]) VALUES (N'NCC004', N'SYM', N'HCM', 987898790, N'sym.com.vn')
INSERT [dbo].[Nhan_Vien] ([MaNV], [HoTenNV], [SoCMT], [DiaChi], [ChuyenMon], [Luong]) VALUES (N'NV001', N'Nguyen Thi A', 123456780, N'HCM', N'Ke Toan', 3000000)
INSERT [dbo].[Nhan_Vien] ([MaNV], [HoTenNV], [SoCMT], [DiaChi], [ChuyenMon], [Luong]) VALUES (N'NV002', N'Ngo Van B', 121212121, N'Dong Nai', N'Ky Thuat Vien', 4500000)
INSERT [dbo].[Nhan_Vien] ([MaNV], [HoTenNV], [SoCMT], [DiaChi], [ChuyenMon], [Luong]) VALUES (N'NV003', N'Nguyen Thi C', 134234345, N'Binh Duong', N'Ban Hang', 2500000)
INSERT [dbo].[Nhan_Vien] ([MaNV], [HoTenNV], [SoCMT], [DiaChi], [ChuyenMon], [Luong]) VALUES (N'NV004', N'Nguyen Tran D', 123456788, N'Long An', N'Ky Thuat Vien', 4500000)
INSERT [dbo].[Nhom_Xe] ([MaNX], [HangSX], [DonGia], [SoLuong]) VALUES (N'Wave S', N'Honda', 16000000, 30)
INSERT [dbo].[Nhom_Xe] ([MaNX], [HangSX], [DonGia], [SoLuong]) VALUES (N'Wave RSX', N'Honda', 20000000, 50)
INSERT [dbo].[Nhom_Xe] ([MaNX], [HangSX], [DonGia], [SoLuong]) VALUES (N'Sirius', N'Suzuki', 18000000, 20)
INSERT [dbo].[Nhom_Xe] ([MaNX], [HangSX], [DonGia], [SoLuong]) VALUES (N'Dream', N'Honda', 22000000, 40)
INSERT [dbo].[Phieu_Nhap] ([MaPN], [MaNV], [MaNCC], [MaNX], [DonGia], [SoLuong], [ThanhTien], [NgayLap]) VALUES (N'PN001', N'NV001', N'NCC001', N'Wave S', 16000000, 50, 800000000, '5/10/2020')
INSERT [dbo].[Phieu_Nhap] ([MaPN], [MaNV], [MaNCC], [MaNX], [DonGia], [SoLuong], [ThanhTien], [NgayLap]) VALUES (N'PN002', N'NV002', N'NCC002', N'Sirius', 18000000, 100, 1800000000, '5/10/2020')
INSERT [dbo].[Phieu_Nhap] ([MaPN], [MaNV], [MaNCC], [MaNX], [DonGia], [SoLuong], [ThanhTien], [NgayLap]) VALUES (N'PN003', N'NV001', N'NCC001', N'Wave RSX', 20000000, 50, 100000000, '5/10/2020')
INSERT [dbo].[Xe] ([MaNX], [SoKhung], [SoMay], [mausac], [dongia]) VALUES (N'Wave S', N'SK001', N'SM001', N'Den', 16000000)
INSERT [dbo].[Xe] ([MaNX], [SoKhung], [SoMay], [mausac], [dongia]) VALUES (N'Wave S', N'SK002', N'SM002', N'Trang', 15500000)
INSERT [dbo].[Xe] ([MaNX], [SoKhung], [SoMay], [mausac], [dongia]) VALUES (N'Dream', N'SK003', N'SM003', N'Den', 22000000)
INSERT [dbo].[Xe] ([MaNX], [SoKhung], [SoMay], [mausac], [dongia]) VALUES (N'Sirius', N'SK004', N'SM004', N'Vang', 18000000)
USE [master]
GO
ALTER DATABASE [QL_CUAHANGXEMAY] SET  READ_WRITE 
GO



select * from Bao_Hanh

select * from Hoa_Don_Ban_Xe

select * from Hoa_Don_Thanh_Toan

