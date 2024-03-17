use _SQL2

-- create table Employee

Create table Employee(Emp_no Numeric(5), Emp_Name varchar(20), job varchar(20),Mgr_id Numeric(5), 

Hire_date Date, Salary Numeric(5),Comm Numeric(5), Dept_no Numeric(3) foreign key references Department(Dept_no))
 

--Insert values in Employee

Insert into Employee  values (7369, 'SMITH', 'CLERK', 7902, '17-DEC-80', 800, NULL, 20),

(7499, 'ALLEN', 'SALESMAN', 7698, '20-FEB-81', 1600, 300, 30),

(7521, 'WARD', 'SALESMAN', 7698, '22-FEB-81', 1250, 500, 30),

(7566, 'JONES', 'MANAGER', 7839, '02-APR-81', 2975, NULL, 20),

(7654, 'MARTIN', 'SALESMAN', 7698, '28-SEP-81', 1250, 1400, 30),

(7698, 'BLAKE', 'MANAGER', 7839, '01-MAY-81', 2850, NULL, 30),

(7782, 'CLARK', 'MANAGER', 7839, '09-JUNE-81', 2450, NULL, 10),

(7788, 'SCOTT', 'ANALYST', 7566, '19-APR-87', 3000, NULL, 20),

(7839, 'KING', 'PRESIDENT', NULL, '17-NOV-81', 5000, NULL, 10),

(7844, 'TURNER', 'SALESMAN', 7698, '08-SEP-81', 1500, 0,30),

(7876, 'ADAMS', 'CLERK', 7788, '23-MAY-87', 1100, NULL, 20),

(7900, 'JAMES', 'CLERK', 7698, '03-DEC-81', 950, NULL, 30),

(7902, 'FORD', 'ANALYST', 7566,'03-DEC-81', 3000, NULL, 20),

(7934, 'MILLER', 'CLERK', 7782,'23-JAN-82', 1300, NULL, 10)
 
-- Data of Table Employee

select * from Employee
 
-- Create tabel Department

create table Department(Dept_No Numeric(3) primary Key, Dept_Name varchar(15), Loc varchar(20))
 select * from Department

-- insert values in Department table

insert into Department values(10, 'ACCOUNTING', 'NEW YORK'),(20, 'RESEARCH', 'DALLAS'),

                              (30, 'SALES', 'CHICAGO'),(40, 'OPERATIONS', 'BOSTON')
 
-- Data of Table Department

select * from Department
 
--1 .List all employees whose name begins with 'A'

select * from Employee where Emp_Name Like 'A%'

 --2 .Select all those employees who don't have a manager

select * from Employee where job!='Manager'
 
--3 .List employee name, number and salary for those employees who earn in the range 1200 to 1400.

select Emp_Name, Emp_no, Salary from Employee where Salary Between 1200 and 1400
 
--4 . Give all the employees in the RESEARCH department a 10% pay rise. 
--Verify that this has been done by listing all their details before and after the rise. 

select Dept_no from Department where Dept_Name = 'research' 
Select Emp_no, Emp_Name, Job, salary From Employee

where Dept_no = 20;-- before the raise

select Emp_no, Emp_Name, Job, Salary = Salary+((Salary*10)/100) from Employee

Where Dept_no = 20 -- after payraise
 
--5 Find the number of CLERKS employed. Give it a descriptive heading.

Select COUNT(*) as " clerk employees " from Employee

where job = 'CLERK';
 
-- 6 Find the average salary for each job type and the number of people employed in each job.

Select job, AVG(salary) as "Average salary",count(*) as "No. of Employees" From Employee Group By job

-- 7 List the employees with the lowest and highest salary. 

--Highest Salary

select Emp_Name,job , Salary as "highest  Salary of Employees" from Employee

where Salary  =(select Max(Salary) from Employee)

--lowest Salary

select Emp_Name,job,Salary as " lowest Salary of Employees", from Employee

where Salary  =(select Min(Salary) from Employee)
 
-- 8List full details of departments that don't have any employees.

select Dept.Dept_No, Dept.Dept_Name, Dept.Loc

FROM Department dept

Left JOIN Employee Em ON Dept.Dept_No = Em.Dept_no

WHERE Em.Emp_no IS NULL;
 
-- 9 Get the names and salaries of all the analysts earning more than 1200 who are based in department 20.
--Sort the answer by ascending order of name. 
 select Emp_Name, Salary, Job from Employee

where Salary>1200 and Dept_no=20 and job = 'Analyst'
-- sorting done by emp name --
Order by Emp_Name

-- 10 . Find out salary of both MILLER and SMITH.
select Salary ,Emp_Name from Employee 
where Emp_Name = ('Smith') or Emp_Name = ('Miller')

select * from Employee


--11 For each department,
--list its name and number together with the total salary paid to employees in that department.

select Dept_Name ,Department.Dept_No  , sum(Salary) as "total salary" from Department
join Employee on  Department.Dept_No = Employee.Dept_no
group by Dept_Name ,Department.Dept_No 



--12 Find out the names of the employees whose name begin with ‘A’ or ‘M’
select Emp_Name from Employee 
where Emp_Name like 'A%' or Emp_Name like 'm%'
-- there are 4 employees .....

--13 Compute yearly salary of SMITH. 
select Emp_Name, Salary*12 from Employee
where Emp_Name='Smith'

--14List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
select Emp_Name, salary from Employee
where salary Not Between 1500 and 2850

--15  Find all managers who have more than 2 employees reporting to them.
select mgr_id  ,count(Emp_no) as ' number of emloyee under mngr ' from Employee 
group by mgr_id
having count ( Emp_no) >2 

--select mgr_id from Employee 
--group by Mgr_id having count (Emp_no)>2
