using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
/*Create an Interface IStudent with StudentId and Name as Properties, ShowDetails() as its method. 
 * Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods.*/

namespace ConsoleApp1
{
    class Interface
    {
        public interface IStudent
    {
        string StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    public class StudentDetails : IStudent
    {
        public string StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($" Student ID:----> {StudentId}");
            Console.WriteLine($"Name:----> {Name}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter details for the first student:");
            IStudent student1 = new StudentDetails();
            Console.Write("Enter Student ID: ");
            student1.StudentId = Console.ReadLine();
            Console.Write("Enter Name: ");
            student1.Name = Console.ReadLine();

                Console.WriteLine("\nEnter details for the second student:");
                IStudent student2 = new StudentDetails();
                Console.Write("Enter Student ID: ");
                student2.StudentId = Console.ReadLine();
                Console.Write("Enter Name: ");
                student2.Name = Console.ReadLine();

             Console.WriteLine("\nDetails of the first student:");
             student1.ShowDetails();

                Console.WriteLine("\nDetails of the second student:");
                student2.ShowDetails();
                Console.ReadLine();
        }
    }
    
    }
}
