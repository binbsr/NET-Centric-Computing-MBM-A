// Create a function that takes the number of wins, draws and losses, and calculates the number of points a football team has obtained so far. 
//Rule - wins get 5 points, draws get 2 point and losses get 0 points.

using System;

public class PointCalc
{
    internal int Points()
    {
        Console.WriteLine("Enter number of Wins: ");
        int win = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of Draws: ");
        int draw = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of Losses: ");
        int loss = int.Parse(Console.ReadLine());

        return ((win * 5) + (draw * 2) + (loss * 0));
    }
}
