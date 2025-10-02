using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _01__Insert_Add_Data
{
    internal class Program
    {
        static string connectionString = "server=.;database=ContactsDB;user id=sa;password=sa123456;";

        struct stContact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryID { get; set; }
        }

        static void AddNewContact(stContact contact)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address, CountryID) " +
                "VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @CountryID)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", contact.FirstName);
            command.Parameters.AddWithValue("@LastName", contact.LastName);
            command.Parameters.AddWithValue("@Email", contact.Email);
            command.Parameters.AddWithValue("@Phone", contact.Phone);
            command.Parameters.AddWithValue("@Address", contact.Address);
            command.Parameters.AddWithValue("@CountryID", contact.CountryID);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if(rowsAffected > 0)
                    Console.WriteLine("Contact added successfully.");
                else
                    Console.WriteLine("Failed to add contact.");

                connection.Close();
            } catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        static void Main(string[] args)
        {
            stContact contact = new stContact()
            {
                FirstName = "Mohammed",
                LastName = "Abu-Hadhoud",
                Email = "mohammed_abuhadhoud@gmail.com",
                Phone = "00972599999999",
                Address = "Ramallah",
                CountryID = 1
            };

            AddNewContact(contact);
            Console.ReadKey();
        }
    }
}
