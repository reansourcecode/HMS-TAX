CREATE TABLE [dbo].[tbluna_account_payable](
	[ap_id] [nvarchar](20) NOT NULL,
	[branchcode] [nvarchar](20) NOT NULL,
	[supply_id] [nvarchar](20) NULL,
	[ap_date] [date] NULL,
	[invoice] [nvarchar](20) NULL,
	[remark] [nvarchar](250) NULL,
	[draft] [bit] NULL,
	[amount] [money] NULL,
	[inputter] [nvarchar](250) NULL,
	[created_at] [datetime] NULL,
	[authoriser] [nvarchar](250) NULL,
	[authorize_at] [datetime] NULL,
 CONSTRAINT [PK_tbluna_account_payable] PRIMARY KEY CLUSTERED 
(
	[ap_id] ASC,
	[branchcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


