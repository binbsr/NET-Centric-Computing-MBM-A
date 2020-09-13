using System;

    class IterationStatement 
    {
        static void Main5(){
            IterationStatement i =new IterationStatement();
            i.LearnWhileLoop();
        }
        void LearnForLoop()
            {
                for (int i = 0; i< 10; i++){
                 Console.WriteLine("I am beautiful.");
            }

            int[] numbers = {34,5,6,78,90};

            foreach (int x in numbers )
            {
                if(x% 2== 0)
                {
                    Console.WriteLine($"{x} is even.");
                }
                else{
                    Console.WriteLine($"{x} is odd.");
                }
            }
        
        
    }
        void LearnWhileLoop()
        {
            int i= 0;
            while(i<10)
            {
                Console.WriteLine("I am BeautifuL.");
                i++;
            }
            //USECASE FOR ONLY WHILE
            Char confirm = 'y';
            while(confirm== 'y')
            {
                Console.WriteLine("I am in Loop");
                Console.WriteLine("Print one more time press 'y':");
                confirm = Console.ReadKey().KeyChar;
            }
            // Do while loop Example 
            do
            {
                Console.WriteLine("I am in Loop");
                Console.WriteLine("Print one more time press 'y':");
                confirm = Console.ReadKey().KeyChar;
            }
             while(confirm== 'y');
        }

}
