using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter your age: ");

        // Read user input
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (int.TryParse(input, out int age))
        {
            // Calculate ticket price based on age
            decimal ticketPrice = CalculateTicketPrice(age);
            Console.WriteLine($"The ticket price is GHC{ticketPrice}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }

    static decimal CalculateTicketPrice(int age)
    {
        // Determine ticket price based on age
        if (age <= 12 || age >= 65)
        {
            return 7m; // Discounted price for children and senior citizens
        }
        else
        {
            return 10m; // Regular price for others
        }
    }
}