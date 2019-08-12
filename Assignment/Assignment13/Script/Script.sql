---------------------CREATE Sql ------------------------------
USE [TutorialDay19]
GO

/****** Object:  Table [dbo].[Projects]    Script Date: 8/12/2019 5:28:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Projects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Description] [nvarchar](1023) NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL DEFAULT ((1))
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


--------------------------DROP Sql Query----------------
USE [TutorialDay19]
GO

/****** Object:  Table [dbo].[Projects]    Script Date: 8/12/2019 5:29:43 PM ******/
DROP TABLE [dbo].[Projects]
GO

----------------------------Select Query----------------
USE [TutorialDay19]
GO

SELECT [Id]
      ,[Name]
      ,[Description]
      ,[StartDate]
      ,[EndDate]
      ,[IsActive]
  FROM [dbo].[Projects]
GO


--------------------------Insert Query----------------

USE [TutorialDay19]
GO

INSERT INTO [dbo].[Projects]
           ([Name]
           ,[Description]
           ,[StartDate]
           ,[EndDate]
           ,[IsActive])
     VALUES
           (<Name, varchar(255),>
           ,<Description, nvarchar(1023),>
           ,<StartDate, datetime,>
           ,<EndDate, datetime,>
           ,<IsActive, bit,>)
GO


---------------------Update Query----------------

USE [TutorialDay19]
GO

UPDATE [dbo].[Projects]
   SET [Name] = <Name, varchar(255),>
      ,[Description] = <Description, nvarchar(1023),>
      ,[StartDate] = <StartDate, datetime,>
      ,[EndDate] = <EndDate, datetime,>
      ,[IsActive] = <IsActive, bit,>
 WHERE <Search Conditions,,>
GO


-------------------------Delete Query----------------

USE [TutorialDay19]
GO

DELETE FROM [dbo].[Projects]
      WHERE <Search Conditions,,>
GO




