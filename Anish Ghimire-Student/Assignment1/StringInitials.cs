using System;
public class StringInitials
{
    internal void NameInitials()
    {
        Console.WriteLine("Enter your Full Name:");
        string FullName=Console.ReadLine();
        int Len= FullName.Length;

        string Initials="";
        Initials= Initials+ FullName[0];

        for (int i=0; i<Len;i++)
        {
           if(FullName[i]== ' ')
           {
               Initials=Initials+FullName[++i];
               
           } 
           
        }
        Console.WriteLine($"Initial string of the name is:{Initials}");



    }
    
}