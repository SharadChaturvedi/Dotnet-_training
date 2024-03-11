using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Code_28feb
{
    internal class ThirdQuestion
    {
        public int thirdquestion()
        {
            int[] arr = new int[3];
            Console.WriteLine("Enter three number: ");
            for (int i = 0; i < 3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            return arr[arr.Length - 1];
        }
    }
}
