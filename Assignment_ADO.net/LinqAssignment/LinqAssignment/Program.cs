using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;

namespace LinqAssignment
{
    /*1. Create a console application and add class named Employee with following field.
   Employee Class
   EmployeeID (Integer)
   FirstName (String)
   LastName (String)
   Title (String)
   DOB (Date)
   DOJ (Date)
   City (String)*/
    class Employees
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        //2. Create a Generic List Collection empList and populate it with the following records.
        static void Main(string[] args)
        {
            List<Employees> emp = new List<Employees>
            {
            new Employees { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
            new Employees { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employees { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
            new Employees { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
            new Employees { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employees { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employees { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
            new Employees { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
            new Employees { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
            new Employees { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };

            // 1. Display a list of all the employees who have joined before 1/1/2015
            var Before2015 = emp.Where(e => e.DOJ < new DateTime(2015, 1, 1));
            foreach (var e in Before2015)
            {
                Console.WriteLine($" The list of Employees who joined before 1/1/2015 are :->{e.FirstName} {e.LastName}");
            }
            Console.WriteLine("============================================================================");




            //2.Display a list of all the employee whose date of birth is after 1 / 1 / 1990
            var After1990 = emp.Where(e => e.DOB > new DateTime(1990, 1, 1));
            foreach (var e in After1990)
            {
                Console.WriteLine($" The list of the employees whose dob is after 1/1//1990 are:->{e.FirstName} {e.LastName}");
            }
            Console.WriteLine("=============================================================================");



            // 3. Display a list of all the employees whose designation is Consultant and Associate
            var consorasso = emp.Where(e => e.Title == "Consultant" || e.Title == "Associate");
            foreach (var e in consorasso)
            {
                Console.WriteLine($"\'Employees with designation Consultant or Associate are':->{e.FirstName} {e.LastName}");
            }
            Console.WriteLine("===============================================================================");




            //4.Display total number of employees
            var EmpCount = emp.Count();
            Console.WriteLine($"The Total Number of Employee are:-> " +
            $"{EmpCount}");
            Console.WriteLine("===============================================================================");




            //5. Display total number of employees belonging to “Chennai”
            var EmpinChennai = emp.Where(e => e.City == "Chennai");
            foreach
            (var e in EmpinChennai)
                Console.WriteLine($"The Employee who belongs to Chennai are :-> " +
                $"{e.FirstName} {e.LastName}");
            Console.WriteLine("================================================================================");

            //6. Display highest employee id from the list
            int Highest_ID = emp.Max(e => e.EmployeeID);
            Console.WriteLine($"The Employee with Higest Employee ID is :->");
            Console.WriteLine($"{Highest_ID}");
            Console.WriteLine("=================================================================================");




            //7.Display total number of employee who have joined after 1 / 1 / 2015
            int empAfter = emp.Count(e => e.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"The Number of Employee who joined after 1/1/2015 are :-> ");
            Console.WriteLine($"{empAfter}");
            Console.WriteLine("=================================================================================");



            // 8. Total number of employees with designation other than "Associate"
            var EMPnot_associate = emp.Count(e => e.Title != "Associate");
            Console.WriteLine($"The Total number of employees with designation other than Associate are:->");
            Console.WriteLine($"{EMPnot_associate}");
            Console.WriteLine("==================================================================================");



            // 9. Total number of employees based on City
            var basedoncity = emp.GroupBy(e => e.City)
            .Select(group => new { city = group.Key, count = group.Count() });//group.key refers to the key of each group,
                                                                              //here we are grouping by city ,so group.key will represent each unique city .
            Console.WriteLine("The total number of employee based on city are :->");
            foreach
                (var city in basedoncity)
            {
                Console.WriteLine($"{city.city} :-> {city.count}");
            }
            Console.WriteLine("==============================================================================");

            // 10. Total number of employees based on city and title


            var basedonCityAndTitle = emp.GroupBy(e => new { e.City, e.Title })
            .Select(groupbycndt => new { City = groupbycndt.Key.City, Title = groupbycndt.Key.Title, EmP_count = groupbycndt.Count() });
                foreach (var v in basedonCityAndTitle)
                {
                Console.WriteLine($"Total number of employees based on city and title :->{v.City}:->{v.Title}:-> {v.EmP_count}");
                 }
            Console.WriteLine("============================================================================");

            //11. Display total number of employee who is youngest in the list
            var Yongestemp = emp.Min(e => (DateTime.Today - e.DOB).TotalDays);
            var Yemp = emp.Where(e => (DateTime.Today - e.DOB).TotalDays == Yongestemp);
            foreach (var v in Yemp)
            {
                Console.WriteLine($"Total number of employee who is youngest in the list is :-> {v.FirstName}{v.LastName} and count is " + Yemp.Count());
            }
            Console.WriteLine("=============================================================================");
            Console.ReadLine();
            }
        }
    }


