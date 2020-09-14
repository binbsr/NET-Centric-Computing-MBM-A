using System;

class Program
{
    static void Main()
    {
        //1
        Console.WriteLine("Sum Of Both Num :");

        ReturnSums returnSums = new ReturnSums();

        Console.WriteLine("Enter 1st Num:");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd Num:");
        int n2 = int.Parse(Console.ReadLine());

        bool total = returnSums.Sums(n1, n2);
        Console.WriteLine($"Your total is {total}.");

        //2
        Console.WriteLine();
        Console.WriteLine("Point:");

        TeamPoints teamPoints = new TeamPoints();

        Console.Write("Enter the number of wins:");
        int win = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of draws:");
        int draw = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of loss:");
        int loss = int.Parse(Console.ReadLine());

        int  Point = teamPoints.Points(win, draw, loss);
        
        Console.WriteLine($"The  points of  team is {Point}");


        //3
        Console.WriteLine();
        Console.WriteLine("Read Initials:");

        Initials initials = new Initials();

        Console.Write("Enter Your Name:");
        string input = Console.ReadLine();

        string resultInitials = initials.GetInitials(input);
        Console.WriteLine($"Your Initials is: {resultInitials}");
    }
}