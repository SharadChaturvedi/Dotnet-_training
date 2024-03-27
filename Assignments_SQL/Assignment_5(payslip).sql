/*write a tsql based procedure to generate complete payslip of a given employee with respect to the following condition
a. HRA as 10% of salary
b. DA as 20% of salary
c. PF as   8% of salary
d . IT as 5% of salary
e. deduction as sum of PF and IT
f. Gross salary as Sum of salary,HRA,DA
g ,Net salary as gross salary - deductions*/

use _SQL2
select * from Employee
create or alter proc Payslip
@employeeno int
as
begin
PRINT 'Employee Payslip for Employee : ' + cast(@employeeno as varchar(20))
declare @salary float
declare @HRA float 
declare @pf float
declare @DA float
declare @IT float
declare @Ded float
declare @GS float
declare @NS float
--now to get employee salary
select @salary = salary 
from Employee
where Emp_no = @employeeno
-------------------------------------------------------------------
set @HRA = 0.1 *@salary--HRA as 10% of salary
set @DA = 0.2 *@salary --DA as 20% of salary
set @pf = 0.08 * @salary--PF as   8% of salary
set @IT = 0.05 * @salary--IT as 5% of salary
set @Ded = @pf + @IT --deduction as sum of PF and IT
set @GS = @salary + @HRA +@DA--Gross salary as Sum of salary,HRA,DA
set @NS = @GS - @Ded --Net salary as gross salary - deductions
 print '------------------------------------------------------------'
Print'-->Basic Salary: ' + cast(@salary as varchar(10))
Print '-->HRA: ' + cast(@HRA as varchar(20))
Print '-->DA: ' + cast(@DA as varchar(12))
Print '-->PF: ' + cast(@PF as varchar(20))
Print '-->IT: ' + cast(@IT as varchar(20))
Print '-->Deductions: ' + cast(@Ded as varchar(20))
Print '-->Gross Salary: ' + cast(@GS as varchar(20))
Print '-->Net Salary: ' + cast(@NS as varchar(20))
print '-------------------------------------------------------------'
end

exec Payslip @employeeno =7499

/*Employee Payslip for Employee : 7499
-----------------------------------
Basic Salary: 1600
HRA: 160
DA: 320
PF: 128
IT: 80
Deductions: 208
Gross Salary: 2080
Net Salary: 1872*/