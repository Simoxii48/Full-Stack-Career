using System;
using System.Data;
using CountriesDataAccessLayer;

namespace CountriesBusinessLayer
{
    public class clsCountries
    {
        // Properties
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        private clsCountries(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }
        // Find a country by ID
        public static clsCountries Find(int CountryID)
        {
            string countryName = "";
            if(clsCountriesDataAccess.FindCountryByID(CountryID,ref countryName))   
                return new clsCountries(CountryID, countryName);
            else
                return null;
        }
    }
}
