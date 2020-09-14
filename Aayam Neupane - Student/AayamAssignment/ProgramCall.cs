//Main Program

using System;

namespace AayamAssignment
{
    // C# method that returns true if sum of both numbers is greater than 500 else returns false.
    internal class ProgramCall
    {
        static void Main(string[] args)
        {
            Method1 m1 = new Method1();
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            bool result = m1.Number(num1 + num2);
            if (result)
            {
                Console.WriteLine("The result is True");
            }
            else
            {
                Console.WriteLine("The result is False");
            }

            //Create a function that takes the number of wins, draws and losses, 
            //and calculates the number of points a football team has obtained so far. 
            //Rule - wins get 5 points, draws get 2 point and losses get 0 points.
            WinLossDraw m2 = new WinLossDraw();
            int result1 = m2.Calc();
            Console.WriteLine($"The Team got {result1} points");

            // A function that takes a two word string separated by space 
            //and returns the concatenated first characters of both the words. 
            //E.g. GetInitials("Bishnu Rawal") => "BR" 
            //GetInitials("Alex Wales") => "AW"

            GetInitials m3 = new GetInitials();
            Console.WriteLine("Enter YourFull Name:");
            string name = Console.ReadLine();
            string initial = m3.Initials(name);
            Console.WriteLine($"The Initials are : {initial}");

        }
    }
}
