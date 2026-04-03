drop table [tblcost]
CREATE TABLE [dbo].[tblcost](
	[sysdocnum] [nvarchar](25) NOT NULL,
	[branchcode] [nvarchar](25) NOT NULL,
	[pro_code] [nvarchar](25) NOT NULL,
	[stock_code] [nvarchar](25) NOT NULL,
	[batch_id] [nvarchar](25) NOT NULL,
	[cost] [money] NULL,
	[inputter] [nvarchar](250) NULL,
	[create_at] [datetime] NULL,
 CONSTRAINT [PK_tblcost] PRIMARY KEY CLUSTERED 
(
	[sysdocnum] ASC,
	[branchcode] ASC,
	[pro_code] ASC,
	[stock_code] ASC,
	[batch_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


