CREATE TABLE [dbo].[Projects]( 
[Id] [int] IDENTITY(1,1) NOT NULL, 
[Name] [varchar](255) NOT NULL, 
[Description] [nvarchar](1023) NULL, 
[StartDate] [datetime] NOT NULL, 
[EndDate] [datetime] NOT NULL, 
[IsActive] [bit] NOT NULL DEFAULT(1), 
) 