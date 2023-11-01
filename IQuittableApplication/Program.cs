using System;

// This interface will be used to indicate that a class can perform a "Quit" action.
public interface IQuittable
{
    void Quit();
}

// This class represents an employee and implements the IQuittable interface.
public class Employee : IQuittable
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Quit()
    {
        Console.WriteLine($"Employee {FirstName} {LastName} with ID: {Id} has quit.");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate an object of type IQuittable using the Employee class.
        IQuittable emp = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };

        // Call the Quit method on the emp object.
        emp.Quit();

        // Wait for user input to keep the console open.
        Console.ReadKey();
    }
}
