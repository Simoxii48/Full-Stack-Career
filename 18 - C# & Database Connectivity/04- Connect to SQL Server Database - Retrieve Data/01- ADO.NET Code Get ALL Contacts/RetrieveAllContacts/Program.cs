using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RetrieveAllContacts
{
    internal class Program
    {
        static string connectionString = "server=.;database=ContactsDB;User Id=sa;Password=sa123456;";

        static void PrintAllContacts()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Contacts";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int ContactId = (int)reader["ContactID"];
                    string Firstname = (string)reader["FirstName"];
                    string Lastname = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    int CountryId = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID : {ContactId}");
                    Console.WriteLine($"First Name : {Firstname}");
                    Console.WriteLine($"Last Name : {Lastname}");
                    Console.WriteLine($"Email : {Email}");
                    Console.WriteLine($"Phone : {Phone}");
                    Console.WriteLine($"Address : {Address}");
                    Console.WriteLine($"Country ID : {CountryId}");
                    Console.WriteLine("-------------------------------");
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        static void Main(string[] args)
        {
            PrintAllContacts();
            Console.ReadKey();
        }
    }
}
