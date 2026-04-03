CREATE TABLE [dbo].[tblpaymentsub](
	[sysdocnum] [nvarchar](50) NOT NULL,
	[branchcode] [nvarchar](50) NOT NULL,
	[pv_id] [nvarchar](50) NOT NULL,
	[pay_no] [nvarchar](50) NULL,
	[pay_des] [nvarchar](250) NULL,
	[pay_amount] [money] NOT NULL,
	[create_at] [datetime] NULL,
 CONSTRAINT [PK_tblpaymentsub] PRIMARY KEY CLUSTERED 
(
	[sysdocnum] ASC,
	[branchcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


