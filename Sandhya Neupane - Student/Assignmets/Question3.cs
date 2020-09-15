// Creates a function that takes a two word string separated by space and returns the concatenated first characters of both the words. E.g. GetInitials("Bishnu Rawal") => "BR" GetInitials("Alex Wales") => "AW"

using System;

public class StrConcatinate
{
    internal string GetInitials()
    {
        Console.WriteLine("Two word string: ");
        string name = Console.ReadLine();
        int length = name.Length;
        string first = "";
        first = first + name[0]; 
        int i = 0;
        for (i = 0; i <  length; i++)
        {
            if (name[i] == ' ')
            {
                first = first + name[i+1];
                break;
            }
        }
        
        return first;

    }
}