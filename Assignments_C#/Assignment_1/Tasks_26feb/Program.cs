using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;
/*1. Write a C# Sharp program to accept two integers and check whether they are equal or not. 

Test Data :
Input 1st number: 5
Input 2nd number: 5
Expected Output :
5 and 5 are equal */



namespace Tasks_26feb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Give the value of FIRST integer");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(" Give the value of Second integer");
            int num2 = Convert.ToInt32(Console.ReadLine());


            if (num1 == num2)
            {
                Console.WriteLine(" the integers are equal");
            }
            else
            {
                Console.WriteLine("the integers are Notequal");
            }


            /*
             * 2. Write a C# Sharp program to check whether a given number is positive or negative. 

               Test Data : 14
               Expected Output :
               14 is a positive number */

            Console.WriteLine("Give the number");
            int a = Convert.ToInt32(Console.ReadLine());

            //using if else for finding the nature of the number 

            if (a >= 0)
            {
                Console.WriteLine(" The number is Positive ");

            }
            else if (a <= 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine(" the number is invalid");
            }

            //           /* 3.Write a C# Sharp program that takes two numbers as input and performs all operations (+,-,*,/) on them and displays the result of that operation. 

            //            Test Data
            //            Input first number: 20
            //            Input operation: -
            //            Input second number: 12
            //            Expected Output :
            //            20 - 12 = 8 */

            Console.WriteLine(" Give the value of First number");
            int first_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Give the value of Second number");
            int Sec_num = Convert.ToInt32(Console.ReadLine());

            int sub = first_num - Sec_num;

            Console.WriteLine(" the value is " + sub);


            //           /*4. Write a C# Sharp program that prints the multiplication table of a number as input.

            //            Test Data:
            //            Enter the number: 5
            //            Expected Output:
            //            5 * 0 = 0
            //            5 * 1 = 5
            //            5 * 2 = 10
            //            5 * 3 = 15
            //....
            // 5 * 10 = 50*/
            Console.WriteLine("Enter the number ");
            int numX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" the multiplication table of the {numX} is");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($" {numX} * {i} = {numX * i} ");


            }




            //5.Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.

            Console.WriteLine("Enter the First Integer");
            int P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter the Second Integer");
            int Q = Convert.ToInt32(Console.ReadLine());

            if (P == Q)
            {
                Console.WriteLine(" The Integer are same " + " so,");
                int r = P + Q;
                Console.WriteLine(" The sum will get doubled and the value is  " + r * 2);
            }


            else
            {
                int w = P + Q;
                Console.WriteLine(" the integers are not same " + " so " + w);

            }
            /* 6.Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.
 Test Data :
 2
 Expected Output :
 Tuesday


 Arrays

 Write a  Program to assign integer values to an array  and then print the following
 a.Average value of Array elements
 b.Minimum and Maximum value in an array


 2.Write a program in C# to accept ten marks and display the 
         following
 a.Total
 b.Average
 c.Minimum marks
 d.Maximum marks
 e.Display marks in ascending order
 f.Display marks in descending order

 3.Write a C# Sharp program to copy the elements of one array into another array.(do not use any inbuilt functions)

 Strings Assignment :

 1.Write a program in C# to accept a word from the user and display the length of it.
 2.Write a program in C# to accept a word from the user and display the reverse of it. 
 3.Write a program in C# to accept two words from user and find out if they are same. 
            */


            //6-- First ,

            Console.WriteLine(" Enter a day Number");
            int day_number = Convert.ToInt32(Console.ReadLine());

            string day_name = " ";

            switch (day_number)
            {
                case 1:
                    day_name = "Monday";
                    break;
                case 2:
                    day_name = " Tuesday";
                    break;
                case 3:
                    day_name = " Wednesday";
                    break;
                case 4:
                    day_name = " Thurday";
                    break;
                case 5:
                    day_name = " Friday";
                    break;
                case 6:
                    day_name = " Saturday";
                    break;
                case 7:
                    day_name = " Sunday";
                    break;
                default:
                    Console.WriteLine(" INVALID day number.");


                    return;
            }
            Console.WriteLine($" The day which belongs to {day_number} is {day_name}.");



            // 6 --- Second -- Arrays 
            //Write a  Program to assign integer values to an array  and then print the following
            //a.Average value of Array elements
            //b.Minimum and Maximum value in an array


            int[] numbers = { 2, 4, 3, 5, 2, 5, 5, 6, 3, 4, 2, 3, 4, 3, 4, };




            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            double average = sum / numbers.Length; // logic for average

            Console.WriteLine($"Average value of array elements: {average}");


            int min = numbers[0];
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine($"Minimum value in array: {min}");
            Console.WriteLine($"Maximum value in array: {max}");

            /*2.Write a program in C# to accept ten marks and display the 
         following
 a.Total
 b.Average
 c.Minimum marks
 d.Maximum marks
 e.Display marks in ascending order
 f.Display marks in descending order */


           // first i have initalized an array to store 10 marks

            int[] marks = new int[10];

            // now we need to get the user input ,

            Console.WriteLine(" enter the marks ");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($" mark {i + 1}:");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            // now to calculate the total and average ; 

            int total = 0;
            foreach (int mark in marks)
            {

                total += mark;
            }
            double average2 = (double)total / marks.Length;

            // now we have to find the max and min marks 

            int min1 = marks[0];
            int max1 = marks[0];
            foreach (int mark in marks)
            {
                if (mark < min1)
                {
                    min1 = mark;

                }
                if (mark > max1)
                {
                    max1 = mark;
                }
            }
            Console.WriteLine($" Total = {total}");
            Console.WriteLine($" Average= {average2}");
            Console.WriteLine($" Minimum Marks = {min1} ");
            Console.WriteLine($" Maximum Marks = {max1}");

            //the above will show the total average max and min 


            // now to find them in ascending order and descending order ;

            Array.Sort(marks);
            Console.WriteLine("Marks in Ascending order are ");
            foreach (int mark in marks)
            {
                Console.Write($"{mark}");
            }
            Console.WriteLine();


            //// ---------------------------------------


            Array.Reverse(marks);
            Console.WriteLine("Marks in descending order:");
            foreach (int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();


            /*Strings Assignment :

 1.Write a program in C# to accept a word from the user and display the length of it.
 2.Write a program in C# to accept a word from the user and display the reverse of it. 
 3.Write a program in C# to accept two words from user and find out if they are same.  */


            Console.WriteLine(" Entere  teh Word ");
            string word = Console.ReadLine();
            //length of the word 
            int lenth = word.Length;
            Console.WriteLine($" length of the word is {lenth}");
             //reverse the word 
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reverseword = new string(charArray);
            Console.WriteLine($" Reverse of the word is {reverseword}");
            //to check if the words are same 

            Console.WriteLine(" enter the fisrt word");
            string word1 = Console.ReadLine();
            Console.WriteLine(" enter the second word ");
            string word2 = Console.ReadLine();
             
            if ( word1 == word2)
            {
                Console.WriteLine(" The words are same ");

            }else
            {
                Console.WriteLine(" the are not same ");
            }

                Console.ReadLine();
        }
    }
}
