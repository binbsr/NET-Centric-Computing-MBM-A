using System;

class Logic
{

 //Given two numbers, write C# method that returns true if sum of both numbers is greater than 500. Otherwise returns false.

 internal Boolean findresult(int a , int b)
 {
     if(a+b>500)
     {
         return true;
     }
     else
     {
        return false;
     }

 }
 // 1. Create a function that takes the number of wins, draws and losses, and calculates the number of points a football team has obtained so far.
// wins get 5 points ,draws get 2 point,losses get 0 points

    internal int CalculatePoints(int Wins, int Losses ,int Draws)
    {
        return(Wins*5+Draws*2+Losses*0);
    }

// 1. Creates a function that takes a two word string separated by space and returns the concatenated first characters of both the words.
// E.g. 
// GetInitials("Bishnu Rawal") => "BR"
// GetInitials("Alex Wales") => "AW"

    internal string GetInitials(string name)
    {
        string result="";
        int i=name.Length;
        int j=0;
        while(j<i)
        {
            if(j==0)
            {
                result+=name[j];
            }
            else if(name[j]==' ')
            {
                result+=name[++j];
            }
            j++;
        }
        return result.ToUpper();
    }
    internal  void SolveQuestion1()
    {
        Console.WriteLine("Enter First Number:");
        int num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int num2=int.Parse(Console.ReadLine());
        bool result=findresult(num1,num2);
        Console.WriteLine($"The result is{result}");
    }
    internal void SolveQuestion2()
    {
        Console.WriteLine("Enter Number of Wins:");
        int wins=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number of Draws:");
        int draws=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number of Losses:");
        int losses=int.Parse(Console.ReadLine());
        int Points= CalculatePoints(wins,losses,draws);
        Console.WriteLine($"Your Team has Scored {Points} Points!");
    }
    internal void SolveQuestion3()
    {
        Console.WriteLine("Enter Your Full Name:");
        string Fullname=Console.ReadLine();
        string initials=GetInitials(Fullname);
        Console.WriteLine($"The Initials Of your name is {initials}");
    }
}


