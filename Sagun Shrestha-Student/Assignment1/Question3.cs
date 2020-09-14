using System;

public class Question3
{
    
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

