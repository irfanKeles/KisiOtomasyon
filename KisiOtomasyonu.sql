USE [KisiTakipotomasyon]
GO
/****** Object:  Table [dbo].[firma]    Script Date: 21.04.2022 01:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[firma](
	[firma_id] [int] IDENTITY(1,1) NOT NULL,
	[firma_ad] [varchar](50) NULL,
	[firma_mail] [varchar](50) NULL,
	[firma_tel] [varchar](50) NULL,
	[firma_adres] [varchar](500) NULL,
	[ref_sehir] [int] NULL,
 CONSTRAINT [PK_fima] PRIMARY KEY CLUSTERED 
(
	[firma_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[kategori]    Script Date: 21.04.2022 01:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[kategori](
	[Kategori_id] [int] IDENTITY(1,1) NOT NULL,
	[Kategori_adi] [varchar](50) NULL,
 CONSTRAINT [PK_Kategori_tbl] PRIMARY KEY CLUSTERED 
(
	[Kategori_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[kullanici]    Script Date: 21.04.2022 01:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[kullanici](
	[Kisi_id] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici_Ad] [varchar](50) NULL,
	[Kullanici_Sifre] [varchar](50) NULL,
	[Kullanici_Durum] [bit] NULL,
	[Kullanici_Admin] [bit] NULL,
 CONSTRAINT [PK_Kisi_tbl] PRIMARY KEY CLUSTERED 
(
	[Kisi_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[musteri]    Script Date: 21.04.2022 01:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[musteri](
	[Musteri_id] [int] IDENTITY(1,1) NOT NULL,
	[Musteri_ad] [varchar](50) NULL,
	[Musteri_soyad] [varchar](50) NULL,
	[Musteri_tel] [varchar](13) NULL,
	[Musteri_adres] [varchar](250) NULL,
	[Musteri_tc] [varchar](11) NULL,
	[Musteri_sehir] [int] NULL,
	[ref_firma] [int] NULL,
 CONSTRAINT [PK_Musteri_tbl] PRIMARY KEY CLUSTERED 
(
	[Musteri_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[satis]    Script Date: 21.04.2022 01:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[satis](
	[Satis_id] [int] IDENTITY(1,1) NOT NULL,
	[Satis_adet] [int] NULL,
	[Satis_tutar] [int] NULL,
	[Satis_tarih] [datetime] NULL,
	[Satis_aciklama] [varchar](50) NULL,
	[ref_musteri] [int] NULL,
	[ref_urun] [int] NULL,
	[ref_kullanici] [int] NULL,
 CONSTRAINT [PK_Satis_tbl] PRIMARY KEY CLUSTERED 
(
	[Satis_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sehir]    Script Date: 21.04.2022 01:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sehir](
	[Sehir_id] [int] IDENTITY(1,1) NOT NULL,
	[Sehir_ad] [varchar](20) NULL,
 CONSTRAINT [PK_Sehir_tbl] PRIMARY KEY CLUSTERED 
(
	[Sehir_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[urun]    Script Date: 21.04.2022 01:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[urun](
	[Urun_id] [int] IDENTITY(1,1) NOT NULL,
	[Urun_ad] [varchar](50) NULL,
	[Urun_aciklama] [varchar](250) NULL,
	[Urun_fiyat] [varchar](50) NULL,
	[ref_katagori] [int] NULL,
 CONSTRAINT [PK_Urun_tbl] PRIMARY KEY CLUSTERED 
(
	[Urun_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[firma] ON 

INSERT [dbo].[firma] ([firma_id], [firma_ad], [firma_mail], [firma_tel], [firma_adres], [ref_sehir]) VALUES (2, N'Arçelik', N'arcelik@gmail.com', N'0548554454', N'Antalya/MuratPaşa ', 4)
INSERT [dbo].[firma] ([firma_id], [firma_ad], [firma_mail], [firma_tel], [firma_adres], [ref_sehir]) VALUES (3, N'Vestel', N'vestel@gmail.com', N'05324550368', N'Samsun / Bafra ', 8)
INSERT [dbo].[firma] ([firma_id], [firma_ad], [firma_mail], [firma_tel], [firma_adres], [ref_sehir]) VALUES (4, N'Olcay Makina', N'olcay_makina@gmail.c', N'05423759230', N'Çorum / Sungurlu', 1)
INSERT [dbo].[firma] ([firma_id], [firma_ad], [firma_mail], [firma_tel], [firma_adres], [ref_sehir]) VALUES (5, N'Beko', N'beko@gmail.com', N'03543545454', N'', 3)
INSERT [dbo].[firma] ([firma_id], [firma_ad], [firma_mail], [firma_tel], [firma_adres], [ref_sehir]) VALUES (6, N'Control Center', N'c_c@gmail.com', N'06575454545', N'Konya / Merkez', 7)
SET IDENTITY_INSERT [dbo].[firma] OFF
SET IDENTITY_INSERT [dbo].[kategori] ON 

INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (1, N'Beyaz Eşya')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (2, N'Bilgisayar')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (3, N'Mobilya')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (4, N'Hırdavat')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (5, N'Elektironik')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (7, N'Makyaj Malzeme')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (12, N'Temizlik')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (13, N'Giyim')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (14, N'Mutfak Aletleri')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (15, N'Telefon')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (16, N'Dekarasyon')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (17, N'Gıda')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (18, N'Oyun Konsolu')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (19, N'Tv Ünitesi')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (20, N'Ses Sitemleri')
INSERT [dbo].[kategori] ([Kategori_id], [Kategori_adi]) VALUES (21, N'addd')
SET IDENTITY_INSERT [dbo].[kategori] OFF
SET IDENTITY_INSERT [dbo].[kullanici] ON 

INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (1, N'İrfan', N'1', 1, 1)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (2, N'İsa', N'15963', 1, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (3, N'Ebru', N'147852', 1, 1)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (4, N'Beyza', N'126984', 0, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (5, N'Berat', N'berat1', 0, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (6, N'Elvan', N'0619123', 0, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (7, N'Eren', N'1234', 1, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (8, N'Ezgi', N'123213', 1, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (9, N'Alperen', N'6976', 1, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (10, N'Emre', N'32421', 1, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (11, N'Enes', N'432', 1, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (12, N'Aynur', N'65744', 1, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (13, N'Ertan', N'er19tan06', 1, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (14, N'Kullamıcı19', N'1', 1, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (15, N'q', N'q', 1, 1)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (16, N'irfan', N'2', 1, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (17, N'deneme', N'1234', 1, 0)
INSERT [dbo].[kullanici] ([Kisi_id], [Kullanici_Ad], [Kullanici_Sifre], [Kullanici_Durum], [Kullanici_Admin]) VALUES (18, N'Yağmur', N'8892', 1, 1)
SET IDENTITY_INSERT [dbo].[kullanici] OFF
SET IDENTITY_INSERT [dbo].[musteri] ON 

INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (1, N'İrfan', N'keleş', N'05313313131', N'Çorum / Merkez', N'11111111111', 1, 3)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (2, N'Ebru', N'Demiral', N'05555555555', N'Çorum / Merkez', N'22222222222', 1, 4)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (3, N'İsa', N'ırız', N'05366666666', N'', N'33333333333', 3, 4)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (4, N'Meriç', N'Aslan', N'08888888888', N'Rize / Merkez', N'44444444444', 5, 3)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (7, N'Eren', N'Arslan', N'06668888888', N'İstanbul / Merkez Xxx.sokak 15/3', N'55555555555', 3, 2)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (8, N'Beyza', N'Bakar', N'03333333333', N'İzmir / Çeşme ', N'66666666666', 6, 4)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (9, N'Alperen', N'Eker', N'09999999999', N'Konya / Merkez', N'77777777777', 1, 3)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (10, N'Aleyna', N'Bektaş', N'07850000000', N'Ankara / Mamak', N'88888888888', 2, 2)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (11, N'Hatice', N'Benli', N'06358444444', N'', N'99999999999', 9, 2)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (12, N'Burhan', N'Dikmen', N'06548978454', N'Ağrı / Merkez', N'10111555555', 10, 3)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (13, N'Ezgi', N'Altaş', N'08978956465', N'Bodrum / Merkez', N'11654654132', 15, 4)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (14, N'Berat', N'Kantırancı', N'06354684545', N'Samsun / Merkez', N'65464654531', 8, 2)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (15, N'Alper', N'Çeşmebaşı', N'06876465456', N'Iğdır / Mekez', N'35436874352', 11, 3)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (16, N'Emre ', N'Demiral', N'06534654878', N'Uşak / Merkez', N'96545234168', 16, 3)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (17, N'Esengül', N'Ünsal', N'08468786648', N'KahramanMaraş / Merkez', N'35741847853', 12, 4)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (18, N'Uğur', N'Aslan', N'06768748768', N'İzmir / Merkez', N'65437443214', 6, 3)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (19, N'Enes', N'Bahadır', N'03676874132', N'Rize / Merkez', N'35748715242', 5, 2)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (20, N'hüseyin', N'özertekin', N'08474687354', N'Kars / Merkez', N'68714875176', 13, 4)
INSERT [dbo].[musteri] ([Musteri_id], [Musteri_ad], [Musteri_soyad], [Musteri_tel], [Musteri_adres], [Musteri_tc], [Musteri_sehir], [ref_firma]) VALUES (21, N'Nufel', N'Eğinci', N'03543564354', N'İzmir / Merkez', N'35425453453', 6, 2)
SET IDENTITY_INSERT [dbo].[musteri] OFF
SET IDENTITY_INSERT [dbo].[satis] ON 

INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (1, 2, 3000, CAST(N'2022-04-18 00:00:00.000' AS DateTime), N'Fırsat Ürünü', 2, 1, 1)
INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (2, 2, 540, CAST(N'2022-04-18 00:00:00.000' AS DateTime), N'', 3, 8, 1)
INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (3, 2, 100, CAST(N'2022-04-18 00:00:00.000' AS DateTime), N'Ace', 10, 19, 3)
INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (4, 1, 3500, CAST(N'2022-04-18 00:00:00.000' AS DateTime), N'Hediye', 13, 16, 3)
INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (5, 3, 150, CAST(N'2022-04-18 00:00:00.000' AS DateTime), N'Torku Mercimek', 11, 18, 7)
INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (6, 2, 1000, CAST(N'2022-04-18 00:00:00.000' AS DateTime), N'Yeşil ve mavi çadır.', 1, 12, 5)
INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (7, 1, 5000, CAST(N'2022-04-18 00:00:00.000' AS DateTime), N'Duvar Montalı Kitap', 14, 9, 12)
INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (8, 1, 3500, CAST(N'2022-04-18 00:00:00.000' AS DateTime), N'Gold 16 GB', 7, 7, 10)
INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (9, 2, 27998, CAST(N'2022-04-18 00:00:00.000' AS DateTime), N'16 GB RAM 1650Ti 8 GB EKRAN KARTI', 19, 14, 9)
INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (10, 2, 11000, CAST(N'2022-04-18 00:00:00.000' AS DateTime), N'Sİyah Karbon Kaplama', 20, 10, 6)
INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (11, 4, 20000, CAST(N'2022-04-18 00:00:00.000' AS DateTime), N'Siyah , Mavi, Bej, Kırmızı  ', 9, 15, 4)
INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (12, 2, 1000, CAST(N'2022-04-20 00:00:00.000' AS DateTime), N'deneme', 7, 21, 1)
INSERT [dbo].[satis] ([Satis_id], [Satis_adet], [Satis_tutar], [Satis_tarih], [Satis_aciklama], [ref_musteri], [ref_urun], [ref_kullanici]) VALUES (13, 2, 7000, CAST(N'2022-04-20 00:00:00.000' AS DateTime), N'Gold rengi', 12, 7, 1)
SET IDENTITY_INSERT [dbo].[satis] OFF
SET IDENTITY_INSERT [dbo].[sehir] ON 

INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (1, N'Çorum')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (2, N'Ankara')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (3, N'İstanbul')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (4, N'Antalya')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (5, N'Rize')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (6, N'İzmir')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (7, N'Konya')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (8, N'Samsun')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (9, N'Sinop')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (10, N'Ağrı')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (11, N'Iğdır')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (12, N'KahramanMaraş')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (13, N'Kars')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (14, N'Burdur')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (15, N'Bodrum')
INSERT [dbo].[sehir] ([Sehir_id], [Sehir_ad]) VALUES (16, N'Uşak')
SET IDENTITY_INSERT [dbo].[sehir] OFF
SET IDENTITY_INSERT [dbo].[urun] ON 

INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (1, N'Masa', N'yemek masası', N'1500', 3)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (2, N'Ütü', N'Simbo', N'2500', 1)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (3, N'Kulaklık', N'DeepBass', N'50', 5)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (5, N'Detejran', N'Kosla', N'150', 12)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (6, N'Tişört', N'Kadın Tişört', N'55', 13)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (7, N'Samsung 7', N'', N'3500', 15)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (8, N'Biblo bebek', N'Siyah Bebek', N'270', 16)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (9, N'Kitaplık', N'Askılı Kitaplık', N'5000', 3)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (10, N'Dİreksiyon seti', N'Ototmatik vites kutulu', N'5500', 18)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (11, N'Prinç', N'1 Kg', N'50', 17)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (12, N'Kamp Çadırı', N'2 Kişilik Yeşil', N'500', 4)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (13, N'Sİyah oje', N'', N'25', 7)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (14, N'Monster Notebokk', N'Abra serisi', N'13999', 2)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (15, N'1m x 1m duvar akısı', N'Tv duvar askısı led ışıklı', N'5000', 19)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (16, N'Mutfak Robotu', N'Arzum', N'3500', 14)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (17, N'16 lı torna vida set', N'Çelik gövde plastik aşlıklı', N'150', 4)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (18, N'Mercimek', N'1 Kg', N'50', 17)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (19, N'Çamaşır Suyu', N'Ace', N'50', 12)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (20, N'Kokulu Mum', N'Her renk mevcut', N'50', 16)
INSERT [dbo].[urun] ([Urun_id], [Urun_ad], [Urun_aciklama], [Urun_fiyat], [ref_katagori]) VALUES (21, N'Ruj Seti', N'Siyah, Kırmızı, Mavi ...', N'500', 7)
SET IDENTITY_INSERT [dbo].[urun] OFF
