using System;

class Question2
{
    static void Main2()
    {
        Question2 answer=new Question2();
        answer.Execute();
    }
        internal void Execute()
    {
        Question2 obj1 = new Question2();
        Console.Write("Enter the number of wins: ");
        int wins = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the number of draws: ");
        int draws = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the number of looses: ");
        int losses = Int32.Parse(Console.ReadLine());
        int res = obj1.CalculateTeamPoint(wins, draws, losses);
        Console.WriteLine($"Team earned {res} point in entire season");
    }

    //method to calculate team point based on number of wins, draws and losses
    int CalculateTeamPoint(int wins, int draws, int losses)
    {
        int totalPoint = 0;
        for (int i=1; i<=wins; i++)
        {
            totalPoint += 5;
        }

        for (int i=1; i<=draws; i++)
        {
            totalPoint += 2;
        }
        return totalPoint;
    }
}