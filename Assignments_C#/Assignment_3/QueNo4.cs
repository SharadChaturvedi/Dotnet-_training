using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_march
{
    internal class QueNo4
    {

        class Scholarship
        {
            public double Merit(double marks, double fees)
            {
                double scholarshipAmount = 0;

                if (marks >= 70 && marks <= 80)
                {
                    scholarshipAmount = 0.2 * fees;
                }
                else if (marks > 80 && marks <= 90)
                {
                    scholarshipAmount = 0.3 * fees;
                }
                else if (marks > 90)
                {
                    scholarshipAmount = 0.5 * fees;
                }

                return scholarshipAmount;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Scholarship scholarship = new Scholarship();

                Console.WriteLine(" Enter the marks of the Student :");
                double marks = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" Enter the Amount of the Fees : ");
                double fees = Convert.ToDouble(Console.ReadLine());

                double scholarshipAmount = scholarship.Merit(marks, fees);
                Console.WriteLine(" The Scholarship amount is : " + scholarshipAmount);
                Console.ReadLine();
            }
        }
    }
}
