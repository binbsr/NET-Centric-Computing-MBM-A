using System;
class SelectionStatement
{
    static void Main2()
    {
        SelectionStatement ss= new SelectionStatement();
        ss.LearnIfElse();
        ss.LearnSwitch ();
    }
    void LearnIfElse()
    {
        Console.Write("Enter any number:");
        string input =Console.ReadLine();
        byte x= byte.Parse(input);
        if (x==3)
        {
            Console.WriteLine("i am Inside If statement");

        }
        else
        {
            Console.WriteLine("Outside If statement");

        }
    }
    void LearnSwitch ()
    {
        char option= 'y';
        switch(option)
        {
            case 'n':
            case 'x':
            Console.WriteLine("You opted for NO");
            break;

            case 'y':
            case 'z':
            Console.WriteLine("You opted for YES");
            break; 
            default :
            break;
        }
    }

}