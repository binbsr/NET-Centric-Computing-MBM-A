//Creates a function that takes a two word string separated by space and returns the concatenated first characters of both the words. 
//E.g. GetInitials("Bishnu Rawal") => "BR" GetInitials("Alex Wales") => "AW"

using System;
class GetFirstLetterWord {

    internal void Execute(){
        Console.WriteLine("\n\n\n\n#######-------Question 3-------#######");
        GetFirstLetterWord obj1 = new GetFirstLetterWord();
        Console.WriteLine("Enter Your Name: ");
        string userName = Console.ReadLine();
        string res = obj1.SplitWord(userName);
        Console.WriteLine($"Result: {res}");
    }

    string SplitWord(string name){
        var res = name.Split(" ");
        string finalResult = "";
        foreach(string word in res){
            finalResult += word.Substring(0, 1);
        }
        return finalResult;
    }
}