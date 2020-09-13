using System;

class IterationStatement {

    static void Main3(){
        IterationStatement obj2 = new IterationStatement();
        obj2.LearnForLoop();
        obj2.LearnWhile();
    }

    int[] numArray = {1, 2, 3};
    void LearnForLoop(){
        int i;
        //forloop in c sharp
        for (i=0;i<10; i++){
            Console.WriteLine("I am good");
        }
        
        //foreach loop in c sharp
        foreach(int n in numArray){
            if (n%2 == 0){
                Console.WriteLine($"{n} is even");
            } else {
                Console.WriteLine($"{n} is odd");
            }
        }
    }

    void LearnWhile(){

        int i = 0 ;
        char confirm;

        while(i < 10){
            Console.WriteLine("Hello World");
            confirm = Console.ReadKey().KeyChar;
            Console.WriteLine(Console.ReadKey());
            i++;
        }
    }
}