use _SQL2
 create table Book (
 id int primary key, title varchar(20),
 author varchar(25),isbn numeric(30) unique,
 published_date datetime)
 drop table Book
  insert into book(id ,title,author,isbn,published_date) 
  values
 (1, 'my first sql book','mary parker' , 981483029127,'2012-02-22 12:08:17'),
 (2 ,'my second sql book ',' john mayer',857300923713, '1972-07-03 09:22:45'),
 (3, 'my third sql', 'cary flint' , 523120967812 , '2015-10-18 14:05:44')

  select * from book
  --Create a book table with id as primary key and provide the appropriate data type to other attributes 
  --.isbn no should be unique for each book
--Write a query to fetch the details of the books written by author whose name ends with er.

select * from book where author like '%er'

create table reviews (id int primary key,
book_id int,reviewer_name varchar(30),content ntext,
rating int,pub_date datetime)
insert into reviews(id ,
book_id ,reviewer_name ,content ,
rating,pub_date )
values (1,1,'John Smith', ' my first review' , 4, '2017-12-10 05:50:11.1'),
(2,2,'John Smith','my second review' , 5 , '2017-10-13 15:05:12.6'),
(3,2 , 'Alice Walker','Another review',1,'2017-10-22 23:47:10.0')

select * from reviews
--Display the Title ,Author and ReviewerName for all the books from the above table

 select title , author ,reviewer_name from book B ,reviews R
 where B.id = R.id

 --Display the reviewer name who reviewed more than one book.
 select reviewer_name from reviews
 group by reviewer_name
 having count (book_id)>1

 create table tblcustomer(
 id int primary key, _name varchar(20),
 age int , adress ntext, salary numeric(10))
 insert into tblcustomer(
 id , _name,
 age, adress, salary)
 values (1,'ramesh',32,'ahemdabad',2000),
 (2,'khilan', 25, 'delhi' , 1500),
 (3,'kaushik',23 , 'kota', 2000),
 (4,'chataili',25,'mumbai',6500),
 (5,'hardik',27,'bhopal',8500),
 (6,'komal',22,'mp',4500),
 (7,'muffy',24,'indore',10000)
 drop table tblcustomer
 select * from tblcustomer
 --Display the Name for the customer 
 --from above customer table who live in same address which
 --has character o anywhere in address
  select _name from tblcustomer where adress like '%o%'

create table orders(
OID int,
_date datetime,
customer_id int,
amount int)
 drop table orders
insert into orders values (102,'2009-10-08 00:00:00',3,3000),
(100,'2009-10-08 00:00:00',3,1500),(101,'2009-11-20',2,1560),
(103,'2008-05-20 00:00:00',4,2060)
select * from orders
select * from tblcustomer
--Write a query to display the Date,
--Total no of customer placed order on same Date
select _date,count(OID) as Total_customer 
from orders group by _date

create table _Employee(
 id int  , _name varchar(20),
 age int , adress ntext, salary numeric(10))
 drop table _Employee

 insert into _Employee(
 id , _name,
 age, adress, salary)
 values (1,'ramesh',32,'ahemdabad',2000),
 (2,'khilan', 25, 'delhi' , 1500),
 (3,'kaushik',23 , 'kota', 2000),
 (4,'chataili',25,'mumbai',6500),
 (5,'hardik',27,'bhopal',8500),
 (6,'komal',22,'mp',null),
 (7,'muffy',24,'indore',null)
 --Display the Names of the Employee in lower case,
 --whose salary is null
 select LOWER(_name) as nullsalary from _employee where salary =null

 create table Students_details(
RegisterNo int,
name varchar(20),
Age int,
Qualification varchar (10),
MobileNo bigint,
mail_id varchar(20),
Location varchar (20),
Gender char)

select * from Students_details
insert into Students_details
Values (1, 'Sai', 22, 'B.E', 9952836777, 'Sai@gmail.com', 'Chennai', 'M'),
 (2, 'Kumar', 20, 'BSC', 7890125648, 'Kumar@gmail.com', 'Madurai', 'M'),
 (3, 'Selvi', 22, 'B.TECH', 8904567342, 'selvi@gmail.com', 'Salem', 'F'),
 (4, 'Nisha', 25, 'M.E', 7834672310, 'Nisha@gmail.com', 'Theni', 'F'),
 (5, 'SaiSaran', 21, 'B.A', 7890345678, 'saran@gmail.com', 'Madurai', 'F'),
 (6, 'Tom', 23, 'BCA', 8901234675, 'Tom@gmail.com', 'Pune', 'M')
 --Write a sql server query to display the Gender,Total no of male and female from the above
--relation .
select gender, count(*) as CountofGender
from students_details
group by gender;

