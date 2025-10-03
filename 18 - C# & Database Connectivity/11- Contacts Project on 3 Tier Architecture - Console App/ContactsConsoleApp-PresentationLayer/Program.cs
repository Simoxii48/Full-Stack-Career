using System;
using System.Data;
using ContactsBusinessLayer;

namespace ContactsConsoleApp_PresentationLayer
{
    internal class Program
    {
        static void TestFindContactByID(int ContactID)
        {
            clsContacts contact = clsContacts.Find(ContactID);
            if (contact != null)
            {
                Console.WriteLine("Contact ID " + ContactID + " found:");
                Console.WriteLine($"ID            : {contact.ContactID}");
                Console.WriteLine($"Name          : {contact.Firstname} {contact.Lastname}");
                Console.WriteLine($"Email         : {contact.ContactEmail}");
                Console.WriteLine($"Phone         : {contact.ContactPhone}");
                Console.WriteLine($"Address       : {contact.ContactAddress}");
                Console.WriteLine($"Date of Birth : {contact.DateOfBirth}");
                Console.WriteLine($"Country ID    : {contact.CountryID}");
                Console.WriteLine($"Image Path    : {contact.ImagePath}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Contact with ID " + ContactID + " not found.");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            TestFindContactByID(1);
            TestFindContactByID(999); // Assuming 999 does not exist

            Console.ReadKey();
        }
    }
}
