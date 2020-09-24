using System;
using System.IO;

public class FileIO
{
    public void LearnFileHandling()
    {
        string fileContent = File.ReadAllText(@"C:\Users\Dell\Desktop\Net Centric Practical\Aayam.Neupane\Instructions.txt");
        Console.WriteLine(fileContent);
        string fileName = "file.txt";
        if (File.Exists(fileName))
        {
            Console.WriteLine("File does exist");
        }
        else
            Console.WriteLine("The File doesnt exist");
    }

    public void LearnFileInfo()
    {
        string fileName = "file.txt";
        FileInfo fileInfo = new FileInfo(fileName);
        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;

        Console.WriteLine($"The file name is {fileName}");
        Console.WriteLine($"The file's size is {size} bytes");
        Console.WriteLine($"The file was created in {createdDate}");


    }

    public void LearnDirectories()
    {
        string directoryName = "A";
        Directory.CreateDirectory(directoryName);
    }
}

//Q2 Create a Folder "ABC", Create 10 subfolers in "ABC".
//Each subfolder should contain a C# file with hello world program