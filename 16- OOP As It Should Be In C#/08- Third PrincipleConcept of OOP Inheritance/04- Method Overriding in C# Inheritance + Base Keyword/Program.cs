using System;

public  class clsA
{

    // Virtual keyword allows a method to be overridden in a derived class
    public virtual void  Print()
    {
        Console.WriteLine("Hi, I'm the print method from the base class A");
    }

}

public class clsB : clsA
{

    // Override keyword is used to extend or modify a virtual/abstract method in a derived class
    public override void  Print() 
    
    {
        Console.WriteLine("Hi, I'm the print method from the derived class B");
        // base keyword is used to access members of the base class from within a derived class
        base.Print();       
      
     }
}

    internal class Program
    {
        static void Main(string[] args)
        {
       
        //Create an object of Empoyee
        clsB ObjB= new clsB();
        ObjB.Print();
        Console.ReadKey();
        }
    }

