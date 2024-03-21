use _SQL2
select *  from Employee
select * from Department

--1. Retrieve a list of MANAGERS. 
 select *  from Employee where job ='Manager'


--2. Find out the names and salaries of all employees earning more than 1000 per month. 

  select Emp_name , salary from Employee where salary>1000

--3. Display the names and salaries of all employees except JAMES. 

    select emp_name , Salary from Employee where Emp_Name!= 'james'

--4. Find out the details of employees whose names begin with ‘S’.

     select * from Employee where Emp_Name like 'S%' 


--5. Find out the names of all employees that have ‘A’ anywhere in their name. 

      select * from Employee where Emp_Name like '%a%'

--6. Find out the names of all employees that have ‘L’ as their third character in their name.

      select * from employee where Emp_Name like '__L%'
--7. Compute daily salary of JONES. 

      select  salary/30 as _dailysalary from Employee where Emp_Name = 'jones' 

--8. Calculate the total monthly salary of all employees. 
      
	  select sum(salary) as TOTALMONTHLY_SALARY from Employee

--9. Print the average annual salary . 
      select AVG( salary*12) as AVERAGEAnnualSALARY from Employee

--10. Select the name, job, salary, department number of all employees except 
--SALESMAN from department number 30. 

    select Emp_Name , job , salary , dept_no
	from Employee 
	where job !='salesman' and Dept_no = 30

--11. List unique departments of the EMP table. 
 
    select distinct Dept_no from Employee -----
	select * from Employee

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
     select emp_name  as Employee, salary as Monthly_salary 
	 from Employee 
	 where Dept_no in (10,30) and salary >1500

--13. Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000. 

   select emp_name , salary, job from Employee where job in ( 'manager' , 'analyst') and salary not in(1000,3000,5000)
   select * from Employee

--14. Display the name, salary and commission for all employees whose commission
--amount is greater than their salary increased by 10%. 
  
  select emp_name , salary , comm from Employee where comm>Salary*1.1

--15. Display the name of all employees who have two Ls in their name and are in 
--department 30 or their manager is 7782.
select * from Employee
select emp_name from employee where Emp_Name like '%L%L%' and (Dept_no = 30 or Mgr_id = 7782)


--16. Display the names of employees with experience of over 30 years and under 40 yrs.
--Count the total number of employees. 

 select emp_name from Employee 
 where 
 YEAR(getdate())- YEAR(hire_date)>30 and YEAR(getdate())- YEAR(hire_date)<40
 select count (*) as _count_of_employee_withEXP_gt30ndLs40 from Employee where
 YEAR(getdate())- YEAR(hire_date)>30 and YEAR(getdate())- YEAR(hire_date)<40


--17. Retrieve the names of departments in ascending order and their employees in 
--descending order. 
 select * from Department
  select x.dept_name ,y.Emp_Name from Department x
  join Employee y on x.Dept_No = y.Dept_no
  order by Dept_Name Asc , Emp_Name desc


--18. Find out experience of MILLER. 
select * from Employee
select DATEDIFF( yy, Hire_date , getdate()) as experience_of_miller from
Employee
where Emp_Name = 'miller'