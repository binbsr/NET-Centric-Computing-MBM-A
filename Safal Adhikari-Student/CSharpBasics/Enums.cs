using System;


namespace EnumsAndProperties
{
    enum DayWeek
    {
        Sunday,
        Monday,
        Tuseday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
    internal class Demo
    {
       public DayWeek DayWeek { get; set; }
        void PrintGreetings()
        {

            if(DayWeek == DayWeek.Saturday)
            {
                Console.WriteLine("It's a good saturday");
            }
            else if(DayWeek == DayWeek.Sunday)
            {
                Console.WriteLine("It's yet another weekend day.");
            }
            else
            {
                Console.WriteLine("Work Day!");
            }
        }
    }
}