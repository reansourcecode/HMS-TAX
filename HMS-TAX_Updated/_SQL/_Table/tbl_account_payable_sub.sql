CREATE TABLE [dbo].[tbl_account_payable_sub](
	[sysdocnum] [nvarchar](50) NOT NULL,
	[branchcode] [nvarchar](50) NOT NULL,
	[ap_id] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NULL,
	[amount] [money] NOT NULL,
	[create_at] [datetime] NULL,
 CONSTRAINT [PK_tbl_account_payable_sub] PRIMARY KEY CLUSTERED 
(
	[sysdocnum] ASC,
	[branchcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


