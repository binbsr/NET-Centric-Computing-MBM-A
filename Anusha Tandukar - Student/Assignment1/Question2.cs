// Create a function that takes the number of wins, draws and losses, and calculates the number of points a football team has obtained so far wins get 5 points, draws get 2 points, losses gets 0 points

public class Calculator
{
    internal int Points (int wins, int draws, int losses)
    {
        int total;
        total = wins * 5 + draws * 2 + losses * 0 ;
        return total;
    }
}