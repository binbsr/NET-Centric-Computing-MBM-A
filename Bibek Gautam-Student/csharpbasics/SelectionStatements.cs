using System;

class SelectionStatements{

    static void Main2(){
        SelectionStatements ss = new SelectionStatements();
        ss.LearnIfElse();
    }

    //methods should  always start with verb and follow PascalCase
    void LearnIfElse(){
        Console.Write("enter  any number: ");
        string input = Console.ReadLine();
        byte x = byte.Parse(input);
        if(x == 34){
            Console.WriteLine("I am inside if statement.");
        }

        else if (x==20){
            Console.WriteLine("You arein the elseif statement. You entered 20.");
        }
        else{
            Console.WriteLine("You are  in the else statement. You didn't enter 34.");
        }
    }

    void LearnSwitch(){
        char option = 'y';
        switch(option){
            case 'n':
            Console.WriteLine("You are in the n block.");
            break;
            
            case 's':
            Console.WriteLine("You are in the s block.");
            break;
            

            //grouping of cases
            case 'y':
            case 't':
            Console.WriteLine("You are in the y or t block.");
            break;
            
            case 'p':
            Console.WriteLine("You are in the p block.");
            break;

            default:
            Console.WriteLine("No cases matched.");
            break;
        }
    }
}