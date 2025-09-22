using System;

namespace InterfaceDemoApp
{
    // Define an interface called IQuittable
    interface IQuittable
    {
        // Declare a void method named Quit
        void Quit();
    }

    // Define the Employee class that implements IQuittable
    class Employee : IQuittable
    {
        // Property for Employee Id
        public int Id { get; set; }

        // Property for Employee First Name
        public string FirstName { get; set; }

        // Property for Employee Last Name
        public string LastName { get; set; }

        // Implement the Quit() method from IQuittable interface
        public void Quit()
        {
            // Output a message indicating that the employee has quit
            Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the company.");
        }
    }

    // Main program class
    class Program
    {
        // Main method — entry point of the console app
        static void Main(string[] args)
        {
            // Create an instance of Employee and assign values
            Employee employee = new Employee
            {
                Id = 200,
                FirstName = "Marwan",
                LastName = "Desho"
            };

            // Use polymorphism to create an object of type IQuittable
            // and assign it to the employee instance (since Employee implements IQuittable)
            IQuittable quittableEmployee = employee;

            // Call the Quit method using the IQuittable object
            quittableEmployee.Quit();

            // Pause the console so the user can see the result before it closes
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
