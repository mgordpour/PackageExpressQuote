using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement 1: Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Requirement 2: Prompt user for the package weight
            Console.WriteLine("Please enter the package weight:");
            // Convert the user's string input into a float/decimal number for calculations
            float weight = float.Parse(Console.ReadLine());

            // Requirement 3: Check if the weight exceeds the maximum allowed limit of 50
            if (weight > 50)
            {
                // Display error message and terminate program execution
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the Program
            }

            // Requirement 4: Prompt user for the package width
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            // Requirement 5: Prompt user for the package height
            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            // Requirement 6: Prompt user for the package length
            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // Requirement 7: Calculate total dimensions and check if they exceed 50
            float totalDimensions = width + height + length;
            if (totalDimensions > 50)
            {
                // Display error message and terminate program execution
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the Program
            }

            // Requirement 8 & 9: Calculate the quote
            // Multiply dimensions, multiply by weight, and divide product by 100
            float quote = (width * height * length * weight) / 100;

            // Requirement 10: Display the calculated quote formatted as currency ($0.00)
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

            // Requirement 11 & 22: Display thank you message
            Console.WriteLine("Thank you!");
        }
    }
}
