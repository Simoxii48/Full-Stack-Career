using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsPerson
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public clsPerson(int ID, string Name, int Age)
    {
        this.ID = ID;
        this.Name = Name;
        this.Age = Age;
    }

    public static clsPerson Find(int ID)
    {
        // Simulate finding a person in a database
        if (ID == 10)
            return new clsPerson(ID, "Mohammed", 27);
        else
            return null;
    }

    public static clsPerson Find(string Username, string Password)
    {
        // Simulate finding a person in a database
        if (Username == "moha48" && Password == "p1234")
            return new clsPerson(10, "Mohammed", 27);
        else
            return null;
    }
}


namespace RealAppUsingStaticMethods_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //clsPerson person1 = new clsPerson(10, "Mohammed", 27);

            Console.WriteLine("Finding Person1 By ID");
            
            // Find by ID
            clsPerson person1 = clsPerson.Find(10);
            if (person1 != null)
            {
                Console.WriteLine("ID : {0}", person1.ID);
                Console.WriteLine("Name : {0}", person1.Name);
                Console.WriteLine("Age : {0}", person1.Age);
            }
            else
                Console.WriteLine("Person not found by ID.");
            
            // Find by Username and Password
            Console.WriteLine("\nFinding Person2 By Username and Password");
            
            clsPerson person2 = clsPerson.Find("moha48", "p1234");
            if (person2 != null)
            {
                Console.WriteLine("ID : {0}", person2.ID);
                Console.WriteLine("Name : {0}", person2.Name);
                Console.WriteLine("Age : {0}", person2.Age);
            }
            else
                Console.WriteLine("Person not found by Username and Password.");

            Console.WriteLine("\nFinding Person3 By ID");

            clsPerson person3 = clsPerson.Find(11);
            if (person3 != null)
            {
                Console.WriteLine("ID : {0}", person3.ID);
                Console.WriteLine("Name : {0}", person3.Name);
                Console.WriteLine("Age : {0}", person3.Age);
            }
            else
                Console.WriteLine("Person not found by ID.");

            Console.WriteLine("\nFinding Person4 By Username and Password");

            clsPerson person4 = clsPerson.Find("moha4", "p1234");
            if (person4 != null)
            {
                Console.WriteLine("ID : {0}", person4.ID);
                Console.WriteLine("Name : {0}", person4.Name);
                Console.WriteLine("Age : {0}", person4.Age);
            }
            else
                Console.WriteLine("Person not found by Username and Password.");

            Console.ReadKey();
        }
    }
}