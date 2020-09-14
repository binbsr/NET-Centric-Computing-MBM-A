using System;

namespace EnumsAndProperties
{
    enum DayWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesady,
        Thursady,
        Friday,
        Saturday
    }

    internal class Demo
    {
        
        Person person;
        public DayWeek DayOfWeek { get; set; }

        void PrintGreetings()
        {

            if (DayOfWeek == DayWeek.Saturday)
            {
                Console.WriteLine("Its a good saturday");
            }
            else if (DayOfWeek == DayWeek.Sunday)
            {
                Console.WriteLine("Its yet another weekend");
            }
            else
            {
                Console.WriteLine("Oh gosh, work day");
            }
        }
    }

}