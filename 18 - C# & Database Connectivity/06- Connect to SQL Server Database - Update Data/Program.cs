using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UpdateData
{
    internal class Program
    {
        static string connectionString = "server=.;database=ContactsDB;user id=sa;password=sa123456;";

        public struct stContactInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryID { get; set; }
        }

        static void UpdateContact(int ContactID,stContactInfo ContactInfo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "UPDATE Contacts " +
                "SET FirstName=@FirstName," +
                "LastName=@LastName," +
                "Email=@Email," +
                "Phone=@Phone," +
                "Address=@Address," +
                "CountryID=@CountryID " +
                "WHERE ContactID=@ContactID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);
            command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
            command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
            command.Parameters.AddWithValue("@Email", ContactInfo.Email);
            command.Parameters.AddWithValue("@Phone", ContactInfo.Phone);
            command.Parameters.AddWithValue("@Address", ContactInfo.Address);
            command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if(rowsAffected > 0)
                    Console.WriteLine("Contact Updated Successfully.");
                else
                    Console.WriteLine("No Contact Found with the given ID.");
            connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Occured : " + ex.Message);
            }
        }
        static void Main(string[] args)
        {
            stContactInfo ContactInfo = new stContactInfo
            {
                FirstName = "Mohammed",
                LastName = "Ali",
                Email = "Moha_Ali@gmail.com",
                Phone = "01111111111",
                Address = "Cairo, Egypt",
                CountryID = 1
            };

            UpdateContact(7, ContactInfo);

            Console.ReadKey();
        }
    }
}
