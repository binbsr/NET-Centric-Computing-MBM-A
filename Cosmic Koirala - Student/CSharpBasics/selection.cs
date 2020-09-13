using System;

class SelectionStatement
{
    static void Main2()
    {
        SelectionStatement ss = new SelectionStatement();
        ss.LearnSwitch();
    }

    void LearnIfElse()
    {
        Console.Write("Enter any number");
        string input=Console.ReadLine();
        byte x = byte.Parse(input);

        if(x==34)
        {
            Console.WriteLine("I am inside If Statement");
        }

        else
        {
            Console.WriteLine("I am inside else Statement");

        }
    }

    void LearnSwitch()
    {
        char option='y';
        switch(option)
        {
            case 'n':
            Console.WriteLine("You opted for nnn");
            break;
            
            case 'y':
            Console.WriteLine("You opted for yyy");
            break;

            case 'x':
            Console.WriteLine("You opted for xxx");
            break;

            case 'z':
            Console.WriteLine("You opted for zzz");
            break;

            default:
            Console.WriteLine("Cosmic dai");
            break;
        }
    }
}