using System;

class SelectionStatement
{
    static void Main2()
    {
        SelectionStatement ss=new SelectionStatement();
        //ss.LearnIfElse();
        ss.LearnSwitch();
    }
    void LearnIfElse()
    {
        Console.Write("Enter any number");
        string input=Console.ReadLine();
        byte x =byte.Parse(input);
        
        if(x == 34)
        {
            Console.WriteLine("I am inside if ststement");
        }
        else
        {
            Console.WriteLine("I am inside else Statement");
        }
    }

    void LearnSwitch()
    {
        char option = 'y';

        switch(option)
        {
            case 'n':
            Console.WriteLine("Ending the task");
            break;

            case 'y':
            Console.WriteLine("Continuing the process..");
            break;

            default:
            Console.WriteLine("Invalid Option!");
            break;
        }

    }
}
