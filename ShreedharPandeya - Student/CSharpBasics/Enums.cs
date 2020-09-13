using System;

enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,





}

internal class Demo
{
    public DayOfWeek DayOfWeek {get; set;}
    void PrintGreetings()
    {
        
        if (DayOfWeek == DayOfWeek.Saturday)
        {
            Console.WriteLine("Good saturday");

        }
        else if(DayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("Weekend");

        }
        else
        {
            Console.WriteLine("Workday");
        }


    }





}