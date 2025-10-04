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
    }
}
