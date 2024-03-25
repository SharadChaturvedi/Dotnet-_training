use _SQL2
select * from emp
select *from holiday

--1.	Write a T-SQL Program to find the factorial of a given number.
declare @num int = 4
declare @factorial int = 1
declare @num2 int = 1
if @num <=0
begin 
print 'Factorial for negative number is non-defined'
end 
else
begin
while 
@num2 <= @num
begin
set @factorial = @factorial*@num2
set @num2 = @num2 +1
end
print ' The factorial of ' + cast (@num as varchar(10)) + ' is ' + cast (@factorial as varchar(10))
end
select @factorial as factorialofnumber
--output
-- The factorial of 4 is 24
--(1 row affected)
--Completion time: 2024-03-25T20:01:55.1364052+05:30

------------------------------------------------------------------------------------------------------------------------

--2.	Create a stored procedure to generate multiplication tables up to a given number.

create or alter proc Multables 
@numx int = 10
as 
begin 
declare @tobemultiplied int =1
declare @multiplier int
while 
@tobemultiplied <= @numx
begin 
set @multiplier =1
while 
@multiplier<=@numx
begin
print concat (@tobemultiplied,'*',@multiplier,'=',@tobemultiplied*@multiplier)
set @multiplier = @multiplier+1
end
set 
@tobemultiplied =@tobemultiplied+1
print'-------------------------------------'
end 
end
exec Multables
      
--3.  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc

--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 

select * from emp
select *from Holiday
-- these are the values in my table holiday 
--holiday_date  holiday_name
--2024-03-18	Maha Shivratri
--2024-03-25	Holi
--2024-03-26	Bhaidooj
--2024-07-15	Independence Day
--2024-11-01	Subh Deepawali
--2025-01-01	New Year

create or alter trigger noDml
on emp
for insert,update,delete
as
begin
declare @_count int
declare @holiday_name varchar(20)
select @_count= count(* )from holiday where holiday_date = convert(date,getdate())
if @_count>0 
begin
select @holiday_name=holiday_name from holiday where holiday_date=convert(date,getdate())
raiserror ('Due to %s, you cannot manipulate date',16,1,@holiday_name)
end
end
drop trigger noDml
select * from emp
insert into emp values(10, 'lala' ,50000, 'admin','2024-08-15')