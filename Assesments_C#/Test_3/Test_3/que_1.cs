using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
       
 namespace ConsoleApp1
    {
        class AppendText_que1
        {
            static string filePath = "Letsgetstarted.txt";

            public static void WriteData()
            {
                FileStream filestream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter stream = new StreamWriter(filestream);

                Console.WriteLine("Enter a String:");
                string str = Console.ReadLine();
                stream.Write(str);

                stream.Close();
                filestream.Close();
            }
        }

        class Program
        {
            public static void Main()
            {
                AppendText_que1.WriteData();
                Console.ReadLine();
            }
        }
    }