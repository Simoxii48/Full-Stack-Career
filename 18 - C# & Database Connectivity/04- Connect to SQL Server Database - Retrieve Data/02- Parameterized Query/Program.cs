using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _02__Parameterized_Query
{
    internal class Program
    {
    
        static string connectionString = "Server=.;Database=ContactsDB;User id=sa;Password=sa123456;";

    
        static void PrintAllContactsWithFirstname(string Firstname)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from Contacts where Firstname = @Firstname";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Firstname", Firstname);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string FirstnameDB = (string)reader["Firstname"];
                    string Lastname = (string)reader["Lastname"];
                    string Phone = (string)reader["Phone"];
                    string Email = (string)reader["Email"];
                    string Address = (string)reader["Address"];
                    int CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"ContactID:  {ContactID}");
                    Console.WriteLine($"Firstname:  {FirstnameDB}");
                    Console.WriteLine($"Lastname:  {Lastname}");
                    Console.WriteLine($"Phone:  {Phone}");
                    Console.WriteLine($"Email:  {Email}");
                    Console.WriteLine($"Address:  {Address}");
                    Console.WriteLine($"CountryID:  {CountryID}");
                    Console.WriteLine("--------------------------------------------------");
                }

                reader.Close();
                connection.Close();
            } catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        static void PrintAllContactsWithFirstnameAndCountry(string Firstname, int CountryID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from Contacts where Firstname = @Firstname and CountryId = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Firstname", Firstname);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string FirstnameDB = (string)reader["Firstname"];
                    string Lastname = (string)reader["Lastname"];
                    string Phone = (string)reader["Phone"];
                    string Email = (string)reader["Email"];
                    string Address = (string)reader["Address"];
                    int CountryIDdB = (int)reader["CountryID"];

                    Console.WriteLine($"ContactID:  {ContactID}");
                    Console.WriteLine($"Firstname:  {FirstnameDB}");
                    Console.WriteLine($"Lastname:  {Lastname}");
                    Console.WriteLine($"Phone:  {Phone}");
                    Console.WriteLine($"Email:  {Email}");
                    Console.WriteLine($"Address:  {Address}");
                    Console.WriteLine($"CountryID:  {CountryIDdB}");
                    Console.WriteLine("--------------------------------------------------");
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
        static void Main(string[] args)
        {
            PrintAllContactsWithFirstname("Jane");
            PrintAllContactsWithFirstnameAndCountry("Jane", 1);
            
            Console.ReadKey();
        }
    }
}
