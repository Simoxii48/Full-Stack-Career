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

                    // ImagePath can be null in the database, so we need to check for DBNull
                    if (reader["ImagePath"] == DBNull.Value)
                        ImagePath = "";
                    else
                        ImagePath = reader["ImagePath"].ToString();

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
    
        public static int AddNewContact(string Firstname, string Lastname, string ContactEmail, string ContactPhone,
            string ContactAddress, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            int newContactID = -1; // Default value indicating failure
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.connectionString);
            string query = "Insert into Contacts (Firstname, Lastname, Email, Phone, Address, DateOfBirth, CountryID, ImagePath) " +
                           "Values (@Firstname, @Lastname, @Email, @Phone, @Address, @DateOfBirth, @CountryID, @ImagePath); " +
                           "SELECT SCOPE_IDENTITY();"; // Retrieve the newly generated ContactID
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Firstname", Firstname);
            command.Parameters.AddWithValue("@Lastname", Lastname);
            command.Parameters.AddWithValue("@Email", ContactEmail);
            command.Parameters.AddWithValue("@Phone", ContactPhone);
            command.Parameters.AddWithValue("@Address", ContactAddress);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            
            // Handle potential null for ImagePath
            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            
            try // will execute only if no exception occurs
            {
                connection.Open();
                object result = command.ExecuteScalar(); // Execute the insert and get the new ContactID
                if (result != null && int.TryParse(result.ToString(), out int ContactID))
                {
                    newContactID = ContactID; // Successfully retrieved new ContactID
                }
            }
            catch (Exception ex) // will execute only if an exception occurs
            {
                throw new Exception("Error in AddNewContact: " + ex.Message);
            }
            finally // will execute always
            {
                connection.Close(); // best practice to close the connection in the finally block if error occurs or not ensures connection is closed
            }
            
            return newContactID;
        }
    
        public static bool UpdateContact(int ContactID, string Firstname, string Lastname, string ContactEmail, string ContactPhone,
            string ContactAddress, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.connectionString);
            string query = "Update Contacts " +
                            "set Firstname=@Firstname, " +
                            "Lastname=@Lastname, " +
                            "Email=@Email, " +
                            "Phone=@Phone, " +
                            "Address=@Address, " +
                            "DateOfBirth=@DateOfBirth, " +
                            "CountryID=@CountryID, " +
                            "ImagePath=@ImagePath " +
                "where ContactID=@ContactID";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);
            command.Parameters.AddWithValue("@Firstname", Firstname);
            command.Parameters.AddWithValue("@Lastname", Lastname);
            command.Parameters.AddWithValue("@Email", ContactEmail);
            command.Parameters.AddWithValue("@Phone", ContactPhone);
            command.Parameters.AddWithValue("@Address", ContactAddress);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            
            // Handle potential null for ImagePath
            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            
            try // will execute only if no exception occurs
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isUpdated = rowsAffected > 0; // If at least one row was affected, the update was successful
            }
            catch (Exception ex) // will execute only if an exception occurs
            {
                throw new Exception("Error in UpdateContact: " + ex.Message);
            }
            finally // will execute always
            {
                connection.Close(); // best practice to close the connection in the finally block if error occurs or not ensures connection is closed
            }
            
            return isUpdated;
        }
    
        public static bool DeleteContact(int ContactID)
        {
            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.connectionString);
            string query = "Delete from Contacts where ContactID=@ContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);
            
            try // will execute only if no exception occurs
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isDeleted = rowsAffected > 0; // If at least one row was affected, the deletion was successful
            }
            catch (Exception ex) // will execute only if an exception occurs
            {
                throw new Exception("Error in DeleteContact: " + ex.Message);
            }
            finally // will execute always
            {
                connection.Close(); // best practice to close the connection in the finally block if error occurs or not ensures connection is closed
            }
            
            return isDeleted;
        }

        public static DataTable GetAllContacts()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.connectionString);
            string query = "Select * from Contacts"; // Select only necessary fields
            SqlCommand command = new SqlCommand(query, connection);

            try // will execute only if no exception occurs
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); // Execute the command and get a data reader

                if(reader.HasRows) // If there are rows to read
                {
                    dt.Load(reader); // Load the data from reader into DataTable
                }

                reader.Close();
            }
            catch (Exception ex) // will execute only if an exception occurs
            {
                throw new Exception("Error in GetAllContacts: " + ex.Message);
            }
            finally // will execute always
            {
                connection.Close(); // best practice to close the connection in the finally block if error occurs or not ensures connection is closed
            }

            return dt;
        }


    }
}
