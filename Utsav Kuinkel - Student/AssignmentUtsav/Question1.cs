using System;

class Assignment1
{
    internal bool SumGreaterThan500(int num1, int num2)
    {
        int sum = num1 + num2;
        if (sum > 500)
            return true;
        else
            return false;

    }

    internal void PointCalculator(int wins, int draws, int loose)
    {
        Console.WriteLine($"Total Points: {wins * 5 + draws * 2}");

    }

    internal string GetInitials(string name)
    {
        string initials = "";
        initials += name[0];
        for (int i = 0; i < name.Length - 1; i++)
        {
            if (name[i] == ' ')
            {
                initials += name[i + 1];
            }
        }
        return initials.ToUpper();
    }
}