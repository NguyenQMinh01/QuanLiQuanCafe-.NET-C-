USE [QL_Quancaphe]
GO
/****** Object:  Table [dbo].[tb_Ban]    Script Date: 6/7/2022 3:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Ban](
	[maban] [int] IDENTITY(1,1) NOT NULL,
	[tenban] [nvarchar](20) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_tbl_Ban] PRIMARY KEY CLUSTERED 
(
	[maban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_CTHDB]    Script Date: 6/7/2022 3:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTHDB](
	[mahdb] [int] NOT NULL,
	[masp] [nvarchar](10) NOT NULL,
	[thanhtien] [float] NULL,
	[khuyenmai] [float] NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_tb_CTHDB] PRIMARY KEY CLUSTERED 
(
	[mahdb] ASC,
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_CTHDN]    Script Date: 6/7/2022 3:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTHDN](
	[macthdn] [int] NOT NULL,
	[mahdn] [int] NOT NULL,
	[MaNL] [nvarchar](50) NULL,
	[thanhtien] [float] NULL,
	[khuyenmai] [float] NULL,
	[soluong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[macthdn] ASC,
	[mahdn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_HDB]    Script Date: 6/7/2022 3:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HDB](
	[mahdb] [int] IDENTITY(1,1) NOT NULL,
	[ngayban] [datetime] NULL,
	[manv] [nvarchar](10) NULL,
	[makh] [nvarchar](10) NULL,
	[tongtien] [float] NULL,
	[maban] [int] NULL,
 CONSTRAINT [PK_tb_HDB] PRIMARY KEY CLUSTERED 
(
	[mahdb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_HDN]    Script Date: 6/7/2022 3:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HDN](
	[mahdn] [int] NOT NULL,
	[ngaynhap] [datetime] NULL,
	[manv] [nvarchar](10) NULL,
	[tongtien] [float] NULL,
	[MaNCC] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[mahdn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Khachhang]    Script Date: 6/7/2022 3:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Khachhang](
	[makh] [nvarchar](10) NOT NULL,
	[tenkh] [nvarchar](50) NULL,
	[sdt] [varchar](50) NULL,
 CONSTRAINT [PK_tb_Khachhang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Loai]    Script Date: 6/7/2022 3:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Loai](
	[maloai] [nvarchar](10) NOT NULL,
	[tenloai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Loai] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_NCC]    Script Date: 6/7/2022 3:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NCC](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[diachi] [varchar](10) NULL,
	[sdt] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Nguyenlieu]    Script Date: 6/7/2022 3:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Nguyenlieu](
	[MaNL] [nvarchar](50) NOT NULL,
	[TenNL] [nvarchar](50) NULL,
	[soluong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Nhanvien]    Script Date: 6/7/2022 3:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Nhanvien](
	[manv] [nvarchar](10) NOT NULL,
	[tennv] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](10) NULL,
	[ngaysinh] [datetime] NULL,
	[tenque] [nvarchar](10) NULL,
	[sdt] [nvarchar](50) NULL,
	[Passwords] [nvarchar](50) NULL,
	[Quyen] [nvarchar](20) NULL,
 CONSTRAINT [PK_tb_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Sanpham]    Script Date: 6/7/2022 3:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Sanpham](
	[masp] [nvarchar](10) NOT NULL,
	[tensp] [nvarchar](50) NULL,
	[maloai] [nvarchar](10) NULL,
	[giaban] [int] NULL,
	[hinhanh] [nvarchar](50) NULL,
	[MaNL] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Sanpham] PRIMARY KEY CLUSTERED 
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_Ban] ON 

INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (1, N'Bàn 1', 1)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (2, N'Bàn 2', 0)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (3, N'Bàn 3', 0)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (4, N'Bàn 4', 0)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (5, N'Bàn 5', 0)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (6, N'Bàn 6', 0)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (7, N'Bàn 7', 0)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (8, N'Bàn 8', 0)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (9, N'Bàn 9', 0)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (10, N'Bàn 10', 0)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (11, N'Bàn 11', 0)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (12, N'Bàn 12', 0)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (13, NULL, 0)
INSERT [dbo].[tb_Ban] ([maban], [tenban], [TrangThai]) VALUES (14, NULL, 0)
SET IDENTITY_INSERT [dbo].[tb_Ban] OFF
GO
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (111, N'SP01', 20000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (163, N'SP01', 30000, 0, 7)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (164, N'SP02', 15000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (165, N'SP04', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (165, N'SP05', 30000, 100, 2)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (167, N'SP01', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (168, N'SP01', 30000, 0, 4)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (168, N'SP02', 15000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (172, N'SP01', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (173, N'SP01', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (175, N'SP01', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (176, N'SP01', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (177, N'SP01', 30000, 0, 2)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (177, N'SP06', 500000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (178, N'SP01', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (178, N'SP06', 500000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (179, N'SP01', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (179, N'SP06', 500000, 0, 2)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (180, N'SP01', 30000, 0, 21)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (180, N'SP02', 15000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (180, N'SP06', 500000, 0, 15)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (185, N'SP05', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (186, N'SP05', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (187, N'SP03', 13420, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (188, N'SP02', 15000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (189, N'SP02', 15000, 0, 3)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (190, N'SP02', 15000, 0, 2)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (191, N'SP02', 15000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (192, N'SP02', 15000, 0, 2)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (196, N'SP01', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (196, N'SP02', 15000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (196, N'SP07', 20000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (197, N'SP02', 15000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (198, N'SP02', 15000, 0, 2)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (198, N'SP07', 20000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (199, N'SP02', 15000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (200, N'SP02', 15000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (200, N'SP07', 20000, 0, 2)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (201, N'SP05', 210000, 0, 7)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (202, N'SP05', 60000, 0, 2)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (213, N'SP02', 15000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (221, N'SP02', 15000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (222, N'SP02', 15000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (223, N'SP02', 30000, 0, 2)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (224, N'SP02', 45000, 0, 3)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (225, N'SP02', 30000, 0, 2)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (226, N'SP01', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (227, N'SP01', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (228, N'SP01', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (229, N'SP05', 30000, 0, 1)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (230, N'SP01', 60000, 0, 2)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (231, N'SP05', 60000, 0, 2)
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [thanhtien], [khuyenmai], [soluong]) VALUES (234, N'SP05', 60000, 0, 2)
GO
INSERT [dbo].[tb_CTHDN] ([macthdn], [mahdn], [MaNL], [thanhtien], [khuyenmai], [soluong]) VALUES (1, 1, N'NL1', 1.1, 34, 7)
INSERT [dbo].[tb_CTHDN] ([macthdn], [mahdn], [MaNL], [thanhtien], [khuyenmai], [soluong]) VALUES (1, 6, N'NL1', 30000, 0, 2)
INSERT [dbo].[tb_CTHDN] ([macthdn], [mahdn], [MaNL], [thanhtien], [khuyenmai], [soluong]) VALUES (2, 2, N'NL2', 30000, 0, 3)
INSERT [dbo].[tb_CTHDN] ([macthdn], [mahdn], [MaNL], [thanhtien], [khuyenmai], [soluong]) VALUES (2, 6, N'NL1', 30000, 0, 2)
INSERT [dbo].[tb_CTHDN] ([macthdn], [mahdn], [MaNL], [thanhtien], [khuyenmai], [soluong]) VALUES (3, 3, N'NL3', 0, 0, 1)
INSERT [dbo].[tb_CTHDN] ([macthdn], [mahdn], [MaNL], [thanhtien], [khuyenmai], [soluong]) VALUES (4, 1, N'NL4', 0, 0, 1)
INSERT [dbo].[tb_CTHDN] ([macthdn], [mahdn], [MaNL], [thanhtien], [khuyenmai], [soluong]) VALUES (5, 1, N'NL1', 2, 0, 2)
INSERT [dbo].[tb_CTHDN] ([macthdn], [mahdn], [MaNL], [thanhtien], [khuyenmai], [soluong]) VALUES (5, 2, N'NL1', 30000, 0, 1)
INSERT [dbo].[tb_CTHDN] ([macthdn], [mahdn], [MaNL], [thanhtien], [khuyenmai], [soluong]) VALUES (6, 6, N'NL1', 30000, 0, 2)
INSERT [dbo].[tb_CTHDN] ([macthdn], [mahdn], [MaNL], [thanhtien], [khuyenmai], [soluong]) VALUES (7, 6, N'NL1', 30000, 0, 2)
INSERT [dbo].[tb_CTHDN] ([macthdn], [mahdn], [MaNL], [thanhtien], [khuyenmai], [soluong]) VALUES (8, 6, N'NL1', 30000, 0, 2)
GO
SET IDENTITY_INSERT [dbo].[tb_HDB] ON 

INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (69, CAST(N'2021-11-14T00:00:00.000' AS DateTime), N'NV06', N'KH06', 45000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (70, CAST(N'2021-11-14T00:00:00.000' AS DateTime), N'NV06', N'KH06', 45000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (71, CAST(N'2021-11-14T00:00:00.000' AS DateTime), N'NV06', N'KH06', 45000, 10)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (72, CAST(N'2021-11-14T00:00:00.000' AS DateTime), N'NV06', N'KH06', 45000, 5)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (73, CAST(N'2021-11-14T00:00:00.000' AS DateTime), N'NV06', N'KH06', 45000, 6)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (74, CAST(N'2021-11-14T00:00:00.000' AS DateTime), N'NV06', N'KH06', 45000, 7)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (75, CAST(N'2021-11-14T00:00:00.000' AS DateTime), N'NV06', N'KH06', 45000, 12)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (76, CAST(N'2021-11-14T00:00:00.000' AS DateTime), N'NV06', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (77, CAST(N'2021-11-14T00:00:00.000' AS DateTime), N'NV06', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (78, CAST(N'2021-11-14T00:00:00.000' AS DateTime), N'NV06', N'KH06', 45000, 9)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (82, CAST(N'2021-11-15T00:00:00.000' AS DateTime), N'NV06', N'KH06', 45000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (83, CAST(N'2021-11-15T00:00:00.000' AS DateTime), N'NV06', N'KH06', 45000, 10)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (89, CAST(N'2021-11-15T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (90, CAST(N'2021-11-15T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (91, CAST(N'2021-11-15T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (93, CAST(N'2021-11-21T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 11)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (94, CAST(N'2021-11-21T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 11)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (95, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH09', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (96, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 2)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (97, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH09', 45000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (98, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH09', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (99, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH09', 45000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (100, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (101, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH09', 45000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (102, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH09', 45000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (103, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (104, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (105, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (106, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (107, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (108, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (109, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (110, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (111, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (112, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (113, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (114, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (115, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (116, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (117, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (118, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (119, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (120, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (121, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (122, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (123, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (124, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (125, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (126, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 5)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (127, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 5)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (128, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH09', 45000, 7)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (129, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (130, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (131, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (132, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'NV01', N'KH06', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (148, CAST(N'1900-01-01T10:22:00.000' AS DateTime), N'NV01', N'KH06', 45000, 2)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (149, CAST(N'1900-01-01T10:23:00.000' AS DateTime), N'NV01', N'KH06', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (150, CAST(N'1900-01-01T10:23:00.000' AS DateTime), N'NV01', N'KH06', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (151, CAST(N'1900-01-01T10:24:00.000' AS DateTime), N'NV01', N'KH06', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (152, CAST(N'1900-01-01T10:27:00.000' AS DateTime), N'NV01', N'KH06', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (153, CAST(N'1900-01-01T11:08:00.000' AS DateTime), N'nv01', N'KH06', 550000, 2)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (154, CAST(N'1900-01-01T12:43:00.000' AS DateTime), N'nv01', N'KH06', 60000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (155, CAST(N'1900-01-01T14:20:00.000' AS DateTime), N'nv01', N'KH07', 35000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (156, CAST(N'1900-01-01T14:37:00.000' AS DateTime), N'nv01', N'KH02', 530000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (157, CAST(N'1900-01-01T14:40:00.000' AS DateTime), N'nv01', N'KH03', 30000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (158, CAST(N'1900-01-01T14:43:00.000' AS DateTime), N'nv01', N'KH03', 30000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (159, CAST(N'1900-01-01T14:52:00.000' AS DateTime), N'nv01', N'KH02', 530000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (160, CAST(N'1900-01-01T14:54:00.000' AS DateTime), N'nv01', N'KH05', 1180000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (161, CAST(N'1900-01-01T15:05:00.000' AS DateTime), N'nv01', N'KH02', 30000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (162, CAST(N'1900-01-01T15:13:00.000' AS DateTime), N'nv01', N'KH03', 60000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (163, CAST(N'1900-01-01T16:14:00.000' AS DateTime), N'NV01', N'KH03', 105000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (164, CAST(N'1900-01-01T16:19:00.000' AS DateTime), N'NV01', N'KH05', 15000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (165, CAST(N'1900-01-01T16:20:00.000' AS DateTime), N'NV01', N'KH07', 164800, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (166, CAST(N'1900-01-01T18:34:00.000' AS DateTime), N'nv01', N'KH04', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (167, CAST(N'1900-01-01T18:34:00.000' AS DateTime), N'nv01', N'KH04', NULL, 2)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (168, CAST(N'1900-01-01T18:40:00.000' AS DateTime), N'nv01', N'KH09', 30000, 6)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (172, CAST(N'1900-01-01T19:34:00.000' AS DateTime), N'nv01', N'KH03', 0, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (173, CAST(N'1900-01-01T19:41:00.000' AS DateTime), N'nv01', N'KH01', 0, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (175, CAST(N'1900-01-01T07:16:00.000' AS DateTime), N'nv01', N'KH04', 30000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (176, CAST(N'1900-01-01T07:50:00.000' AS DateTime), N'nv01', N'KH03', 30000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (177, CAST(N'1900-01-01T07:52:00.000' AS DateTime), N'nv01', N'KH01', 0, 2)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (178, CAST(N'1900-01-01T07:53:00.000' AS DateTime), N'nv01', N'KH03', 530000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (179, CAST(N'1900-01-01T13:52:00.000' AS DateTime), N'nv01', N'KH10', 1030000, 2)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (180, CAST(N'1900-01-01T18:16:00.000' AS DateTime), N'nv01', N'KH06', 8145000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (185, CAST(N'1900-01-01T17:01:00.000' AS DateTime), N'nv01', N'KH01', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (186, CAST(N'1900-01-01T17:03:00.000' AS DateTime), N'nv01', N'KH02', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (187, CAST(N'1900-01-01T17:06:00.000' AS DateTime), N'nv01', N'KH01', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (188, CAST(N'1900-01-01T17:11:00.000' AS DateTime), N'nv01', N'KH01', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (189, CAST(N'1900-01-01T17:16:00.000' AS DateTime), N'nv01', N'KH01', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (190, CAST(N'1900-01-01T17:26:00.000' AS DateTime), N'nv01', N'KH01', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (191, CAST(N'1900-01-01T17:33:00.000' AS DateTime), N'nv01', N'KH01', 15000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (192, CAST(N'1900-01-01T09:19:00.000' AS DateTime), N'nv01', N'KH01', 30000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (194, CAST(N'1900-01-01T22:07:00.000' AS DateTime), N'nv01', N'KH04', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (196, CAST(N'2022-06-05T22:12:51.000' AS DateTime), N'nv01', N'KH02', 65000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (197, CAST(N'2022-06-06T18:16:50.000' AS DateTime), N'nv01', N'KH04', 15000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (198, CAST(N'2022-06-06T18:18:06.000' AS DateTime), N'nv01', N'KH07', 50000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (199, CAST(N'2022-06-06T18:23:24.000' AS DateTime), N'nv01', N'KH03', 15000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (200, CAST(N'2022-06-06T18:40:11.000' AS DateTime), N'nv01', N'KH03', 55000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (201, CAST(N'2022-06-06T18:50:51.000' AS DateTime), N'nv01', N'KH03', 60000, 1)
GO
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (202, CAST(N'2022-06-06T19:09:21.000' AS DateTime), N'nv01', N'KH02', 120000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (211, CAST(N'2022-06-07T07:30:19.000' AS DateTime), N'nv01', N'KH02', NULL, 2)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (212, CAST(N'2022-06-07T07:30:49.000' AS DateTime), N'nv01', N'KH02', NULL, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (213, CAST(N'2022-06-07T07:32:44.000' AS DateTime), N'nv01', N'KH04', 15000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (221, CAST(N'2022-06-07T07:47:38.000' AS DateTime), N'nv01', N'GUEST', 0, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (222, CAST(N'2022-06-07T07:47:49.000' AS DateTime), N'nv01', N'GUEST', 0, 4)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (223, CAST(N'2022-06-07T08:45:48.000' AS DateTime), N'nv01', N'GUEST', 60000, 3)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (224, CAST(N'2022-06-07T08:53:47.000' AS DateTime), N'nv01', N'GUEST', 45000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (225, CAST(N'2022-06-07T11:23:12.000' AS DateTime), N'nv01', N'GUEST', 30000, 2)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (226, CAST(N'2022-06-07T11:26:20.000' AS DateTime), N'nv01', N'GUEST', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (227, CAST(N'2022-06-07T11:29:40.000' AS DateTime), N'nv01', N'GUEST', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (228, CAST(N'2022-06-07T11:31:28.000' AS DateTime), N'nv01', N'GUEST', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (229, CAST(N'2022-06-07T11:32:27.000' AS DateTime), N'nv01', N'GUEST', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (230, CAST(N'2022-06-07T11:41:49.000' AS DateTime), N'nv01', N'GUEST', 60000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (231, CAST(N'2022-06-07T11:44:02.000' AS DateTime), N'nv01', N'GUEST', 60000, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (232, CAST(N'2022-06-07T12:39:35.000' AS DateTime), N'nv01', N'GUEST', 13420, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (233, CAST(N'2022-06-07T12:43:07.000' AS DateTime), N'nv01', N'GUEST', 0, 1)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayban], [manv], [makh], [tongtien], [maban]) VALUES (234, CAST(N'2022-06-07T14:10:04.000' AS DateTime), N'nv01', N'GUEST', 60000, 3)
SET IDENTITY_INSERT [dbo].[tb_HDB] OFF
GO
INSERT [dbo].[tb_HDN] ([mahdn], [ngaynhap], [manv], [tongtien], [MaNCC]) VALUES (1, CAST(N'2000-11-20T00:00:00.000' AS DateTime), N'NV02', 330279.7, N'NCC3')
INSERT [dbo].[tb_HDN] ([mahdn], [ngaynhap], [manv], [tongtien], [MaNCC]) VALUES (2, CAST(N'2000-10-20T00:00:00.000' AS DateTime), N'NV01', 35307.1, N'NCC1')
INSERT [dbo].[tb_HDN] ([mahdn], [ngaynhap], [manv], [tongtien], [MaNCC]) VALUES (3, CAST(N'2000-10-20T00:00:00.000' AS DateTime), N'NV03', 17671.100000000002, N'NCC2')
INSERT [dbo].[tb_HDN] ([mahdn], [ngaynhap], [manv], [tongtien], [MaNCC]) VALUES (4, CAST(N'2000-10-20T00:00:00.000' AS DateTime), N'NV04', 76991.4, N'NCC4')
INSERT [dbo].[tb_HDN] ([mahdn], [ngaynhap], [manv], [tongtien], [MaNCC]) VALUES (5, CAST(N'2022-06-05T00:00:00.000' AS DateTime), N'NV01', 158422.4, N'NCC1')
INSERT [dbo].[tb_HDN] ([mahdn], [ngaynhap], [manv], [tongtien], [MaNCC]) VALUES (6, CAST(N'2022-06-07T00:00:00.000' AS DateTime), N'NV03', 300000, N'NCC3')
GO
INSERT [dbo].[tb_Khachhang] ([makh], [tenkh], [sdt]) VALUES (N'GUEST', N'GUEST', N'NULL')
INSERT [dbo].[tb_Khachhang] ([makh], [tenkh], [sdt]) VALUES (N'KH01', N'Nguyễn Văn A', N'0123456789')
INSERT [dbo].[tb_Khachhang] ([makh], [tenkh], [sdt]) VALUES (N'KH02', N'Trần Văn A', N'NULL')
INSERT [dbo].[tb_Khachhang] ([makh], [tenkh], [sdt]) VALUES (N'KH03', N'Lê Thị C', N'NULL')
INSERT [dbo].[tb_Khachhang] ([makh], [tenkh], [sdt]) VALUES (N'KH04', N'Võ Văn B', N'NULL')
INSERT [dbo].[tb_Khachhang] ([makh], [tenkh], [sdt]) VALUES (N'KH05', N'Nguyễn D', N'NULL')
INSERT [dbo].[tb_Khachhang] ([makh], [tenkh], [sdt]) VALUES (N'KH06', N'TCT', N'NULL')
INSERT [dbo].[tb_Khachhang] ([makh], [tenkh], [sdt]) VALUES (N'KH07', N'Trần Cao Tùng', N'NULL')
INSERT [dbo].[tb_Khachhang] ([makh], [tenkh], [sdt]) VALUES (N'KH08', N'Nguyễn Quang Minh', N'NULL')
INSERT [dbo].[tb_Khachhang] ([makh], [tenkh], [sdt]) VALUES (N'KH09', N'M', N'NULL')
INSERT [dbo].[tb_Khachhang] ([makh], [tenkh], [sdt]) VALUES (N'KH10', N'A', N'NULL')
INSERT [dbo].[tb_Khachhang] ([makh], [tenkh], [sdt]) VALUES (N'KH11', N'A', N'NULL')
GO
INSERT [dbo].[tb_Loai] ([maloai], [tenloai]) VALUES (N'L01', N'Cà phê hạt')
INSERT [dbo].[tb_Loai] ([maloai], [tenloai]) VALUES (N'L02', N'Cà phê gói')
INSERT [dbo].[tb_Loai] ([maloai], [tenloai]) VALUES (N'L03', N'Trà')
INSERT [dbo].[tb_Loai] ([maloai], [tenloai]) VALUES (N'L04', N'Bánh ngọt')
INSERT [dbo].[tb_Loai] ([maloai], [tenloai]) VALUES (N'L05', N'Nước có gas')
GO
INSERT [dbo].[tb_NCC] ([MaNCC], [TenNCC], [diachi], [sdt]) VALUES (N'NCC1', N'A', N'TPHCM', N'09864633')
INSERT [dbo].[tb_NCC] ([MaNCC], [TenNCC], [diachi], [sdt]) VALUES (N'NCC2', N'B', N'TPHCM', N'09864633')
INSERT [dbo].[tb_NCC] ([MaNCC], [TenNCC], [diachi], [sdt]) VALUES (N'NCC3', N'C', N'TPHCM', N'09864633')
INSERT [dbo].[tb_NCC] ([MaNCC], [TenNCC], [diachi], [sdt]) VALUES (N'NCC4', N'D', N'TPHCM', N'09864633')
GO
INSERT [dbo].[tb_Nguyenlieu] ([MaNL], [TenNL], [soluong]) VALUES (N'NL1', N'Trà Gói', 10)
INSERT [dbo].[tb_Nguyenlieu] ([MaNL], [TenNL], [soluong]) VALUES (N'NL2', N'Bịch Cà Phê', 0)
INSERT [dbo].[tb_Nguyenlieu] ([MaNL], [TenNL], [soluong]) VALUES (N'NL3', N'Nước Tăng Lực', 10)
INSERT [dbo].[tb_Nguyenlieu] ([MaNL], [TenNL], [soluong]) VALUES (N'NL4', N'Củ Gừng', 4)
INSERT [dbo].[tb_Nguyenlieu] ([MaNL], [TenNL], [soluong]) VALUES (N'NL5', N'Bánh', 5)
INSERT [dbo].[tb_Nguyenlieu] ([MaNL], [TenNL], [soluong]) VALUES (N'NL6', N'Gói Trà Sữa', 10)
GO
INSERT [dbo].[tb_Nhanvien] ([manv], [tennv], [diachi], [gioitinh], [ngaysinh], [tenque], [sdt], [Passwords], [Quyen]) VALUES (N'NV01', N'Âu Dương Phong', N'Tây Nguyên', N'Nam', CAST(N'1989-02-20T00:00:00.000' AS DateTime), N'Q01', N'036458794', N'admin', N'1')
INSERT [dbo].[tb_Nhanvien] ([manv], [tennv], [diachi], [gioitinh], [ngaysinh], [tenque], [sdt], [Passwords], [Quyen]) VALUES (N'NV02', N'Lương Sơn Bạc', N'Bạc Liêu', N'Nam', CAST(N'1989-02-20T00:00:00.000' AS DateTime), N'Q03', N'036458794', N'123', N'0')
INSERT [dbo].[tb_Nhanvien] ([manv], [tennv], [diachi], [gioitinh], [ngaysinh], [tenque], [sdt], [Passwords], [Quyen]) VALUES (N'NV03', N'Mộ Dung Phục', N'Nam Định', N'Nam', CAST(N'1989-02-20T00:00:00.000' AS DateTime), N'Q04', N'036458794', N'123', N'0')
INSERT [dbo].[tb_Nhanvien] ([manv], [tennv], [diachi], [gioitinh], [ngaysinh], [tenque], [sdt], [Passwords], [Quyen]) VALUES (N'NV04', N'Âu Dương Chấn Hoa', N'Bình Định', N'Nam', CAST(N'1989-02-20T00:00:00.000' AS DateTime), N'Q01', N'036458794', N'123', N'0')
INSERT [dbo].[tb_Nhanvien] ([manv], [tennv], [diachi], [gioitinh], [ngaysinh], [tenque], [sdt], [Passwords], [Quyen]) VALUES (N'NV05', N'Trương Thúy Sơn', N'TPHCM', N'Nam', CAST(N'1989-02-20T00:00:00.000' AS DateTime), N'Q02', N'036458794', N'123', N'0')
INSERT [dbo].[tb_Nhanvien] ([manv], [tennv], [diachi], [gioitinh], [ngaysinh], [tenque], [sdt], [Passwords], [Quyen]) VALUES (N'NV06', N'Trần Cao Tùng', N'Quảng Ngãi', N'Nam', CAST(N'2001-10-27T00:00:00.000' AS DateTime), N'Q05', N'0363102884', N'123', N'0')
GO
INSERT [dbo].[tb_Sanpham] ([masp], [tensp], [maloai], [giaban], [hinhanh], [MaNL]) VALUES (N'SP01', N'Trà túi lọc', N'L03', 30000, N'coffee_mug.png', N'NL1')
INSERT [dbo].[tb_Sanpham] ([masp], [tensp], [maloai], [giaban], [hinhanh], [MaNL]) VALUES (N'SP02', N'Cafe đen đá', N'L01', 15000, N'tea.png', N'NL2')
INSERT [dbo].[tb_Sanpham] ([masp], [tensp], [maloai], [giaban], [hinhanh], [MaNL]) VALUES (N'SP03', N'Nước tăng lực', N'L05', 13420, N'NuocTangLuc.png', N'NL3')
INSERT [dbo].[tb_Sanpham] ([masp], [tensp], [maloai], [giaban], [hinhanh], [MaNL]) VALUES (N'SP04', N'Trà gừng', N'L03', 30000, N'traGung.png', N'NL4')
INSERT [dbo].[tb_Sanpham] ([masp], [tensp], [maloai], [giaban], [hinhanh], [MaNL]) VALUES (N'SP05', N'Bánh ngọt', N'L04', 30000, N'cake.png', N'NL5')
INSERT [dbo].[tb_Sanpham] ([masp], [tensp], [maloai], [giaban], [hinhanh], [MaNL]) VALUES (N'SP06', N'Trà Sữa', N'L03', 500000, N'trasua.png', N'NL6')
INSERT [dbo].[tb_Sanpham] ([masp], [tensp], [maloai], [giaban], [hinhanh], [MaNL]) VALUES (N'SP07', N'Cafe Sữa', N'L02', 20000, N'coffee_mug.png', N'NL2')
GO
ALTER TABLE [dbo].[tb_CTHDB]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHDB_tb_HDB] FOREIGN KEY([mahdb])
REFERENCES [dbo].[tb_HDB] ([mahdb])
GO
ALTER TABLE [dbo].[tb_CTHDB] CHECK CONSTRAINT [FK_tb_CTHDB_tb_HDB]
GO
ALTER TABLE [dbo].[tb_CTHDB]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHDB_tb_Sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[tb_Sanpham] ([masp])
GO
ALTER TABLE [dbo].[tb_CTHDB] CHECK CONSTRAINT [FK_tb_CTHDB_tb_Sanpham]
GO
ALTER TABLE [dbo].[tb_CTHDN]  WITH CHECK ADD FOREIGN KEY([mahdn])
REFERENCES [dbo].[tb_HDN] ([mahdn])
GO
ALTER TABLE [dbo].[tb_CTHDN]  WITH CHECK ADD FOREIGN KEY([MaNL])
REFERENCES [dbo].[tb_Nguyenlieu] ([MaNL])
GO
ALTER TABLE [dbo].[tb_HDB]  WITH CHECK ADD  CONSTRAINT [FK_tb_HDB_tb_Ban] FOREIGN KEY([maban])
REFERENCES [dbo].[tb_Ban] ([maban])
GO
ALTER TABLE [dbo].[tb_HDB] CHECK CONSTRAINT [FK_tb_HDB_tb_Ban]
GO
ALTER TABLE [dbo].[tb_HDB]  WITH CHECK ADD  CONSTRAINT [FK_tb_HDB_tb_Khachhang] FOREIGN KEY([makh])
REFERENCES [dbo].[tb_Khachhang] ([makh])
GO
ALTER TABLE [dbo].[tb_HDB] CHECK CONSTRAINT [FK_tb_HDB_tb_Khachhang]
GO
ALTER TABLE [dbo].[tb_HDB]  WITH CHECK ADD  CONSTRAINT [FK_tb_HDB_tb_Nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[tb_Nhanvien] ([manv])
GO
ALTER TABLE [dbo].[tb_HDB] CHECK CONSTRAINT [FK_tb_HDB_tb_Nhanvien]
GO
ALTER TABLE [dbo].[tb_HDN]  WITH CHECK ADD  CONSTRAINT [fk_hdn_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tb_NCC] ([MaNCC])
GO
ALTER TABLE [dbo].[tb_HDN] CHECK CONSTRAINT [fk_hdn_NCC]
GO
ALTER TABLE [dbo].[tb_HDN]  WITH CHECK ADD  CONSTRAINT [fk_hdn_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[tb_Nhanvien] ([manv])
GO
ALTER TABLE [dbo].[tb_HDN] CHECK CONSTRAINT [fk_hdn_nhanvien]
GO
ALTER TABLE [dbo].[tb_Sanpham]  WITH CHECK ADD FOREIGN KEY([MaNL])
REFERENCES [dbo].[tb_Nguyenlieu] ([MaNL])
GO
ALTER TABLE [dbo].[tb_Sanpham]  WITH CHECK ADD  CONSTRAINT [FK_tb_Sanpham_tb_Loai] FOREIGN KEY([maloai])
REFERENCES [dbo].[tb_Loai] ([maloai])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_Sanpham] CHECK CONSTRAINT [FK_tb_Sanpham_tb_Loai]
GO
/****** Object:  StoredProcedure [dbo].[show_BC_DoanhThu]    Script Date: 6/7/2022 3:01:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_BC_DoanhThu] @thang int, @nam int
as
begin
	select tensp, sum(cthdb.thanhtien) as tongtienban, sum(ct_hdn.thanhtien) as tongtiennhap, (sum(cthdb.thanhtien) - sum(ct_hdn.thanhtien)) as doanhthu
	from tb_Sanpham sp, tb_CTHDN ct_hdn, tb_HDB hdb, tb_CTHDB cthdb
	where sp.masp = cthdb.masp and hdb.mahdb = cthdb.mahdb and MONTH(hdb.ngayban) = @thang and YEAR(hdb.ngayban) = @nam
	group by tensp
end
GO
/****** Object:  StoredProcedure [dbo].[show_BC_HDBan]    Script Date: 6/7/2022 3:01:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_BC_HDBan] @mahd int
as
begin
	select hdb.mahdb, tenkh, ngayban, tennv, tensp, soluong, sp.giaban, khuyenmai, thanhtien
	from tb_HDB hdb, tb_CTHDB ct_hdb, tb_Sanpham sp,  tb_Khachhang kh, tb_Nhanvien nv
	where hdb.mahdb = ct_hdb.mahdb and hdb.makh = kh.makh and hdb.manv = nv.manv and ct_hdb.masp = sp.masp
	and hdb.mahdb = @mahd
end
GO
/****** Object:  StoredProcedure [dbo].[show_BC_HDNhap]    Script Date: 6/7/2022 3:01:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_BC_HDNhap] @mahd int
as
begin
	select hdn.mahdn, TenNCC, ngaynhap, tennv, TenNL, nl.soluong, ct_hdn.thanhtien, khuyenmai, (nl.soluong * ct_hdn.thanhtien) as tongtien
	from tb_HDN hdn, tb_CTHDN ct_hdn, tb_Nguyenlieu nl,  tb_NCC ncc, tb_Nhanvien nv
	where hdn.mahdn = ct_hdn.mahdn and hdn.MaNCC = ncc.MaNCC and hdn.manv = nv.manv and ct_hdn.MaNL = nl.MaNL
	and hdn.mahdn = @mahd
end
GO
