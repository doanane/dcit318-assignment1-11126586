using System;

namespace Assignment1
{
    class TriangleTypeIdentifier
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Triangle Type Identifier ---");
            
            double[] sides = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter length of side {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out sides[i]) || sides[i] <= 0)
                {
                    Console.WriteLine("Invalid input. Side lengths must be positive numbers.");
                    return;
                }
            }

            if (!IsValidTriangle(sides[0], sides[1], sides[2]))
            {
                Console.WriteLine("These sides do not form a valid triangle.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            string triangleType = DetermineTriangleType(sides[0], sides[1], sides[2]);
            Console.WriteLine($"Triangle type: {triangleType}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        static string DetermineTriangleType(double a, double b, double c)
        {
            if (a == b && b == c) return "Equilateral Triangle";
            if (a == b || a == c || b == c) return "Isosceles Triangle";
            return "Scalene Triangle";
        }
    }
}