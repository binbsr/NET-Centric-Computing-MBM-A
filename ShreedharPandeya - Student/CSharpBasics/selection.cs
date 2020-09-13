
using System;
class selectionstatement
{

    static void Main1()
    {
        selectionstatement ss = new selectionstatement();
        //ss.LearnIfElse();
        ss.LearnSwitch();
        iterationStatement i = new iterationStatement();
        i.LearnForLoop();
        i.LearnWhileLoop();
        MethodTeacher mt = new MethodTeacher();
        double x = mt.Sum(12, 14);
        Console.WriteLine($"The sum is {x}");



    }
    void LearnIfElse()
    {
        // byte x = 34;
        // if(x == 34)
        // {
        //     Console.Write("It is correct");

        // }

        Console.Write("Enter any number: ");
        string input = Console.ReadLine();
        byte x = byte.Parse(input);

        if (x == 34)
        {
            Console.Write("You did enter 34");
        }
        else
        {
            Console.Write("You didnt enter 34");
        }

    }
    void LearnSwitch()
    {
        char option = 'y';

        switch (option)
        {
            case 'n':
                Console.WriteLine("You opted for no");
                break;

            case 'y':
                Console.WriteLine("You opted for yes");
                break;

            case 'x':
                Console.WriteLine("You opted for xes");
                break;

            default:
                break;
        }

    }



}

