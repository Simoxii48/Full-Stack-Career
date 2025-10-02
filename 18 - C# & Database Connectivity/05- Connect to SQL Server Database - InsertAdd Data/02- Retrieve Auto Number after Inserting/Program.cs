using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace _02__Retrieve_Auto_Number_after_Inserting
{
    internal class Program
    {
        static string connectionString = "server=.;database=ContactsDB;user id=sa;password=sa123456;";

        public struct stContact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryId { get; set; }
        }

        static void AddNewContactAndGetID(stContact Contact)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string Query = "INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address, CountryId) " +
                "VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @CountryId); " +
                "SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
            command.Parameters.AddWithValue("@LastName", Contact.LastName);
            command.Parameters.AddWithValue("@Email", Contact.Email);
            command.Parameters.AddWithValue("@Phone", Contact.Phone);
            command.Parameters.AddWithValue("@Address", Contact.Address);
            command.Parameters.AddWithValue("@CountryId", Contact.CountryId);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int newContactID))
                {
                    Console.WriteLine("New inserted ContactID: " + newContactID);
                }
                else
                {
                    Console.WriteLine("Failed to retrieve the new Contact ID.");
                }

            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
        }
        static void Main(string[] args)
        {
            stContact Contact = new stContact
            {
                FirstName = "Layla",
                LastName = "Smith",
                Email = "Layla@smith.com",
                Phone = "1234567890",
                Address = "123 Main St, City, Country",
                CountryId = 1
            };

            AddNewContactAndGetID(Contact);
            Console.ReadKey();
        }
    }
}
