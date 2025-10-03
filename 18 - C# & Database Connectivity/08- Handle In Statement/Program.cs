using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Handle_In_Statement
{
    internal class Program
    {
        static string connectionString = "server=.;database=ContactsDB;user id=sa;password=sa123456;";

        static void DeleteContacts(string ContactIDs)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"DELETE Contacts WHERE ContactID IN ( " + ContactIDs + ")";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                int result = command.ExecuteNonQuery();
                if(result > 0)
                {
                    Console.WriteLine("Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("No record found");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erroe : " + ex.Message);
            }
        }
        static void Main(string[] args)
        {
            DeleteContacts("7,8,9");

            Console.ReadKey();
        }
    }
}
