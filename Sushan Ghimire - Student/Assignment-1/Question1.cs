//Given two numbers, write C# method that returns true if sum of both numbers is greater than 500. Otherwise returns false.

public class SumOfNumbers
{
    internal bool SumNum(int x, int y)
    {
        int sum = x + y;
        if (sum > 500)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}