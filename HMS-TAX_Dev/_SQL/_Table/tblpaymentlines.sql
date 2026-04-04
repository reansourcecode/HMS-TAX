CREATE TABLE [dbo].[tblpaymentlines](
	[line_id] [nvarchar](50) NOT NULL,
	[branchcode] [nvarchar](50) NOT NULL,
	[title] [nvarchar](250) NULL,
	[account] [nvarchar](250) NULL,
	[group_line] [nvarchar](50) NULL,
	[active] [bit] NULL,
	[remark] [nvarchar](250) NULL,
	[inputter] [nvarchar](250) NULL,
	[created_at] [datetime] NULL,
 CONSTRAINT [PK_tblpaymentlines] PRIMARY KEY CLUSTERED 
(
	[line_id] ASC,
	[branchcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
