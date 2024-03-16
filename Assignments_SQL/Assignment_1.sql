use _SQL
   create database _SQL
   -- client table --
  create table Clients(ClientID numeric(4) primary key,
  Cname varchar(40) not null,
  Adress varchar(30),
  Email varchar(30) unique,
  phone numeric(10),
  Business varchar (20))
  
  
  -- Departments Table--
  create table Departments
  ( Deptno numeric(2) primary key,
  Dname varchar(15) not null, 
  Loc varchar(20) )
 
  -- Employee table --
  create table Employee(Empno numeric (4) primary key,
  Ename varchar(20) not null,
  job varchar (15),
 Salary numeric(7) check (salary>0),
 Deptno numeric(2) foreign key references Departments(Deptno) )

 -- project table --
 create table project(
 projectID numeric (3) primary key,
 Descr varchar (30) not null,
 Startdate Date ,
 planned_end_date Date,
 Actual_end_date Date ,
 budget numeric(10) check (budget>0),
 client_ID numeric(4) foreign key references Clients(ClientID))
 alter table project 
add Constraint new_Actual_end_date check (Actual_end_date>planned_end_date)
-- using constraints for the table project to get actual date greater than panned end date,
 

 create table EmpProjectTasks
(projectID numeric(3),Empno numeric(4),StartDate date,EndDate date,
Task varchar(25),Status varchar(15),primary key(projectID,Empno),
foreign key (projectID)references project(projectID),
foreign key (Empno)references Employee(Empno)
)

 
 select * from EmpProjectTasks
 select * from Employee
 select * from project
 select * from Clients
 select * from Departments

 

--Insert values in client table 

insert into Clients values

(1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing'),

(1002,'Trackon Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant'),

(1003,'MoneySaver Distributors','Kolkata','save@moneysaver.com',7799886655,'Reseller'),

(1004,'Lawful Corp','Chennai','justice@lawful.com',9210342219,'Professional')
 
select * from Clients
 
--insert values in Department table

insert into Departments values
(10,'Design','Pune'),
(20,'Development','pune'),
(30,'Testing','Mumbai'),
(40,'Document','Mumbai')
 
select * from Departments
 
--Insert values in Employees Table

insert into Employee values
(7001,'Sandeep','Analyst',25000,10),
(7002,'Rajesh','Designer',30000,10),
(7003,'Madhav','Developer',40000,20),
(7004,'Manoj','Developer',40000,20),
(7005,'Abhay','Designer',35000,10),
(7006,'Uma','Tester',30000,30),
(7007,'Gita','Tech. Writer',30000,40),
(7008,'Priya','Tester',35000,30),
(7009,'Nutan','Developer',45000,20),
(7010,'Smita','Analyst',20000,10),
(7011,'Anand','Project Mgr',65000,10)
 
select * from Employee
 
--Insert into Project Table

insert into Project values(401,'Inventory','2011-04-01','2011-10-01','2011-10-31',150000,1001),

(402,'Accounting','2011-08-01','2012-01-01',null,150000,1002),(403,'Payroll','2011-12-11','2011-12-31',null,150000,1003),

(404,'Contact mgmt','2011-11-01','2011-12-31',null,150000,1004)
 
select * from Project
 
 
--insert value in EmpProject task 

insert into EmpProjectTasks 
values
(401,7001,'2011-04-01','2011-04-20','System Analysis','Completed'),
(401,7002,'2011-04-21','2011-05-30','System Design','Completed'),

(401,7003,'2011-06-01','2011-07-15','Coding','Completed'),
(401,7004,'2011-07-18','2011-09-01','Coding','Completed'),

(401,7006,'2011-09-03','2011-09-15','Testing','Completed'),
(401,7009,'2011-09-18','2011-10-05','Code Change','Completed'),

(401,7008,'2011-10-06','2011-10-16','Testing','Completed'),
(401,7007,'2011-10-06','2011-10-22','Documentation','Completed'),

(402,7011,'2011-10-22','2011-10-31','Sign Off','Completed'),
(402,7010,'2011-08-01','2011-08-20','System Analysis','Completed'),

(402,7002,'2011-08-22','2011-09-30','System Design','Completed'),
(402,7004,'2011-10-01',null,'Coding','in Process')
 
select * from EmpProjectTasks

drop table Clients
drop table project
drop table Employee
drop table EmpProjectTasks










