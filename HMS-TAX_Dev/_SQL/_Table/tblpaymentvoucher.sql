CREATE TABLE [dbo].[tblpaymentvoucher](
	[pv_id] [nvarchar](50) NOT NULL,
	[branchcode] [nvarchar](50) NOT NULL,
	[pay_date] [date] NULL,
	[pay_to] [nvarchar](50) NULL,
	[pay_option] [nvarchar](50) NOT NULL,
	[receipt] [nvarchar](50) NULL,
	[invoice] [nvarchar](50) NULL,
	[draft] [bit] NOT NULL,
	[inputter] [nvarchar](50) NULL,
	[created_at] [datetime] NOT NULL,
	[authoriser] [nvarchar](250) NULL,
	[authorize_at] [datetime] NULL,
 CONSTRAINT [PK_tblpaymentvoucher] PRIMARY KEY CLUSTERED 
(
	[pv_id] ASC,
	[branchcode] ASC,
	[pay_option] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblpaymentvoucher] ADD  CONSTRAINT [DF_tblpaymentvoucher_created_at]  DEFAULT (getdate()) FOR [created_at]
GO


