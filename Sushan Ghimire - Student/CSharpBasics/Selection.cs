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
        Console.Write("Enter any number::");
        string input = Console.ReadLine(); //input will be entered as a string always
        byte x = byte.Parse(input); //converts input string to byte type
        
        if(x == 34)
        {
            Console.WriteLine("The value of x is 34");
        }
        else if(x == 20)
        {
            Console.WriteLine("The value of x is 20");
        }
        else
        {
            Console.WriteLine("The value of x is not 20 or 30");
        }
    }

    void LearnSwitch()
    {
        char option = 'a';
        switch(option)
        {
            case 'n':
            Console.WriteLine("You Clicked n");
            break;

            case 'y':
            case 'Y': //we can group both the cases if they perform the similar task
            Console.WriteLine("You Clicked y");
            break;

            case 'x':
            Console.WriteLine("You Clicked x");
            break;

            default:
            Console.WriteLine("You Clicked extra value");
            break;      
        }
    }
}

