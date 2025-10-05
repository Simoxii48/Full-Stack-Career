using System;
using System.Data;
using CountriesDataAccessLayer;

namespace CountriesBusinessLayer
{
    public class clsCountries
    {
        public enum enMode { AddNew, Update };

        private enMode Mode; // To track whether we are adding a new country or updating an existing one

        // Properties
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        // Private constructor to enforce the use of the Find method
        private clsCountries(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;

            Mode = enMode.Update;
        }

        // Default constructor
        public clsCountries()
        {
            CountryName = "";
            Mode = enMode.AddNew;
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

        // Private method to add a new country
        private bool _AddNewCountry()
        {
            // Call the data access layer to add a new country
            this.CountryID = clsCountriesDataAccess.AddNewCountry(this.CountryName);
            return this.CountryID != -1; // Return true if CountryID is assigned
        }

        // Private method to update an existing country
        private bool _UpdateCountry()
        {   
            // Call the data access layer to update the country
            return clsCountriesDataAccess.UpdateCountry(this.CountryID, this.CountryName);
        }

        // Public method to delete a country by ID
        public static bool DeleteCountry(int CountryID)
        {
            return clsCountriesDataAccess.DeleteCountry(CountryID);
        }

        // Get all countries
        public static DataTable GetAllCountries()
        {
            return clsCountriesDataAccess.GetAllCountries();
        }

        // Is country exists
        public static bool IsCountryExists(int CountryID)
        {
            return clsCountriesDataAccess.IsCountryExists(CountryID);
        }

        // Save method
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewCountry())
                    {
                        Mode = enMode.Update; // Switch to update mode after adding
                        return true;
                    }
                    else
                        return false;
                
                case enMode.Update:
                    return _UpdateCountry();
                
                default:
                    return false;
            }
        }
    }
}
