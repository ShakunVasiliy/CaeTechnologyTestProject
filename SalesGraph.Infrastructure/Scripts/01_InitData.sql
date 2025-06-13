begin try
	begin tran;

		declare @startDate date = '2000-01-01';
		declare @endDate date = '2030-12-31';
		declare @currentDate date;
		declare @nextDate date;

		-- fill DaySales (template rows)
		if not exists(select top(1) * from [dbo].[DaySales])
		begin
			set @currentDate = @startDate;
			while (@currentDate <= @endDate)
			begin
				set @nextDate = dateadd(day, 1, @currentDate);

				insert into [dbo].[DaySales] (StartDate, EndDate)
				values (@currentDate, @nextDate);

				set @currentDate = @nextDate;
			end;
		end;

		-- fill WeekSale (template rows)
		set datefirst 1; -- set that Monday is the first day of week
		if not exists(select top(1) * from [dbo].[WeekSales])
		begin
			declare @dayShift int = 1;
			declare @weekDayCount int = 7;

			set @currentDate = @startDate;
			while (@currentDate <= @endDate)
			begin
				set @dayShift = @weekDayCount - (DATEPART(weekday, @currentDate) - 1);
				set @nextDate = dateadd(day, @dayShift, @currentDate);

				--select @currentDate, @nextDate, @dayShift, DATEPART(weekday, @currentDate), FORMAT(@currentDate, 'dddd');

				insert into [dbo].[WeekSales] (StartDate, EndDate)
				values (@currentDate, @nextDate);

				set @currentDate = @nextDate;
			end;
		end;
		
		-- fill MonthSales (template rows)
		if not exists(select top(1) * from [dbo].[MonthSales])
		begin
			set @currentDate = @startDate;
			while (@currentDate <= @endDate)
			begin
				set @nextDate = dateadd(month, 1, @currentDate);

				insert into [dbo].[MonthSales] (StartDate, EndDate)
				values (@currentDate, @nextDate);

				set @currentDate = @nextDate;
			end;
		end;
		
		-- fill QuarterSales (template rows)
		if not exists(select top(1) * from [dbo].[QuarterSales])
		begin
			set @currentDate = @startDate;
			while (@currentDate <= @endDate)
			begin
				set @nextDate = dateadd(month, 3, @currentDate);

				insert into [dbo].[QuarterSales] (StartDate, EndDate)
				values (@currentDate, @nextDate);

				set @currentDate = @nextDate;
			end;
		end;

	commit tran;
end try
begin catch
	if @@TRANCOUNT > 0
	begin
		rollback tran;
	end;
end catch;