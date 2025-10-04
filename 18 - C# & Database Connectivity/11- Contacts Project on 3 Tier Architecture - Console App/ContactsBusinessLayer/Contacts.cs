using System;
using System.Data;
using ContactsDataAccessLayer;

namespace ContactsBusinessLayer
{
    public class clsContacts
    {
        private enMode Mode; // To track whether we are adding a new contact or updating an existing one
        public enum enMode { Addnew, Update } // Enum to represent the mode

        // Properties
        public int ContactID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }

        // Constructor
        private clsContacts(int contactID, string firstname, string lastname, string contactEmail, string contactPhone,
            string contactAddress, DateTime dateOfBirth, int countryID, string imagePath)
        {
            ContactID = contactID;
            Firstname = firstname;
            Lastname = lastname;
            ContactEmail = contactEmail;
            ContactPhone = contactPhone;
            ContactAddress = contactAddress;
            DateOfBirth = dateOfBirth;
            CountryID = countryID;
            ImagePath = imagePath;

            Mode = enMode.Update;
        }

        private bool _AddNewContact()
        {
            // Call the data access layer to add a new contact
            this.ContactID = ClsContactsDataAccess.AddNewContact(this.Firstname, this.Lastname, this.ContactEmail, this.ContactPhone, this.ContactAddress,
                this.DateOfBirth, this.CountryID, this.ImagePath);
            
            return this.ContactID != -1; // Return true if ContactID is assigned (not -1)
        }

        private bool _UpdateContact()
        {
            // Call the data access layer to update the contact
            return ClsContactsDataAccess.UpdateContact(this.ContactID, this.Firstname, this.Lastname, this.ContactEmail, this.ContactPhone, this.ContactAddress,
                this.DateOfBirth, this.CountryID, this.ImagePath);
        }

        public clsContacts()
        {
            this.ContactID = -1; // New contact, ID will be assigned by the database
            this.Firstname = "";
            this.Lastname = "";
            this.ContactEmail = "";
            this.ContactPhone = "";
            this.ContactAddress = "";
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1; // Default CountryID
            this.ImagePath = "";

            Mode = enMode.Addnew; // Set mode to Addnew
        }

        public static clsContacts Find(int ContactID)
        {
            string Firstname = "", Lastname = "", ContactEmail = "", ContactPhone = "", ContactAddress = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int CountryID = 1;

            if(ClsContactsDataAccess.GetContactInfoByID(ContactID,ref Firstname,ref Lastname,ref ContactEmail, ref ContactPhone,ref ContactAddress,
                ref DateOfBirth, ref CountryID, ref ImagePath))
                return new clsContacts(ContactID, Firstname, Lastname, ContactEmail, ContactPhone, ContactAddress, DateOfBirth, CountryID, ImagePath);
            else
                return null;
        }

        public static bool DeleteContact(int ContactID)
        {
            return ClsContactsDataAccess.DeleteContact(ContactID);
        }

        public static DataTable GetAllContacts()
        {
            return ClsContactsDataAccess.GetAllContacts();
        }

        public bool Save()
        {
            switch(Mode) // Check the current mode
            {
                case enMode.Addnew: // If we are in Addnew mode
                    if (_AddNewContact()) // Try to add the new contact
                    {
                        Mode = enMode.Update; // Change mode to Update after successful addition
                        return true; // Return true indicating success
                    }
                    else // If adding the new contact failed
                        return false; // Return false indicating failure
                
                case enMode.Update: // If we are in Update mode
                       return _UpdateContact(); // Call the update method and return its result

                default:
                    return false; // Ensure all code paths return a value
            }
        }
    }
}
