using System;

namespace AssignmentUtsav
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment1 assignment = new Assignment1();
            do
            {
                Console.Write("Enter question number (1-3) or any other number to exit: ");
                int control = Convert.ToInt32(Console.ReadLine());
                if (control > 3)
                    break;
                switch (control)
                {
                    case 1:
                        Console.WriteLine("Program to give true if sum of two numbers is > 500");
                        Console.Write("Enter first number :");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter second number :");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        bool result = assignment.SumGreaterThan500(num1, num2);
                        Console.WriteLine(result);
                        break;
                    case 2:
                        Console.WriteLine("Program to show total points for given wins, draws and looses");

                        Console.Write("Enter number of wins: ");
                        int wins = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter number of draws: ");
                        int draws = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter number of losses: ");
                        int losses = Convert.ToInt32(Console.ReadLine());
                        assignment.PointCalculator(wins: wins, draws: draws, loose: losses);
                        break;

                    case 3:
                        Console.WriteLine("Program to print the initials of name");

                        Console.Write("Enter your full Name : ");
                        string name = Console.ReadLine();
                        Console.WriteLine(name);
                        Console.WriteLine($"The initials is: {assignment.GetInitials(name)}");
                        break;
                }
            } while (true);
        }
    }
}
