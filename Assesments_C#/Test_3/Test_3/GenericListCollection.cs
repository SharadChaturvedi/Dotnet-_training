using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Test_3
{
    class Generics
    {
        static void Main()
        {

            List<Employee> empList = new List<Employee>()
        {
            new Employee(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 6, 8), "Mumbai"),
            new Employee(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai"),
            new Employee(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 4, 12), "Pune"),
            new Employee(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 6, 3), new DateTime(2016, 2, 2), "Pune"),
            new Employee(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 3, 8), new DateTime(2016, 2, 2), "Mumbai"),
            new Employee(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 7), new DateTime(2014, 8, 8), "Chennai"),
            new Employee(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 2), new DateTime(2015, 6, 1), "Mumbai"),
            new Employee(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 6, 11), "Chennai"),
            new Employee(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 8, 12), new DateTime(2014, 3, 12), "Chennai"),
            new Employee(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 4, 12), new DateTime(2016, 1, 2), "Pune")
        };

            // a. Display detail of all the employee
            Console.WriteLine("a. The Details of all employees:");
            empList.ForEach(emp => Console.WriteLine(emp));
            Console.WriteLine("------------------------------------------------------------");

            // b. Display details of all the employee whose location is not Mumbai
            var notMumbaiEmployees = empList.Where(emp => emp.City != "Mumbai");
            Console.WriteLine("\nb. The Details of employees whose location is not Mumbai:");
            notMumbaiEmployees.ToList().ForEach(emp => Console.WriteLine(emp));
            Console.WriteLine(" ------------------------------------------------------------");

            // c. Display details of all the employee whose title is AsstManager
            var asstManagers = empList.Where(emp => emp.Title == "AsstManager");
            Console.WriteLine("\nc.  The Details of employees with the title AsstManager:");
            asstManagers.ToList().ForEach(emp => Console.WriteLine(emp));
            Console.WriteLine(" -------------------------------------------------------------");


            // d. Display details of all the employee whose Last Name starts with S
            var lastNameStartsWithS = empList.Where(emp => emp.LastName.StartsWith("S"));
            Console.WriteLine("\nd.  The Details of employees whose Last Name starts with 'S':");
            lastNameStartsWithS.ToList().ForEach(emp => Console.WriteLine(emp));
            Console.WriteLine(" --------------------------------------------------------------");

            Console.ReadLine();
        }
    }

    class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;

        public Employee(int id, string firstName, string lastName, string title, DateTime dob, DateTime doj, string city)
        {
            EmployeeID = id;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            DOB = dob;
            DOJ = doj;
            City = city;
        }

        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID}, " +
                $"Name: {FirstName} {LastName}," +
                $" Title: {Title}, " +
                $"DOB: {DOB.ToShortDateString()}, " +
                $"DOJ: {DOJ.ToShortDateString()}, " +
                $"City: {City}";

        }

    }
}