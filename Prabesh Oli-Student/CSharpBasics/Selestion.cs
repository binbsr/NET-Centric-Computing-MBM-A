using System;
 class SelectionStatement{
static void Main(){
    SelectionStatement ss = new SelectionStatement();
    ItterationStatement itteration = new ItterationStatement();
    itteration.LearnLoop();
    ss.LearnIfelse();
    ss.LearnSwitch();
    itteration.LearnWhile();

}
void LearnIfelse(){
    Console.Write("Enter any number");
    String input = Console.ReadLine();
    
    byte x = byte.Parse(input);
    if(x==34){

        Console.WriteLine("I am student");

        }
        else 
        {
            Console.WriteLine("I am in else");
        }

    }
    void LearnSwitch(){
        char option = 'y';
        switch(option){
            case 'n':
            Console.WriteLine("you opted for no");
            break;
            case 'm':
             Console.WriteLine("you opted for no");
            break;
            case 'o':
             Console.WriteLine("you opted for no");
            break;
            case 'y':
             Console.WriteLine("you opted for Yes");
            break;
            default:
            break;


        }
    }
}