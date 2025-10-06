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
        public string Code { get; set; }
        public string PhoneCode { get; set; }

        // Private constructor to enforce the use of the Find method
        private clsCountries(int countryID, string countryName, string Code, string PhoneCode)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
            this.Code = Code;
            this.PhoneCode = PhoneCode;

            Mode = enMode.Update;
        }

        // Default constructor
        public clsCountries()
        {
            this.CountryName = "";
            this.Code = "";
            this.PhoneCode = "";

            Mode = enMode.AddNew;
        }

        // Find a country by ID
        public static clsCountries Find(int CountryID)
        {
            string countryName = "";
            string Code = "";
            string PhoneCode = "";

            if (clsCountriesDataAccess.FindCountry(CountryID,ref countryName, ref Code, ref PhoneCode))   
                return new clsCountries(CountryID, countryName,Code,PhoneCode);
            else
                return null;
        }

        // Find a country by Name
        public static clsCountries Find(string CountryName,int countryID, string Code, string PhoneCode)
        {
            if(clsCountriesDataAccess.FindCountry(CountryName,ref countryID, ref Code, ref PhoneCode))   
                return new clsCountries(countryID, CountryName, Code, PhoneCode);
            else
                return null;
        }

        // Private method to add a new country
        private bool _AddNewCountry()
        {
            // Call the data access layer to add a new country
            this.CountryID = clsCountriesDataAccess.AddNewCountry(this.CountryName,this.Code,this.PhoneCode);
            return this.CountryID != -1; // Return true if CountryID is assigned
        }

        // Private method to update an existing country
        private bool _UpdateCountry()
        {   
            // Call the data access layer to update the country
            return clsCountriesDataAccess.UpdateCountry(this.CountryID, this.CountryName,this.Code,this.PhoneCode);
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

        // Is country exists by name
        public static bool IsCountryExists(string CountryName)
        {
            int countryID = -1;
            string TypeCode = "";
            string PhoneCode = "";

            return clsCountriesDataAccess.FindCountry(CountryName, ref countryID, ref TypeCode, ref PhoneCode);
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
