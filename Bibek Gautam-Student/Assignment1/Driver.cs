using System;
class Driver{
    static void Main(string[] args){
        Methods methods = new Methods();

        //Sum of two numbers
        Console.WriteLine("Enter the two numbers: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        bool result = methods.FindSum(num1, num2);
        if(result)
            Console.WriteLine($"Returned value is {result} since {num1} + {num2} = {num1 + num2} > 500.");
        else
            Console.WriteLine($"Returned value is {result} since {num1} + {num2} = {num1 + num2} <= 500.");


        //Points
        Console.WriteLine("Enter the number of wins, draws and losses in given order: ");
        int numberOfWins = int.Parse(Console.ReadLine());
        int numberOfDraws = int.Parse(Console.ReadLine());
        int numberOfLosses = int.Parse(Console.ReadLine());
        int points = methods.FindPoints(numberOfWins, numberOfDraws, numberOfLosses);
        Console.WriteLine($"Your team has earned {points} points.");

        //Initails generator
        Console.WriteLine("Enter two strings separated by space: ");
        string myString = Console.ReadLine();
        string initials = methods.GetInitials(myString);
        Console.WriteLine($"Your initials are {initials}");
    }
}