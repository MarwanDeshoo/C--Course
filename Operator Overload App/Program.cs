using System;

// Define the namespace for the application
namespace EmployeeComparisonApp
{
    // Define the Employee class
    class Employee
    {
        // Property for Employee Id
        public int Id { get; set; }

        // Property for Employee First Name
        public string FirstName { get; set; }

        // Property for Employee Last Name
        public string LastName { get; set; }

        // Overload the '==' operator to compare two Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both are same instance, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null, but not both, return false
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Return true if the Ids are equal
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator (must be overloaded in pair with '==')
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the inverse of the == operator
            return !(emp1 == emp2);
        }

        // Override Equals() to match operator overloading logic
        public override bool Equals(object obj)
        {
            // If the object is not an Employee, return false
            var other = obj as Employee;
            if (other == null)
                return false;

            // Compare by Id
            return this.Id == other.Id;
        }

        // Override GetHashCode() when Equals() is overridden
        public override int GetHashCode()
        {
            // Return hash code based on Id
            return this.Id.GetHashCode();
        }
    }

    // Define the Program class with Main method
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values
            Employee employee1 = new Employee
            {
                Id = 101,
                FirstName = "Marwan",
                LastName = "Desho"
            };

            // Instantiate the second Employee object and assign values
            Employee employee2 = new Employee
            {
                Id = 102,
                FirstName = "Another",
                LastName = "Person"
            };

            // Compare the two employees using the overloaded '=='
            bool areEqual = employee1 == employee2;

            // Display result of the comparison
            Console.WriteLine("Are employee1 and employee2 equal? " + areEqual);

            // Compare the two employees using the overloaded '!='
            bool areNotEqual = employee1 != employee2;

            // Display result of the inequality comparison
            Console.WriteLine("Are employee1 and employee2 not equal? " + areNotEqual);

            // Pause the console so it doesn't close immediately
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
