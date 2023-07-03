using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlInjectionRefactoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=SwabhavDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                Console.WriteLine( "Refactored app..running..");
                connection.Open();
                Console.WriteLine("connected successfully to " + connection.Database);
                string customerId = "";
                Console.WriteLine("Enter cusotmer id ");
                customerId = Console.ReadLine();
                String customerByIdQuery = "SELECT * FROM CUSTOMER WHERE ID= @CustomerId";



                SqlCommand cmd = new SqlCommand(customerByIdQuery, connection);
                cmd.Parameters.AddWithValue("@CustomerId",customerId);
                
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("{0} {1} {2} ", dr["id"], dr["name"], dr["balance"]);
                    }
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

    }
}
