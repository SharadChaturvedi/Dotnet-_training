using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Code_28feb
{
    internal class second_question
    {
        public second_question()
        {
            void swap()
            {
                Console.WriteLine("Enter any Word:- ");
                string str = Convert.ToString(Console.ReadLine());
                int last = str.Length;
                string newStr = string.Empty;
                newStr += str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
                Console.WriteLine(newStr);
                Console.ReadLine();
            }


        }
    }



}



        




