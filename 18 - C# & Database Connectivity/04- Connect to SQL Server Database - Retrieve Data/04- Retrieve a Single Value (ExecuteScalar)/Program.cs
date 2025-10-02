using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _04__Retrieve_a_Single_Value__ExecuteScalar_
{
    internal class Program
    {
        static string connectionString = "server=.;database=ContactsDB;user id=sa;password=sa123456;";

        static string GetFirstName(int ContactID)
        {
            string firstname = "";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT FirstName FROM Contacts WHERE ContactID = @ContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar(); // Returns the first column of the first row in the result set

                if (result != null)
                {
                    firstname = result.ToString();
                } else           
                {
                    firstname = "No Data Found";
                }

                connection.Close();
            } catch (Exception ex)
            {
                Console.WriteLine("Error Occured : " + ex.Message);
            }

            return firstname;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetFirstName(1));
            Console.ReadKey();
        }
    }
}
