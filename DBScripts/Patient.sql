/****** Object:  Table [dbo].[Patient]    Script Date: 3/11/2020 5:53:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Patient](
	[PatientId] [bigint] IDENTITY(1,1) NOT NULL,
	[BirthDate] [datetime2](7) NULL,
	[Gender] [varchar](1) NULL,
	[FirstName] [varchar](50) NULL,
	[MiddleName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[CreateDate] [datetime2](7) NULL,
	[LastUpdateDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


