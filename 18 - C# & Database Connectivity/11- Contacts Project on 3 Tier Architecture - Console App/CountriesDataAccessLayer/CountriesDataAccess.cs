using System;
using System.Data;
using System.Data.SqlClient;

namespace CountriesDataAccessLayer
{
    public class clsCountriesDataAccess
    {
        public static bool FindCountryByID(int CountryId, ref string countryName)
        {
            bool isCountryFound = false;
            SqlConnection connection = new SqlConnection(clsCountriesDataAccessSettings.connectionString);
            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Assuming CountryName is the second column in the Countries table
                    countryName = reader["CountryName"].ToString();
                    isCountryFound = true;
                }
                else
                {
                    isCountryFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error finding country by ID: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isCountryFound;
        }

        public static int AddNewCountry(string countryName)
        {
            SqlConnection connection = new SqlConnection(clsCountriesDataAccessSettings.connectionString);
            string query = "insert into Countries (CountryName) values (@CountryName);" +
                "Select Scope_Identity();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", countryName);
            int newCountryID = -1;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                
                if(result != null && int.TryParse(result.ToString(), out int CountryID))
                {
                    // Successfully retrieved the new CountryID
                    newCountryID = CountryID;
                }
                else
                {
                    throw new Exception("Failed to retrieve the new CountryID.");
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error adding new country: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return newCountryID;
        }

        public static bool UpdateCountry(int CountryID, string countryName)
        {
            SqlConnection connection = new SqlConnection(clsCountriesDataAccessSettings.connectionString);
            string query = "update Countries set CountryName = @countryName where CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("countryName", countryName);
            bool isUpdated = false;

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isUpdated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating country: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            
            return isUpdated;
        }
    }
}
