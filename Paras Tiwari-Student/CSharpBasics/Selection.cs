
using System;
class SlectionStatement
{
    static void Main2()
    {
        SlectionStatement ss = new SlectionStatement();
        ss.LearnIfElse();
      
    }
    void LearnIfElse()
    {
        Console.Write("Enter any number");
        string input = Console.ReadLine();
        byte x = byte.Parse(input);
        if (x==14)
        {
            Console.WriteLine("You Entered 14");
        }
         else if (x==20)
        {
            Console.WriteLine("You Entered 20");
        }
        else
        {

            Console.WriteLine("You didn't Enter 34");

        }


    }
    void LeranSwitch()
    {
        char option = 'y';
        switch(option)
        {
            case 'n':
            case 'x':
                Console.WriteLine("You opted for No.");
                break;
            case 'y':
            case 'z':
                Console.WriteLine("You opted for Yes.");
                break;
            default:
             Console.WriteLine("No cases Matched");
            break;
        }

    }

}