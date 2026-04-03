CREATE TABLE [dbo].[tbl_account_payable_paid](
	[sysdoc] [nvarchar](50) NOT NULL,
	[branchcode] [nvarchar](50) NOT NULL,
	[ap_id] [nvarchar](50) NOT NULL,
	[paiddate] [date] NULL,
	[amount] [money] NULL,
	[remark] [nvarchar](250) NULL,
	[inputter] [nvarchar](250) NULL,
	[created_at] [datetime] NULL
) ON [PRIMARY]


