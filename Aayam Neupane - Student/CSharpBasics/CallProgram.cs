using System;
using System.IO;
using LearnCollections;
using System.Linq;

public class CallProgram
{
    static void Main()
    {

        string countriesText = File.ReadAllText("Countries.txt");
        string[] countries = countriesText.Split("\r\n");

        var countriesWithInitial = countries.Select(x => x.StartsWith("N")).ToArray();

        foreach (var country in countriesWithInitial)
        {
            Console.WriteLine(country);
        }




        /*FileIO fileIO = new FileIO();
        fileIO.LearnFileHandling();
        fileIO.LearnFileInfo();
        fileIO.LearnDirectories();*/

        /*var square = new Square(34.56);
        square.Display();

        var rectangle = new Rectangle(34.56, 55.14);
        rectangle.Display();*/



    }
}