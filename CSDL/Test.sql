USE [Test]
GO
/****** Object:  Table [dbo].[tblLopHoc]    Script Date: 11/28/2020 9:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLopHoc](
	[MaLop] [nchar](100) NOT NULL,
	[TenLop] [ntext] NULL,
	[DiaChi] [ntext] NULL,
 CONSTRAINT [PK_tblLopHoc] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 11/28/2020 9:01:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSinhVien](
	[MaSV] [nchar](10) NOT NULL,
	[TenSV] [nchar](100) NULL,
	[DiaChi] [ntext] NULL,
	[SDT] [nchar](15) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
 CONSTRAINT [PK_tblSinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [DiaChi]) VALUES (N'001                                                                                                 ', N'toan', N'p001')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [DiaChi]) VALUES (N'002                                                                                                 ', N'Ly', N'p002')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [DiaChi]) VALUES (N'asdas                                                                                               ', N'asdasdas', N'asdasdas')
INSERT [dbo].[tblSinhVien] ([MaSV], [TenSV], [DiaChi], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'23423423  ', N'asda                                                                                                ', N'SDFSD', N'asdasdasd      ', CAST(N'2020-11-26T20:25:20.000' AS DateTime), 1)
INSERT [dbo].[tblSinhVien] ([MaSV], [TenSV], [DiaChi], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'asdas     ', N'asda                                                                                                ', N'SDFSD', N'asdasdasd      ', CAST(N'2020-11-26T20:25:20.000' AS DateTime), 1)
INSERT [dbo].[tblSinhVien] ([MaSV], [TenSV], [DiaChi], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'asdas da  ', N'asdas                                                                                               ', N'asdasdas', N'423423as       ', CAST(N'2020-11-28T18:35:45.000' AS DateTime), 1)
INSERT [dbo].[tblSinhVien] ([MaSV], [TenSV], [DiaChi], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'asdasdas  ', N'asdas                                                                                               ', N'asdasdas', N'asdasdas       ', CAST(N'2020-11-28T18:35:56.000' AS DateTime), 1)
INSERT [dbo].[tblSinhVien] ([MaSV], [TenSV], [DiaChi], [SDT], [NgaySinh], [GioiTinh]) VALUES (N'sdfsdfsdq ', N'sdfdsd                                                                                              ', N'asdfasdas', N'34534534534    ', CAST(N'2020-11-28T18:39:19.000' AS DateTime), 1)
