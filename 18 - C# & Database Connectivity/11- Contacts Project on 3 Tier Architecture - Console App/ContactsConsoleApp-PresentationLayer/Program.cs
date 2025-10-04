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

        static void TestAddNewContact()
        {
            clsContacts Contact = new clsContacts();
            
            Contact.Firstname = "John";
            Contact.Lastname = "Doe";
            Contact.ContactEmail = "John_Doe@gmail.com";
            Contact.ContactPhone = "123-456-7890";
            Contact.ContactAddress = "123 Main St, Anytown, USA";
            Contact.DateOfBirth = new DateTime(1977, 11, 6,10,30,0);
            Contact.CountryID = 1; // Assuming 1 is a valid CountryID
            Contact.ImagePath = ""; // No image

            if(Contact.Save())
                Console.WriteLine("New contact added successfully with ID: " + Contact.ContactID);
            else
                Console.WriteLine("Failed to add new contact.");
        }

        static void TestUpdateContact(int ContactID)
        {
            clsContacts contact = clsContacts.Find(ContactID);
            
            if (contact != null)
            {
                contact.Firstname = "Cristiana"; // Update first name
                contact.Lastname = "Domain"; // Update last name
                contact.ContactEmail = "exemple@gmail.com"; // Update email
                contact.ContactPhone = "987-654-3210"; // Update phone number
                contact.ContactAddress = "456 Another St, Othertown, USA"; // Update address
                contact.DateOfBirth = new DateTime(1985, 5, 15); // Update date of birth
                contact.CountryID = 2; // Update country ID
                contact.ImagePath = "path/to/new/image.jpg"; // Update image path

                if(contact.Save())
                    Console.WriteLine("Contact with ID " + ContactID + " updated successfully.");
                else
                    Console.WriteLine("Failed to update contact with ID " + ContactID + ".");
            }
            else
            {
                Console.WriteLine("Contact with ID " + ContactID + " not found for update.");
            }
        }

        // Delete Case to delete a contact by ID, no need to find the contact first and consume memory then delete it, we will delete it directly by ID from the data access layer
        static void TestDeleteContact(int ContactID)
        {
            if (clsContacts.DeleteContact(ContactID)) // Call the Delete method
                Console.WriteLine("Contact with ID " + ContactID + " deleted successfully.");
            else
                Console.WriteLine("Failed to delete contact with ID " + ContactID + ".");
        }

        static void ListContacts()
        {
            DataTable dataTable = clsContacts.GetAllContacts();

            Console.WriteLine("List of all contacts:");
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"ID: {row["ContactID"]}, Name: {row["Firstname"]} {row["Lastname"]}, Email: {row["Email"]}, Phone: {row["Phone"]}");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // Test cases to find contacts by ID
            //TestFindContactByID(1);
            //TestFindContactByID(999); // Assuming 999 does not exist

            // Test Case to add a new contact
            //TestAddNewContact();

            // Test Case to update an existing contact
            //TestUpdateContact(9); // Assuming 1 exists

            // Test case to delete a contact
            //TestDeleteContact(10); // Assuming 10 exists

            // List all Contacts
            ListContacts();

            Console.ReadKey();
        }
    }
}
