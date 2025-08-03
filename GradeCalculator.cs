using System;

namespace Assignment1
{
    class GradeCalculator
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Grade Calculator ---");
            Console.Write("Enter numerical grade (0-100): ");
            
            if (!double.TryParse(Console.ReadLine(), out double grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                return;
            }

            string letterGrade = grade >= 90 ? "A" :
                               grade >= 80 ? "B" :
                               grade >= 70 ? "C" :
                               grade >= 60 ? "D" : "F";

            Console.WriteLine($"Letter grade: {letterGrade}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}