USE [HagJob]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 28/06/2022 2:10:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[adressses]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adressses](
	[UserId] [nvarchar](450) NOT NULL,
	[Country] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NOT NULL,
	[Street] [nvarchar](max) NOT NULL,
	[ZipCode] [int] NOT NULL,
 CONSTRAINT [PK_adressses] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplyJobs]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplyJobs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Question1] [nvarchar](max) NULL,
	[Question2] [nvarchar](max) NULL,
	[Question3] [nvarchar](max) NULL,
	[Question4] [nvarchar](max) NULL,
	[Question5] [nvarchar](max) NULL,
	[jobsId] [int] NOT NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_ApplyJobs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[ApplicationUserId] [nvarchar](450) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[Department_Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feelings]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feelings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[YourFeeling] [nvarchar](max) NULL,
 CONSTRAINT [PK_Feelings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jobs]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jobs](
	[Job_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Requriments] [nvarchar](max) NOT NULL,
	[Skills] [nvarchar](max) NOT NULL,
	[Education] [nvarchar](max) NOT NULL,
	[JobDescription] [nvarchar](max) NOT NULL,
	[CompanyName] [nvarchar](max) NOT NULL,
	[Location] [nvarchar](max) NOT NULL,
	[Experience] [nvarchar](max) NOT NULL,
	[Time] [nvarchar](max) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Salary] [nvarchar](max) NULL,
	[Statues] [bit] NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[DepId] [int] NOT NULL,
 CONSTRAINT [PK_jobs] PRIMARY KEY CLUSTERED 
