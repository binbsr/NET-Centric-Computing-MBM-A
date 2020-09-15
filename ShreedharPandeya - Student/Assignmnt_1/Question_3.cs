// Creates a function that takes a two word string separated by space and returns the concatenated first characters of both the words.
// E.g. 
// GetInitials("Bishnu Rawal") => "BR"
// GetInitials("Alex Wales") => "AW"


using System;

public class Abbre{

   internal void Initials()
   {
       Console.WriteLine("Enter your Full Name:");
       String name = Console.ReadLine();
       if(name.Length == 0)
            return;
        
        Console.Write(char.ToUpper(name[0]));

        for( int i = 0; i< name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    Console.Write(char.ToUpper(name[i+1]));
                }
            }
   }

}



