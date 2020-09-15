using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            All all = new All();
            
            //Sum
            Console.WriteLine("Enter two integers:");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            bool sumResult = all.SumChecker( firstNum, secondNum);
            Console.WriteLine($"The result is {sumResult}");

            //WinDrawLoss total points
            Console.WriteLine("Enter the win, draw and loss number of the team:");
            int win = int.Parse(Console.ReadLine());
            int draw = int.Parse(Console.ReadLine());
            int loss = int.Parse(Console.ReadLine());
            int totalPoints = all.WinDrawLoss( win, draw, loss);
            Console.WriteLine($"The total points of the team is {totalPoints}");

            //StringConcatenation
            Console.WriteLine("Enter string of two words:");
            string words = Console.ReadLine();
            string stringResult = all.StringConcatenation( words );
            Console.WriteLine($"The initials concatenated result is {stringResult}");
        }
    }
}
