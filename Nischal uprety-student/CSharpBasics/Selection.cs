

using System;

class SelectionStatement
{
    static void Main2()
    {
        SelectionStatement ss=new SelectionStatement();
        ss.LearnIfElse();
    }
    void LearnIfElse()
    {
        Console.Write("enter any number");
        String input=Console.ReadLine();
        byte x= byte.Parse(input);

        if(x==34)
        {
            Console.WriteLine("i am inside If statement");
        }
        else if(x==20)
        {
            Console.WriteLine("you entered 20");
        }
        else
        {
            Console.WriteLine("you did not enter as we expected");
        }

    }
    void LearnSwitch()
    {
        char option = 'y';

        switch(option)
        {
            case 'x':
            Console.WriteLine("you opted NO");
            break;

            case 'y':
            Console.WriteLine("you opted yes");
            break;

            default:
            Console.WriteLine("no cases");
            break;
        }
    }
}