(
	[Job_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[post]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[post](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Mention] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NULL,
	[FeelingId] [int] NULL,
	[DateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_post] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[questions]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[questions](
	[Job_Id] [int] NOT NULL,
	[Question1] [nvarchar](max) NULL,
	[Question2] [nvarchar](max) NULL,
	[Question3] [nvarchar](max) NULL,
	[Question4] [nvarchar](max) NULL,
	[Question5] [nvarchar](max) NULL,
 CONSTRAINT [PK_questions] PRIMARY KEY CLUSTERED 
(
	[Job_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userInformation]    Script Date: 28/06/2022 2:10:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userInformation](
	[UserId] [nvarchar](450) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[JobTitle] [nvarchar](max) NOT NULL,
	[Photo] [nvarchar](max) NOT NULL,
	[CV] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_userInformation] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220419132538_First', N'5.0.12')
GO
INSERT [dbo].[adressses] ([UserId], [Country], [City], [Street], [ZipCode]) VALUES (N'4866dbf1-970d-40af-80c9-dbfbeb6353e4', N'مصر', N'Banisuaf', N'Somosta', 1234)
INSERT [dbo].[adressses] ([UserId], [Country], [City], [Street], [ZipCode]) VALUES (N'56f6dd56-50c0-4bf5-b125-a94ad0380f38', N'مصر', N'Banisuaf', N'Somosta', 1234)
INSERT [dbo].[adressses] ([UserId], [Country], [City], [Street], [ZipCode]) VALUES (N'6d57c8f2-3b78-4fee-a23d-66016943f465', N'مصر', N'Banisuaf5555', N'Somosta', 1234)
INSERT [dbo].[adressses] ([UserId], [Country], [City], [Street], [ZipCode]) VALUES (N'6f9c2734-4c66-400f-b5de-b63ec32d43e8', N'مصر', N'Banisuaf', N'Somosta', 1234)
INSERT [dbo].[adressses] ([UserId], [Country], [City], [Street], [ZipCode]) VALUES (N'8009162f-de27-4f93-a096-a46992214f37', N'مصر', N'Banisuaf', N'Somosta', 1234)
INSERT [dbo].[adressses] ([UserId], [Country], [City], [Street], [ZipCode]) VALUES (N'876a91de-c680-4a76-a94b-4cbd4e981ea4', N'مصر', N'Banisuaf', N'Somosta', 1234)
INSERT [dbo].[adressses] ([UserId], [Country], [City], [Street], [ZipCode]) VALUES (N'b64b3a25-d204-4adc-ace5-58dca6f4aa6d', N'مصر', N'Banisuaf', N'Somosta', 1234)
INSERT [dbo].[adressses] ([UserId], [Country], [City], [Street], [ZipCode]) VALUES (N'fab842eb-b5a1-4eaa-bc5c-ca3c566ace92', N'مصر', N'Banisuaf', N'Somosta', 1234)
GO
SET IDENTITY_INSERT [dbo].[ApplyJobs] ON 

INSERT [dbo].[ApplyJobs] ([Id], [Question1], [Question2], [Question3], [Question4], [Question5], [jobsId], [UserId]) VALUES (1, N'kh', N'how much have Experiece With Paython Language? ', N'how much have Experiece With Entity Framwork? ', N'Do You Work with Crystal Report Befor ? ', N'sd2', 1, N'fab842eb-b5a1-4eaa-bc5c-ca3c566ace92')
SET IDENTITY_INSERT [dbo].[ApplyJobs] OFF
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'Publisher', N'Publisher', N'Publisher')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'Researcher', N'Reasearcher', N'Reasearcher')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3', N'Admin', N'Admin', N'Admin')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4866dbf1-970d-40af-80c9-dbfbeb6353e4', N'1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'56f6dd56-50c0-4bf5-b125-a94ad0380f38', N'1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6c9e148d-de4a-4e20-9d61-cecdce137cde', N'1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6d57c8f2-3b78-4fee-a23d-66016943f465', N'1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6f9c2734-4c66-400f-b5de-b63ec32d43e8', N'1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8009162f-de27-4f93-a096-a46992214f37', N'1')
GO
INSERT [dbo].[AspNetUsers] ([Id], [ApplicationUserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4866dbf1-970d-40af-80c9-dbfbeb6353e4', NULL, N'khaled Gamal ', N'KHALED GAMAL ', N'khaledjamal274@gmail.com', N'KHALEDJAMAL274@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEH0O5h4uCHR22wm/fzfzEs2eA7e8WK2sTsyg8Vujl5pzBhjFBpaTHypEi/tSgq3grA==', N'JBFXI6QNDVKG5VF6IYBAD7YGMV7YUMM7', N'1cb1145f-3a5f-49d2-b6f0-b80a5f873bf0', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [ApplicationUserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'56f6dd56-50c0-4bf5-b125-a94ad0380f38', NULL, N'zyad', N'ZYAD', N'zyad@gmail.com', N'ZYAD@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEBhQMeKlaMJIuDunelCMe/+74pmLYDsFP+H8O7OX+HL7YdBO0ODsbVm60UFwjLqM2A==', N'4UKTNHLTIZ3U3BZMN6FAWXXHZG6XWEOZ', N'de935597-609c-42af-ae2c-40e7658b017a', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [ApplicationUserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'6c9e148d-de4a-4e20-9d61-cecdce137cde', NULL, N'khkhk', N'KHKHK', N'khaledjamal254@gmail.com', N'KHALEDJAMAL254@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEF6xcUGmH7p3k1i3eBbJCQwp5j+y71JV04rBAhAQ81tVccY1U1BxfXHLWFQJTqtKvQ==', N'L2DKKRGFIE3CKPF2OVFEUOQAMR6COVTJ', N'231c89eb-53d1-476a-a74b-9060a5de702e', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [ApplicationUserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'6d57c8f2-3b78-4fee-a23d-66016943f465', NULL, N'khkhkdf', N'KHKHKDF', N'khaledjamal5@gmail.com', N'KHALEDJAMAL5@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEFRGTrfzDe7O0azGjDJxSHsAg8yL7cwMK0ZCwexs3nIvAocgX7/+FOOVuo4Qjg+1ZA==', N'ULULJ6DLKSS3XAQ7ICRWD4JAK2J2XCMB', N'24c0a1d1-a4cb-41f1-97ec-8cf32fa82071', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [ApplicationUserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'6f9c2734-4c66-400f-b5de-b63ec32d43e8', NULL, N'Mahmoud Mostafa', N'MAHMOUD MOSTAFA', N'Mahmoud@gmail.com', N'MAHMOUD@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEOObYk0pnG4Y8PgEppwfVyBbAjZGV1JFRP0egTOO7zDEEcycxFKzp8vMJrtCVTECWg==', N'6X5PQRBQ4DVFQB6YYDJI5NJN2PP75GQU', N'35736615-18b7-4547-a60b-6d48ba282d49', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [ApplicationUserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'8009162f-de27-4f93-a096-a46992214f37', NULL, N'Mahmoud Mostafajklhk', N'MAHMOUD MOSTAFAJKLHK', N'Mody@gmail.com', N'MODY@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEN2jn4je25Zds9KmyHJKmSmRQbrf5psuU6Bjq1AeQOyrhYwFZafMCyTuQK47IHciwg==', N'6HCNXTVTVSDIAHNFFHWBDQ63BA5I3LFX', N'3a60c2ba-d62c-459d-9b9b-d1a579283a6d', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [ApplicationUserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'876a91de-c680-4a76-a94b-4cbd4e981ea4', NULL, N'OsamaZyad', N'OSAMAZYAD', N'Osos@gmail.com', N'OSOS@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEOK7Hw4Gw1LbRG/oRnBA47kWniDcZmKdlHN753ZuJZ/l+iGx68AWId5RHosidZ8mcA==', N'JOKAGITHYEDQOQMJSDI2EDQCSW4XXPBC', N'6ab0faa5-5298-4d90-8e1d-3eab5e08201a', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [ApplicationUserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b64b3a25-d204-4adc-ace5-58dca6f4aa6d', NULL, N'Kemo', N'KEMO', N'Kariem@gmail.com', N'KARIEM@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEPzEnwqSa8NOyLRUkkEqMM3EpSECvo8doi0R1tSJ/qCqFJDI/EVKSGh1svsgmNIUvQ==', N'LDWJQYBDUU5H346EXMRX4SOE4VTWYIFH', N'f0f7c559-5024-462b-bd8c-f764686006a2', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [ApplicationUserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'fab842eb-b5a1-4eaa-bc5c-ca3c566ace92', NULL, N'Osama', N'OSAMA', N'osama@gmail.com', N'OSAMA@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEJW9goa1XJeZbGFhGBic7kpKRno5OIWCj0ftrGyWSNwnTjhy0L0ndiZPAs0GEH37WQ==', N'JG3MTIODTN5OZHO7UZK4VSBHW7QD2WKF', N'f2bf15d4-f897-4bef-b26c-eba02f03cf55', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([DepartmentId], [Department_Name]) VALUES (1, N'Front ')
INSERT [dbo].[Departments] ([DepartmentId], [Department_Name]) VALUES (2, N'Back ')
INSERT [dbo].[Departments] ([DepartmentId], [Department_Name]) VALUES (3, N'Full Stack')
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Feelings] ON 

INSERT [dbo].[Feelings] ([Id], [YourFeeling]) VALUES (1, N'Sad')
INSERT [dbo].[Feelings] ([Id], [YourFeeling]) VALUES (2, N'Angry')
INSERT [dbo].[Feelings] ([Id], [YourFeeling]) VALUES (3, N'Happy')
SET IDENTITY_INSERT [dbo].[Feelings] OFF
GO
SET IDENTITY_INSERT [dbo].[jobs] ON 

INSERT [dbo].[jobs] ([Job_Id], [Name], [Image], [Requriments], [Skills], [Education], [JobDescription], [CompanyName], [Location], [Experience], [Time], [Date], [Salary], [Statues], [UserId], [DepId]) VALUES (1, N'Re Searcher', N'faecb03a-2d8b-42b2-9eb1-0d8d745fa94a7652074618c92d26f051682a8307bd0b.jpg', N'C# , java , ;ldf, ,  ', N'C# ', N'Graduated', N'khaled jamal', N'khkhk', N';lmk', N'1', N'Full Time', CAST(N'2022-05-28T07:19:44.3448554' AS DateTime2), N'36.25', 1, N'6d57c8f2-3b78-4fee-a23d-66016943f465', 1)
INSERT [dbo].[jobs] ([Job_Id], [Name], [Image], [Requriments], [Skills], [Education], [JobDescription], [CompanyName], [Location], [Experience], [Time], [Date], [Salary], [Statues], [UserId], [DepId]) VALUES (2, N'Re Searcher', N'35071837-8413-48c0-968f-d4c7047b615eKHaled.png', N'SQL Server ', N'C# ', N'Graduated', N'khaled jamal', N'khkhk', N';lmk', N'1', N'Full Time', CAST(N'2022-05-28T10:41:12.4157944' AS DateTime2), N'36.25', 1, N'876a91de-c680-4a76-a94b-4cbd4e981ea4', 1)
SET IDENTITY_INSERT [dbo].[jobs] OFF
GO
INSERT [dbo].[questions] ([Job_Id], [Question1], [Question2], [Question3], [Question4], [Question5]) VALUES (1, N'kh', N'how much have Experiece With Paython Language? ', N'how much have Experiece With Entity Framwork? ', N'Do You Work with Crystal Report Befor ? ', N'how much have Experiece With C#? ')
INSERT [dbo].[questions] ([Job_Id], [Question1], [Question2], [Question3], [Question4], [Question5]) VALUES (2, N'what is the Salary Expected ? ', N'how much have Experiece With Paython Language? ', N'how much have Experiece With Entity Framwork? ', N'Do You Work with Crystal Report Befor ? ', N'how much have Experiece With C#? ')
GO
INSERT [dbo].[userInformation] ([UserId], [FirstName], [LastName], [Phone], [JobTitle], [Photo], [CV]) VALUES (N'4866dbf1-970d-40af-80c9-dbfbeb6353e4', N'khaled', N'Rabea Mourad', N'01118168853', N'.NEt Developer', N'24fd62dc-d437-40ed-be6b-597b9702de82ad8a52a26d36c0c5214377c24270e3a5.jpg', N'0377e523-c4f5-47f2-8780-9721fd5c57cdCamScanner ٠٥-٢٠-٢٠٢٢ ١٩.٥٨ (1).pdf')
INSERT [dbo].[userInformation] ([UserId], [FirstName], [LastName], [Phone], [JobTitle], [Photo], [CV]) VALUES (N'56f6dd56-50c0-4bf5-b125-a94ad0380f38', N'Zyad', N'Hamdy', N'011212165', N'.NEt Developer', N'a758dad0-d3e0-4950-a76a-0eb1c2921473KHaled.png', N'4021c288-c6f0-4a35-85b7-0f93d6cf53a0CamScanner ٠٥-٢٠-٢٠٢٢ ١٩.٥٨ (1).pdf')
INSERT [dbo].[userInformation] ([UserId], [FirstName], [LastName], [Phone], [JobTitle], [Photo], [CV]) VALUES (N'6d57c8f2-3b78-4fee-a23d-66016943f465', N'khaled', N'Rabea Mourad', N';jk', N'kj', N'8efc7313-e2bd-4f5e-8357-8ca2e89c964dad8a52a26d36c0c5214377c24270e3a5.jpg', N'120f06e8-0549-41e8-b82c-4ca77a1773f8routing-configuration.pdf')
INSERT [dbo].[userInformation] ([UserId], [FirstName], [LastName], [Phone], [JobTitle], [Photo], [CV]) VALUES (N'6f9c2734-4c66-400f-b5de-b63ec32d43e8', N'mahmoud mostaf', N'ramdan', N'01118168853', N'.NEt Developer', N'1ca724a5-00a7-4c2c-9b05-fed9a9d72a49FB_IMG_1576552480346.jpg', N'c31d9bf1-4072-4fd7-affe-8e389cb1ad9eCamScanner ٠٥-٢٠-٢٠٢٢ ١٩.٥٨.pdf')
INSERT [dbo].[userInformation] ([UserId], [FirstName], [LastName], [Phone], [JobTitle], [Photo], [CV]) VALUES (N'8009162f-de27-4f93-a096-a46992214f37', N'khaled', N'Rabea Mourad', N'01118168853', N'.NEt Developer', N'adfff001-c3d6-4cc4-83fa-772803028932ad8a52a26d36c0c5214377c24270e3a5.jpg', N'ee368ba0-f239-4e1a-a128-9dc48544719bCamScanner ٠٥-٢٠-٢٠٢٢ ١٩.٥٨.pdf')
INSERT [dbo].[userInformation] ([UserId], [FirstName], [LastName], [Phone], [JobTitle], [Photo], [CV]) VALUES (N'876a91de-c680-4a76-a94b-4cbd4e981ea4', N'khaled', N'Rabea Mourad', N';jk', N'.NEt Developer', N'724779cf-bfd5-4105-abf4-5200364504c720190217_213526.jpg', N'87cd13aa-d9a2-4677-9b74-be361ead4318CamScanner ٠٥-٢٠-٢٠٢٢ ١٩.٥٨.pdf')
INSERT [dbo].[userInformation] ([UserId], [FirstName], [LastName], [Phone], [JobTitle], [Photo], [CV]) VALUES (N'b64b3a25-d204-4adc-ace5-58dca6f4aa6d', N'kariem', N'mohamed', N'01118168853', N'.NEt Developer', N'14ebf3b8-a307-4995-bf2a-f569fb59fac1IMG_٢٠٢١٠٧٢٥_١٧٥٨٤٧.jpg', N'eabebf60-d056-4c01-9f2f-beddf51ba1b9CamScanner ٠٥-٢٠-٢٠٢٢ ١٩.٥٨ (1).pdf')
INSERT [dbo].[userInformation] ([UserId], [FirstName], [LastName], [Phone], [JobTitle], [Photo], [CV]) VALUES (N'fab842eb-b5a1-4eaa-bc5c-ca3c566ace92', N'khaled', N'Rabea Mourad', N';jk', N'kj', N'556289e0-fa96-4875-92cd-bf43d0a5061aad8a52a26d36c0c5214377c24270e3a5.jpg', N'1d173819-5a54-4edf-9417-11702a0368eckhaled')
GO
ALTER TABLE [dbo].[adressses]  WITH CHECK ADD  CONSTRAINT [FK_adressses_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[adressses] CHECK CONSTRAINT [FK_adressses_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ApplyJobs]  WITH CHECK ADD  CONSTRAINT [FK_ApplyJobs_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[ApplyJobs] CHECK CONSTRAINT [FK_ApplyJobs_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ApplyJobs]  WITH CHECK ADD  CONSTRAINT [FK_ApplyJobs_jobs_jobsId] FOREIGN KEY([jobsId])
REFERENCES [dbo].[jobs] ([Job_Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ApplyJobs] CHECK CONSTRAINT [FK_ApplyJobs_jobs_jobsId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUsers]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUsers_AspNetUsers_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[AspNetUsers] CHECK CONSTRAINT [FK_AspNetUsers_AspNetUsers_ApplicationUserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[jobs]  WITH CHECK ADD  CONSTRAINT [FK_jobs_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[jobs] CHECK CONSTRAINT [FK_jobs_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[jobs]  WITH CHECK ADD  CONSTRAINT [FK_jobs_Departments_DepId] FOREIGN KEY([DepId])
REFERENCES [dbo].[Departments] ([DepartmentId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[jobs] CHECK CONSTRAINT [FK_jobs_Departments_DepId]
GO
ALTER TABLE [dbo].[post]  WITH CHECK ADD  CONSTRAINT [FK_post_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[post] CHECK CONSTRAINT [FK_post_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[post]  WITH CHECK ADD  CONSTRAINT [FK_post_Feelings_FeelingId] FOREIGN KEY([FeelingId])
REFERENCES [dbo].[Feelings] ([Id])
GO
ALTER TABLE [dbo].[post] CHECK CONSTRAINT [FK_post_Feelings_FeelingId]
GO
ALTER TABLE [dbo].[questions]  WITH CHECK ADD  CONSTRAINT [FK_questions_jobs_Job_Id] FOREIGN KEY([Job_Id])
REFERENCES [dbo].[jobs] ([Job_Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[questions] CHECK CONSTRAINT [FK_questions_jobs_Job_Id]
GO
ALTER TABLE [dbo].[userInformation]  WITH CHECK ADD  CONSTRAINT [FK_userInformation_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[userInformation] CHECK CONSTRAINT [FK_userInformation_AspNetUsers_UserId]
GO
