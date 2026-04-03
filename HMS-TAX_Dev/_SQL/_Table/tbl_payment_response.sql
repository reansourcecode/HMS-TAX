CREATE TABLE [dbo].[tbl_payment_response](
	[rs_id] [nvarchar](50) NOT NULL,
	[branchcode] [nvarchar](50) NOT NULL,
	[title] [nvarchar](250) NULL,
	[rs_default] [nvarchar](250) NULL,
	[rs_default_position] [nvarchar](250) NULL,
	[active] [bit] NULL,
	[create_at] [datetime] NULL,
 CONSTRAINT [PK_tbl_payment_response] PRIMARY KEY CLUSTERED 
(
	[rs_id] ASC,
	[branchcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


