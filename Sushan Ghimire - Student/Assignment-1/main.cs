using System;

class Program
{
    static void Main()
    {
        //Question-1
        Console.WriteLine("Sum Checker::->");

        SumOfNumbers sumOfNumbers = new SumOfNumbers();

        Console.WriteLine("Enter First Number");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Number");
        int num2 = int.Parse(Console.ReadLine());

        bool result = sumOfNumbers.SumNum(num1, num2);
        Console.WriteLine($"Your result is {result}.");

        //Question-2
        Console.WriteLine();
        Console.WriteLine("Points Calculator::->");

        CalculatePoints calculatePoints = new CalculatePoints();

        Console.Write("Enter the number of wins:");
        int win = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of draws:");
        int draw = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of loss:");
        int loss = int.Parse(Console.ReadLine());

        int totalPoints = calculatePoints.Points(win, draw, loss);
        Console.WriteLine($"The total point of your team is {totalPoints}");


        //Question-3
        Console.WriteLine();
        Console.WriteLine("Read Initials::->");

        Initials initials = new Initials();

        Console.Write("Enter Your Name::");
        string input = Console.ReadLine();

        string resultInitials = initials.GetInitials(input);
        Console.WriteLine($"Your Initials is:: {resultInitials}");
    }
}