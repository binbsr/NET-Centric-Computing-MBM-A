using System;
class Question3
{
    static void Main()
    {
         Console.Write("Enter your full Name : ");
        string name = Console.ReadLine();
        Console.WriteLine(name);
        Question3 answer=new Question3();
        string res=answer.GetInitials(name);
        Console.WriteLine($"The initials is: {res}");
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