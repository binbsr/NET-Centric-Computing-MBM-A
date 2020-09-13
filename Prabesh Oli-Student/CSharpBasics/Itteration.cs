using System;

class ItterationStatement{
    internal void LearnLoop(){
        int i = 0;
        for(i=0; i<10;i++){
        Console.WriteLine("I am boy");

        }
    }
    internal void LearnWhile(){
      
      char confirm = 'y';
      while(confirm=='y'){
          Console.WriteLine("i am boy");
          Console.WriteLine("you want to continue");
          confirm = Console.ReadKey().KeyChar;
      }
    }

}