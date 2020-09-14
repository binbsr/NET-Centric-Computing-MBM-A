//Create a function that takes the number of wins, draws and losses, 
//and calculates the number of points a football team has obtained so far. 
//Rule - wins get 5 points, draws get 2 point and losses get 0 points.

using System;

internal class WinLossDraw
{


    internal int Calc()
    {

        Console.Write("Enter the no of wins of the team: ");
        int w = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the no of Draws of the team: ");
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the no of loses of the team: ");
        int l = int.Parse(Console.ReadLine());

        return (w * 5 + d * 2 + l * 0);


    }




}