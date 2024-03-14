using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestClinet
/*Write a query that returns list of numbers and their suares only if the square is greater than 20

Example input {7,2,30}
Expected Output : 49,900*/

{
    public class LambdaQuery
    {
        public void Sqaure()
        {
            // List<int> a = new List<int> { 5, 7, 30,1,3 };
            List<int> a = new List<int>();
            Console.WriteLine("Enter the size of list: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the {size} numbers: ");
            for (int i = 0; i < size; i++)
            {
                //int value=int.Parse(Console.ReadLine());
                a.Add(int.Parse(Console.ReadLine()));
            }

            var sqaure = a.FindAll(x => (x * x) > 20);
            Console.WriteLine("The list of number whose square is greater then 20:-> ");
            foreach (int i in sqaure)
            {
                Console.WriteLine(i * i);
            }
        }

        public void Places_AM()
        {
            List<string> places = new List<string>();
            Console.WriteLine("Enter the size of list: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the {size} places: ");
            for (int i = 0; i < size; i++)
            {
                //int value=int.Parse(Console.ReadLine());
                places.Add(Console.ReadLine());
            }
            Console.WriteLine("The list of places which start from A and ends with m:->>>> ");
            var res = places.Where(p => p.StartsWith("A") && p.EndsWith("m"));
            foreach (var i in res)
            {
                Console.WriteLine(i);
            }

        }
    }
}