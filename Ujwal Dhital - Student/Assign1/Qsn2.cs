using System;

class Qsn2
{
    static void Main2()
    {
        Qsn2 answer=new Qsn2();
        answer.Execute();
    }
        internal void Execute()
    {
        Qsn2 obj1 = new Qsn2();
        Console.Write("Enter the number of wins: ");
        int wins = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the number of draws: ");
        int draws = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the number of loss: ");
        int loss = Int32.Parse(Console.ReadLine());
        int res = obj1.CalculateTeamPoint(wins, draws, loss);
        Console.WriteLine($"Team earned {res} point in the session");
    }

    
    int CalculateTeamPoint(int wins, int draws, int loss)
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