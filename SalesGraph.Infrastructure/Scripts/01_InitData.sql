declare @startDate date = '2000-01-01';
declare @endDate date = '2030-12-31';

-- fill DaySales
declare @currentDate date = @startDate;
declare @nextDate date;
while (@currentDate <= @endDate)
begin
	set @nextDate = dateadd(day, 1, @currentDate);

	insert into [dbo].[DaySales] (StartDate, EndDate)
	values (@currentDate, @nextDate);

	set @currentDate = @nextDate;
end