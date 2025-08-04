namespace Grade_Calculator
{
    internal class Program
    {


        class GradeCalculator
        {
            static void Main()
            {
                Console.WriteLine("Enter a numerical grade between 0 and 100:");

                // Read input from the user
                string input = Console.ReadLine();
                int grade;

                // Validate and parse input
                if (int.TryParse(input, out grade))
                {
                    if (grade >= 0 && grade <= 100)
                    {
                        // Determine the letter grade
                        string letterGrade;

                        if (grade >= 90)
                            letterGrade = "A";
                        else if (grade >= 80)
                            letterGrade = "B";
                        else if (grade >= 70)
                            letterGrade = "C";
                        else if (grade >= 60)
                            letterGrade = "D";
                        else
                            letterGrade = "F";

                        // Display result
                        Console.WriteLine($"The letter grade is: {letterGrade}");
                    }
                    else
                    {
                        Console.WriteLine("Grade must be between 0 and 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                // Pause before exiting
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

    }
}