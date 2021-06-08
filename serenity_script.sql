USE [SerenityDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 8.06.2021 14:25:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 8.06.2021 14:25:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Birthdate] [datetime] NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](12) NULL,
	[Adress] [nvarchar](500) NULL,
 CONSTRAINT [PK_dbo.Members] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202106070927403_AutomaticMigration', N'SerenityProje.DataAccessLayer.Migrations.Configuration', 0x1F8B0800000000000400CD58DB6EE336107D2FD07F10F4D40259331714E806F22EB24E52048D936095DDF7B134B6D952A44A52A9FD6D7DE827F5173AD4FD12DF92DDC5C280215133672E240F8FF4DF3FFF06EF5789F09E501BAEE4D83F191DFB1ECA48C55C2EC67E66E76F7EF5DFBFFBF187E02A4E56DEE7CAEECCD991A734637F696D7ACE988996988019253CD2CAA8B91D452A61102B767A7CFC969D9C3024089FB03C2FF89849CB13CC6FE876A26484A9CD404C558CC294E3F424CC51BD3B48D0A410E1D80F51A3E476FDA0D51F38BA040B175184C6DCC21AF588902CAEACEF5D080EC6598BB9EF8194CA82A5D4CF3F190CAD567211A63400E2719D22D9CD41182C4B3A6FCCF7ADEEF8D455C71AC70A2ACA8C55C98180276765BB58DFFD454DF7EB765243AFA8F176EDAACE9B3AF6A798CC50FB5E3FD4F9446867D6EB7864470544D1EFFC9AA319153047DE16E3A37AFDD03273BF236F92099B691C4BCCAC0671E43D6433C1A3DF71FDA8FE4439969910EDF4A9007AD619A0218A95A2B6EB8F382F8BBA897D8F75FD58DFB1766BF91405DF487B76EA7B77141C6602EBD5D16A4E6895C6DF50A2068BF103588B5A3A0CCCEB1D44EFC572FF55345A8EB4D97C6F0AAB5B940BBBA4398195EF5DF315C6D54899C127C9696F9293D519EE0A12665A7E8B381FB8B6CB98FA5045A24D898FDC451EB4703BD255025C7CF57C1FC098BF958EB704FAE5F84BC4592A897759B1BDBE724D17B1260EDC5AD1E12505AC618B218738AA054E3BA05A6EE5CEAF2978C028C4BD25A998325CB7A6023744DBA126AAAA49A360F451455ACF655BE7D59C22AC3846AAE3866D386F8229A42935AE75FE94235E581C3E9337E1E1149C14182C32CF30719D6D1D89980516D87B4AA129D36BAE8D7547DE0CDCD44DE26460D69F850D1DAEA2751BDD27D6A6EF95BDBBEE4EF7D673B89AA81E70D3D86BAA3521CECCCBC63ABDFA581A38E69A0004E867D87BA24496C84D27C036EF828FDBFEC5C8FE0835D9B641EAC1FD715A64DA466A0DEF8F55D2691BA71CDA1FA321CB364C337A00529B0E3B60ED07FBE35594D786AAC6862801EBADB8FE5A6783C5DED30FFDBDB38D7AFA2675F49A827A541394DB7EB7FE1DF04061E27BD49E271EE71CB03616937C4F8EC2BFC44470AAB7319882E47334B690583EE9CDD39E5EFE7EB42B3326167B09D86FAE12B9EBE94E1D78A0026A0B43F9043A5A82FE2981D5CF6DA41788BF57610D049EBBB6AF1678AFCAA92FE22AB0818C3B1076A8D95E956657976D4872479687C9B0A14ED847646DD15805BFD0A4CF14D55124592BB3170AB021DB05ACFD4D20B844C3170D84FB4220E9759268A401AD6C6EE45C556DA7BADA195526BD5999A285D829166DF91C224B8F9D74C935F3671059BE526718DFC8FBCCA699BD30860A169DD7BA806D8F9FABCC6ECEC17DEAEECC972881D2E46E1BDECB0F1917719DF7F5701B6E82702BA5A42ECA8ADE19086EB1AE91EE6827EC0754B6EF1253948EF81E31490581997B19C213BE24377A55B8C50544EBEAD0DA0CB27B22BA6D0F2E392C3424A6C468FCDD772EE63E74BDFB1F8FCA83C51A130000, N'6.4.4')
SET IDENTITY_INSERT [dbo].[Members] ON 

INSERT [dbo].[Members] ([Id], [Name], [Surname], [Birthdate], [Email], [Password], [PhoneNumber], [Adress]) VALUES (2, N'Ali', N'Cengiz', CAST(N'2021-01-06T00:00:00.000' AS DateTime), N'alicengiz@hotmail.com', N'Ac12345678', N'5551111111', N'test adres')
INSERT [dbo].[Members] ([Id], [Name], [Surname], [Birthdate], [Email], [Password], [PhoneNumber], [Adress]) VALUES (6, N'Cem', N'Can', CAST(N'2021-03-06T00:00:00.000' AS DateTime), N'cemcan@hotmail.com', N'Cc12345678', N'5551111111', N'test adres')
INSERT [dbo].[Members] ([Id], [Name], [Surname], [Birthdate], [Email], [Password], [PhoneNumber], [Adress]) VALUES (7, N'Cenk', N'Ahmet', CAST(N'2021-06-05T00:00:00.000' AS DateTime), N'cenk@hotmail.com', N'Ca12345678', N'2623227577', N'test')
INSERT [dbo].[Members] ([Id], [Name], [Surname], [Birthdate], [Email], [Password], [PhoneNumber], [Adress]) VALUES (8, N'aaa', N'Candan', CAST(N'2017-07-12T00:00:00.000' AS DateTime), N'dd@gmail.com', N'Dd12345678', N'12345678998', N'text')
INSERT [dbo].[Members] ([Id], [Name], [Surname], [Birthdate], [Email], [Password], [PhoneNumber], [Adress]) VALUES (10, N'Mehmet', N'Çiçek', CAST(N'2000-03-22T18:32:00.000' AS DateTime), N'mehmetcicek@gmail.com', N'Mc12345678', N'1234567899', N'test')
INSERT [dbo].[Members] ([Id], [Name], [Surname], [Birthdate], [Email], [Password], [PhoneNumber], [Adress]) VALUES (11, N'Kemal', N'Durmaz', CAST(N'2021-06-03T00:00:00.000' AS DateTime), N'kemaldurmaz@hotmail.com', N'Kd12345678', N'1234567898', N'test')
SET IDENTITY_INSERT [dbo].[Members] OFF
