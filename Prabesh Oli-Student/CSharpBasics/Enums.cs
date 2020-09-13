using System;
enum DayofWeek{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday, 
    Friday,
    Saturday

}
class Demo{
    public DayofWeek DayofWeek{set;get;}
    void PrintGreetings(){
        if (DayofWeek ==DayofWeek.Saturday)
            Console.WriteLine("Its is  Saturday");
            else if(DayofWeek==DayofWeek.Sunday)
                Console.WriteLine("Its another weekend day");
                else
                
                    Console.WriteLine("oh gosh. work day");
                
            
        
    }
}