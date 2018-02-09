USE [GroceryApp]
GO
/****** Object:  Table [dbo].[GroceryLists]    Script Date: 2/9/2018 10:40:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroceryLists](
	[GroceryListID] [int] IDENTITY(1,1) NOT NULL,
	[GroceryName] [nvarchar](50) NOT NULL,
	[GroceryQty] [int] NOT NULL
) ON [PRIMARY]
GO
