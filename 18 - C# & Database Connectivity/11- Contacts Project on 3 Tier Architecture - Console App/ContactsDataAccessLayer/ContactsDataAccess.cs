using System;
using System.Data;
using System.Data.SqlClient;

namespace ContactsDataAccessLayer
{
    public class ClsContactsDataAccess
    {
        public static bool GetContactInfoByID(int ContactID, ref string Firstname, ref string Lastname, ref string ContactEmail, ref string ContactPhone,
            ref string ContactAddress, ref DateTime DateOfBirth, ref int CountryID, ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.connectionString);
            string query = "Select * from Contacts where ContactID=@ContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

            try // will execute only if no exception occurs
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read()) // If a record is found
                {
                    Firstname = reader["Firstname"].ToString();
                    Lastname = reader["Lastname"].ToString();
                    ContactEmail = reader["Email"].ToString();
                    ContactPhone = reader["Phone"].ToString();
                    ContactAddress = reader["Address"].ToString();
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CountryID = (int) reader["CountryID"];
                    ImagePath = (string) reader["ImagePath"];
                    
                    isFound = true;
                }
                else
                    isFound = false; // No record found

                reader.Close();
            }
            catch (Exception ex) // will execute only if an exception occurs
            {
                throw new Exception("Error in GetContactInfoByID: " + ex.Message);
            }
            finally // will execute always
            {
                connection.Close(); // best practice to close the connection in the finally block if error occurs or not ensures connection is closed
            }

            return isFound;
        }
    }
}
