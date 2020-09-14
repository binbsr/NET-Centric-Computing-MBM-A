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
        Console.Write("Enter any number: ");
        string input = Console.ReadLine();


    
        byte x = byte.Parse(input);
        if(x == 34)
        {
            Console.WriteLine("I am inside If statement");
        }
        else
        {
             Console.WriteLine("error");
        }
    }
    void LearnSwitch()
    {
        char option = 'y';
        switch(option)
        {
            case 'n':
            case 'x':
            Console.WriteLine("You opted for No.");
            break;
            case 'y':
            break;
            default:
            break;
        }
    }


    
}