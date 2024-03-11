using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_march
{
    internal class QueNo5
    {
        class Doctor { 

                private int regnNo;
                private string name;
                private double feesCharged;

                public Doctor(int regnNo, string name, double feesCharged)
                {
                    this.regnNo = regnNo;
                    this.name = name;
                    this.feesCharged = feesCharged;
                }

                public void SetValues(int regnNo, string name, double feesCharged)
                {
                    this.regnNo = regnNo;
                    this.name = name;
                    this.feesCharged = feesCharged;
                }

                public void Display()
                {
                    Console.WriteLine("Registration Number: " + regnNo);
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Fees Charged: " + feesCharged);
                }
            }

            class Hospital
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Enter Doctor's Information:");

                    Console.Write(" Give Registration Number: ");
                    int regnNo = Convert.ToInt32(Console.ReadLine());

                    Console.Write( " Give the Name: ");
                    string name = Console.ReadLine();

                    Console.Write( " what is the amount of Fees Charged: rs" );
                    double feesCharged = Convert.ToDouble(Console.ReadLine());

                    Doctor doctor = new Doctor(regnNo, name,  feesCharged);

                    Console.WriteLine("\n Doctor's Information is :");
                    doctor.Display();
                    Console.ReadLine();
                }
            }
        }
    }
    
