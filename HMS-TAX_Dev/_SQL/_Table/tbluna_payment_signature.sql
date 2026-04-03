CREATE TABLE [dbo].[tbluna_payment_signature](
	[sysdocnum] [nvarchar](25) NOT NULL,
	[branchcode] [nvarchar](25) NOT NULL,
	[pv_id] [nvarchar](25) NULL,
	[rs_id] [nvarchar](25) NULL,
	[responder] [nvarchar](250) NULL,
	[position] [nvarchar](250) NULL,
	[rs_date] [datetime] NULL,
	[inputter] [nvarchar](250) NULL,
	[created_at] [datetime] NOT NULL,
 CONSTRAINT [PK_tbluna_payment_signature] PRIMARY KEY CLUSTERED 
(
	[sysdocnum] ASC,
	[branchcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


