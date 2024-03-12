using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Create an Employee class with Empid int, Empname string, Salary float.
 * Pass values to the members through Constructor.
Create a derived class called ParttimeEmployee with Wages as a data member. 
Instantiate the base class through the derived class constructor */
namespace ConsoleApp1
{
    class Employee
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }
        public Employee(int empid, string empname, float salary)
        {
            Empid = empid;
            EmpName = empname;
            Salary = salary;

        }
    }
    class ParttimeEmployee : Employee
    {
        public float Wages { get; set; }

        public ParttimeEmployee(int empid, string empname, float salary, float wages) : base(empid, empname, salary)
        { 
            Wages = wages;

        }
    }
        class Empdetails
        {
        static void Main()
        {
            Console.WriteLine(" Enter the Employee Id :");
            int empid = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the Employee Name:");
            string empname = Console.ReadLine();

            Console.WriteLine(" Enter the Salary of the Employee : ");
            float salaray = float.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the Wages of the Employee :");
            float wages = float.Parse(Console.ReadLine());
           
            ParttimeEmployee pt = new ParttimeEmployee( empid, empname, salaray ,wages);
            Console.WriteLine(" Employee Id is->" + empid);
            Console.WriteLine(" Employee Name ->" + empname);
            Console.WriteLine(" Employee Salaray ->" + salaray);
            Console.WriteLine(" Employee Wages ->" + wages);
            Console.ReadLine();
        }

    }
}
