//Create a function that takes the number of wins, draws and losses, and calculates the number of points a football team has obtained so far. wins get 5 points draws get 2 point losses get 0 points

public class TeamPoints
{
    internal int Points (int wins, int draws, int loses)
    {
        int total;
        total= wins * 5 + draws * 2 + loses * 0 ;
        return total;
    }
}