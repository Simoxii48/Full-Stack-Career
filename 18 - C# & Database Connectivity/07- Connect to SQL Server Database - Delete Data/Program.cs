using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Delete_Data
{
    internal class Program
    {
        static string connectionString = "server=.;database=ContactsDB;user id=sa;password=sa123456;";

        static void DeleteData(int ContactID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "DELETE FROM Contacts WHERE ContactID=@ContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);
            
            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if(rowsAffected > 0)
                    Console.WriteLine("Record deleted successfully.");
                else
                    Console.WriteLine("No record found with the given ContactID.");

                connection.Close();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            DeleteData(7);

            Console.ReadKey();
        }
    }
}
