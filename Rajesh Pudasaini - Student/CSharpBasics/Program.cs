using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main1(string[] args)
        {
            string store;
            Console.WriteLine("Hello World!");
            Console.Write("No Line");
            Console.WriteLine("Line");
            store = Console.ReadLine();
            Console.Write(store);

            //1.1Numbers in C#
                // 1.1.1 Integers data type:
                //byte (max -> 255 (8 bit)), short (16 bit), int, longint

                //1.1.2 Floating Point Numbers:
                //float
                float a = 1.2f; //accept 6-9 digit after decimal -> accuracy is low
                double c = 123.456; //accuracy better than float
                decimal b = 123.45m; //accuracy better than float and double

            //1.2 Characters in C#
                char h = 'a';

            //3 Booleans
                bool i = true; //or false

            //2.Reference Types:
            string j = "werjkfsdsds";
            object k = false; //we can assign any type
        }

        int GetNumber(){
            
            return 1234;
        }
    }
}
