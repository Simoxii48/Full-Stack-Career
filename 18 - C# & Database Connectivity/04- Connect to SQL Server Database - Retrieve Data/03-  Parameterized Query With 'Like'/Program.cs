using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _03___Parameterized_Query_With__Like_
{
    internal class Program
    {
        static string connectionString = "server=.;database=ContactsDB;user id=sa;password=sa123456;";

        static void SearchContactsStartsWith(string startingLetter)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from Contacts where Firstname like '' + @startingLetter + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@startingLetter", startingLetter);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string Firstname = (string)reader["Firstname"];
                    string Lastname = (string)reader["Lastname"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    int CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"ContactID : {ContactID}");
                    Console.WriteLine($"Firstname : {Firstname}");
                    Console.WriteLine($"Lastname : {Lastname}");
                    Console.WriteLine($"Email : {Email}");
                    Console.WriteLine($"Phone : {Phone}");
                    Console.WriteLine($"Address : {Address}");
                    Console.WriteLine($"CountryID : {CountryID}");
                    Console.WriteLine("-------------------------------");
                }
                
                reader.Close();
                connection.Close();

            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SearchContactsEndsWith(string endingLetter)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from Contacts where Firstname like '%' + @endingLetter + ''";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@endingLetter", endingLetter);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string Firstname = (string)reader["Firstname"];
                    string Lastname = (string)reader["Lastname"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    int CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"ContactID : {ContactID}");
                    Console.WriteLine($"Firstname : {Firstname}");
                    Console.WriteLine($"Lastname : {Lastname}");
                    Console.WriteLine($"Email : {Email}");
                    Console.WriteLine($"Phone : {Phone}");
                    Console.WriteLine($"Address : {Address}");
                    Console.WriteLine($"CountryID : {CountryID}");
                    Console.WriteLine("-------------------------------");
                }

                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SearchContactsContains(string contains)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from Contacts where Firstname like '%' + @contains + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@contains", contains);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string Firstname = (string)reader["Firstname"];
                    string Lastname = (string)reader["Lastname"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    int CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"ContactID : {ContactID}");
                    Console.WriteLine($"Firstname : {Firstname}");
                    Console.WriteLine($"Lastname : {Lastname}");
                    Console.WriteLine($"Email : {Email}");
                    Console.WriteLine($"Phone : {Phone}");
                    Console.WriteLine($"Address : {Address}");
                    Console.WriteLine($"CountryID : {CountryID}");
                    Console.WriteLine("-------------------------------");
                }

                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("------------Contacts starts With 'j'");
            SearchContactsStartsWith("j");

            Console.WriteLine("------------Contacts ends With 'ne'");
            SearchContactsEndsWith("ne");

            Console.WriteLine("------------Contacts contains 'ae'");
            SearchContactsContains("ae");

            Console.ReadKey();
        }
    }
}
