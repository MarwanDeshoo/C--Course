using System;

class Program
{
    static void Main()
    {
        // Welcome message displayed first
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for package weight
        Console.Write("Please enter the package weight: ");
        // Read weight and convert to a decimal
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Check if package weight exceeds limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit program
        }

        // Prompt for package width
        Console.Write("Please enter the package width: ");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Prompt for package height
        Console.Write("Please enter the package height: ");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Prompt for package length
        Console.Write("Please enter the package length: ");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Check if total dimensions exceed the maximum allowed
        decimal dimensionTotal = width + height + length;
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit program
        }

        // Calculate shipping quote using the formula:
        // (width * height * length * weight) / 100
        decimal quote = (width * height * length * weight) / 100;

        // Display the quote formatted as currency with 2 decimal places
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
        Console.WriteLine("Thank you!");
    }
}
