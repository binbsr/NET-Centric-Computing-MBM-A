using System;

class SelectionStatement
{
    static void Main4()
    {
        SelectionStatement ss =new SelectionStatement();
        ss.LearnIfElse();
    }

    void LearnIfElse()
    {
     Console.Write("Enter any number: ");
        string input = Console.ReadLine();
        byte x = byte.Parse(input);
 
        if(x == 34)
        {
            Console.WriteLine("You did enter 34");
        }
        else if(x == 20)
        {
            Console.WriteLine("You enteres 20");
        }
        else{
            Console.WriteLine("You didnt enter 34 and 20");
        }
    }
    void LearnSwitch()
    {
        char option = 'y';
        switch(option)
        {
            case 'n':
            case 'y':
            Console.WriteLine("You optioned for no");
            break;

            case 'z':
            case 'k':
             Console.WriteLine("You optioned for Yes");
            break;

            default:
             Console.WriteLine("Now you fcked up");
            break;
        }
    }
}