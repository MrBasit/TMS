USE [master]
GO
/****** Object:  Database [TheProject]    Script Date: 9/29/2020 12:48:58 AM ******/
CREATE DATABASE [TheProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TheProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TheProject.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TheProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TheProject_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TheProject] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TheProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TheProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TheProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TheProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TheProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TheProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [TheProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TheProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TheProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TheProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TheProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TheProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TheProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TheProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TheProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TheProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TheProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TheProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TheProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TheProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TheProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TheProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TheProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TheProject] SET RECOVERY FULL 
GO
ALTER DATABASE [TheProject] SET  MULTI_USER 
GO
ALTER DATABASE [TheProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TheProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TheProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TheProject] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TheProject] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TheProject', N'ON'
GO
USE [TheProject]
GO
/****** Object:  Table [dbo].[AcademyIncomeTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcademyIncomeTable](
	[AI_ID] [int] IDENTITY(1,1) NOT NULL,
	[Std_ID] [int] NULL,
	[Amount] [float] NOT NULL,
	[Note] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_AcademyIncomeTable] PRIMARY KEY CLUSTERED 
(
	[AI_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AttendanceTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttendanceTable](
	[Att_ID] [int] IDENTITY(1,1) NOT NULL,
	[E_ID] [int] NULL,
	[Date] [date] NOT NULL,
	[InTime] [time](7) NULL,
	[OutTime] [time](7) NULL,
	[State_ID] [int] NULL,
 CONSTRAINT [PK_AttendanceTable] PRIMARY KEY CLUSTERED 
(
	[Att_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ConsultantTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConsultantTable](
	[C_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[F_Name] [nvarchar](50) NOT NULL,
	[DOB] [date] NOT NULL,
	[G_ID] [int] NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Phone1] [nvarchar](50) NOT NULL,
	[Phone2] [nvarchar](50) NOT NULL,
	[Cons_ID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ConsultantTable] PRIMARY KEY CLUSTERED 
(
	[C_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DesignationTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DesignationTable](
	[D_ID] [int] IDENTITY(1,1) NOT NULL,
	[PostName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DesignationTable] PRIMARY KEY CLUSTERED 
(
	[D_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee_Salaries]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_Salaries](
	[ES_ID] [int] IDENTITY(1,1) NOT NULL,
	[E_ID] [int] NULL,
	[Amount] [float] NOT NULL,
	[Date] [date] NOT NULL,
	[Note] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employee_Salaries] PRIMARY KEY CLUSTERED 
(
	[ES_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmployeeSkillTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeSkillTable](
	[ES_ID] [int] IDENTITY(1,1) NOT NULL,
	[E_ID] [int] NULL,
	[S_ID] [int] NULL,
 CONSTRAINT [PK_EmployeeSkillTable] PRIMARY KEY CLUSTERED 
(
	[ES_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmployeeTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTable](
	[E_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[F_Name] [nvarchar](50) NOT NULL,
	[CNIC] [nvarchar](50) NOT NULL,
	[DOB] [date] NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Agreement] [nvarchar](50) NOT NULL,
	[T_ID] [int] NULL,
	[G_ID] [int] NULL,
	[D_ID] [int] NULL,
	[Q_ID] [int] NULL,
	[Phone1] [nvarchar](50) NOT NULL,
	[Phone2] [nvarchar](50) NOT NULL,
	[Employee_ID] [nvarchar](50) NULL,
	[Salary] [float] NOT NULL,
 CONSTRAINT [PK_EmployeeTable] PRIMARY KEY CLUSTERED 
(
	[E_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GenderTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GenderTable](
	[G_ID] [int] IDENTITY(1,1) NOT NULL,
	[GenderName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_GenderTable] PRIMARY KEY CLUSTERED 
(
	[G_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoginInfoTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginInfoTable](
	[L_ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Role_ID] [int] NULL,
 CONSTRAINT [PK_LoginInfoTable] PRIMARY KEY CLUSTERED 
(
	[L_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OfficeTimeTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OfficeTimeTable](
	[Intime] [time](7) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectAssignedTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectAssignedTable](
	[PA_ID] [int] IDENTITY(1,1) NOT NULL,
	[Pro_ID] [int] NULL CONSTRAINT [DF_ProjectAssignedTable_Pro_ID]  DEFAULT ((-2)),
	[E_ID] [int] NULL CONSTRAINT [DF_ProjectAssignedTable_E_ID]  DEFAULT ((-1)),
 CONSTRAINT [PK_ProjectAssignedTable] PRIMARY KEY CLUSTERED 
(
	[PA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectExpense]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectExpense](
	[PE_ID] [int] IDENTITY(1,1) NOT NULL,
	[Pro_ID] [int] NULL CONSTRAINT [DF_ProjectExpense_Pro_ID]  DEFAULT ((-2)),
	[E_ID] [int] NULL,
	[Amount] [float] NOT NULL,
	[Date] [date] NOT NULL,
	[Note] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProjectExpense] PRIMARY KEY CLUSTERED 
(
	[PE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectIncomeTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectIncomeTable](
	[PI_ID] [int] IDENTITY(1,1) NOT NULL,
	[Project_id] [int] NULL CONSTRAINT [DF_ProjectIncomeTable_Project_id]  DEFAULT ((-2)),
	[Amount] [float] NOT NULL,
	[Note] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_ProjectIncomeTable] PRIMARY KEY CLUSTERED 
(
	[PI_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTable](
	[Pro_ID] [int] IDENTITY(1,1) NOT NULL,
	[Date_Of_Start] [date] NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[C_ID] [int] NULL,
	[Amount] [float] NOT NULL,
	[Date_Of_Completion] [date] NULL CONSTRAINT [DF_ProjectTable_Date_Of_Completion]  DEFAULT (NULL),
	[Date_Of_Delivery] [date] NULL CONSTRAINT [DF_ProjectTable_Date_Of_Delivery]  DEFAULT (NULL),
	[Project_Date] [date] NOT NULL,
 CONSTRAINT [PK_ProjectTable] PRIMARY KEY CLUSTERED 
(
	[Pro_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QualificationTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QualificationTable](
	[Q_ID] [int] IDENTITY(1,1) NOT NULL,
	[QName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QualificationTable] PRIMARY KEY CLUSTERED 
(
	[Q_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Regular_Expenses]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regular_Expenses](
	[RE_ID] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [float] NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Regular_Expenses] PRIMARY KEY CLUSTERED 
(
	[RE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoleTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleTable](
	[Role_ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_RoleTable] PRIMARY KEY CLUSTERED 
(
	[Role_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SkillsTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SkillsTable](
	[S_ID] [int] IDENTITY(1,1) NOT NULL,
	[SkillName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SkillsTable] PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StatusTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusTable](
	[State_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusTable] PRIMARY KEY CLUSTERED 
(
	[State_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentsTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsTable](
	[Std_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StudentsTable] PRIMARY KEY CLUSTERED 
(
	[Std_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TestedByTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestedByTable](
	[Test_ID] [int] IDENTITY(1,1) NOT NULL,
	[Pro_ID] [int] NULL CONSTRAINT [DF_TestedByTable_Pro_ID]  DEFAULT ((-2)),
	[E_ID] [int] NULL,
 CONSTRAINT [PK_TestedByTable] PRIMARY KEY CLUSTERED 
(
	[Test_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TypeTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeTable](
	[T_ID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TypeTable] PRIMARY KEY CLUSTERED 
(
	[T_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Withdrawal]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Withdrawal](
	[WithdrawalID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Date] [datetime] NULL,
	[Amount] [float] NULL,
	[Note] [nvarchar](250) NULL,
 CONSTRAINT [PK__Withdraw__7C842C4EF77DD326] PRIMARY KEY CLUSTERED 
(
	[WithdrawalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[AcademyIncomeTable] ON 

INSERT [dbo].[AcademyIncomeTable] ([AI_ID], [Std_ID], [Amount], [Note], [Date]) VALUES (1, 1, 1000, N'learning graphic design', CAST(N'2020-01-01' AS Date))
INSERT [dbo].[AcademyIncomeTable] ([AI_ID], [Std_ID], [Amount], [Note], [Date]) VALUES (2, 2, 200, N'learning .net c# ', CAST(N'2020-02-02' AS Date))
INSERT [dbo].[AcademyIncomeTable] ([AI_ID], [Std_ID], [Amount], [Note], [Date]) VALUES (3, 3, 300, N'learning PHP', CAST(N'2020-09-03' AS Date))
INSERT [dbo].[AcademyIncomeTable] ([AI_ID], [Std_ID], [Amount], [Note], [Date]) VALUES (4, 4, 400, N'learning ASP.net', CAST(N'2020-04-04' AS Date))
INSERT [dbo].[AcademyIncomeTable] ([AI_ID], [Std_ID], [Amount], [Note], [Date]) VALUES (5, 5, 500, N'learning Android development', CAST(N'2020-09-01' AS Date))
INSERT [dbo].[AcademyIncomeTable] ([AI_ID], [Std_ID], [Amount], [Note], [Date]) VALUES (6, 2, 10000, N'AI Python', CAST(N'2020-09-03' AS Date))
INSERT [dbo].[AcademyIncomeTable] ([AI_ID], [Std_ID], [Amount], [Note], [Date]) VALUES (7, 4, 25000, N'Python', CAST(N'2020-09-03' AS Date))
INSERT [dbo].[AcademyIncomeTable] ([AI_ID], [Std_ID], [Amount], [Note], [Date]) VALUES (1006, 5, 155, N'Fine', CAST(N'2020-09-09' AS Date))
INSERT [dbo].[AcademyIncomeTable] ([AI_ID], [Std_ID], [Amount], [Note], [Date]) VALUES (1007, 3, 1200, N'qwerty', CAST(N'2020-09-09' AS Date))
SET IDENTITY_INSERT [dbo].[AcademyIncomeTable] OFF
SET IDENTITY_INSERT [dbo].[AttendanceTable] ON 

INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (1, 1, CAST(N'2021-08-12' AS Date), CAST(N'12:00:00' AS Time), CAST(N'13:45:07' AS Time), 2)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2, 1, CAST(N'2021-01-03' AS Date), CAST(N'12:05:00' AS Time), CAST(N'05:10:00' AS Time), 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (3, 1, CAST(N'2021-01-05' AS Date), CAST(N'12:30:00' AS Time), CAST(N'06:10:00' AS Time), 2)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (4, 1, CAST(N'2022-08-12' AS Date), CAST(N'00:00:00' AS Time), CAST(N'13:45:07' AS Time), 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (5, 1, CAST(N'2022-09-08' AS Date), CAST(N'16:59:02' AS Time), CAST(N'15:10:20' AS Time), 3)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (6, 1, CAST(N'2022-09-06' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (7, 1, CAST(N'2020-09-08' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), 2)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (8, 1, CAST(N'2020-08-12' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (9, 2, CAST(N'2020-09-08' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), 3)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (10, 3, CAST(N'2020-09-08' AS Date), CAST(N'13:08:28' AS Time), CAST(N'13:45:07' AS Time), 2)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (11, 4, CAST(N'2020-09-08' AS Date), CAST(N'13:08:28' AS Time), CAST(N'10:30:00' AS Time), 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (12, 1, CAST(N'2020-08-13' AS Date), CAST(N'16:55:36' AS Time), CAST(N'13:45:07' AS Time), 3)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (13, 1, CAST(N'2020-08-13' AS Date), CAST(N'17:12:13' AS Time), CAST(N'13:45:07' AS Time), 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (14, 1, CAST(N'2020-08-13' AS Date), CAST(N'16:55:36' AS Time), NULL, 3)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (15, 1, CAST(N'2020-08-13' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (16, 1, CAST(N'2020-08-13' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (17, 5, CAST(N'2020-09-08' AS Date), CAST(N'15:39:51' AS Time), NULL, 2)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (18, 1, CAST(N'2020-08-18' AS Date), CAST(N'12:59:19' AS Time), CAST(N'13:45:07' AS Time), 2)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (19, 1, CAST(N'2020-08-18' AS Date), CAST(N'12:59:59' AS Time), NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (20, 1, CAST(N'2020-08-18' AS Date), CAST(N'13:00:11' AS Time), NULL, 4)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (21, 1, CAST(N'2020-08-18' AS Date), CAST(N'13:00:23' AS Time), CAST(N'13:45:07' AS Time), 2)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (22, 1, CAST(N'2020-08-18' AS Date), CAST(N'13:00:29' AS Time), CAST(N'13:45:07' AS Time), 2)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (23, 1, CAST(N'2020-09-09' AS Date), CAST(N'14:41:52' AS Time), CAST(N'23:55:31' AS Time), 2)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (24, 2, CAST(N'2020-09-09' AS Date), CAST(N'16:02:20' AS Time), NULL, 4)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (25, 3, CAST(N'2020-09-09' AS Date), CAST(N'14:41:57' AS Time), CAST(N'15:28:14' AS Time), 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (26, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (27, 5, CAST(N'2020-09-09' AS Date), CAST(N'14:42:03' AS Time), CAST(N'15:59:45' AS Time), 4)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (28, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (29, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (30, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (31, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (32, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (33, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (34, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (35, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (36, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (37, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (38, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (39, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (40, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (41, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (42, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (43, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (44, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (45, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (46, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (47, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (48, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (49, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (50, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (51, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (52, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (53, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (54, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (55, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (56, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (57, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (58, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (59, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (60, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (61, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (62, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (63, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (64, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (65, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (66, 4, CAST(N'2020-09-09' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (67, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (68, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (69, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (70, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (71, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (72, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (73, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (74, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (75, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (76, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (77, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (78, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (79, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (80, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (81, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (82, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (83, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (84, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (85, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (86, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (87, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (88, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (89, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (90, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (91, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (92, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (93, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (94, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (95, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (96, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (97, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (98, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (99, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
GO
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (100, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (101, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (102, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (103, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (104, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (105, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (106, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (107, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (108, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (109, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (110, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (111, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (112, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (113, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (114, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (115, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (116, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (117, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (118, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (119, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (120, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (121, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (122, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (123, 1, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (124, 2, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (125, 3, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (126, 4, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (127, 5, CAST(N'2020-09-09' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (133, 1, CAST(N'2020-09-10' AS Date), CAST(N'09:06:15' AS Time), NULL, 2)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (134, 2, CAST(N'2020-09-10' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (135, 3, CAST(N'2020-09-10' AS Date), CAST(N'09:07:49' AS Time), NULL, 4)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (136, 4, CAST(N'2020-09-10' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (137, 5, CAST(N'2020-09-10' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (138, 1, CAST(N'2020-09-11' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (139, 2, CAST(N'2020-09-11' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (140, 3, CAST(N'2020-09-11' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (141, 4, CAST(N'2020-09-11' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (142, 5, CAST(N'2020-09-11' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (143, 1, CAST(N'2020-09-12' AS Date), CAST(N'13:47:44' AS Time), NULL, 2)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (144, 2, CAST(N'2020-09-12' AS Date), CAST(N'14:27:36' AS Time), NULL, 4)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (145, 3, CAST(N'2020-09-12' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (146, 4, CAST(N'2020-09-12' AS Date), CAST(N'13:47:48' AS Time), NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (147, 5, CAST(N'2020-09-12' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (1140, 1, CAST(N'2020-09-13' AS Date), CAST(N'14:20:54' AS Time), NULL, 3)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (1141, 2, CAST(N'2020-09-13' AS Date), CAST(N'11:22:42' AS Time), NULL, 2)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (1142, 3, CAST(N'2020-09-13' AS Date), CAST(N'21:15:27' AS Time), CAST(N'22:18:24' AS Time), NULL)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (1143, 4, CAST(N'2020-09-13' AS Date), CAST(N'21:15:56' AS Time), NULL, 3)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (1144, 5, CAST(N'2020-09-13' AS Date), CAST(N'14:21:35' AS Time), NULL, 4)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2150, 1, CAST(N'2020-09-28' AS Date), CAST(N'22:30:21' AS Time), NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2151, 2, CAST(N'2020-09-28' AS Date), CAST(N'22:30:27' AS Time), NULL, 3)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2152, 3, CAST(N'2020-09-28' AS Date), CAST(N'22:30:31' AS Time), NULL, 4)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2153, 4, CAST(N'2020-09-28' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2154, 5, CAST(N'2020-09-28' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2155, 1, CAST(N'2020-09-29' AS Date), CAST(N'00:18:22' AS Time), CAST(N'00:18:37' AS Time), 3)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2156, 2, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2157, 3, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2158, 4, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2159, 5, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2160, 1, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2161, 2, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2162, 3, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2163, 4, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2164, 5, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2165, 1, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2166, 2, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2167, 3, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2168, 4, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
INSERT [dbo].[AttendanceTable] ([Att_ID], [E_ID], [Date], [InTime], [OutTime], [State_ID]) VALUES (2169, 5, CAST(N'2020-09-29' AS Date), NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[AttendanceTable] OFF
SET IDENTITY_INSERT [dbo].[ConsultantTable] ON 

INSERT [dbo].[ConsultantTable] ([C_ID], [Name], [F_Name], [DOB], [G_ID], [Address], [Phone1], [Phone2], [Cons_ID]) VALUES (2, N'Ayesha', N'Abdullah', CAST(N'2000-08-11' AS Date), 2, N'A-400 gulshan-e-hadeed phase 1', N'0311-0986744', N'0300-2678167', N'2')
INSERT [dbo].[ConsultantTable] ([C_ID], [Name], [F_Name], [DOB], [G_ID], [Address], [Phone1], [Phone2], [Cons_ID]) VALUES (3, N'Younus', N'Abdullah', CAST(N'2000-08-11' AS Date), 1, N'A-300 steel town Block E', N'0322-4325671', N'0333-3678345', N'3')
INSERT [dbo].[ConsultantTable] ([C_ID], [Name], [F_Name], [DOB], [G_ID], [Address], [Phone1], [Phone2], [Cons_ID]) VALUES (4, N'Aiman', N'Abdullah', CAST(N'2000-08-11' AS Date), 2, N'A-200 gulshan-e-hadeed phase 1', N'0344-0864489', N'0301-4678986', N'4')
INSERT [dbo].[ConsultantTable] ([C_ID], [Name], [F_Name], [DOB], [G_ID], [Address], [Phone1], [Phone2], [Cons_ID]) VALUES (5, N'Younus1', N'Abdullah', CAST(N'2000-08-11' AS Date), 1, N'A-100 Shah town near Famous Bakery', N'0355-4561230', N'0330-5567893', N'5')
SET IDENTITY_INSERT [dbo].[ConsultantTable] OFF
SET IDENTITY_INSERT [dbo].[DesignationTable] ON 

INSERT [dbo].[DesignationTable] ([D_ID], [PostName]) VALUES (1, N'Manager')
INSERT [dbo].[DesignationTable] ([D_ID], [PostName]) VALUES (2, N'Project Manager')
INSERT [dbo].[DesignationTable] ([D_ID], [PostName]) VALUES (3, N'Trainee Engineer')
INSERT [dbo].[DesignationTable] ([D_ID], [PostName]) VALUES (4, N'Senior Software Engineer')
INSERT [dbo].[DesignationTable] ([D_ID], [PostName]) VALUES (5, N'System Analyst')
INSERT [dbo].[DesignationTable] ([D_ID], [PostName]) VALUES (6, N'Project Lead')
INSERT [dbo].[DesignationTable] ([D_ID], [PostName]) VALUES (7, N'Internee')
INSERT [dbo].[DesignationTable] ([D_ID], [PostName]) VALUES (8, N'Trainee')
SET IDENTITY_INSERT [dbo].[DesignationTable] OFF
SET IDENTITY_INSERT [dbo].[Employee_Salaries] ON 

INSERT [dbo].[Employee_Salaries] ([ES_ID], [E_ID], [Amount], [Date], [Note]) VALUES (2, 2, 10500, CAST(N'2020-02-02' AS Date), N'cut 500')
INSERT [dbo].[Employee_Salaries] ([ES_ID], [E_ID], [Amount], [Date], [Note]) VALUES (3, 3, 67000, CAST(N'2020-03-03' AS Date), N'bunus 1000')
INSERT [dbo].[Employee_Salaries] ([ES_ID], [E_ID], [Amount], [Date], [Note]) VALUES (4, 4, 9500, CAST(N'2020-04-04' AS Date), N'cut  500')
INSERT [dbo].[Employee_Salaries] ([ES_ID], [E_ID], [Amount], [Date], [Note]) VALUES (5, 5, 56000, CAST(N'2020-05-05' AS Date), N'bunus 1000')
INSERT [dbo].[Employee_Salaries] ([ES_ID], [E_ID], [Amount], [Date], [Note]) VALUES (1007, 1, 1020102, CAST(N'2020-09-29' AS Date), N'')
SET IDENTITY_INSERT [dbo].[Employee_Salaries] OFF
SET IDENTITY_INSERT [dbo].[EmployeeSkillTable] ON 

INSERT [dbo].[EmployeeSkillTable] ([ES_ID], [E_ID], [S_ID]) VALUES (1, 1, 1)
INSERT [dbo].[EmployeeSkillTable] ([ES_ID], [E_ID], [S_ID]) VALUES (2, 2, 2)
INSERT [dbo].[EmployeeSkillTable] ([ES_ID], [E_ID], [S_ID]) VALUES (3, 3, 3)
INSERT [dbo].[EmployeeSkillTable] ([ES_ID], [E_ID], [S_ID]) VALUES (4, 4, 4)
INSERT [dbo].[EmployeeSkillTable] ([ES_ID], [E_ID], [S_ID]) VALUES (5, 5, 5)
INSERT [dbo].[EmployeeSkillTable] ([ES_ID], [E_ID], [S_ID]) VALUES (6, 1, 2)
INSERT [dbo].[EmployeeSkillTable] ([ES_ID], [E_ID], [S_ID]) VALUES (7, 1, 5)
INSERT [dbo].[EmployeeSkillTable] ([ES_ID], [E_ID], [S_ID]) VALUES (8, 3, 3)
SET IDENTITY_INSERT [dbo].[EmployeeSkillTable] OFF
SET IDENTITY_INSERT [dbo].[EmployeeTable] ON 

INSERT [dbo].[EmployeeTable] ([E_ID], [Name], [F_Name], [CNIC], [DOB], [Address], [Agreement], [T_ID], [G_ID], [D_ID], [Q_ID], [Phone1], [Phone2], [Employee_ID], [Salary]) VALUES (1, N'Ali', N'khan', N'1234-4234-123', CAST(N'2020-08-12' AS Date), N'A-600 Gulshan-e-hadeed Phase 2', N'1 year job contract', 1, 1, 1, 1, N'0333-3401615', N'0311-4585581', N'1', 5000)
INSERT [dbo].[EmployeeTable] ([E_ID], [Name], [F_Name], [CNIC], [DOB], [Address], [Agreement], [T_ID], [G_ID], [D_ID], [Q_ID], [Phone1], [Phone2], [Employee_ID], [Salary]) VALUES (2, N'Sana', N'Akram', N'4321-5234-124', CAST(N'2000-01-13' AS Date), N'A-700 Gulshan-e-hadeed Phase 1', N'6 month job contract', 2, 2, 2, 2, N'0311-4567891', N'0322-4585581', N'2', 11000)
INSERT [dbo].[EmployeeTable] ([E_ID], [Name], [F_Name], [CNIC], [DOB], [Address], [Agreement], [T_ID], [G_ID], [D_ID], [Q_ID], [Phone1], [Phone2], [Employee_ID], [Salary]) VALUES (3, N'Aqsa', N'Bilal', N'3789-6234-125', CAST(N'2005-02-14' AS Date), N'A-12 Block A steel town', N'5 year job contract', 1, 2, 3, 3, N'0322-1234567', N'0333-4585581', N'3', 66000)
INSERT [dbo].[EmployeeTable] ([E_ID], [Name], [F_Name], [CNIC], [DOB], [Address], [Agreement], [T_ID], [G_ID], [D_ID], [Q_ID], [Phone1], [Phone2], [Employee_ID], [Salary]) VALUES (4, N'Abbas', N'Haris', N'1452-7234-126', CAST(N'2006-04-15' AS Date), N'A-890 DHA Phase 2', N'2 year job contract', 2, 1, 4, 4, N'0300-5678901', N'0344-4585581', N'4', 10000)
INSERT [dbo].[EmployeeTable] ([E_ID], [Name], [F_Name], [CNIC], [DOB], [Address], [Agreement], [T_ID], [G_ID], [D_ID], [Q_ID], [Phone1], [Phone2], [Employee_ID], [Salary]) VALUES (5, N'Yousra', N'Hasnain', N'9876-8234-127', CAST(N'2007-05-16' AS Date), N'A-590 Phase 2 Green City', N'3 month job contract', 1, 2, 5, 5, N'0301-3144551', N'0355-4585581', N'5', 55000)
SET IDENTITY_INSERT [dbo].[EmployeeTable] OFF
SET IDENTITY_INSERT [dbo].[GenderTable] ON 

INSERT [dbo].[GenderTable] ([G_ID], [GenderName]) VALUES (1, N'Male')
INSERT [dbo].[GenderTable] ([G_ID], [GenderName]) VALUES (2, N'Female')
SET IDENTITY_INSERT [dbo].[GenderTable] OFF
SET IDENTITY_INSERT [dbo].[LoginInfoTable] ON 

INSERT [dbo].[LoginInfoTable] ([L_ID], [Username], [Password], [Role_ID]) VALUES (1, N'talha', N'321', 2)
INSERT [dbo].[LoginInfoTable] ([L_ID], [Username], [Password], [Role_ID]) VALUES (3, N'a', N'ab', 1)
INSERT [dbo].[LoginInfoTable] ([L_ID], [Username], [Password], [Role_ID]) VALUES (4, N'b', N'b', 3)
INSERT [dbo].[LoginInfoTable] ([L_ID], [Username], [Password], [Role_ID]) VALUES (7, N'Shaikh1999', N'Shaikh11', 1)
INSERT [dbo].[LoginInfoTable] ([L_ID], [Username], [Password], [Role_ID]) VALUES (8, N'Namaloom', N'Namaloom', 2)
INSERT [dbo].[LoginInfoTable] ([L_ID], [Username], [Password], [Role_ID]) VALUES (1006, N'Basit', N'Basit', 1)
SET IDENTITY_INSERT [dbo].[LoginInfoTable] OFF
INSERT [dbo].[OfficeTimeTable] ([Intime]) VALUES (CAST(N'12:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[ProjectAssignedTable] ON 

INSERT [dbo].[ProjectAssignedTable] ([PA_ID], [Pro_ID], [E_ID]) VALUES (1, 1, 1)
INSERT [dbo].[ProjectAssignedTable] ([PA_ID], [Pro_ID], [E_ID]) VALUES (2, 2, 2)
INSERT [dbo].[ProjectAssignedTable] ([PA_ID], [Pro_ID], [E_ID]) VALUES (3, 3, 3)
INSERT [dbo].[ProjectAssignedTable] ([PA_ID], [Pro_ID], [E_ID]) VALUES (4, NULL, 4)
INSERT [dbo].[ProjectAssignedTable] ([PA_ID], [Pro_ID], [E_ID]) VALUES (5, 5, 5)
SET IDENTITY_INSERT [dbo].[ProjectAssignedTable] OFF
SET IDENTITY_INSERT [dbo].[ProjectExpense] ON 

INSERT [dbo].[ProjectExpense] ([PE_ID], [Pro_ID], [E_ID], [Amount], [Date], [Note]) VALUES (1, 1, 1, 1100, CAST(N'2019-01-01' AS Date), N'due to edit of skfs ewr fewifpo kwe j9ew9 jf ewnfo')
INSERT [dbo].[ProjectExpense] ([PE_ID], [Pro_ID], [E_ID], [Amount], [Date], [Note]) VALUES (2, 2, 3, 200, CAST(N'2020-02-02' AS Date), N'due to xyz ewr 435')
INSERT [dbo].[ProjectExpense] ([PE_ID], [Pro_ID], [E_ID], [Amount], [Date], [Note]) VALUES (3, 3, 4, 300, CAST(N'2020-03-03' AS Date), N'due to abc')
INSERT [dbo].[ProjectExpense] ([PE_ID], [Pro_ID], [E_ID], [Amount], [Date], [Note]) VALUES (4, NULL, 2, 400, CAST(N'2020-04-04' AS Date), N'due to edition')
INSERT [dbo].[ProjectExpense] ([PE_ID], [Pro_ID], [E_ID], [Amount], [Date], [Note]) VALUES (5, 5, 5, 500, CAST(N'2020-05-05' AS Date), N'due to some reason')
INSERT [dbo].[ProjectExpense] ([PE_ID], [Pro_ID], [E_ID], [Amount], [Date], [Note]) VALUES (8, 2, 4, 111, CAST(N'2020-09-09' AS Date), N'Faltu M')
INSERT [dbo].[ProjectExpense] ([PE_ID], [Pro_ID], [E_ID], [Amount], [Date], [Note]) VALUES (1009, 7, 4, 120, CAST(N'2020-09-12' AS Date), N'Ese')
SET IDENTITY_INSERT [dbo].[ProjectExpense] OFF
SET IDENTITY_INSERT [dbo].[ProjectIncomeTable] ON 

INSERT [dbo].[ProjectIncomeTable] ([PI_ID], [Project_id], [Amount], [Note], [Date]) VALUES (1, 1, 100000, N'positive feedback !', CAST(N'2020-02-04' AS Date))
INSERT [dbo].[ProjectIncomeTable] ([PI_ID], [Project_id], [Amount], [Note], [Date]) VALUES (2, 2, 1250, N'fair', CAST(N'2020-09-05' AS Date))
INSERT [dbo].[ProjectIncomeTable] ([PI_ID], [Project_id], [Amount], [Note], [Date]) VALUES (3, 3, 350, N'good feedback', CAST(N'2020-04-06' AS Date))
INSERT [dbo].[ProjectIncomeTable] ([PI_ID], [Project_id], [Amount], [Note], [Date]) VALUES (4, NULL, 450, N'normal feedback', CAST(N'2020-05-07' AS Date))
INSERT [dbo].[ProjectIncomeTable] ([PI_ID], [Project_id], [Amount], [Note], [Date]) VALUES (5, 5, 550, N'nice feedback', CAST(N'2020-09-01' AS Date))
INSERT [dbo].[ProjectIncomeTable] ([PI_ID], [Project_id], [Amount], [Note], [Date]) VALUES (6, 3, 20000, N'Baap Project', CAST(N'2020-09-03' AS Date))
INSERT [dbo].[ProjectIncomeTable] ([PI_ID], [Project_id], [Amount], [Note], [Date]) VALUES (7, 5, 25000, N'Halka Project', CAST(N'2020-09-03' AS Date))
INSERT [dbo].[ProjectIncomeTable] ([PI_ID], [Project_id], [Amount], [Note], [Date]) VALUES (1006, NULL, 190, N'Extra', CAST(N'2020-09-09' AS Date))
INSERT [dbo].[ProjectIncomeTable] ([PI_ID], [Project_id], [Amount], [Note], [Date]) VALUES (2007, 7, 12000, N'New', CAST(N'2020-09-12' AS Date))
SET IDENTITY_INSERT [dbo].[ProjectIncomeTable] OFF
SET IDENTITY_INSERT [dbo].[ProjectTable] ON 

INSERT [dbo].[ProjectTable] ([Pro_ID], [Date_Of_Start], [Name], [Description], [C_ID], [Amount], [Date_Of_Completion], [Date_Of_Delivery], [Project_Date]) VALUES (1, CAST(N'2020-01-01' AS Date), N'Symbol to speech for mute', N'iot based project', 1, 100, CAST(N'2020-02-02' AS Date), CAST(N'2020-02-03' AS Date), CAST(N'2020-01-01' AS Date))
INSERT [dbo].[ProjectTable] ([Pro_ID], [Date_Of_Start], [Name], [Description], [C_ID], [Amount], [Date_Of_Completion], [Date_Of_Delivery], [Project_Date]) VALUES (2, CAST(N'2020-02-02' AS Date), N'Hotel Managment', N'.net based project', 2, 500, CAST(N'1900-01-01' AS Date), CAST(N'2020-03-04' AS Date), CAST(N'2020-02-02' AS Date))
INSERT [dbo].[ProjectTable] ([Pro_ID], [Date_Of_Start], [Name], [Description], [C_ID], [Amount], [Date_Of_Completion], [Date_Of_Delivery], [Project_Date]) VALUES (3, CAST(N'2020-03-03' AS Date), N'School Managment', N'Asp.net based project', 3, 300, NULL, NULL, CAST(N'2020-03-03' AS Date))
INSERT [dbo].[ProjectTable] ([Pro_ID], [Date_Of_Start], [Name], [Description], [C_ID], [Amount], [Date_Of_Completion], [Date_Of_Delivery], [Project_Date]) VALUES (5, CAST(N'2020-05-05' AS Date), N'Learning Managment System', N'.NET based project', 5, 500, CAST(N'1900-01-01' AS Date), CAST(N'1900-01-01' AS Date), CAST(N'2020-05-05' AS Date))
INSERT [dbo].[ProjectTable] ([Pro_ID], [Date_Of_Start], [Name], [Description], [C_ID], [Amount], [Date_Of_Completion], [Date_Of_Delivery], [Project_Date]) VALUES (6, CAST(N'2020-09-09' AS Date), N'Haris Ka Project', N'Shaikh', 2, 20000, CAST(N'1900-01-01' AS Date), CAST(N'1900-01-01' AS Date), CAST(N'2020-09-09' AS Date))
INSERT [dbo].[ProjectTable] ([Pro_ID], [Date_Of_Start], [Name], [Description], [C_ID], [Amount], [Date_Of_Completion], [Date_Of_Delivery], [Project_Date]) VALUES (7, CAST(N'2020-09-09' AS Date), N'Shaikhoo', N'dsg', 2, 435, CAST(N'1900-01-01' AS Date), CAST(N'1900-01-01' AS Date), CAST(N'2020-09-09' AS Date))
SET IDENTITY_INSERT [dbo].[ProjectTable] OFF
SET IDENTITY_INSERT [dbo].[QualificationTable] ON 

INSERT [dbo].[QualificationTable] ([Q_ID], [QName]) VALUES (1, N'Graduate')
INSERT [dbo].[QualificationTable] ([Q_ID], [QName]) VALUES (2, N'Undergraduate')
INSERT [dbo].[QualificationTable] ([Q_ID], [QName]) VALUES (3, N'Master')
INSERT [dbo].[QualificationTable] ([Q_ID], [QName]) VALUES (4, N'PHD')
INSERT [dbo].[QualificationTable] ([Q_ID], [QName]) VALUES (5, N'Diploma')
INSERT [dbo].[QualificationTable] ([Q_ID], [QName]) VALUES (6, N'Intermediate')
SET IDENTITY_INSERT [dbo].[QualificationTable] OFF
SET IDENTITY_INSERT [dbo].[Regular_Expenses] ON 

INSERT [dbo].[Regular_Expenses] ([RE_ID], [Amount], [Description], [Date]) VALUES (1, 255, N'Stationary', CAST(N'2020-08-22' AS Date))
INSERT [dbo].[Regular_Expenses] ([RE_ID], [Amount], [Description], [Date]) VALUES (2, 100, N'Accessories', CAST(N'2020-09-01' AS Date))
INSERT [dbo].[Regular_Expenses] ([RE_ID], [Amount], [Description], [Date]) VALUES (3, 20, N'mouse pad', CAST(N'2020-09-02' AS Date))
INSERT [dbo].[Regular_Expenses] ([RE_ID], [Amount], [Description], [Date]) VALUES (4, 50, N'mouse', CAST(N'2020-10-05' AS Date))
INSERT [dbo].[Regular_Expenses] ([RE_ID], [Amount], [Description], [Date]) VALUES (7, 150, N'Khaapa Kiya Tha', CAST(N'2020-11-10' AS Date))
INSERT [dbo].[Regular_Expenses] ([RE_ID], [Amount], [Description], [Date]) VALUES (9, 200, N'Pata Nhi kuxh', CAST(N'2020-10-10' AS Date))
INSERT [dbo].[Regular_Expenses] ([RE_ID], [Amount], [Description], [Date]) VALUES (1006, 111, N'Ese Hi', CAST(N'2020-10-10' AS Date))
INSERT [dbo].[Regular_Expenses] ([RE_ID], [Amount], [Description], [Date]) VALUES (1007, 1234, N'Chorr Yaar', CAST(N'2020-10-01' AS Date))
INSERT [dbo].[Regular_Expenses] ([RE_ID], [Amount], [Description], [Date]) VALUES (2006, 111, N'Ese Hi BAs', CAST(N'2020-09-09' AS Date))
SET IDENTITY_INSERT [dbo].[Regular_Expenses] OFF
SET IDENTITY_INSERT [dbo].[RoleTable] ON 

INSERT [dbo].[RoleTable] ([Role_ID], [RoleName]) VALUES (1, N'Owner')
INSERT [dbo].[RoleTable] ([Role_ID], [RoleName]) VALUES (2, N'Student')
INSERT [dbo].[RoleTable] ([Role_ID], [RoleName]) VALUES (3, N'Admin')
SET IDENTITY_INSERT [dbo].[RoleTable] OFF
SET IDENTITY_INSERT [dbo].[SkillsTable] ON 

INSERT [dbo].[SkillsTable] ([S_ID], [SkillName]) VALUES (1, N'C# programming and coding')
INSERT [dbo].[SkillsTable] ([S_ID], [SkillName]) VALUES (2, N'ASP.net')
INSERT [dbo].[SkillsTable] ([S_ID], [SkillName]) VALUES (3, N'MVC 3.0')
INSERT [dbo].[SkillsTable] ([S_ID], [SkillName]) VALUES (4, N'Web developer')
INSERT [dbo].[SkillsTable] ([S_ID], [SkillName]) VALUES (5, N'Data scientist')
INSERT [dbo].[SkillsTable] ([S_ID], [SkillName]) VALUES (6, N'C++')
INSERT [dbo].[SkillsTable] ([S_ID], [SkillName]) VALUES (7, N'PHP')
SET IDENTITY_INSERT [dbo].[SkillsTable] OFF
SET IDENTITY_INSERT [dbo].[StatusTable] ON 

INSERT [dbo].[StatusTable] ([State_ID], [Name]) VALUES (1, N'Absent')
INSERT [dbo].[StatusTable] ([State_ID], [Name]) VALUES (2, N'Present')
INSERT [dbo].[StatusTable] ([State_ID], [Name]) VALUES (3, N'Late')
INSERT [dbo].[StatusTable] ([State_ID], [Name]) VALUES (4, N'Leave')
SET IDENTITY_INSERT [dbo].[StatusTable] OFF
SET IDENTITY_INSERT [dbo].[StudentsTable] ON 

INSERT [dbo].[StudentsTable] ([Std_ID], [Name]) VALUES (1, N'Ali')
INSERT [dbo].[StudentsTable] ([Std_ID], [Name]) VALUES (2, N'Asad')
INSERT [dbo].[StudentsTable] ([Std_ID], [Name]) VALUES (3, N'Tariq')
INSERT [dbo].[StudentsTable] ([Std_ID], [Name]) VALUES (4, N'Usman')
INSERT [dbo].[StudentsTable] ([Std_ID], [Name]) VALUES (5, N'Younus')
SET IDENTITY_INSERT [dbo].[StudentsTable] OFF
SET IDENTITY_INSERT [dbo].[TestedByTable] ON 

INSERT [dbo].[TestedByTable] ([Test_ID], [Pro_ID], [E_ID]) VALUES (1, 1, 1)
INSERT [dbo].[TestedByTable] ([Test_ID], [Pro_ID], [E_ID]) VALUES (2, 2, 2)
INSERT [dbo].[TestedByTable] ([Test_ID], [Pro_ID], [E_ID]) VALUES (3, 3, 3)
INSERT [dbo].[TestedByTable] ([Test_ID], [Pro_ID], [E_ID]) VALUES (4, NULL, 4)
INSERT [dbo].[TestedByTable] ([Test_ID], [Pro_ID], [E_ID]) VALUES (5, 5, 5)
SET IDENTITY_INSERT [dbo].[TestedByTable] OFF
SET IDENTITY_INSERT [dbo].[TypeTable] ON 

INSERT [dbo].[TypeTable] ([T_ID], [TypeName]) VALUES (1, N'physicaL')
INSERT [dbo].[TypeTable] ([T_ID], [TypeName]) VALUES (2, N'Remotely')
INSERT [dbo].[TypeTable] ([T_ID], [TypeName]) VALUES (3, N'Part Time')
INSERT [dbo].[TypeTable] ([T_ID], [TypeName]) VALUES (4, N'Half Day')
SET IDENTITY_INSERT [dbo].[TypeTable] OFF
SET IDENTITY_INSERT [dbo].[Withdrawal] ON 

INSERT [dbo].[Withdrawal] ([WithdrawalID], [Name], [Date], [Amount], [Note]) VALUES (1, N'Hassan', CAST(N'2020-01-01 00:00:00.000' AS DateTime), 1003, N'do something')
INSERT [dbo].[Withdrawal] ([WithdrawalID], [Name], [Date], [Amount], [Note]) VALUES (2, N'Yousaf', CAST(N'2020-02-02 00:00:00.000' AS DateTime), 200, N'do finishing')
INSERT [dbo].[Withdrawal] ([WithdrawalID], [Name], [Date], [Amount], [Note]) VALUES (3, N'Ali', CAST(N'2020-03-03 00:00:00.000' AS DateTime), 300, N'do nothing')
INSERT [dbo].[Withdrawal] ([WithdrawalID], [Name], [Date], [Amount], [Note]) VALUES (4, N'Shakeel', CAST(N'2020-04-04 00:00:00.000' AS DateTime), 400, N'do early')
INSERT [dbo].[Withdrawal] ([WithdrawalID], [Name], [Date], [Amount], [Note]) VALUES (5, N'Hasnain', CAST(N'2020-05-05 00:00:00.000' AS DateTime), 500, N'do fair work')
INSERT [dbo].[Withdrawal] ([WithdrawalID], [Name], [Date], [Amount], [Note]) VALUES (1006, N'Haris', CAST(N'2020-09-09 00:00:00.000' AS DateTime), 100, N'Don''t Ask')
INSERT [dbo].[Withdrawal] ([WithdrawalID], [Name], [Date], [Amount], [Note]) VALUES (2007, N'Aadil', CAST(N'2020-09-12 00:00:00.000' AS DateTime), 900, N'kokprew')
INSERT [dbo].[Withdrawal] ([WithdrawalID], [Name], [Date], [Amount], [Note]) VALUES (3007, N'Haris', CAST(N'2020-09-13 00:00:00.000' AS DateTime), 1500, N'sfwer')
SET IDENTITY_INSERT [dbo].[Withdrawal] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Consulta__B7B2E7DCAE1528AA]    Script Date: 9/29/2020 12:48:58 AM ******/
ALTER TABLE [dbo].[ConsultantTable] ADD UNIQUE NONCLUSTERED 
(
	[Cons_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Employee__78113480AA388E98]    Script Date: 9/29/2020 12:48:58 AM ******/
ALTER TABLE [dbo].[EmployeeTable] ADD  CONSTRAINT [UQ__Employee__78113480AA388E98] UNIQUE NONCLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__LoginInf__536C85E4196EE94D]    Script Date: 9/29/2020 12:48:58 AM ******/
ALTER TABLE [dbo].[LoginInfoTable] ADD  CONSTRAINT [UQ__LoginInf__536C85E4196EE94D] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AcademyIncomeTable]  WITH CHECK ADD  CONSTRAINT [FK__AcademyIn__Std_I__38996AB5] FOREIGN KEY([Std_ID])
REFERENCES [dbo].[StudentsTable] ([Std_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[AcademyIncomeTable] CHECK CONSTRAINT [FK__AcademyIn__Std_I__38996AB5]
GO
ALTER TABLE [dbo].[AttendanceTable]  WITH CHECK ADD  CONSTRAINT [FK__Attendanc__State__398D8EEE] FOREIGN KEY([State_ID])
REFERENCES [dbo].[StatusTable] ([State_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[AttendanceTable] CHECK CONSTRAINT [FK__Attendanc__State__398D8EEE]
GO
ALTER TABLE [dbo].[AttendanceTable]  WITH CHECK ADD  CONSTRAINT [FK__Attendance__E_ID__3A81B327] FOREIGN KEY([E_ID])
REFERENCES [dbo].[EmployeeTable] ([E_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[AttendanceTable] CHECK CONSTRAINT [FK__Attendance__E_ID__3A81B327]
GO
ALTER TABLE [dbo].[ConsultantTable]  WITH CHECK ADD  CONSTRAINT [FK__Consultant__G_ID__3B75D760] FOREIGN KEY([G_ID])
REFERENCES [dbo].[GenderTable] ([G_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ConsultantTable] CHECK CONSTRAINT [FK__Consultant__G_ID__3B75D760]
GO
ALTER TABLE [dbo].[EmployeeSkillTable]  WITH CHECK ADD  CONSTRAINT [FK__EmployeeSk__E_ID__3D5E1FD2] FOREIGN KEY([E_ID])
REFERENCES [dbo].[EmployeeTable] ([E_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[EmployeeSkillTable] CHECK CONSTRAINT [FK__EmployeeSk__E_ID__3D5E1FD2]
GO
ALTER TABLE [dbo].[EmployeeSkillTable]  WITH CHECK ADD  CONSTRAINT [FK__EmployeeSk__S_ID__3E52440B] FOREIGN KEY([S_ID])
REFERENCES [dbo].[SkillsTable] ([S_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[EmployeeSkillTable] CHECK CONSTRAINT [FK__EmployeeSk__S_ID__3E52440B]
GO
ALTER TABLE [dbo].[EmployeeTable]  WITH CHECK ADD  CONSTRAINT [FK__EmployeeTa__D_ID__3F466844] FOREIGN KEY([D_ID])
REFERENCES [dbo].[DesignationTable] ([D_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[EmployeeTable] CHECK CONSTRAINT [FK__EmployeeTa__D_ID__3F466844]
GO
ALTER TABLE [dbo].[EmployeeTable]  WITH CHECK ADD  CONSTRAINT [FK__EmployeeTa__G_ID__403A8C7D] FOREIGN KEY([G_ID])
REFERENCES [dbo].[GenderTable] ([G_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[EmployeeTable] CHECK CONSTRAINT [FK__EmployeeTa__G_ID__403A8C7D]
GO
ALTER TABLE [dbo].[EmployeeTable]  WITH CHECK ADD  CONSTRAINT [FK__EmployeeTa__Q_ID__412EB0B6] FOREIGN KEY([Q_ID])
REFERENCES [dbo].[QualificationTable] ([Q_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[EmployeeTable] CHECK CONSTRAINT [FK__EmployeeTa__Q_ID__412EB0B6]
GO
ALTER TABLE [dbo].[EmployeeTable]  WITH CHECK ADD  CONSTRAINT [FK__EmployeeTa__T_ID__4222D4EF] FOREIGN KEY([T_ID])
REFERENCES [dbo].[TypeTable] ([T_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[EmployeeTable] CHECK CONSTRAINT [FK__EmployeeTa__T_ID__4222D4EF]
GO
ALTER TABLE [dbo].[LoginInfoTable]  WITH CHECK ADD  CONSTRAINT [FK__LoginInfo__Role___4316F928] FOREIGN KEY([Role_ID])
REFERENCES [dbo].[RoleTable] ([Role_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[LoginInfoTable] CHECK CONSTRAINT [FK__LoginInfo__Role___4316F928]
GO
ALTER TABLE [dbo].[ProjectAssignedTable]  WITH CHECK ADD  CONSTRAINT [FK__ProjectAs__Pro_I__440B1D61] FOREIGN KEY([Pro_ID])
REFERENCES [dbo].[ProjectTable] ([Pro_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ProjectAssignedTable] CHECK CONSTRAINT [FK__ProjectAs__Pro_I__440B1D61]
GO
ALTER TABLE [dbo].[ProjectExpense]  WITH CHECK ADD  CONSTRAINT [FK__ProjectEx__Pro_I__45F365D3] FOREIGN KEY([Pro_ID])
REFERENCES [dbo].[ProjectTable] ([Pro_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ProjectExpense] CHECK CONSTRAINT [FK__ProjectEx__Pro_I__45F365D3]
GO
ALTER TABLE [dbo].[ProjectIncomeTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectIncomeTable_ProjectTable] FOREIGN KEY([Project_id])
REFERENCES [dbo].[ProjectTable] ([Pro_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ProjectIncomeTable] CHECK CONSTRAINT [FK_ProjectIncomeTable_ProjectTable]
GO
ALTER TABLE [dbo].[TestedByTable]  WITH CHECK ADD  CONSTRAINT [FK__TestedByT__Pro_I__48CFD27E] FOREIGN KEY([Pro_ID])
REFERENCES [dbo].[ProjectTable] ([Pro_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[TestedByTable] CHECK CONSTRAINT [FK__TestedByT__Pro_I__48CFD27E]
GO
/****** Object:  StoredProcedure [dbo].[absentattendance]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[absentattendance]
as
begin
select count(*) as Absent from AttendanceTable where Date=(SELECT CAST( GETDATE() AS Date )) AND InTime 
is not null AND State_ID = 1 
end

GO
/****** Object:  StoredProcedure [dbo].[Academy_Income_Month]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Academy_Income_Month]
@dateTodayS date,@dateTodayE date
as
begin
  declare @Acad_in_sum float,@Pro_in_sum float,@adda float

  select @Acad_in_sum=sum(Amount) from AcademyIncomeTable where Date between @dateTodayS and @dateTodayE


  if (@Acad_in_sum IS NULL)
  BEGIN
set @Acad_in_sum=0
  END




  set @adda=@Acad_in_sum
 select @adda;
 end


GO
/****** Object:  StoredProcedure [dbo].[Academydatashowbyacademyincomeid]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Academydatashowbyacademyincomeid] @id int
as
begin
select AI_ID,StudentsTable.Std_ID,StudentsTable.Name,Amount,Date,Note from AcademyIncomeTable left join StudentsTable on AcademyIncomeTable.Std_ID=StudentsTable.Std_ID where AI_ID=@id
end



GO
/****** Object:  StoredProcedure [dbo].[Academydatashowbyids]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Academydatashowbyids] @id int
as
begin
select AI_ID,StudentsTable.Std_ID,StudentsTable.Name,Amount,Date,Note from AcademyIncomeTable left join StudentsTable on AcademyIncomeTable.Std_ID=StudentsTable.Std_ID where StudentsTable.Std_ID=@id
end



GO
/****** Object:  StoredProcedure [dbo].[Academydatashowbyname]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[Academydatashowbyname] @name nvarchar(50)
as
begin
select AI_ID,AcademyIncomeTable.Std_ID,StudentsTable.Name,Amount,Date,Note from AcademyIncomeTable left join StudentsTable on AcademyIncomeTable.AI_ID=StudentsTable.Std_ID where StudentsTable.Name=@name
end



GO
/****** Object:  StoredProcedure [dbo].[AcademydatasortbyDATE]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[AcademydatasortbyDATE]
as
begin
select AI_ID,AcademyIncomeTable.Std_ID,StudentsTable.Name,Amount,Date,Note from AcademyIncomeTable left join StudentsTable on AcademyIncomeTable.Std_ID=StudentsTable.Std_ID order by AcademyIncomeTable.Date
end




GO
/****** Object:  StoredProcedure [dbo].[Academydatasortbyname]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Academydatasortbyname]
as
begin
select AcademyIncomeTable.Std_ID,StudentsTable.Name,Amount,Date,Note from AcademyIncomeTable left join StudentsTable on AcademyIncomeTable.AI_ID=StudentsTable.Std_ID order by StudentsTable.Name
end


GO
/****** Object:  StoredProcedure [dbo].[Academyincomedatasortbyname]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Academyincomedatasortbyname]
as
begin
select AI_ID,AcademyIncomeTable.Std_ID,StudentsTable.Name,Amount,Date,Note from AcademyIncomeTable left join StudentsTable on AcademyIncomeTable.Std_ID=StudentsTable.Std_ID order by StudentsTable.Name
end



GO
/****** Object:  StoredProcedure [dbo].[Active_consultant]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Active_consultant]
as
begin
Select count( distinct ct.C_ID) from ProjectTable pt join ConsultantTable ct on pt.C_ID=ct.C_ID where pt.Date_Of_Completion is not NULL
end



GO
/****** Object:  StoredProcedure [dbo].[addconsultant]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addconsultant] @name nvarchar(50), @Fname nvarchar(50), @dob date,@gname nvarchar(50), @address nvarchar(50), @phone1 nvarchar(50), @phone2 nvarchar(50),@uniqueConsId nvarchar(50)
as
begin
insert into ConsultantTable (Name,F_Name,DOB,G_ID,Address,Phone1,Phone2,Cons_ID) 
values (@name,@Fname,@dob,(select G_ID from GenderTable where GenderName=@gname),@address,@phone1,@phone2,@uniqueConsId)
end


GO
/****** Object:  StoredProcedure [dbo].[addincome]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[addincome] @stdid int, @amount float, @note nvarchar(50), @date date
as
begin
insert into AcademyIncomeTable values (@stdid,@amount,@note,@date)
end



GO
/****** Object:  StoredProcedure [dbo].[addprojectincome]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[addprojectincome] @pro_id int, @amount float, @note nvarchar(50), @date date
as
begin
insert into ProjectIncomeTable values (@pro_id,@amount,@note,@date)
end



GO
/****** Object:  StoredProcedure [dbo].[AllAcademydatashow]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AllAcademydatashow]
as
begin
select AI_ID,AcademyIncomeTable.Std_ID,StudentsTable.Name,Amount,Date,Note from AcademyIncomeTable left join StudentsTable on AcademyIncomeTable.Std_ID=StudentsTable.Std_ID
end

GO
/****** Object:  StoredProcedure [dbo].[AllExpenseAmountSum]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[AllExpenseAmountSum] @year int, @month int
as
begin
declare @pe float;
declare @re float;
declare @es float;
SELECT @pe=sum(Amount)  FROM ProjectExpense where YEAR(Date)=@year AND MONTH(Date)=@month
SELECT @re=sum(Amount)  FROM Regular_Expenses where YEAR(Date)=@year AND MONTH(Date)=@month	
SELECT @es=sum(Amount)  FROM Employee_Salaries where YEAR(Date)=@year AND MONTH(Date)=@month
SELECT @pe as ProjectExpense ,@re as RegularExpense,@es as EmployeeSalaries
end





GO
/****** Object:  StoredProcedure [dbo].[Allprojectdatashow]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Allprojectdatashow]
as
begin
select PI_ID,projectTable.Name,ProjectTable.Pro_ID,ProjectIncomeTable.Amount,Date,Note from ProjectIncomeTable left join ProjectTable on ProjectIncomeTable.Project_id=ProjectTable.Pro_ID
end



GO
/****** Object:  StoredProcedure [dbo].[assignedprojectEmployee]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[assignedprojectEmployee] @id int
  as
  begin
  select et.Name from ProjectAssignedTable pat join EmployeeTable et on  pat.E_ID=et.E_ID where pat.Pro_ID=@id
  end


GO
/****** Object:  StoredProcedure [dbo].[attendence_marked]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[attendence_marked]
as
begin
select count(*) from AttendanceTable where InTime is not NULL and Date = (SELECT CAST( GETDATE() AS Date ))
end
GO
/****** Object:  StoredProcedure [dbo].[attendence_Unmarked]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[attendence_Unmarked]
as
begin
select count(*) from AttendanceTable where InTime is NULL and Date = (SELECT CAST( GETDATE() AS Date ))
end
GO
/****** Object:  StoredProcedure [dbo].[completed_project_names]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[completed_project_names] @id nvarchar(50)
as
begin
select ProjectTable.Name 
from ProjectAssignedTable 
left join ProjectTable 
	on ProjectAssignedTable.Pro_ID = ProjectTable.Pro_ID  
where 
	ProjectAssignedTable.E_ID = (select E_ID from EmployeeTable where Employee_ID=@id ) 
	AND 
	ProjectTable.Date_Of_Completion is NULL
end


GO
/****** Object:  StoredProcedure [dbo].[ConsultantCompletedProject]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ConsultantCompletedProject] @id nvarchar(50)
as
begin
SELECT (select Name from ConsultantTable where Cons_ID=@id) As Cons_Name ,Name as ProjectName FROM ProjectTable  where C_ID=(select C_ID from ConsultantTable where Cons_ID=@id) And Date_Of_Completion is not Null
end


GO
/****** Object:  StoredProcedure [dbo].[ConsultantdetailsbyUniqueId]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ConsultantdetailsbyUniqueId] @id nvarchar(50)
as
begin
SELECT Cons_ID, CT.Name,F_Name,DOB,gt.GenderName,Address,Phone1,Phone2 FROM ConsultantTable CT LEFT JOIN GenderTable gt on CT.G_ID = gt.G_ID where Cons_ID=@id
end


GO
/****** Object:  StoredProcedure [dbo].[ConsultantEarning]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ConsultantEarning] @id varchar(50)
as
begin

declare @s float;

SELECT @s=sum(Amount)  FROM ProjectTable  
	where C_ID=(select C_ID from ConsultantTable where Cons_ID=@id) 
	And 
	Date_Of_Completion is not  Null

SELECT top 1 ( 0.2 * @s) as Consultant_earning 

end


GO
/****** Object:  StoredProcedure [dbo].[ConsultantExpectedEarning]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[ConsultantExpectedEarning] @id nvarchar(50)
as
begin

declare @s float;

SELECT @s=sum(Amount)  FROM ProjectTable  
where   C_ID=(select C_ID from ConsultantTable where Cons_ID=@id) 
		And 
		Date_Of_Completion is  Null

SELECT top 1 ( 0.2 * @s) as Consultant_Cut FROM ProjectTable  
	where C_ID=(select C_ID from ConsultantTable where Cons_ID=@id) 
	And 
	Date_Of_Completion is  Null
end


GO
/****** Object:  StoredProcedure [dbo].[ConsultantOngoingProject]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ConsultantOngoingProject] @id nvarchar(50)
as
begin
SELECT (select Name from ConsultantTable where Cons_ID=@id) As Cons_Name ,Name as ProjectName FROM ProjectTable  where C_ID=(select C_ID from ConsultantTable where Cons_ID=@id) And Date_Of_Completion is Null
end


GO
/****** Object:  StoredProcedure [dbo].[count_employees]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[count_employees]
as
begin
select count(*) from EmployeeTable
end


GO
/****** Object:  StoredProcedure [dbo].[datashowfromattendance]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[datashowfromattendance]
as
begin
select Att_ID,EmployeeTable.Name,AttendanceTable.E_ID,Date,InTime,OutTime,StatusTable.Name from AttendanceTable left join EmployeeTable on AttendanceTable.E_ID = EmployeeTable.E_ID left join StatusTable on AttendanceTable.State_ID = StatusTable.State_ID
end
GO
/****** Object:  StoredProcedure [dbo].[datashowfromattendancebyattid]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[datashowfromattendancebyattid] @id int
as
begin
select Att_ID,EmployeeTable.Name,AttendanceTable.E_ID,Date,InTime,OutTime,StatusTable.Name from AttendanceTable left join EmployeeTable on AttendanceTable.E_ID = EmployeeTable.E_ID left join StatusTable on AttendanceTable.State_ID = StatusTable.State_ID where AttendanceTable.Att_ID = @id 
end
GO
/****** Object:  StoredProcedure [dbo].[datashowfromattendancebyid]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[datashowfromattendancebyid] @id int
as
begin
select Att_ID,EmployeeTable.Name,AttendanceTable.E_ID,Date,InTime,OutTime,StatusTable.Name from AttendanceTable left join EmployeeTable on AttendanceTable.E_ID = EmployeeTable.E_ID left join StatusTable on AttendanceTable.State_ID = StatusTable.State_ID where AttendanceTable.E_ID=@id ORDER BY [Date]
end
GO
/****** Object:  StoredProcedure [dbo].[datashowfromattendancebyname]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[datashowfromattendancebyname] @name nvarchar(50)
as
begin
select Att_ID,EmployeeTable.Name,AttendanceTable.E_ID,Date,InTime,OutTime,StatusTable.Name from AttendanceTable left join EmployeeTable on AttendanceTable.E_ID = EmployeeTable.E_ID left join StatusTable on AttendanceTable.State_ID = StatusTable.State_ID where AttendanceTable.E_ID= (select E_ID from EmployeeTable where Name=@name) ORDER BY [Date]
end

GO
/****** Object:  StoredProcedure [dbo].[datashowfromprojectid]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[datashowfromprojectid] @id int
as
begin
select Pro_ID,Date_Of_Start,pt.Name,Description, ConsultantTable.Name, 
Amount,Date_Of_Completion,Date_Of_Delivery,Project_Date   
from ProjectTable pt left join ConsultantTable on Pt.C_ID=ConsultantTable.C_ID   where Pro_ID=@id
end


GO
/****** Object:  StoredProcedure [dbo].[datashowofattendanceofdate]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[datashowofattendanceofdate]
as
begin
select Att_ID,EmployeeTable.Name,AttendanceTable.E_ID,Date,InTime,OutTime,StatusTable.Name from AttendanceTable left join EmployeeTable on AttendanceTable.E_ID = EmployeeTable.E_ID left join StatusTable on AttendanceTable.State_ID = StatusTable.State_ID where Month(Date) = MONTH(GETDATE())   ORDER BY [Date];
end
GO
/****** Object:  StoredProcedure [dbo].[datashowoflogininfobyusername]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[datashowoflogininfobyusername]
@username nvarchar(50)
as
begin
select Username,Password, RoleTable.RoleName from LoginInfoTable left join RoleTable on  RoleTable.Role_ID  = LoginInfoTable.Role_ID where Username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[datashowoflogininfotable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[datashowoflogininfotable]
as
begin
select L_ID,Username,Password, RoleTable.RoleName from LoginInfoTable left join RoleTable on  RoleTable.Role_ID  = LoginInfoTable.Role_ID
end

GO
/****** Object:  StoredProcedure [dbo].[deletelogininfotabless]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletelogininfotabless]  @username nvarchar(50)
as
begin
delete from LoginInfoTable Where Username=@username
end

GO
/****** Object:  StoredProcedure [dbo].[employee_id]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[employee_id] @id nvarchar(50)
as
begin
select Name,Employee_ID, TypeTable.TypeName,Salary from EmployeeTable left join TypeTable on EmployeeTable.T_ID=TypeTable.T_ID where Employee_ID=@id
end


GO
/****** Object:  StoredProcedure [dbo].[employee_name]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[employee_name] @name nvarchar(50)
as
begin
select Name,Employee_ID, TypeTable.TypeName,Salary from EmployeeTable left join TypeTable on EmployeeTable.T_ID=TypeTable.T_ID where Name=@name
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_EmployeesRecord]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_EmployeesRecord] @v_name nvarchar(50), @v_FName nvarchar(50), @v_CNIC nvarchar(50), @v_DOB date, @v_address nvarchar(50), @v_agreement nvarchar(50), @typename nvarchar(50), @gendername nvarchar(50), @postname nvarchar(50), @qualificationname nvarchar(50), @phone1 nvarchar(50), @phone2 nvarchar(50), @employeeid nvarchar(50), @salary float
as
begin
insert into EmployeeTable values  (@v_name, @v_FName , @v_CNIC,@v_DOB, @v_address ,@v_agreement,(select T_ID from TypeTable where TypeName=@typename), (select G_ID from GenderTable where GenderName=@gendername), (select D_ID from DesignationTable where PostName=@postname ), (select Q_ID from QualificationTable where QName=@qualificationname),@phone1,@phone2,@employeeid,@salary)
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_ProjectDetail]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_ProjectDetail] @v_dateofstart date, @v_name nvarchar(50), @v_description nvarchar(50), @v_cname nvarchar(50), @v_amount float, @v_dateofcompletion date, @v_dateofdelivery date, @v_projectdate date
as
begin
insert into ProjectTable values ( @v_dateofstart, @v_name, @v_description,(select C_ID from ConsultantTable where Name=@v_cname), @v_amount, @v_dateofcompletion, @v_dateofdelivery, @v_projectdate)
  
end
GO
/****** Object:  StoredProcedure [dbo].[insertdatainlogintabless]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertdatainlogintabless] @username nvarchar(50),@password nvarchar(50), @rolename nvarchar(50) 
as
begin
insert LoginInfoTable (Username,Password,Role_ID)
values(@username,@password,(select Role_Id from RoleTable where RoleName=@rolename))
end

GO
/****** Object:  StoredProcedure [dbo].[lateattendance]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[lateattendance]
as
begin
select count(*) as Late from AttendanceTable where Date=(SELECT CAST( GETDATE() AS Date )) AND InTime 
is not null AND State_ID = 3 
end

GO
/****** Object:  StoredProcedure [dbo].[leaveattendance]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[leaveattendance]
as
begin
select count(*) as Leave from AttendanceTable where Date=(SELECT CAST( GETDATE() AS Date )) AND InTime 
is not null AND State_ID = 4
end

GO
/****** Object:  StoredProcedure [dbo].[markedattendance]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[markedattendance]
as
begin 
select count(*) as Marked from AttendanceTable where Date=(SELECT CAST( GETDATE() AS Date )) AND InTime is not null 
end

GO
/****** Object:  StoredProcedure [dbo].[markedattendancesearchbyid]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[markedattendancesearchbyid] @id int
as
begin 
select 
(select Name from EmployeeTable et where et.E_ID=at.E_ID),
E_ID,Date,InTime,OutTime, 
(select  Name from StatusTable st where st.State_ID=at.State_ID)
from AttendanceTable at



where Date=(SELECT CAST( GETDATE() AS Date )) AND InTime is not null AND E_ID=@id
end

GO
/****** Object:  StoredProcedure [dbo].[markedattendancesearchbyname]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[markedattendancesearchbyname] @name nvarchar(50)
as
begin 
select 
(select Name from EmployeeTable et where et.E_ID=at.E_ID),
E_ID,Date,InTime,OutTime, 
(select  Name from StatusTable st where st.State_ID=at.State_ID)
from AttendanceTable at
where Date=(SELECT CAST( GETDATE() AS Date )) AND InTime is not null 
AND E_ID= (select E_ID from EmployeeTable where Name=@name)        


end

GO
/****** Object:  StoredProcedure [dbo].[MarkOutAttendence]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[MarkOutAttendence] @id int
as
begin
UPDATE AttendanceTable
SET OutTime = Convert(Time(0), GetDate())
WHERE E_ID=@id; 
end

GO
/****** Object:  StoredProcedure [dbo].[NotActive_consultant]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[NotActive_consultant]
as
begin
SELECT (select count (*) from ConsultantTable ) - (Select count( distinct ct.C_ID) from ProjectTable pt join ConsultantTable ct on pt.C_ID=ct.C_ID where pt.Date_Of_Completion is not NULL)
end


GO
/****** Object:  StoredProcedure [dbo].[ongoing_project]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ongoing_project]
as
begin
select count(*) from projectTable where Date_Of_Delivery is NULL
end
 


GO
/****** Object:  StoredProcedure [dbo].[ongoing_project_names]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ongoing_project_names] @id nvarchar(50)
as
begin
select ProjectTable.Name 
from ProjectAssignedTable 
left join ProjectTable 
	on ProjectAssignedTable.Pro_ID = ProjectTable.Pro_ID  
where 
	ProjectAssignedTable.E_ID = (select E_ID from EmployeeTable where Employee_ID=@id) 
	AND 
	ProjectTable.Date_Of_Completion is not NULL
end


GO
/****** Object:  StoredProcedure [dbo].[physical_appearence]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[physical_appearence]
as
begin
select count(*) from EmployeeTable left join TypeTable on EmployeeTable .T_id = TypeTable.T_id where TypeTable.TypeName='physical'
end


GO
/****** Object:  StoredProcedure [dbo].[presentattendance]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[presentattendance]
as
begin
select count(*) as Present from AttendanceTable where Date=(SELECT CAST( GETDATE() AS Date )) AND InTime 
is not null AND State_ID = 2 
end

GO
/****** Object:  StoredProcedure [dbo].[ProcAcademyIncomeSum_Month]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcAcademyIncomeSum_Month]
as
begin
select sum(Amount) from AcademyIncomeTable where (select MONTH( Date )) = (SELECT MONTH( Cast (GETDATE() as Date))) AND (select YEAR(AcademyIncomeTable.Date)) = (SELECT YEAR( Cast (GETDATE() as Date)))
end
GO
/****** Object:  StoredProcedure [dbo].[ProcAcademyIncomeSum_Year]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcAcademyIncomeSum_Year]
as
begin
select sum(Amount) from AcademyIncomeTable where (select YEAR( Date )) = (SELECT YEAR( Cast (GETDATE() as Date)))
end

GO
/****** Object:  StoredProcedure [dbo].[ProcAddDesignation]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcAddDesignation]
@name nvarchar(50)
as
begin
insert into DesignationTable values(@name)
end
GO
/****** Object:  StoredProcedure [dbo].[ProcAddEmpSkill]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcAddEmpSkill]
@EmpId nvarchar(50), @Skillname nvarchar(50)
as
begin
insert into EmployeeSkillTable values((select E_ID from EmployeeTable where Employee_ID = @EmpId), (select S_ID from SkillsTable where SkillName = @Skillname))
end
GO
/****** Object:  StoredProcedure [dbo].[ProcAddEmpType]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcAddEmpType]
@name nvarchar(50)
as
begin
insert into TypeTable values(@name)
end
GO
/****** Object:  StoredProcedure [dbo].[ProcAddProjectExpense]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcAddProjectExpense] @pname nvarchar(50),@ename nvarchar(50), @amount float, @date date, @note nvarchar(50)
as
begin
insert into ProjectExpense values ((select Pro_ID from ProjectTable where Name=@pname),(select E_ID from EmployeeTable where Name=@ename),@amount,@date,@note)
end

GO
/****** Object:  StoredProcedure [dbo].[ProcAddQualification]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ProcAddQualification]
@name nvarchar(50)
as
begin
insert into QualificationTable values(@name)
end
GO
/****** Object:  StoredProcedure [dbo].[ProcAttendenceShowBySpecific_Day]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcAttendenceShowBySpecific_Day] @year int,@month int,@day int
as
begin
Select 
AttendanceTable.Att_ID,
EmployeeTable.Name as EmployeeName,
AttendanceTable.E_ID as EmployeeId,
AttendanceTable.Date,AttendanceTable.InTime,AttendanceTable.OutTime, StatusTable.Name as Status
from 
AttendanceTable
 left join
  EmployeeTable
   on
    AttendanceTable.E_ID=EmployeeTable.E_ID left join StatusTable on AttendanceTable.State_ID= StatusTable.State_ID
	 where
	 YEAR(Date)=@year
	 AND 
	 MONTH(Date)=@month
	 AND
	 DAY(Date)=@day
	 
end
GO
/****** Object:  StoredProcedure [dbo].[ProcAttendenceShowBySpecific_Month]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcAttendenceShowBySpecific_Month] @year int,@month int
as
begin
Select 
AttendanceTable.Att_ID,
EmployeeTable.Name as EmployeeName,
AttendanceTable.E_ID as EmployeeId,
AttendanceTable.Date,AttendanceTable.InTime,AttendanceTable.OutTime, StatusTable.Name as Status
from 
AttendanceTable
 left join
  EmployeeTable
   on
    AttendanceTable.E_ID=EmployeeTable.E_ID left join StatusTable on AttendanceTable.State_ID= StatusTable.State_ID
	 where
	 YEAR(Date)=@year
	 AND 
	 MONTH(Date)=@month	 
end
GO
/****** Object:  StoredProcedure [dbo].[ProcAttendenceShowBySpecific_Year]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcAttendenceShowBySpecific_Year] @year int
as
begin
Select 
AttendanceTable.Att_ID,
EmployeeTable.Name as EmployeeName,
AttendanceTable.E_ID as EmployeeId,
AttendanceTable.Date,AttendanceTable.InTime,AttendanceTable.OutTime, StatusTable.Name as Status
from 
AttendanceTable
 left join
  EmployeeTable
   on
    AttendanceTable.E_ID=EmployeeTable.E_ID left join StatusTable on AttendanceTable.State_ID= StatusTable.State_ID
	 where
	 YEAR(Date)=@year 
end
GO
/****** Object:  StoredProcedure [dbo].[ProcConsultantDetail]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcConsultantDetail]
as
begin
SELECT Cons_ID,Name as ConsultantName,Phone1,Phone2 FROM ConsultantTable
end

GO
/****** Object:  StoredProcedure [dbo].[ProcDeleteEmployeeSalaries]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcDeleteEmployeeSalaries] @id int
as
begin
delete from Employee_Salaries where ES_ID=@id
end

GO
/****** Object:  StoredProcedure [dbo].[ProcDeleteFromConsultantTable]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[ProcDeleteFromConsultantTable] @UConsId nvarchar(50)
as
begin
	delete from ConsultantTable where Cons_ID=@UConsId;
end


GO
/****** Object:  StoredProcedure [dbo].[ProcDeleteProjectExpense]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcDeleteProjectExpense] @id int
as
begin
delete from ProjectExpense where PE_ID=@id
end

GO
/****** Object:  StoredProcedure [dbo].[ProcDeleteRegularExpense]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcDeleteRegularExpense]
@id int
as
begin
delete from Regular_Expenses where RE_ID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[ProcDeleteWithdrawal]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcDeleteWithdrawal]
@id int
as
begin
delete from Withdrawal where WithdrawalID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[ProcEmployeeSalariesDetailSearchByName]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[ProcEmployeeSalariesDetailSearchByName] @name nvarchar(50)
as
begin

SELECT 
 Employee_Salaries.ES_ID,
 EmployeeTable.Name as EmployeeName, 
 Amount, 
 Date,
 Note 
 from
  Employee_Salaries 
  left join
   EmployeeTable 
   on 
   Employee_Salaries.E_ID=EmployeeTable.E_ID where EmployeeTable.Name=@name
end



GO
/****** Object:  StoredProcedure [dbo].[ProcEmployeeSalariesDetailSearchBySpecific_Day]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[ProcEmployeeSalariesDetailSearchBySpecific_Day] @year int,@month int,@day int
as
begin

SELECT 
  Employee_Salaries.ES_ID,
  EmployeeTable.Name as EmployeeName, 
 Amount, 
 Date,
 Note 
 from
  Employee_Salaries 
  left join
   EmployeeTable 
   on 
   Employee_Salaries.E_ID=EmployeeTable.E_ID
   where
   YEAR(Date)=@year
   AND 
   MONTH(Date)=@month
   AND
   DAY(Date)=@day
end



GO
/****** Object:  StoredProcedure [dbo].[ProcEmployeeSalariesDetailSearchBySpecific_Month]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE proc [dbo].[ProcEmployeeSalariesDetailSearchBySpecific_Month] @year int,@month int
as
begin

SELECT 
  Employee_Salaries.ES_ID,
  EmployeeTable.Name as EmployeeName, 
 Amount, 
 Date,
 Note 
 from
  Employee_Salaries 
  left join
   EmployeeTable 
   on 
   Employee_Salaries.E_ID=EmployeeTable.E_ID
   where
   YEAR(Date)=@year
   AND 
   MONTH(Date)=@month
end




GO
/****** Object:  StoredProcedure [dbo].[ProcEmployeeSalariesDetailSearchBySpecific_Year]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE proc [dbo].[ProcEmployeeSalariesDetailSearchBySpecific_Year] @year int
as
begin

SELECT 
  Employee_Salaries.ES_ID,
  EmployeeTable.Name as EmployeeName, 
 Amount, 
 Date,
 Note 
 from
  Employee_Salaries 
  left join
   EmployeeTable 
   on 
   Employee_Salaries.E_ID=EmployeeTable.E_ID
   where
   YEAR(Date)=@year
end




GO
/****** Object:  StoredProcedure [dbo].[ProcEmployeeSalariesDetailShow]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[ProcEmployeeSalariesDetailShow]
as
begin

SELECT 
 Employee_Salaries.ES_ID,
 EmployeeTable.Name as EmployeeName, 
 Amount, 
 Date,
 Note 
 from
  Employee_Salaries 
  left join
   EmployeeTable 
   on 
   Employee_Salaries.E_ID=EmployeeTable.E_ID
end


GO
/****** Object:  StoredProcedure [dbo].[ProcEmployeeSalariesDetailShowSortByAmountAsc]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[ProcEmployeeSalariesDetailShowSortByAmountAsc]
as
begin

SELECT 
  Employee_Salaries.ES_ID,
  EmployeeTable.Name as EmployeeName, 
 Amount, 
 Date,
 Note 
 from
  Employee_Salaries 
  left join
   EmployeeTable 
   on 
   Employee_Salaries.E_ID=EmployeeTable.E_ID order by Amount
end


GO
/****** Object:  StoredProcedure [dbo].[ProcEmployeeSalariesDetailShowSortByAmountDesc]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[ProcEmployeeSalariesDetailShowSortByAmountDesc]
as
begin

SELECT 
 Employee_Salaries.ES_ID,
 EmployeeTable.Name as EmployeeName, 
 Amount, 
 Date,
 Note 
 from
  Employee_Salaries 
  left join
   EmployeeTable 
   on 
   Employee_Salaries.E_ID=EmployeeTable.E_ID order by Amount desc
end


GO
/****** Object:  StoredProcedure [dbo].[ProcEmployeeSalariesDetailShowSortByE_Name]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[ProcEmployeeSalariesDetailShowSortByE_Name]
as
begin

SELECT 
  Employee_Salaries.ES_ID,
  EmployeeTable.Name as EmployeeName, 
 Amount, 
 Date,
 Note 
 from
  Employee_Salaries 
  left join
   EmployeeTable 
   on 
   Employee_Salaries.E_ID=EmployeeTable.E_ID order by EmployeeTable.Name
end

GO
/****** Object:  StoredProcedure [dbo].[ProcEmployeesSalariesDetailSearchByEmpSalaryId]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create proc [dbo].[ProcEmployeesSalariesDetailSearchByEmpSalaryId] @id int
as
begin

SELECT 
  Employee_Salaries.ES_ID,
  EmployeeTable.Name as EmployeeName, 
 Amount, 
 Date,
 Note 
 from
  Employee_Salaries 
  left join
   EmployeeTable 
   on 
   Employee_Salaries.E_ID=EmployeeTable.E_ID where Employee_Salaries.ES_ID = @id
end


GO
/****** Object:  StoredProcedure [dbo].[ProcEmployeesSalariesDetailSearchById]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcEmployeesSalariesDetailSearchById] @id int
as
begin

SELECT 
  Employee_Salaries.ES_ID,
  EmployeeTable.Name as EmployeeName, 
 Amount, 
 Date,
 Note 
 from
  Employee_Salaries 
  left join
   EmployeeTable 
   on 
   Employee_Salaries.E_ID=EmployeeTable.E_ID where Employee_Salaries.E_ID = (select E_ID from EmployeeTable where Employee_ID = @id)
end

GO
/****** Object:  StoredProcedure [dbo].[ProcInsertEmplyeeSalaries]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcInsertEmplyeeSalaries] @ename nvarchar(50), @amount float, @date date, @note nvarchar(50)
as
begin
insert into Employee_Salaries values
((select E_ID from EmployeeTable where Name= @ename),@amount,@date,@note)
end

GO
/****** Object:  StoredProcedure [dbo].[ProcInsertRegularExpense]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcInsertRegularExpense]
@amount float, @description nvarchar(max), @date date
as
begin
insert into Regular_Expenses values(@amount, @description, @date)
end


GO
/****** Object:  StoredProcedure [dbo].[ProcInsertSkills]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcInsertSkills]
@name nvarchar(50)
as
begin
insert into SkillsTable values(@name)
end
GO
/****** Object:  StoredProcedure [dbo].[ProcInsertWithdrawal]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcInsertWithdrawal]
@Name nvarchar(50), @date datetime, @amount float, @note Nvarchar(250)
as
begin
insert into Withdrawal values(@Name,@date,@amount,@note)
end
GO
/****** Object:  StoredProcedure [dbo].[ProcMarkedAttendenceShow]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcMarkedAttendenceShow]
as
begin
Select EmployeeTable.Name as EmployeeName,
AttendanceTable.E_ID as EmployeeId,
AttendanceTable.Date,
AttendanceTable.InTime,
AttendanceTable.OutTime,
 StatusTable.Name as Status
from 
AttendanceTable
 left join
  EmployeeTable
   on
    AttendanceTable.E_ID=EmployeeTable.E_ID left join StatusTable on AttendanceTable.State_ID= StatusTable.State_ID
	 where
	 InTime is not NULL AND Date=(Select Cast (GETDATE() as Date ) as Date)


end

GO
/****** Object:  StoredProcedure [dbo].[ProcMarkingAttendence]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcMarkingAttendence] @id int,@stat nvarchar(50)
as
begin
declare @a varchar(50),@b varchar(50),@status nvarchar(50)	
set @a=(select convert(varchar, getdate(), 8))
set @b=(select Intime from OfficeTimeTable )

if (@stat='Present')
begin

if (@a >@b )
begin
set @status='Late'
end

if (@a <@b )
begin
set @status='Present'
end
end

if (@stat='Leave')
begin
set @status='Leave'
end


if (@stat='Absent')
begin
set @status='Absent'
end

UPDATE AttendanceTable
SET InTime=@a,State_ID=(select State_ID from StatusTable where Name=@status) where E_ID=@id and Date=(select convert(varchar, getdate(), 23))

 end

GO
/****** Object:  StoredProcedure [dbo].[ProcMarkOutAttendance]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcMarkOutAttendance]
@id int
as
begin
update AttendanceTable set OutTime = (select convert(varchar, getdate(), 8)) where E_ID = @id AND Date = (select convert(varchar, getdate(), 1))
end
GO
/****** Object:  StoredProcedure [dbo].[ProcMonthlyEmployeeSalaries]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcMonthlyEmployeeSalaries]
@year int,@month int
as
begin
select sum(Amount) as MonthlyExpense from Employee_Salaries where 
     YEAR(Date)=@year
	 AND 
	 MONTH(Date)=@month
end


GO
/****** Object:  StoredProcedure [dbo].[ProcMonthlyProjectExpenses]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcMonthlyProjectExpenses]
@year int,@month int
as
begin
select sum(Amount) as MonthlyExpense from ProjectExpense where 
     YEAR(Date)=@year
	 AND 
	 MONTH(Date)=@month
end


GO
/****** Object:  StoredProcedure [dbo].[ProcMonthlyRegularExpense]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcMonthlyRegularExpense]
@year int,@month int
as
begin
select sum(Amount) as MonthlyExpense from Regular_Expenses where 
     YEAR(Date)=@year
	 AND 
	 MONTH(Date)=@month
end


GO
/****** Object:  StoredProcedure [dbo].[ProcProjectExpenseDetailShow]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[ProcProjectExpenseDetailShow]
as
begin

SELECT 
  ProjectExpense.PE_ID,
  ProjectTable.Name as ProjectName,
  EmployeeTable.Name AS EmployeeName, 
  ProjectExpense.Amount,
  ProjectExpense.Date, 
  ProjectExpense.Note from ProjectExpense 
  left join
     EmployeeTable
   on
    EmployeeTable.E_ID=ProjectExpense.E_ID
  left join 
	 ProjectTable on ProjectTable.Pro_ID=ProjectExpense.Pro_ID
end

GO
/****** Object:  StoredProcedure [dbo].[ProcProjectExpenseDetailShowByProjectExpenseId]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[ProcProjectExpenseDetailShowByProjectExpenseId] @id int
as
begin
SELECT 
ProjectExpense.PE_ID,
ProjectTable.Name as ProjectName, 
EmployeeTable.Name AS EmployeeName,  
ProjectExpense.Amount, 
ProjectExpense.Date, 
ProjectExpense.Note 
from
 ProjectExpense 
 left join 
 EmployeeTable
  on 
  EmployeeTable.E_ID=ProjectExpense.E_ID
   left join 
   ProjectTable 
   on 
   ProjectTable.Pro_ID=ProjectExpense.Pro_ID where ProjectExpense.PE_ID=@id
   end


GO
/****** Object:  StoredProcedure [dbo].[ProcProjectExpenseDetailShowByProjectId]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[ProcProjectExpenseDetailShowByProjectId] @id int
as
begin
SELECT 
ProjectExpense.PE_ID,
ProjectTable.Name as ProjectName, 
EmployeeTable.Name AS EmployeeName,  
ProjectExpense.Amount, 
ProjectExpense.Date, 
ProjectExpense.Note 
from
 ProjectExpense 
 left join 
 EmployeeTable
  on 
  EmployeeTable.E_ID=ProjectExpense.E_ID
   left join 
   ProjectTable 
   on 
   ProjectTable.Pro_ID=ProjectExpense.Pro_ID where ProjectExpense.Pro_ID=@id
   end



GO
/****** Object:  StoredProcedure [dbo].[ProcProjectExpenseDetailShowByProjectName]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[ProcProjectExpenseDetailShowByProjectName] @name nvarchar(50)
as
begin
SELECT
ProjectExpense.PE_ID,
ProjectTable.Name as ProjectName,
EmployeeTable.Name AS EmployeeName,
ProjectExpense.Amount,
ProjectExpense.Date,
 ProjectExpense.Note 
 from
  ProjectExpense 
  left join
	 EmployeeTable
	  on
	  EmployeeTable.E_ID=ProjectExpense.E_ID 
  left join 
  ProjectTable 
  on 
  ProjectTable.Pro_ID=ProjectExpense.Pro_ID where ProjectTable.Name=@name
end







GO
/****** Object:  StoredProcedure [dbo].[ProcProjectExpenseDetailShowBySpecificDay]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[ProcProjectExpenseDetailShowBySpecificDay] @year int, @month int,@day int
as
begin


SELECT 
  ProjectExpense.PE_ID,
  ProjectTable.Name as ProjectName,
  EmployeeTable.Name AS EmployeeName, 
  ProjectExpense.Amount,
  ProjectExpense.Date, 
  ProjectExpense.Note from ProjectExpense 
  left join
     EmployeeTable
   on
    EmployeeTable.E_ID=ProjectExpense.E_ID
  left join 
	 ProjectTable on ProjectTable.Pro_ID=ProjectExpense.Pro_ID
	  where
	 YEAR(Date)=@year
	 AND MONTH(Date)=@month
	 AND DAY(Date)=@day
	 order by Date
end


GO
/****** Object:  StoredProcedure [dbo].[ProcProjectExpenseDetailShowBySpecificMonth]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[ProcProjectExpenseDetailShowBySpecificMonth] @year int, @month int
as
begin


SELECT 
  ProjectExpense.PE_ID,
  ProjectTable.Name as ProjectName,
  EmployeeTable.Name AS EmployeeName, 
  ProjectExpense.Amount,
  ProjectExpense.Date, 
  ProjectExpense.Note from ProjectExpense 
  left join
     EmployeeTable
   on
    EmployeeTable.E_ID=ProjectExpense.E_ID
  left join 
	 ProjectTable on ProjectTable.Pro_ID=ProjectExpense.Pro_ID
	  where
	 YEAR(Date)=@year
	 AND MONTH(Date)=@month
	 order by Date
end


GO
/****** Object:  StoredProcedure [dbo].[ProcProjectExpenseDetailShowBySpecificYear]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[ProcProjectExpenseDetailShowBySpecificYear] @year int
as
begin


SELECT 
  ProjectExpense.PE_ID,
  ProjectTable.Name as ProjectName,
  EmployeeTable.Name AS EmployeeName, 
  ProjectExpense.Amount,
  ProjectExpense.Date, 
  ProjectExpense.Note from ProjectExpense 
  left join
     EmployeeTable
   on
    EmployeeTable.E_ID=ProjectExpense.E_ID
  left join 
	 ProjectTable on ProjectTable.Pro_ID=ProjectExpense.Pro_ID where YEAR(DATE)=@year order by Date

end


GO
/****** Object:  StoredProcedure [dbo].[ProcProjectExpenseDetailShowSortByDate]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[ProcProjectExpenseDetailShowSortByDate]
as
begin

SELECT 
  ProjectExpense.PE_ID,
  ProjectTable.Name as ProjectName,
  EmployeeTable.Name AS EmployeeName, 
  ProjectExpense.Amount,
  ProjectExpense.Date, 
  ProjectExpense.Note from ProjectExpense 
  left join
     EmployeeTable
   on
    EmployeeTable.E_ID=ProjectExpense.E_ID
  left join 
	 ProjectTable on ProjectTable.Pro_ID=ProjectExpense.Pro_ID order by Date
end

GO
/****** Object:  StoredProcedure [dbo].[ProcProjectExpenseDetailShowSortByEmployeeName]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[ProcProjectExpenseDetailShowSortByEmployeeName]
as
begin

SELECT 
  ProjectExpense.PE_ID,
  ProjectTable.Name as ProjectName,
  EmployeeTable.Name AS EmployeeName, 
  ProjectExpense.Amount,
  ProjectExpense.Date, 
  ProjectExpense.Note from ProjectExpense 
  left join
     EmployeeTable
   on
    EmployeeTable.E_ID=ProjectExpense.E_ID
  left join 
	 ProjectTable on ProjectTable.Pro_ID=ProjectExpense.Pro_ID order by EmployeeTable.Name
end



GO
/****** Object:  StoredProcedure [dbo].[ProcProjectExpenseDetailShowSortByProjectName]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcProjectExpenseDetailShowSortByProjectName]
as
begin

SELECT 
 ProjectExpense.PE_ID,
  ProjectTable.Name as ProjectName,
  EmployeeTable.Name AS EmployeeName, 
  ProjectExpense.Amount,
  ProjectExpense.Date, 
  ProjectExpense.Note from ProjectExpense 
  left join
     EmployeeTable
   on
    EmployeeTable.E_ID=ProjectExpense.E_ID
  left join 
	 ProjectTable on ProjectTable.Pro_ID=ProjectExpense.Pro_ID order by ProjectTable.Name
end


GO
/****** Object:  StoredProcedure [dbo].[ProcProjectIncomeSum_Month]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcProjectIncomeSum_Month]
as
begin
select sum(Amount) from ProjectIncomeTable  where (select MONTH( ProjectIncomeTable.Date )) = (SELECT MONTH( Cast (GETDATE() as Date))) AND (select YEAR(ProjectIncomeTable.Date)) = (SELECT YEAR( Cast (GETDATE() as Date)))
end
GO
/****** Object:  StoredProcedure [dbo].[ProcProjectIncomeSum_Year]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[ProcProjectIncomeSum_Year]
as
begin
select sum(Amount) from ProjectIncomeTable  where (select YEAR( ProjectIncomeTable.Date )) = (SELECT YEAR( Cast (GETDATE() as Date)))
end




GO
/****** Object:  StoredProcedure [dbo].[ProcProjectTableDelete]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcProjectTableDelete] @id int
as
begin
Delete  from ProjectTable where Pro_ID=@id
end

GO
/****** Object:  StoredProcedure [dbo].[ProcRegularExpenseDetailSearchBySpecificDay]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[ProcRegularExpenseDetailSearchBySpecificDay] @year int,@month int, @day int 
as
begin

SELECT 
  RE_ID,
  Amount,
  Date,
  Description
  from Regular_Expenses 
  where
  YEAR(Date)=@year
  AND 
  MONTH(Date)=@month
  AND
  DAY(Date)=@day
end




GO
/****** Object:  StoredProcedure [dbo].[ProcRegularExpenseDetailSearchBySpecificMonth]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[ProcRegularExpenseDetailSearchBySpecificMonth] @year int,@month int
as
begin

SELECT 
  RE_ID,
  Amount,
  Date,
  Description
  from Regular_Expenses 
  where
  YEAR(Date)=@year
  AND 
  MONTH(Date)=@month
end



GO
/****** Object:  StoredProcedure [dbo].[ProcRegularExpenseDetailSearchBySpecificYear]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[ProcRegularExpenseDetailSearchBySpecificYear] @year int 
as
begin

SELECT 
  RE_ID,
  Amount,
  Date,
  Description
  from Regular_Expenses where YEAR(DATE)=@year
end


GO
/****** Object:  StoredProcedure [dbo].[ProcRegularExpenseDetailShow]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[ProcRegularExpenseDetailShow]
as
begin

SELECT 
  RE_ID,
  Amount,
  Date,
  Description
  from Regular_Expenses
end



GO
/****** Object:  StoredProcedure [dbo].[ProcRegularExpenseDetailShowByRegularExpenseID]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ProcRegularExpenseDetailShowByRegularExpenseID]
@id int
as
begin

SELECT 
  RE_ID,
  Amount,
  Date,
  Description
  from Regular_Expenses
  where RE_ID = @id
end





GO
/****** Object:  StoredProcedure [dbo].[ProcRegularExpenseDetailShowSortByAmountASC]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[ProcRegularExpenseDetailShowSortByAmountASC]
as
begin

SELECT 
  RE_ID,
  Amount,
  Date,
  Description
  from Regular_Expenses order by Amount
end


GO
/****** Object:  StoredProcedure [dbo].[ProcRegularExpenseDetailShowSortByAmountDesc]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[ProcRegularExpenseDetailShowSortByAmountDesc]
as
begin

SELECT 
  RE_ID,
  Amount,
  Date,
    Description
  from Regular_Expenses order by Amount DESC
end





GO
/****** Object:  StoredProcedure [dbo].[ProcRegularExpenseDetailShowSortByDateAsc]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[ProcRegularExpenseDetailShowSortByDateAsc]
as
begin

SELECT 
  RE_ID,
  Amount,
  Date,
    Description
  from Regular_Expenses order by Date
end



GO
/****** Object:  StoredProcedure [dbo].[ProcShowAllDesignations]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcShowAllDesignations]
as
begin
select * from DesignationTable
end
GO
/****** Object:  StoredProcedure [dbo].[ProcShowAllEmpSkills]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcShowAllEmpSkills]
as
begin
select EmployeeTable.Name,SkillsTable.SkillName from EmployeeSkillTable left join EmployeeTable on EmployeeSkillTable.E_ID = EmployeeTable.E_ID left join SkillsTable on EmployeeSkillTable.S_ID = SkillsTable.S_ID
end

GO
/****** Object:  StoredProcedure [dbo].[ProcShowAllEmpTypes]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[ProcShowAllEmpTypes]
as
begin
select * from TypeTable
end
GO
/****** Object:  StoredProcedure [dbo].[ProcShowAllQualifications]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcShowAllQualifications]
as
begin
select * from QualificationTable
end


GO
/****** Object:  StoredProcedure [dbo].[ProcShowAllSkills]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ProcShowAllSkills]
as
begin
select * from SkillsTable
end
GO
/****** Object:  StoredProcedure [dbo].[ProcShowEmployeeSkillById]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcShowEmployeeSkillById]
@id nvarchar(50)
as
begin
select SkillsTable.SkillName from EmployeeSkillTable left join SkillsTable on EmployeeSkillTable.S_ID = SkillsTable.S_ID where EmployeeSkillTable.E_ID = (select E_ID from EmployeeTable where Employee_ID = @id) 
end
GO
/****** Object:  StoredProcedure [dbo].[ProcTodayEmployeeSalaries]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcTodayEmployeeSalaries]
@date date
as
begin
select sum(Amount) as TodayExpense from Employee_Salaries where Employee_Salaries.Date = @date
end
GO
/****** Object:  StoredProcedure [dbo].[ProcTotalExpenseOfCompany]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcTotalExpenseOfCompany]
as
begin
declare @pe float;
declare @re float;
declare @es float;
SELECT @pe=sum(Amount)  FROM ProjectExpense
SELECT @re=sum(Amount)  FROM Regular_Expenses
SELECT @es=sum(Amount)  FROM Employee_Salaries
SELECT @pe + @re + @es 
end

GO
/****** Object:  StoredProcedure [dbo].[ProcTotalIncomeOfCompany]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcTotalIncomeOfCompany]
as
begin
declare @pe float;
declare @re float;
SELECT @pe=sum(Amount)  FROM AcademyIncomeTable
SELECT @re=sum(Amount)  FROM ProjectIncomeTable
SELECT @pe + @re
end
GO
/****** Object:  StoredProcedure [dbo].[ProcTotalWithdrawalOfCompany]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ProcTotalWithdrawalOfCompany]
as
begin
SELECT sum(Amount)  FROM Withdrawal
end
GO
/****** Object:  StoredProcedure [dbo].[ProcUnmarkedAttendenceShow]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcUnmarkedAttendenceShow]
as
begin
Select EmployeeTable.Name as EmployeeName,
AttendanceTable.E_ID as EmployeeId,
AttendanceTable.Date 
from 
AttendanceTable
 left join
  EmployeeTable
   on
    AttendanceTable.E_ID=EmployeeTable.E_ID
	 where
	 InTime is NULL AND Date=(Select Cast (GETDATE() as Date ) as Date)

end

GO
/****** Object:  StoredProcedure [dbo].[ProcUpdateAcademyIncome]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcUpdateAcademyIncome] @Ai_id int, @stdid int, @amount float, @note nvarchar(50), @date date
as
begin
update AcademyIncomeTable set Std_ID=@stdid,Amount=@amount,Note=@note,Date=@date where AI_ID=@Ai_id
end

GO
/****** Object:  StoredProcedure [dbo].[ProcUpdateAttendance]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcUpdateAttendance]
@id int, @intime time, @outtime time, @status nvarchar(50)
as
begin
update AttendanceTable set InTime = @intime, OutTime = @outtime, State_ID = (select StatusTable.State_ID from StatusTable where StatusTable.Name = @status) where Att_ID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[ProcUpdateConsultact]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ProcUpdateConsultact] @name varchar(50),@Fname varchar(50),@Dob datetime,@Gname varchar(50),@Address varchar(50),@Phone1 varchar(50), @Phone2 varchar(50),@UConsId varchar(50)
as
begin
	update ConsultantTable
	set Name = @name,
		F_Name = @Fname,
		DOB=@Dob,
		G_ID=(select G_ID from GenderTable where GenderName=@Gname),
		Address=@Address,
		Phone1=@Phone1,
		Phone2=@Phone2
	where Cons_ID=@UConsId
end


GO
/****** Object:  StoredProcedure [dbo].[ProcUpdateEmplyeeSalaries]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcUpdateEmplyeeSalaries] @id int, @ename nvarchar(50), @amount float, @date date, @note nvarchar(50)
as
begin
UPDATE Employee_Salaries
SET E_ID = (select E_ID from EmployeeTable where Name= @ename), Amount=@amount,Date=@date,Note=@note
WHERE ES_ID= @id
end

GO
/****** Object:  StoredProcedure [dbo].[ProcUpdateProjectExpense]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcUpdateProjectExpense] @id int, @pname nvarchar(50), @ename nvarchar(50), @amount float, @date date, @note nvarchar(50)
as
begin
UPDATE ProjectExpense
SET Pro_ID = (select Pro_ID from ProjectTable where Name= @pname),E_ID=(select E_ID from EmployeeTable where Name= @ename), Amount=@amount,Date=@date,Note=@note
WHERE PE_ID= @id
end

GO
/****** Object:  StoredProcedure [dbo].[ProcUpdateProjectIncome]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcUpdateProjectIncome] @Pi_id int, @projid int, @amount float, @note nvarchar(50), @date date
as
begin
Update ProjectIncomeTable set  Project_id=@projid,Amount=@amount,Note=@note,Date=@date where PI_ID=@Pi_id;
end

GO
/****** Object:  StoredProcedure [dbo].[ProcUpdateRegularExpense]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcUpdateRegularExpense]
@id int, @amount float, @description nvarchar(max), @date date
as
begin
update Regular_Expenses set Amount = @amount, Description = @description, Date = @date where RE_ID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[ProcUpdateWithdrawal]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcUpdateWithdrawal]
@id int, @Name nvarchar(50), @date datetime, @amount float, @note Nvarchar(250)
as
begin
update Withdrawal set Name = @Name , Date = @date, Amount = @amount, Note = @note where WithdrawalID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[ProcWithdrawalDatailSearchByNames]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcWithdrawalDatailSearchByNames] @name nvarchar(50)
as
begin
SELECT WithdrawalID,Name,Amount,Date,Note FROM Withdrawal where Name=@name
end

GO
/****** Object:  StoredProcedure [dbo].[ProcWithdrawalDatailSearchBySpecific_Day]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcWithdrawalDatailSearchBySpecific_Day] @year int,@month int,@day int
as
begin
SELECT WithdrawalID,Name,Amount,Date,Note FROM Withdrawal 
   where
     YEAR(Date)=@year
	 AND 
	 MONTH(Date)=@month
	 AND
	 DAY(Date)=@day
end

GO
/****** Object:  StoredProcedure [dbo].[ProcWithdrawalDatailSearchBySpecific_Month]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcWithdrawalDatailSearchBySpecific_Month] @year int,@month int
as
begin
SELECT WithdrawalID,Name,Amount,Date,Note FROM Withdrawal 
   where
     YEAR(Date)=@year
	 AND 
	 MONTH(Date)=@month
end
GO
/****** Object:  StoredProcedure [dbo].[ProcWithdrawalDatailSearchBySpecific_Year]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcWithdrawalDatailSearchBySpecific_Year] @year int
as
begin
SELECT WithdrawalID,Name,Amount,Date,Note FROM Withdrawal 
   where
     YEAR(Date)=@year
end
GO
/****** Object:  StoredProcedure [dbo].[ProcWithdrawalDatailShow]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcWithdrawalDatailShow]
as
begin
SELECT WithdrawalID,Name,Amount,Date,Note FROM Withdrawal 
end

GO
/****** Object:  StoredProcedure [dbo].[ProcWithdrawalDatailShowById]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcWithdrawalDatailShowById]
@id int
as
begin
SELECT WithdrawalID,Name,Amount,Date,Note FROM Withdrawal where WithdrawalID = @id
end

GO
/****** Object:  StoredProcedure [dbo].[ProcWithdrawalDatailSortByAmount]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcWithdrawalDatailSortByAmount]
as
begin
SELECT WithdrawalID,Name,Amount,Date,Note FROM Withdrawal order by Amount
end

GO
/****** Object:  StoredProcedure [dbo].[ProcWithdrawalDatailSortByNames]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcWithdrawalDatailSortByNames]
as
begin
SELECT WithdrawalID,Name,Amount,Date,Note FROM Withdrawal order by Name
end

GO
/****** Object:  StoredProcedure [dbo].[ProcWithdrawalShowDistinctName]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcWithdrawalShowDistinctName]
as
begin
select distinct Name from Withdrawal
end

GO
/****** Object:  StoredProcedure [dbo].[ProcYearlyEmployeeSalaries]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcYearlyEmployeeSalaries]
@year int
as
begin
select sum(Amount) as YearlyExpense from Employee_Salaries where 
     YEAR(Date)=@year
	 
end

GO
/****** Object:  StoredProcedure [dbo].[ProcYearlyProjectExpense]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcYearlyProjectExpense]
@year int
as
begin
select sum(Amount) as YearlyExpense from ProjectExpense where 
     YEAR(Date)=@year
end

GO
/****** Object:  StoredProcedure [dbo].[ProcYearlyRegularExpense]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcYearlyRegularExpense]
@year int
as
begin
select sum(Amount) as YearlyExpense from Regular_Expenses where 
     YEAR(Date)=@year
end


GO
/****** Object:  StoredProcedure [dbo].[project_completed]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[project_completed]
as
begin
select count(*) from projectTable where Date_Of_Delivery is not NULL
end



GO
/****** Object:  StoredProcedure [dbo].[Project_Income_Month]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[Project_Income_Month]
@dateTodayS date,@dateTodayE date
as
begin
  declare @Pro_in_sum float,@adda float

  select @Pro_in_sum=sum(Amount) from ProjectIncomeTable where Date between @dateTodayS and @dateTodayE


  if (@Pro_in_sum IS NULL)
  BEGIN
set @Pro_in_sum=0
  END
  set @adda=@Pro_in_sum
 select @adda;
 end


GO
/****** Object:  StoredProcedure [dbo].[remotely_working]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[remotely_working]
as
begin
select count(*) from EmployeeTable left join TypeTable on EmployeeTable .T_id = TypeTable.T_id where TypeTable.TypeName='remotely'
end
GO
/****** Object:  StoredProcedure [dbo].[searchAcademyIncomebyspecific_year]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[searchAcademyIncomebyspecific_year] @year int
as
begin
Select
   AI_ID,AcademyIncomeTable.Std_ID,StudentsTable.Name,Amount,Date,Note from AcademyIncomeTable left join StudentsTable on AcademyIncomeTable.AI_ID=StudentsTable.Std_ID
WHERE 
    YEAR(Date) = @year
ORDER BY [Date];    
end



GO
/****** Object:  StoredProcedure [dbo].[SearchbyProjectid]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SearchbyProjectid] @id int 
as
begin
select PI_ID,projectTable.Name,ProjectTable.Pro_ID,ProjectIncomeTable.Amount,Date,Note from ProjectIncomeTable left join ProjectTable on ProjectIncomeTable.Project_id=ProjectTable.Pro_ID where ProjectIncomeTable.Project_id=@id
end


GO
/****** Object:  StoredProcedure [dbo].[Searchbyprojectincomeid]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Searchbyprojectincomeid] @id int 
as
begin
select PI_ID,projectTable.Name,ProjectTable.Pro_ID,ProjectIncomeTable.Amount,Date,Note from ProjectIncomeTable left join ProjectTable on ProjectIncomeTable.Project_id=ProjectTable.Pro_ID where ProjectIncomeTable.PI_ID=@id
end

GO
/****** Object:  StoredProcedure [dbo].[SearchbyProjectName]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SearchbyProjectName] @name nvarchar(50)
as
begin
select PI_ID,projectTable.Name,ProjectTable.Pro_ID,ProjectIncomeTable.Amount,Date,Note from ProjectIncomeTable left join ProjectTable on ProjectIncomeTable.Project_id=ProjectTable.Pro_ID where projectTable.Name=@name
end

GO
/****** Object:  StoredProcedure [dbo].[searchconsultantbyuname]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[searchconsultantbyuname] @name nvarchar(50)
as
begin
SELECT Cons_ID, Name,Phone1,Phone2 FROM ConsultantTable where Name=@name
end


GO
/****** Object:  StoredProcedure [dbo].[searchemployeebyid]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[searchemployeebyid] @id nvarchar(50)
as
begin
select 
Name,
F_Name,
CNIC,
DOB,
[Address],
Agreement,
TypeTable.TypeName,
GenderTable.GenderName,
DesignationTable.PostName,
QualificationTable.QName,
Phone1,
Phone2,
Employee_ID,
Salary 
from EmployeeTable 
left join TypeTable on EmployeeTable.T_ID=TypeTable.T_ID 
left join GenderTable on EmployeeTable.G_ID=GenderTable.G_ID 
left join DesignationTable on EmployeeTable.D_ID=DesignationTable.D_ID 
left join QualificationTable on EmployeeTable.Q_ID=QualificationTable.Q_ID 
where Employee_ID=@id
end


GO
/****** Object:  StoredProcedure [dbo].[searchinAcademyIncomebyspecific_day]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[searchinAcademyIncomebyspecific_day] @year int, @month int, @day int
as
begin

SELECT 
   AI_ID,AcademyIncomeTable.Std_ID,StudentsTable.Name,Amount,Date,Note from AcademyIncomeTable left join StudentsTable on AcademyIncomeTable.AI_ID=StudentsTable.Std_ID
WHERE 
    
    YEAR(Date) = @year
    AND MONTH(Date) = @month
	AND DAY(Date)=@day
ORDER BY [Date];    
  
end


GO
/****** Object:  StoredProcedure [dbo].[searchinAcademyIncomebyspecific_month]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[searchinAcademyIncomebyspecific_month] @year int, @month int
as
begin

SELECT 
   AI_ID,AcademyIncomeTable.Std_ID,StudentsTable.Name,Amount,Date,Note from AcademyIncomeTable left join StudentsTable on AcademyIncomeTable.AI_ID=StudentsTable.Std_ID
WHERE 
    
    YEAR(Date) = @year
    AND MONTH(Date) = @month
ORDER BY [Date];    
   
  
end

GO
/****** Object:  StoredProcedure [dbo].[serachconsultantbyuid]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[serachconsultantbyuid] @id int
as
begin
SELECT Cons_ID, Name,Phone1,Phone2 FROM ConsultantTable where Cons_ID=@id
end


GO
/****** Object:  StoredProcedure [dbo].[showprojectbydate]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[showprojectbydate] @date date
as
begin
SELECT Name,Pro_id, CASE
            WHEN Date_Of_Completion is null
               THEN 'Ongoing'
               ELSE 'Complete'
       END as Status,Amount
FROM ProjectTable where Project_Date=@date
end


GO
/****** Object:  StoredProcedure [dbo].[showprojectbyName]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[showprojectbyName] @name nvarchar(50)
as
begin 
SELECT Name,Pro_id, CASE
            WHEN Date_Of_Completion is null
               THEN 'Ongoing'
               ELSE 'Complete'
       END as Status,Amount
FROM ProjectTable where Name=@name
end


GO
/****** Object:  StoredProcedure [dbo].[showprojectdates]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[showprojectdates]
as
begin
select Project_Date,Date_Of_Delivery,Date_Of_Completion from ProjectTable
end


GO
/****** Object:  StoredProcedure [dbo].[showprojectnames]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[showprojectnames]
as
begin
select Name from ProjectTable
end


GO
/****** Object:  StoredProcedure [dbo].[sortbyname]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sortbyname]
as 
begin
SELECT Name,Pro_id, CASE
            WHEN Date_Of_Completion is null
               THEN 'Ongoing'
               ELSE 'Complete'
       END as Status,Amount
FROM ProjectTable order by Name
end


GO
/****** Object:  StoredProcedure [dbo].[sortbystatus]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sortbystatus]
as 
begin
SELECT Name,Pro_id, CASE
            WHEN Date_Of_Completion is null
               THEN 'Ongoing'
               ELSE 'Complete'
       END as Status,Amount
FROM ProjectTable order by Status
end


GO
/****** Object:  StoredProcedure [dbo].[SortingAmountAscending]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SortingAmountAscending]
as
begin
select PI_ID,projectTable.Name,ProjectTable.Pro_ID,ProjectIncomeTable.Amount,Date,Note from ProjectIncomeTable left join ProjectTable on ProjectIncomeTable.Project_id=ProjectTable.Pro_ID order by Amount
end


GO
/****** Object:  StoredProcedure [dbo].[SortingAmountdescending]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SortingAmountdescending]
as
begin
select PI_ID,projectTable.Name,ProjectTable.Pro_ID,ProjectIncomeTable.Amount,Date,Note from ProjectIncomeTable left join ProjectTable on ProjectIncomeTable.Project_id=ProjectTable.Pro_ID order by Amount desc
end




GO
/****** Object:  StoredProcedure [dbo].[SortingName]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SortingName]
as
begin
select PI_ID,projectTable.Name,ProjectTable.Pro_ID,ProjectIncomeTable.Amount,Date,Note from ProjectIncomeTable left join ProjectTable on ProjectIncomeTable.Project_id=ProjectTable.Pro_ID order by projectTable.Name
end


GO
/****** Object:  StoredProcedure [dbo].[specific_day]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc  [dbo].[specific_day] @year int, @month int, @day int
as
begin

SELECT 
PI_ID,
projectTable.Name,
ProjectTable.Pro_ID,
ProjectIncomeTable.Amount,
Date,
Note 
from ProjectIncomeTable 
left join ProjectTable 
on 
ProjectIncomeTable.Project_id = ProjectTable.Pro_ID
WHERE 
    YEAR(Date) = @year
	AND MONTH(Date)=@month
	AND DAY(Date)=@day

ORDER BY [Date];    
end


GO
/****** Object:  StoredProcedure [dbo].[specific_month]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc  [dbo].[specific_month] @year int, @month int
as
begin

SELECT 
PI_ID,
projectTable.Name,
ProjectTable.Pro_ID,
ProjectIncomeTable.Amount,
Date,
Note 
from ProjectIncomeTable 
left join ProjectTable 
on 
ProjectIncomeTable.Project_id = ProjectTable.Pro_ID
WHERE 
    YEAR(Date) = @year
	AND MONTH(Date) = @month
ORDER BY [Date]; 
end



GO
/****** Object:  StoredProcedure [dbo].[specific_year]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc  [dbo].[specific_year] @date int
as
begin

SELECT 
PI_ID,
projectTable.Name,
ProjectTable.Pro_ID,
ProjectIncomeTable.Amount,
Date,
Note 
from ProjectIncomeTable 
left join ProjectTable 
on 
ProjectIncomeTable.Project_id = ProjectTable.Pro_ID
WHERE 
    YEAR(Date) = @date
ORDER BY [Date]; 
end

GO
/****** Object:  StoredProcedure [dbo].[today_academy_income]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[today_academy_income]
@date date
as
begin
select sum(Amount) from AcademyIncomeTable where AcademyIncomeTable.Date = @date
end








GO
/****** Object:  StoredProcedure [dbo].[today_academy_income_Sum]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[today_academy_income_Sum]
@date date
as
begin
select sum(Amount) from AcademyIncomeTable where AcademyIncomeTable.Date = @date
end


GO
/****** Object:  StoredProcedure [dbo].[today_Proj_income_Sum]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[today_Proj_income_Sum]
@date date
as
begin
select sum(Amount) from ProjectIncomeTable  where ProjectIncomeTable.Date = @date
end


GO
/****** Object:  StoredProcedure [dbo].[today_project_expense]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[today_project_expense]
@date date
as
begin
select sum(Amount) from ProjectExpense where ProjectExpense.Date = @date
end



GO
/****** Object:  StoredProcedure [dbo].[today_project_income]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[today_project_income]
@date date
as
begin
select sum(Amount) from ProjectIncomeTable where ProjectIncomeTable.Date = @date
end



GO
/****** Object:  StoredProcedure [dbo].[today_regular_expense]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[today_regular_expense]
@date date
as
begin
select sum(Amount) from Regular_Expenses where Regular_Expenses.Date = @date
end



GO
/****** Object:  StoredProcedure [dbo].[total_consultant]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[total_consultant]
as
begin
select count(*) from consultantTable
end


GO
/****** Object:  StoredProcedure [dbo].[Total_Expense_Month]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Total_Expense_Month]
@dateTodayS date, @dateTodayE date
as
begin
  declare @Emp_sal_sum float,@Reg_exp_sum float,@Pro_exp_sum float, @adda float

  select @Emp_sal_sum=sum(Amount) from Employee_Salaries where Date between @dateTodayS and @dateTodayE
  select @Reg_exp_sum=sum(Amount) from Regular_Expenses where Date between @dateTodayS and @dateTodayE
  select @Pro_exp_sum=sum(Amount) from ProjectExpense where Date between @dateTodayS and @dateTodayE

  if (@Emp_sal_sum IS NULL)
  BEGIN
set @Emp_sal_sum=0
  END

  if (@Reg_exp_sum IS NULL)
  BEGIN
set @Reg_exp_sum=0
  END

  if (@Pro_exp_sum IS NULL)
  BEGIN
set @Pro_exp_sum=0
  END


  set @adda=@Emp_sal_sum+@Reg_exp_sum+@Pro_exp_sum
 select @adda from Employee_Salaries 
 end

GO
/****** Object:  StoredProcedure [dbo].[Total_Expense_Today]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[Total_Expense_Today]
@dateToday date
as
begin
  declare @Emp_sal_sum float,@Reg_exp_sum float,@Pro_exp_sum float, @adda float

  select @Emp_sal_sum=sum(Amount) from Employee_Salaries where Date=@dateToday
  select @Reg_exp_sum=sum(Amount) from Regular_Expenses where Date=@dateToday
  select @Pro_exp_sum=sum(Amount) from ProjectExpense where Date=@dateToday

  if (@Emp_sal_sum IS NULL)
  BEGIN
set @Emp_sal_sum=0
  END

  if (@Reg_exp_sum IS NULL)
  BEGIN
set @Reg_exp_sum=0
  END

  if (@Pro_exp_sum IS NULL)
  BEGIN
set @Pro_exp_sum=0
  END


  set @adda=@Emp_sal_sum+@Reg_exp_sum+@Pro_exp_sum
 select @adda from Employee_Salaries 
 end


GO
/****** Object:  StoredProcedure [dbo].[Total_Income_Month]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[Total_Income_Month]
@dateTodayS date,@dateTodayE date
as
begin
  declare @Acad_in_sum float,@Pro_in_sum float,@adda float

  select @Acad_in_sum=sum(Amount) from AcademyIncomeTable where Date between @dateTodayS and @dateTodayE
  select @Pro_in_sum=sum(Amount) from ProjectIncomeTable where Date between @dateTodayS and @dateTodayE


  if (@Acad_in_sum IS NULL)
  BEGIN
set @Acad_in_sum=0
  END

  if (@Pro_in_sum IS NULL)
  BEGIN
set @Pro_in_sum=0
  END



  set @adda=@Pro_in_sum+@Acad_in_sum
 select @adda;
 end


GO
/****** Object:  StoredProcedure [dbo].[Total_Income_Today]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  
 create proc [dbo].[Total_Income_Today]
@dateToday date
as
begin
  declare @Acad_in_sum float,@Pro_in_sum float,@adda float

  select @Acad_in_sum=sum(Amount) from AcademyIncomeTable where Date=@dateToday
  select @Pro_in_sum=sum(Amount) from [ProjectIncomeTable] where Date=@dateToday

  if (@Acad_in_sum IS NULL)
  BEGIN
set @Acad_in_sum=0
  END

  if (@Pro_in_sum IS NULL)
  BEGIN
set @Pro_in_sum=0
  END



  set @adda=@Pro_in_sum+@Acad_in_sum
 select @adda;
 end


GO
/****** Object:  StoredProcedure [dbo].[total_project]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[total_project]
as
begin
select count(*) from ProjectTable
end



GO
/****** Object:  StoredProcedure [dbo].[total_users]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[total_users]
@role int
as
begin
select count(*) from logininfotable where Role_id = @role
end



GO
/****** Object:  StoredProcedure [dbo].[unmarkedattendance]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[unmarkedattendance]
as
begin
select count(*) as Unmarked from AttendanceTable where Date=(SELECT CAST( GETDATE() AS Date )) AND InTime is  null 
end

GO
/****** Object:  StoredProcedure [dbo].[unmarkedattendancesearchbyid]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[unmarkedattendancesearchbyid] @id int
as
begin 
select
(select Name from EmployeeTable et where et.E_ID=at.E_ID),
E_ID,Date,InTime,OutTime,
(select  Name from StatusTable st where st.State_ID=at.State_ID)
 from AttendanceTable at

where Date=(SELECT CAST( GETDATE() AS Date )) AND InTime is  null AND E_ID=@id
end

GO
/****** Object:  StoredProcedure [dbo].[unmarkedattendancesearchbyname]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[unmarkedattendancesearchbyname] @name nvarchar(50)
as
begin 
select 
(select Name from EmployeeTable et where et.E_ID=at.E_ID),
E_ID,Date,InTime,OutTime, 
(select  Name from StatusTable st where st.State_ID=at.State_ID)



 from AttendanceTable at where Date=(SELECT CAST( GETDATE() AS Date )) AND InTime is  null AND E_ID= (select E_ID from EmployeeTable where Name=@name)        
end

GO
/****** Object:  StoredProcedure [dbo].[Update_Employee]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_Employee] @v_name nvarchar(50), @v_FName nvarchar(50), @v_CNIC nvarchar(50), @v_DOB date, @v_address nvarchar(50), @v_agreement nvarchar(50), @typename nvarchar(50), @gendername nvarchar(50), @postname nvarchar(50), @qualificationname nvarchar(50), @phone1 nvarchar(50), @phone2 nvarchar(50), @employeeid nvarchar(50), @salary float
as
begin
UPDATE EmployeeTable
SET Name = @v_name, F_Name = @v_FName,CNIC= @v_CNIC,DOB=@v_DOB,Address= @v_address,
Agreement=@v_agreement,T_ID=(select T_ID from TypeTable where TypeName=@typename ), 
G_ID=(select G_ID from GenderTable where GenderName=@gendername ),
 D_ID=(select D_ID from DesignationTable where PostName=@postname ), 
Q_ID=(select Q_ID from QualificationTable where QName=@qualificationname), Phone1 = @phone1, Phone2 = @phone2, 
Employee_ID=@employeeid, Salary=@salary
WHERE E_ID= ( select E_ID from EmployeeTable where Employee_ID= @employeeid)  
end



GO
/****** Object:  StoredProcedure [dbo].[Update_ProjectDetail]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_ProjectDetail] @id int,@v_dateofstart date, @v_name nvarchar(50), @v_description nvarchar(50), @v_cname nvarchar(50), @v_amount float, @v_dateofcompletion date, @v_dateofdelivery date, @v_projectdate date
as
begin
UPDATE ProjectTable
SET Date_Of_Start = @v_dateofstart, Name = @v_name, Description= @v_description,C_ID=(select C_ID from ConsultantTable where Name=@v_cname ),Amount = @v_amount, Date_Of_Completion = @v_dateofcompletion, Date_Of_Delivery=@v_dateofdelivery, Project_Date=@v_projectdate
WHERE Pro_ID=@id;  
end


GO
/****** Object:  StoredProcedure [dbo].[updatelogininfotabless]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[updatelogininfotabless] @password nvarchar(50), @rolename nvarchar(50), @username nvarchar(50) 
as
begin
update LoginInfoTable
set Password = @password , Role_ID =(Select Role_ID from RoleTable where RoleName=@rolename)
where Username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[wholedatashowfromattendancebyid]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[wholedatashowfromattendancebyid] @id int
as
begin
select Att_ID,EmployeeTable.Name,AttendanceTable.E_ID,Date,InTime,OutTime,StatusTable.Name from AttendanceTable left join EmployeeTable on AttendanceTable.E_ID = EmployeeTable.E_ID left join StatusTable on AttendanceTable.State_ID = StatusTable.State_ID where Month(Date) = MONTH(GETDATE()) AND AttendanceTable.E_ID = (select E_ID from EmployeeTable where Employee_ID = @id) ORDER BY [Date]
end
GO
/****** Object:  StoredProcedure [dbo].[wholedatashowfromattendancebyname]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[wholedatashowfromattendancebyname] @name nvarchar(50)
as
begin
select Att_ID,EmployeeTable.Name,AttendanceTable.E_ID,Date,InTime,OutTime,StatusTable.Name from AttendanceTable left join EmployeeTable on AttendanceTable.E_ID = EmployeeTable.E_ID left join StatusTable on AttendanceTable.State_ID = StatusTable.State_ID where Month(Date) = MONTH(GETDATE()) AND AttendanceTable.E_ID= (select E_ID from EmployeeTable where Name=@name) ORDER BY [Date]
end
GO
/****** Object:  StoredProcedure [dbo].[withdrawals]    Script Date: 9/29/2020 12:48:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[withdrawals]
as
begin 
select 
((select sum(Amount) from AcademyIncomeTable) + (select sum(Amount) from ProjectIncomeTable)) 
-
((select sum(Amount) from Regular_Expenses) + (select sum(Amount) from ProjectExpense) + (select sum(Amount) from Employee_Salaries)) 
-
(SELECT sum(Amount)
  FROM [TheProject].[dbo].[Withdrawal])
end








GO
USE [master]
GO
ALTER DATABASE [TheProject] SET  READ_WRITE 
GO
