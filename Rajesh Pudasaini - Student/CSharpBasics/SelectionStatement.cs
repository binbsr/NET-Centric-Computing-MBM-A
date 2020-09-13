using System;

class SelectionStatement {

    static void Main2(){
        SelectionStatement obj1 = new SelectionStatement();
        obj1.LearnIfElse();
        obj1.LearnSwitch();
    }
    void LearnIfElse(){
        Console.Write("Enter an number: ");
        string y = Console.ReadLine();
        byte x = byte.Parse(y);
        if (x < 10){
            Console.WriteLine(x + " is less than 10");
        } else if (x > 10) {
            Console.WriteLine(x + " is greater than 10");
        } else {
            Console.WriteLine(x + " is equal to 10");
        }
    }

    void LearnSwitch(){
        //Switch Statement in C Sharp
        string option;
        Console.WriteLine("Option A\nOption B\nOption C");
        option = Console.ReadLine();

        switch(option) {
            case "a":
                Console.WriteLine("Oh you choose option A");
                break;
            
            case "b":
                Console.WriteLine("You choose option B");
                break;

            case "c":
                Console.WriteLine("You choose option C");
                break;

            case "d":
            case "e":
                Console.WriteLine("Option D and E");
                break;

            default:
                Console.WriteLine("Option is not in our list");
                break;
                
        }
    }
}
