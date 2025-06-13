select *
from [dbo].[DaySales];

select *
from [dbo].[WeekSales];

select *
from [dbo].[MonthSales];

select *
from [dbo].[QuarterSales];


/*

DELETE FROM [dbo].[Sales];
DBCC CHECKIDENT ('[dbo].[Sales]', RESEED, 0);

DELETE FROM [dbo].[DaySales];
DBCC CHECKIDENT ('[dbo].[DaySales]', RESEED, 0);

DELETE FROM [dbo].[WeekSales];
DBCC CHECKIDENT ('[dbo].[WeekSales]', RESEED, 0);

DELETE FROM [dbo].[MonthSales];
DBCC CHECKIDENT ('[dbo].[MonthSales]', RESEED, 0);

DELETE FROM [dbo].[QuarterSales];
DBCC CHECKIDENT ('[dbo].[QuarterSales]', RESEED, 0);

*/
