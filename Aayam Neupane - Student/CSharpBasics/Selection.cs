using System;

class SelectionStatement
{
    static void Main23()
    {
        SelectionStatement ss = new SelectionStatement();
        ss.LearnIfElse();
    }
    void LearnIfElse()
    {
        Console.Write("Enter any number: ");
        string input  = Console.ReadLine();
        byte x = byte.Parse(input);

        if(x==34)
        {
            Console.WriteLine("I am inside If statement");
        }
        else{
            Console.WriteLine("Invalid value");
        }
    }

    void LearnSwitchCase()
    {
        char option = 'y';
        switch(option)
        {
            case 'n':
            Console.WriteLine("You chose No.");
            break;

            case 'p':
            Console.WriteLine("You chose Yes.");
            break;

            case 'y':
            Console.WriteLine("You chose Yes.");
            break;

            default:
            Console.WriteLine("Invalid Option.");
            break;

        }
    }
}
