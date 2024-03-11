using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_4__March

    /*1. Create an Abstract class called  Student with  Name, StudentId, Grade as members and also an abstract method boolean Ispassed(grade) which takes grade as an input and checks whether student passed the course or not.  
 
Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed(grade) method
 
For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false.*/
{
            public abstract class Student // ----------------Abst class created -------------------
        {     //abs class containing name stid frade ,
        public string Name;
        public int StudentId;
        public double Grade;

            public Student(string name, int studentId, double grade)
            {
                Name = name;
                StudentId = studentId; // ----------------constructors to initialize student details------------- 
                Grade = grade;
            }
              // ---------------abst mthd to check using bool -------------------
            public abstract bool IsPassed(double grade); 
        }

        public class Undergraduate : Student //---------- creating sub class ----------( undergraduate)--------------
        {
            public Undergraduate(string name, int studentId, double grade) : base(name, studentId, grade)
            {
            string s = name;

            }

            public override bool IsPassed(double grade)
            {
             
                    return grade > 70;
                   
            
            }
        }

            public class Graduate : Student //---- creating sub class rep graduate ------------
             {
            public Graduate(string name, int studentId, double grade) : base(name, studentId, grade)
            {
            }

            public override bool IsPassed(double grade)
            {
                return grade > 80; // overriding to determine if grad stu passed 
            }
        }

        class StudentTesting
        {

            static void Main(string[] args)  // for user input 
            {

                Console.WriteLine("Give the Details of UG Student :");
             
                Console.Write("Name: ");
                string undergradName = Console.ReadLine();
            
                Console.Write("Student ID: ");
                int undergradId = Convert.ToInt32(Console.ReadLine());
               
                Console.Write("Grade: ");
                double undergradGrade = Convert.ToDouble(Console.ReadLine());

                Undergraduate undergrad = new Undergraduate(undergradName, undergradId, undergradGrade);

                Console.WriteLine("Enter graduate student details:");
              
                 Console.Write("Name: ");
                string gradName = Console.ReadLine();
              
                Console.Write("Student ID: ");
                int gradId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Grade: ");
                double gradGrade = Convert.ToDouble(Console.ReadLine());

                Graduate grad = new Graduate(gradName, gradId, gradGrade);

               Console.WriteLine($"{undergrad.Name} passed: {undergrad.IsPassed(undergrad.Grade)}");
               Console.WriteLine($"{grad.Name} passed: {grad.IsPassed(grad.Grade)}");
               Console.ReadLine(); 
           
        
             }
      
        }
        
  }
 //output

/*
 * Give the Details of UG Student :
Name: sharad
Student ID: 6969
Grade: 100
Enter graduate student details:
Name: Suryansh
Student ID: 786
Grade: 0
sharad  passed: True
Suryansh  passed: False */


