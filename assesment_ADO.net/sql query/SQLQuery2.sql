--> creating database named Employeemanagement......
create database Employeemanagement
use Employeemanagement

/*2. Create a table in the database called Employee_Details (Empno int Primary Key,
EmpName varchar(50) not null,
Empsal numeric(10,2) apply a check condition that empsal >=25000
Emptype char(1) check whether type is 'P' or 'C'
)*/

-- creating the table --
create table Employee_Details
(Empno int Primary key,
EmpName varchar(50) not null,
Empsal numeric(10,2),
Emp_type char(1))

----i have added constraint check_esal and check_etype to a check condition that empsal >=25000 Emptype char(1)
--check whether type is 'P' or 'C'

alter table Employee_Details
add constraint check_esal check (Empsal >= 25000)

alter table Employee_Details
add constraint check_etype check (Emp_type in ('P', 'C'))

select * from Employee_Details


--Create a stored procedure that adds new rows to the Employee_Details Table. 
--The procedure should accept all the details as input except empno.
--You need to write the code in the procedure to generate the empno and then insert


create sequence Empno_Sequence
start with 1
Increment by 1

drop sequence Empno_Sequence

create or alter procedure Add_row (
@EmpName varchar(50) ,
@Empsal numeric(10,2),
@Emp_type char(1)
)
as
begin 
declare 
@new_empno int;

 SET @new_empno = next value for Empno_Sequence;

   insert into  Employee_Details (Empno, EmpName, Empsal, Emp_type)
    values (@new_empno, @EmpName, @Empsal, @Emp_type);



	select @new_empno as Empno

end


exec Add_row 'sharad' ,55000 ,'p'
exec Add_row 'vikash',30000,'p'
exec Add_row 'avinsah',40000,'c'
select * from Employee_Details
drop table Employee_Details

-- the output is 
/*
1	sharad	55000.00	p
2	vikash	30000.00	p
3	avinsah	40000.00	c
*/



