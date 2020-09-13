using System;

class SelectionStatement
{
    static void Main4()
    {
        SelectionStatement s1 = new SelectionStatement();
        // s1.LearnIfElse();
        // s1.LearnSwitch();
        IterationStatement i1 = new IterationStatement();
        i1.LearnForLoop();
        i1.LearnWhileLoop();
    }
    void LearnIfElse()
    {
        Console.Write("Enter the number: ");
        string input = Console.ReadLine();

        byte x = byte.Parse(input);

        if (x == 34)
        {
            Console.WriteLine("Wohoo, you got into if statement");
        }
        else if (x == 24)
        {
            Console.Write("I dont want 24 you moron");
        }
        else
        {
            Console.WriteLine("Ohhoh, You didnot got into if statement, but be happy, you are inside the else");
        }
    }

    void LearnSwitch()
    {
        char option = 't';

        switch (option)
        {
            case 't':
                Console.WriteLine("Print you pressed t");
                break;
            case 'y':
                Console.WriteLine("Print you pressed y");
                break;
            default:
                Console.WriteLine("I only know y and t");
                break;
        }
    }
}