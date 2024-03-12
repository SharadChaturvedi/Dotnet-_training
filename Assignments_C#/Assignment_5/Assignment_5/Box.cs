using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a class Box that has Length and breadth as its members.
 * Write a function that adds 2 box objects and stores in the 3rd.
 * Create a Test class to execute the above.*/

namespace ConsoleApp1
{
    internal class Box
    {
        public double Length {  get; set; }
        public double Breadth { get; set; }
        public Box(double l , double b) { 
        Length = l;
        Breadth = b;
        
        }
        public static  Box Addbox(Box box1 , Box box2)
        {
            double  SumOflength = box1.Length + box2.Length;
            double SumOfBreadth = box1.Breadth + box2.Breadth;  

            return new  Box(SumOflength, SumOfBreadth);

        }
             public void Display ()
        {
            Console.WriteLine(" Length : " + Length);
            Console.WriteLine(" Breadth :" + Breadth);


        }

        class Test
        {
           public   static  void  Main()
            {
                Console.WriteLine(" Enter the length of the First Box ");
                double length1 = double.Parse(Console.ReadLine());

                Console.WriteLine(" Enter the breadth of the First Box");
                double breadth1 = double.Parse(Console.ReadLine());

                Box b1 = new Box(length1, breadth1);// object for box 1 


                Console.WriteLine( " Enter the length Of the Second Box");
                double length2 = double.Parse(Console.ReadLine());

                Console.WriteLine(" Enter the breadth of the Second Box");
                double breadth2 = double.Parse(Console.ReadLine());

               Box b2 = new Box(length2, breadth2);//object of box 2


                Box box3 = Box.Addbox(b1,b2);
                Console.Write(" The value Of Box 3 after adding box1 and box2 is : ");
                box3.Display();
                Console.ReadLine();



            }

        }
    }



}
