CREATE TABLE [dbo].[sysversions](
	[version] [nvarchar](50) NOT NULL,
	[date_at] [datetime] NULL,
	[tag] [nvarchar](1) NULL,
 CONSTRAINT [PK_sys_versions] PRIMARY KEY CLUSTERED 
(
	[version] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY])