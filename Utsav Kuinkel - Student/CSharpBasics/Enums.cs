using System;

public enum DayOfWeek
{
    sunday,
    monday,
    tuesday,
    wednesday,
    friday,
    saturday
}
class Demo
{
    public DayOfWeek dayOfWeek = DayOfWeek.monday;
    void PrintGreetings()
    {

        if (dayOfWeek == DayOfWeek.saturday)
        {
            Console.WriteLine("Happy holiday my friend");
        }
        else if (dayOfWeek == DayOfWeek.sunday)
        {
            Console.WriteLine("Yet another week starts");
        }
        else if (dayOfWeek == DayOfWeek.friday)
        {
            Console.WriteLine("TGIF");
        }
        else
        {
            Console.WriteLine("Friday please come soon");
        }
    }
}
