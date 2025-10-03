using System;
using System.Data;
using ContactsDataAccessLayer;

namespace ContactsBusinessLayer
{
    public class clsContacts
    {
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
        clsContacts(int contactID, string firstname, string lastname, string contactEmail, string contactPhone,
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
    }
}
