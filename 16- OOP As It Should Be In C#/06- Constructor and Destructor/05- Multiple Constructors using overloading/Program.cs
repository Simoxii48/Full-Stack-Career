using System;
class clsPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public clsPerson()
    {
        this.Id = -1;
        this.Name = "Empty";
        this.Age = 0;
    }

    public clsPerson(int Id, string Name, short Age)
    {
        this.Id = Id;
        this.Name = Name;
        this.Age = Age;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calling Parameterless Construcor");
        clsPerson Person1 = new clsPerson();
        Console.WriteLine("ID:= {0}", Person1.Id);
        Console.WriteLine("Name:= {0}", Person1.Name);
        Console.WriteLine("Age:= {0}", Person1.Age);

        Console.WriteLine("\n\nCalling Parametarized Construcor");
        clsPerson Person2 = new clsPerson(10, "Mohammed Abu-Hadhoud", 45);
        Console.WriteLine("ID:= {0}", Person2.Id);
        Console.WriteLine("Name:= {0}", Person2.Name);
        Console.WriteLine("Age:= {0}", Person2.Age);

        Console.ReadKey();


    }
}

