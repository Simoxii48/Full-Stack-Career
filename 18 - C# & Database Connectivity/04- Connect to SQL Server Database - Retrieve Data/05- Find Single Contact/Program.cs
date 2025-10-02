using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05__Find_Single_Contact
{
    internal class Program
    {
        static string connectionString = "server=.;database=ContactsDB;user id=sa;password=sa123456;";

        public struct stContact
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryId { get; set; }
        }

        static bool FindContactByID(int ContactID, ref stContact ContactInfo)
        {
            bool isFound = false;
            
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Contacts WHERE ContactId = @ContactId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactId", ContactID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read()) // If a record is found
                {
                    ContactInfo.Id = (int)reader["ContactId"];
                    ContactInfo.FirstName = (string)reader["FirstName"]; // Alternative: reader["FirstName"].ToString();
                    ContactInfo.LastName = reader["LastName"].ToString(); // Alternative: (string)reader["LastName"];
                    ContactInfo.Email = reader["Email"].ToString();
                    ContactInfo.Phone = reader["Phone"].ToString();
                    ContactInfo.Address = reader["Address"].ToString();
                    ContactInfo.CountryId = (int)reader["CountryId"];
                    isFound = true;
                }
                else // No record found
                {
                    isFound = false;
                }

                connection.Close();
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return isFound;
        }
        static void Main(string[] args)
        {
            stContact ContactInfo = new stContact();

            if(FindContactByID(1, ref ContactInfo))
            {
                Console.WriteLine("Contact Found:");
                Console.WriteLine($"ID: {ContactInfo.Id}");
                Console.WriteLine($"Name: {ContactInfo.FirstName} {ContactInfo.LastName}");
                Console.WriteLine($"Email: {ContactInfo.Email}");
                Console.WriteLine($"Phone: {ContactInfo.Phone}");
                Console.WriteLine($"Address: {ContactInfo.Address}");
                Console.WriteLine($"Country ID: {ContactInfo.CountryId}");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }
}
