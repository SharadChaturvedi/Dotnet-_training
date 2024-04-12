using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.net_codebasetest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string ConnectionString = "Data source=ICS-LT-8BLV8C3\\SQLEXPRESS;Initial catalog=Employeemanagement;Integrated Security=True";

            Console.WriteLine("Enter employee name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter employee salary:");
            decimal empsal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter employee type ");
            string emptype = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("Add_row", connection);
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@EmpName", empName);
                command.Parameters.AddWithValue("@Empsal", empsal);
                command.Parameters.AddWithValue("@Emp_type", emptype);


                
                command.ExecuteNonQuery();



                connection.Close();
            }

            Console.WriteLine("Employee details inserted successfully.");



           }
       
        }
    }
    

