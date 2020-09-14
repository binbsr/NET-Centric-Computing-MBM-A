using System;

namespace EnumsAndProporties
{

    enum DayWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    internal class Demo
    {
        public DayWeek DayWeek { get; set; }
        void PrintGreetings()
        {

            if (DayWeek == DayWeek.Saturday)
            {
                Console.WriteLine("Its a good saturday");
            }
            else if (DayWeek == DayWeek.Saturday)
            {
                Console.WriteLine("Another Weekend");
            }
            else
            {
                Console.WriteLine("No, Workday");
            }

        }

    }
}
