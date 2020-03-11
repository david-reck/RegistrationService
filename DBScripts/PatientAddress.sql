/****** Object:  Table [dbo].[PatientAddress]    Script Date: 3/11/2020 5:54:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PatientAddress](
	[PatientAddressId] [bigint] IDENTITY(1,1) NOT NULL,
	[StreetAddress] [varchar](100) NULL,
	[StreetAddress2] [varchar](100) NULL,
	[City] [varchar](100) NULL,
	[State] [char](2) NULL,
	[ZipCode] [varchar](10) NULL,
	[CreateDate] [datetime2](7) NULL,
	[LastUpdateDate] [datetime2](7) NULL,
	[PatientId] [bigint] NOT NULL,
 CONSTRAINT [PK_PatientAddress] PRIMARY KEY CLUSTERED 
(
	[PatientAddressId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PatientAddress]  WITH CHECK ADD  CONSTRAINT [FK_PatientAddress_Patient] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patient] ([PatientId])
GO

ALTER TABLE [dbo].[PatientAddress] CHECK CONSTRAINT [FK_PatientAddress_Patient]
GO


