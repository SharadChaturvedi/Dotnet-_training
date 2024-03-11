using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_march
{

    public class Flnamee { 

        public static void Display(string firstName, string lastName)
        {
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(lastName.ToUpper());
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter the first name :");
            string Firstname = Console.ReadLine();

            Console.WriteLine(" Enter the last name :");
            string LastName = Console.ReadLine();

            Display(Firstname, LastName);
            Console.ReadLine();
        }
    } 
}