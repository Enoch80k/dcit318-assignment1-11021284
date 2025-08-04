using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter the length of side A: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side B: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side C: ");
        double sideC = Convert.ToDouble(Console.ReadLine());

        // Determine the type of triangle
        string triangleType = DetermineTriangleType(sideA, sideB, sideC);

        // Output the result
        Console.WriteLine($"The triangle is {triangleType}.");
    }

    static string DetermineTriangleType(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            return "not a valid triangle (sides must be positive)";
        }

        if (a == b && b == c)
        {
            return "Equilateral";
        }
        else if (a == b || b == c || a == c)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}