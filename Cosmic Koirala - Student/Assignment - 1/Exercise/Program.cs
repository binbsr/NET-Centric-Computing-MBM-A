using System;
namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Method assign = new Method();
    //Sum of number
            Console.WriteLine("Enter First Number");
            int num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2=  int.Parse(Console.ReadLine());
            bool result= assign.SumOfNum(num1,num2); //calling first method
            if (result)
            {
                Console.WriteLine($"Sum of {num1} and {num2} is greater than 500 so result is {result}");
            }
            else
            {
                Console.WriteLine($"Sum of {num1} and {num2} is not greater than 500 so result is {result}");
            }
    //point calcuator
            Console.WriteLine("Enter the  Number of wins: ");
            int wins= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the  Number of Draws: ");
            int draws= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the  Number of losses: ");
            int losses= int.Parse(Console.ReadLine());
            int points = assign.PointsCalculator(wins,draws,losses); // calling second Method
            Console.WriteLine($"Your team played {wins+draws+losses} matches and earned {points} points.");
    //Initails generator
             Console.WriteLine("Enter your name: ");
             string name = Console.ReadLine();
             string initials = assign.GetInitials(name);
             Console.WriteLine($"Your initials are {initials}");

        }
    }
}