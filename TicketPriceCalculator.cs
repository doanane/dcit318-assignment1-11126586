using System;

namespace Assignment1
{
    class TicketPriceCalculator
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Ticket Price Calculator ---");
            Console.Write("Enter your age: ");
            
            if (!int.TryParse(Console.ReadLine(), out int age) || age <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }
            

            decimal price = (age <= 12 || age >= 65) ? 7.00m : 10.00m;
            Console.WriteLine($"Ticket price: GHC{price:F2}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}