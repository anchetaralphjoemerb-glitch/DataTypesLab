using System;

class Program
{
    static void Main()
    {
        // =========================================================
        // TASK 1: Grade Evaluator & Academic Status
        // =========================================================
        Console.WriteLine("=== TASK 1: GRADE EVALUATOR ===");

        Console.Write("Enter numerical grade (0-100): ");
        string gradeInput = Console.ReadLine();
        double numericalGrade = double.Parse(gradeInput);

        // Validate grade is within range
        if (numericalGrade < 0 || numericalGrade > 100)
        {
            Console.WriteLine("Error: Grade must be between 0 and 100.");
        }
        else
        {
            // Determine letter grade using if/else if/else ladder
            char letterGrade;

            if (numericalGrade >= 90)
            {
                letterGrade = 'A';
            }
            else if (numericalGrade >= 80)
            {
                letterGrade = 'B';
            }
            else if (numericalGrade >= 70)
            {
                letterGrade = 'C';
            }
            else if (numericalGrade >= 60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            // Use ternary operator to determine pass/fail status
            string status = (numericalGrade >= 60) ? "Passed" : "Failed";

            Console.WriteLine();
            Console.WriteLine("--- Results ---");
            Console.WriteLine($"Letter Grade: {letterGrade}");
            Console.WriteLine($"Status: {status}");
        }

        // =========================================================
        // TASK 2: Role-Based Access Control
        // =========================================================
        Console.WriteLine();
        Console.WriteLine("=== TASK 2: ROLE-BASED ACCESS CONTROL ===");

        Console.Write("Enter your system role (Admin/Instructor/Student): ");
        string role = Console.ReadLine().ToLower();

        // Use switch statement with case-insensitive role check
        string permissionLevel = role switch
        {
            "admin" => "Full Access: Read, Write, Delete, System Settings",
            "instructor" => "Elevated Access: Read, Write, Grade Submissions",
            "student" => "Standard Access: Read, Submit Assignments",
            _ => "Access Denied: Invalid Role"
        };

        Console.WriteLine();
        Console.WriteLine($"Permission Level: {permissionLevel}");

        // =========================================================
        // TASK 3: Movie Ticket Pricing Calculator
        // =========================================================
        Console.WriteLine();
        Console.WriteLine("=== TASK 3: MOVIE TICKET PRICING ===");

        Console.Write("Enter customer age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Is this a matinee show? (Y/N): ");
        string matineeInput = Console.ReadLine().ToUpper();
        bool isMatinee = (matineeInput == "Y");

        // Calculate ticket price using logical operators
        double basePrice = 12.00;
        double ticketPrice;

        // Check if customer qualifies for discount (senior 65+ OR child 12 and under)
        if (age >= 65 || age <= 12)
        {
            ticketPrice = 8.00;
        }
        else
        {
            ticketPrice = basePrice;
        }

        // Apply matinee discount if applicable
        if (isMatinee)
        {
            ticketPrice -= 2.00;
        }

        Console.WriteLine();
        Console.WriteLine($"Final Ticket Price: {ticketPrice:C}");

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
