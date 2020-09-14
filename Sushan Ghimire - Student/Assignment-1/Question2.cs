//Create a function that takes the number of wins, draws and losses, and calculates the number of points a football team has obtained so far. Rule - wins get 5 points, draws get 2 point and losses get 0 points.

public class CalculatePoints
{
    internal int Points(int wins, int draw, int loss)
    {
        int total;
        total = wins * 5 + draw * 2 + loss * 0;
        return total;
    }
}