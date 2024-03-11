using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a Program to count the no. of occurrences of a letter in a given string (for example in a string called “OOPS PROGRAMMING”, O appears 3 times)
Hint : Accept a string and also the letter to be counted*/

namespace Assignment_5_march
{
    internal class QueNo2
    {
     static void Main(string[] args)
        {
            Console.WriteLine(" enter a String ");
            String inputstring = Console.ReadLine();

            Console.WriteLine(" enter the letter to be counted ");
            char letter = Convert.ToChar(Console.ReadLine());

            int count = inputstring.Count(c => c == letter);
            Console.WriteLine($" The letter '{letter}' occurs {count} times in the string");
            Console.ReadLine();

        }
    }
}
