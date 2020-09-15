//Given two numbers, write c# method that returns true if sum of both numbers is greater than 500. Otherwise return false.
public class NumberSum
{
    internal bool total (int a, int b)
    {
         int total = a + b;
         if (total > 500)
         {
             return true;
         }
         else
         {
             return false;
         }
    }
}