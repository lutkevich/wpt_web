CREATE TABLE [dbo].[wpt]
(
	[wpt_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [wpt_name] VARCHAR(50) NULL, 
    [wpt_date_create] DATETIME NULL, 
    [wpt_coordinate] [sys].[geography] NULL
)
