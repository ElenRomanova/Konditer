USE [PastryShop]
GO
/****** Object:  Table [dbo].[Cheque]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cheque](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Count] [int] NULL,
	[IdWachPow] [int] NULL,
	[IdWachMac] [int] NULL,
	[IdWashing] [int] NULL,
	[IdScore] [int] NULL,
	[IdReport] [int] NULL,
 CONSTRAINT [PK_Cheki-Briki] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Composition]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Composition](
	[IdComposition] [int] IDENTITY(1,1) NOT NULL,
	[IdIngredients] [int] NOT NULL,
	[IdProduct] [int] NOT NULL,
 CONSTRAINT [PK_Composition] PRIMARY KEY CLUSTERED 
(
	[IdComposition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drying]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drying](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[IdWashingMachines] [int] NULL,
 CONSTRAINT [PK_Syshka] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingredients]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredients](
	[IdIngredients] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[IdProvder] [int] NOT NULL,
	[IdUnitMeasurement] [int] NOT NULL,
	[Weight] [float] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Ingredients] PRIMARY KEY CLUSTERED 
(
	[IdIngredients] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[IdProduct] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [money] NOT NULL,
	[Masa] [float] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[provider]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[provider](
	[IdProvider] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Adress] [nvarchar](max) NOT NULL,
	[Telephone] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_provider] PRIMARY KEY CLUSTERED 
(
	[IdProvider] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Report]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CountWashing] [int] NULL,
	[SumNal] [int] NULL,
	[SumBeznal] [nchar](10) NULL,
 CONSTRAINT [PK_Otchet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id_Role] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id_Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Score]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Score](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rachel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Count] [nvarchar](50) NULL,
	[Price] [nvarchar](50) NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](max) NULL,
	[FirstName] [nvarchar](max) NULL,
	[MiddleName] [nvarchar](max) NULL,
	[Login] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Role] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnitMeasurement]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnitMeasurement](
	[IdUnitMeasurement] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_UnitMeasurement] PRIMARY KEY CLUSTERED 
(
	[IdUnitMeasurement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Washing]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Washing](
	[IdWashing] [int] IDENTITY(1,1) NOT NULL,
	[IdService] [int] NULL,
	[IdDrying] [int] NULL,
	[IdStaff] [int] NULL,
	[IdStatus] [int] NULL,
	[IdScore] [int] NULL,
	[IdReport] [int] NULL,
	[IdWashingMachines] [int] NULL,
	[IdWashingPowser] [int] NULL,
 CONSTRAINT [PK_Stirki] PRIMARY KEY CLUSTERED 
(
	[IdWashing] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WashingMachines]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WashingMachines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [nvarchar](50) NULL,
 CONSTRAINT [PK_Washing machines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WashingPowder]    Script Date: 08.02.2022 18:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WashingPowder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [nvarchar](50) NULL,
 CONSTRAINT [PK_WashingPowder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Composition] ON 

INSERT [dbo].[Composition] ([IdComposition], [IdIngredients], [IdProduct]) VALUES (36, 1009, 1012)
INSERT [dbo].[Composition] ([IdComposition], [IdIngredients], [IdProduct]) VALUES (37, 3, 1013)
INSERT [dbo].[Composition] ([IdComposition], [IdIngredients], [IdProduct]) VALUES (38, 1009, 1013)
INSERT [dbo].[Composition] ([IdComposition], [IdIngredients], [IdProduct]) VALUES (42, 1012, 1014)
INSERT [dbo].[Composition] ([IdComposition], [IdIngredients], [IdProduct]) VALUES (44, 1009, 1015)
INSERT [dbo].[Composition] ([IdComposition], [IdIngredients], [IdProduct]) VALUES (47, 3, 1012)
INSERT [dbo].[Composition] ([IdComposition], [IdIngredients], [IdProduct]) VALUES (50, 1008, 1012)
SET IDENTITY_INSERT [dbo].[Composition] OFF
GO
SET IDENTITY_INSERT [dbo].[Ingredients] ON 

INSERT [dbo].[Ingredients] ([IdIngredients], [Name], [IdProvder], [IdUnitMeasurement], [Weight], [Price]) VALUES (3, N'Сахар', 6, 1, 4, 5000.0000)
INSERT [dbo].[Ingredients] ([IdIngredients], [Name], [IdProvder], [IdUnitMeasurement], [Weight], [Price]) VALUES (1008, N'Ванилин', 2007, 3, 123, 234.0000)
INSERT [dbo].[Ingredients] ([IdIngredients], [Name], [IdProvder], [IdUnitMeasurement], [Weight], [Price]) VALUES (1009, N'Вода', 6, 2, 12, 3000.0000)
INSERT [dbo].[Ingredients] ([IdIngredients], [Name], [IdProvder], [IdUnitMeasurement], [Weight], [Price]) VALUES (1012, N'Паста Шоколадная', 2007, 1, 120, 28373.0000)
INSERT [dbo].[Ingredients] ([IdIngredients], [Name], [IdProvder], [IdUnitMeasurement], [Weight], [Price]) VALUES (1016, N'Молоко', 6, 3, 12, 111.0000)
INSERT [dbo].[Ingredients] ([IdIngredients], [Name], [IdProvder], [IdUnitMeasurement], [Weight], [Price]) VALUES (1019, N'Фундук', 2007, 1, 40, 120.0000)
SET IDENTITY_INSERT [dbo].[Ingredients] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([IdProduct], [Name], [Price], [Masa]) VALUES (1012, N'Мармелад', 1500.0000, 122)
INSERT [dbo].[Product] ([IdProduct], [Name], [Price], [Masa]) VALUES (1013, N'Конфеты ', 45.0000, 3)
INSERT [dbo].[Product] ([IdProduct], [Name], [Price], [Masa]) VALUES (1014, N'Вафли шоколадные', 5.0000, 54)
INSERT [dbo].[Product] ([IdProduct], [Name], [Price], [Masa]) VALUES (1015, N'аа', 45.0000, 34)
INSERT [dbo].[Product] ([IdProduct], [Name], [Price], [Masa]) VALUES (1017, N'Яблоки', 459.0000, 300)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[provider] ON 

INSERT [dbo].[provider] ([IdProvider], [Name], [Adress], [Telephone], [Email]) VALUES (6, N'ООО"КарамелькаИСласть"', N'Г. Новосибирск', N'+394776646', N'4@gmail.com')
INSERT [dbo].[provider] ([IdProvider], [Name], [Adress], [Telephone], [Email]) VALUES (2007, N'ООО"Вкусности"', N'г. Новосибирск, ул. Пушкина, д. 43', N'+898288282', N'Vkusn@gmail.com')
INSERT [dbo].[provider] ([IdProvider], [Name], [Adress], [Telephone], [Email]) VALUES (2008, N'ООО«Добрые традиции»', N'Г. Новосибирск', N'+79009385884', N'DobrNov00@gmail.com')
SET IDENTITY_INSERT [dbo].[provider] OFF
GO
SET IDENTITY_INSERT [dbo].[UnitMeasurement] ON 

INSERT [dbo].[UnitMeasurement] ([IdUnitMeasurement], [Name]) VALUES (1, N'кг')
INSERT [dbo].[UnitMeasurement] ([IdUnitMeasurement], [Name]) VALUES (2, N'л')
INSERT [dbo].[UnitMeasurement] ([IdUnitMeasurement], [Name]) VALUES (3, N'гр')
INSERT [dbo].[UnitMeasurement] ([IdUnitMeasurement], [Name]) VALUES (4, N'мл')
SET IDENTITY_INSERT [dbo].[UnitMeasurement] OFF
GO
ALTER TABLE [dbo].[Cheque]  WITH CHECK ADD  CONSTRAINT [FK_Cheki-Briki_Service] FOREIGN KEY([IdWachPow])
REFERENCES [dbo].[Service] ([Id])
GO
ALTER TABLE [dbo].[Cheque] CHECK CONSTRAINT [FK_Cheki-Briki_Service]
GO
ALTER TABLE [dbo].[Cheque]  WITH CHECK ADD  CONSTRAINT [FK_Cheki-Briki_Syshka] FOREIGN KEY([IdWachMac])
REFERENCES [dbo].[Drying] ([Id])
GO
ALTER TABLE [dbo].[Cheque] CHECK CONSTRAINT [FK_Cheki-Briki_Syshka]
GO
ALTER TABLE [dbo].[Cheque]  WITH CHECK ADD  CONSTRAINT [FK_Cheque_Report] FOREIGN KEY([IdReport])
REFERENCES [dbo].[Report] ([Id])
GO
ALTER TABLE [dbo].[Cheque] CHECK CONSTRAINT [FK_Cheque_Report]
GO
ALTER TABLE [dbo].[Cheque]  WITH CHECK ADD  CONSTRAINT [FK_Cheque_Score] FOREIGN KEY([IdScore])
REFERENCES [dbo].[Score] ([Id])
GO
ALTER TABLE [dbo].[Cheque] CHECK CONSTRAINT [FK_Cheque_Score]
GO
ALTER TABLE [dbo].[Cheque]  WITH CHECK ADD  CONSTRAINT [FK_Cheque_Washing] FOREIGN KEY([IdWashing])
REFERENCES [dbo].[Washing] ([IdWashing])
GO
ALTER TABLE [dbo].[Cheque] CHECK CONSTRAINT [FK_Cheque_Washing]
GO
ALTER TABLE [dbo].[Composition]  WITH CHECK ADD  CONSTRAINT [FK_Composition_Ingredients] FOREIGN KEY([IdIngredients])
REFERENCES [dbo].[Ingredients] ([IdIngredients])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Composition] CHECK CONSTRAINT [FK_Composition_Ingredients]
GO
ALTER TABLE [dbo].[Composition]  WITH CHECK ADD  CONSTRAINT [FK_Composition_Product] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Product] ([IdProduct])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Composition] CHECK CONSTRAINT [FK_Composition_Product]
GO
ALTER TABLE [dbo].[Drying]  WITH CHECK ADD  CONSTRAINT [FK_Drying_WashingMachines] FOREIGN KEY([IdWashingMachines])
REFERENCES [dbo].[WashingMachines] ([Id])
GO
ALTER TABLE [dbo].[Drying] CHECK CONSTRAINT [FK_Drying_WashingMachines]
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD  CONSTRAINT [FK_Ingredients_provider] FOREIGN KEY([IdProvder])
REFERENCES [dbo].[provider] ([IdProvider])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ingredients] CHECK CONSTRAINT [FK_Ingredients_provider]
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD  CONSTRAINT [FK_Ingredients_UnitMeasurement] FOREIGN KEY([IdUnitMeasurement])
REFERENCES [dbo].[UnitMeasurement] ([IdUnitMeasurement])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ingredients] CHECK CONSTRAINT [FK_Ingredients_UnitMeasurement]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Role] FOREIGN KEY([Role])
REFERENCES [dbo].[Role] ([Id_Role])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Role]
GO
ALTER TABLE [dbo].[Washing]  WITH CHECK ADD  CONSTRAINT [FK_Stirki_Employee] FOREIGN KEY([IdStaff])
REFERENCES [dbo].[Staff] ([Id])
GO
ALTER TABLE [dbo].[Washing] CHECK CONSTRAINT [FK_Stirki_Employee]
GO
ALTER TABLE [dbo].[Washing]  WITH CHECK ADD  CONSTRAINT [FK_Stirki_Service] FOREIGN KEY([IdService])
REFERENCES [dbo].[Service] ([Id])
GO
ALTER TABLE [dbo].[Washing] CHECK CONSTRAINT [FK_Stirki_Service]
GO
ALTER TABLE [dbo].[Washing]  WITH CHECK ADD  CONSTRAINT [FK_Stirki_Status] FOREIGN KEY([IdStatus])
REFERENCES [dbo].[Status] ([Id])
GO
ALTER TABLE [dbo].[Washing] CHECK CONSTRAINT [FK_Stirki_Status]
GO
ALTER TABLE [dbo].[Washing]  WITH CHECK ADD  CONSTRAINT [FK_Stirki_Syshka] FOREIGN KEY([IdDrying])
REFERENCES [dbo].[Drying] ([Id])
GO
ALTER TABLE [dbo].[Washing] CHECK CONSTRAINT [FK_Stirki_Syshka]
GO
ALTER TABLE [dbo].[Washing]  WITH CHECK ADD  CONSTRAINT [FK_Washing_WashingMachines] FOREIGN KEY([IdWashingMachines])
REFERENCES [dbo].[WashingMachines] ([Id])
GO
ALTER TABLE [dbo].[Washing] CHECK CONSTRAINT [FK_Washing_WashingMachines]
GO
ALTER TABLE [dbo].[Washing]  WITH CHECK ADD  CONSTRAINT [FK_Washing_WashingPowder] FOREIGN KEY([IdWashingPowser])
REFERENCES [dbo].[WashingPowder] ([Id])
GO
ALTER TABLE [dbo].[Washing] CHECK CONSTRAINT [FK_Washing_WashingPowder]
GO
