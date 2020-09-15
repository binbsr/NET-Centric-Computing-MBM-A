using System;

public class FootballResult
{
    public int Resultvar()
    {
        Console.WriteLine("Enter the number of wins:");
        int Win= int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of draws:");
        int Draw= int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of losses");
        int Loss= int.Parse(Console.ReadLine());

         int Result=Win*5+Draw*2+Loss*0;
        return Result;


    }

}