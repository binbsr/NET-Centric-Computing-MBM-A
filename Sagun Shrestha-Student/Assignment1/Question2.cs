using System;
class Question2
{
    
    internal void Prediction()
    {
        Question2 obj1 = new Question2();
        Console.Write("Enter the number of wins: ");
        int wins = Int16.Parse(Console.ReadLine());
        Console.Write("Enter the number of draws: ");
        int draws = Int16.Parse(Console.ReadLine());
        Console.Write("Enter the number of losses: ");
        int losses = Int16.Parse(Console.ReadLine());
        int result = obj1.CalculateTeamPoint(wins, draws, losses);
        Console.WriteLine($"Team earned {result} point in entire season");
    }
 
   //method to calculate team point based on number of wins, draws and losses
   int CalculateTeamPoint(int wins, int draws, int losses)
    {
        int totalPoint = 0;
        for (int i = 1; i <= wins; i++)
            {
                totalPoint += 5;
            }
 
        for (int i = 1; i <= draws; i++)
            {
                totalPoint += 2;
            }
        return totalPoint;
    }
}