use _SQL
select * from Employee
--1.	Write a query to display your birthday( day of week)
declare
@date date = '1999-11-10'
select datename (dw, @date) as 'my birthday - Day of week'
--output 
--my birthday -Day of week
--Wednesday


------------------------------------------------------------------------------------------------------
--2.	Write a query to display your age in days
select datediff (day,'1999-11-10',getdate()) as 'age_in_days'
--output 
--age_in_days 
--8905


------------------------------------------------------------------------------------------------------ 
--3.	Write a query to display all employees information those who joined before 5 years in the current month
 --(Hint : If required update some HireDates in your EMP table of the assignment)
 select * from Employee
 select * 
 from
 Employee where DATEDIFF(yy,hire_date,getdate()) >5


-------------------------------------------------------------
 

--4.	Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
	--a. First insert 3 rows 
	--b. Update the second row sal with 15% increment  
        --c. Delete first row.
--After completing above all actions how to recall the deleted row without losing increment of second row.

--select * from Employee
create table Empl_2
(empno int primary key,
ename varchar(20),
salary numeric(10),
doj date)
Insert into  Empl_2 (empno, ename, salary, doj) Values
(1, 'ram', 50000, '2020-01-15'),
(2, 'sita', 60000, '2019-05-20'),
(3, 'gita', 55000, '2021-03-10'),
(4, 'Bhari', 48000, '2022-02-25');
select * from Empl_2

begin transaction
----a. First insert 3 rows 
Insert into  Empl_2 (empno, ename, salary, doj) Values
(5, 'gautam', 2000, '2021-01-16'),
(6, 'guddu', 9000, '2024-01-01'),
(7,'hariya',13000,'2023-11-8')
 save tran f1

----Update the second row sal with 15% increment  
update Empl_2 set salary = salary*1.15 where empno =6;
save tran f2
--output
--6	guddu	10350	2024-01-01

----c. Delete first row.
delete from Empl_2 where empno =5
save tran f3

--output 
--1	ram	50000	2020-01-15
--2	sita	60000	2019-05-20
--3	gita	55000	2021-03-10
--4	Bhari	48000	2022-02-25
--6	guddu	11903	2024-01-01
--7	hariya	13000	2023-11-08
rollback tran f2
commit 


 
--5.      Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
	--a.     For Deptno 10 employees 15% of sal as bonus.
	--b.     For Deptno 20 employees  20% of sal as bonus
	--c      For Others employees 5%of sal as bonus

	select * from Employee
	create or alter function bonuscalculation 
	(@deptno int ,
	@sal float(20))
	returns varchar(100)
	as
	begin
	declare @bonus float
	declare @message varchar(100)

	if 
	@deptno = 10
	set @bonus = @sal * 0.15
	else 
	if 
	@deptno =20
	set @bonus = @sal * 0.20
	else 
	set
	@bonus = @sal *0.05
	return @bonus
	end

	select dbo.bonuscalculation(10,50000) AS Bonus_calculation
	--output
	--7500
	
	

