using System;

class SelectionStatement
{
    static void Main2()
    {
        SelectionStatement ss = new SelectionStatement();
        ss.LearnIfElse();
    }

    void LearnIfElse()

    {
        Console.Write("Enter any number:");
        string input = Console.ReadLine();
        byte x = byte.Parse(input);
        if(x == 34)
        {
            Console.WriteLine("You enter 34");
        }
        else if(x==20)
        {
            Console.WriteLine("You enter 20");
        }
        else
        {
            Console.WriteLine("You didn't enter what we expected.");
        }
    }

    void LearnSwitch()
    {
        char option ='y';
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
            Console.WriteLine("None of the cases matched");
            break;
        }
    }
}