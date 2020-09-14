// A function that takes a two word string separated by space 
//and returns the concatenated first characters of both the words. 
//E.g. GetInitials("Bishnu Rawal") => "BR" 
//GetInitials("Alex Wales") => "AW"

using System;

public class GetInitials
{

    internal string Initials(string name)
    {

        string initial = "";
        for (int i = 0; i < name.Length; i++)
        {
            if (i == 0)
                initial += name[i];
            else if (name[i] == ' ')
            {
                initial += name[i+1];
            }
        }
        return initial;
    }

}