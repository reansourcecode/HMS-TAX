-- Run first to create DATABASE ;
----* CREATE DATABASE HMS_TAX;


USE HMS_TAX;

CREATE TABLE [dbo].[sysversions](
	[version] [nvarchar](50) NOT NULL,
	[date_at] [date] NULL,
	[tag] [nvarchar](1) NULL,
 CONSTRAINT [PK_sys_versions] PRIMARY KEY CLUSTERED 
(
	[version] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]

CREATE TABLE [dbo].[sysconstants](
	[con_id] [nvarchar](50) NOT NULL,
	[con_display] [nvarchar](50) NOT NULL,
	[con_line] [nvarchar](50) NOT NULL,
	[disable] [bit] NULL,
 CONSTRAINT [PK_sysconstants] PRIMARY KEY CLUSTERED 
(
	[con_id] ASC,
	[con_display] ASC,
	[con_line] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]


--- User can create sub branch 
CREATE TABLE [dbo].[sysbranch](
	[branchcode] [nvarchar](10) NOT NULL,
	[subofbranch] [nvarchar](10) NOT NULL,
	[is_branch] [bit] NULL,
	[Disable] [bit] NULL,
	[branchname] [nvarchar](250) NULL,
	[branchshort] [nvarchar](250) NULL,
	[inputter] [nvarchar](150) NULL,
	[create_at] [datetime] NULL,
 CONSTRAINT [PK_tblbranch] PRIMARY KEY CLUSTERED 
(
	[branchcode] ASC,
	[subofbranch] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY];


--- User profile 

CREATE TABLE [dbo].[tbl_user_profile](
	[pro_id] [nvarchar](10) NOT NULL,
	[pro_name] [nvarchar](50) NULL,
	[pro_name_kh] [nvarchar](50) NULL,
	[disable] [bit] NULL,
	[inputter] [nvarchar](150) NULL,
	[create_at] [datetime] NULL,
 CONSTRAINT [PK_tbl_user_profile] PRIMARY KEY CLUSTERED 
(
	[pro_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]


CREATE TABLE [dbo].[sys_user_logins](
	[user_id] [nvarchar](10) NOT NULL,
	[branchcode] [nvarchar](10) NOT NULL,
	[sub_of_branch] [nvarchar](10) NOT NULL,
	[profile_id] [nvarchar](10) NOT NULL,
	[user_login] [nvarchar](250) NULL,
	[user_pwd] [nvarchar](250) NULL,
	[disable] [bit] NULL,
	[create_at] [datetime] NULL,
	[expired_at] [date] NULL,
	[inputter] [nvarchar](150) NULL,
 CONSTRAINT [PK_sys_user_logins] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC,
	[branchcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY] ;


--- Insert testing DATA

truncate table [sys_user_logins] ;
INSERT [dbo].[sys_user_logins] ([user_id], [branchcode], [sub_of_branch], [profile_id], [user_login], [user_pwd], [disable], [create_at], [expired_at], [inputter]) VALUES (N'1010-0001', N'0101', N'0101', N'02', N'reanit', N'gMJWe9NHnAnecmSXYNIhHsLcOJ5C6XNA/yBV+CI8riWkrmTXGtr9/A==', 0, CAST(N'2022-01-08T10:49:25.143' AS DateTime), CAST(N'2023-01-08' AS Date), N'bongmap.user')
GO

truncate table [sysversions] ;
INSERT [dbo].[sysversions] ([version], [date_at], [tag]) VALUES (N'0.0.0.1', CAST(N'2025-01-17' AS Date), N'1')
GO

truncate table [sysconstants] ;
INSERT [dbo].[sysconstants] ([con_id], [con_display], [con_line], [disable]) VALUES (N'0', N'No', N'Active', 0)
INSERT [dbo].[sysconstants] ([con_id], [con_display], [con_line], [disable]) VALUES (N'01', N'Male', N'gender', 0)
INSERT [dbo].[sysconstants] ([con_id], [con_display], [con_line], [disable]) VALUES (N'02', N'Female', N'gender', 0)
INSERT [dbo].[sysconstants] ([con_id], [con_display], [con_line], [disable]) VALUES (N'1', N'Yes', N'Active', 0)
INSERT [dbo].[sysconstants] ([con_id], [con_display], [con_line], [disable]) VALUES (N'S0001', N'ទទួលសំណើ', N'Status', 0)
GO


truncate table [tbl_user_profile] ;
INSERT [dbo].[tbl_user_profile] ([pro_id], [pro_name], [pro_name_kh], [disable], [inputter], [create_at]) VALUES (N'01', N'Requester', N'អ្នកស្នើរសុំ', 0, N'reancode.user', CAST(N'2022-01-16T20:18:08.790' AS DateTime))
INSERT [dbo].[tbl_user_profile] ([pro_id], [pro_name], [pro_name_kh], [disable], [inputter], [create_at]) VALUES (N'02', N'Approver', N'អ្នកទទួលដោះស្រាយ', 0, N'reancode.user', CAST(N'2022-01-16T20:18:08.790' AS DateTime))
GO

truncate table [sysbranch] ;
INSERT [dbo].[sysbranch] ([branchcode], [subofbranch], [is_branch], [Disable], [branchname], [branchshort], [inputter], [create_at]) VALUES (N'0101', N'9090', 1, 0, N'TC', N'TC', N'reancode.user', CAST(N'2022-01-16T20:18:08.790' AS DateTime))
GO
