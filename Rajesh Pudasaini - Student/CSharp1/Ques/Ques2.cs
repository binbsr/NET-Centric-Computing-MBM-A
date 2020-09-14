//Create a function that takes the number of wins, draws and losses, and 
//calculates the number of points a football team has obtained so far. wins get 5 points draws get 2 point losses get 0 points

using System;
class TeamPoint {
    internal void Execute(){
        Console.WriteLine("\n\n\n\n#######-------Question 2-------#######");
        TeamPoint obj1 = new TeamPoint();
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
    int CalculateTeamPoint(int wins, int draws, int losses){
        int totalPoint = 0;
        for (int i=1; i<=wins; i++){
            totalPoint += 5;
        }

        for (int i=1; i<=draws; i++){
            totalPoint += 2;
        }
        return totalPoint;
    }

}