using System;
internal class Person
{
    private byte age;
    int grade;
    DateTime dob;
    public byte Age
    {       // property
        get { return age; }
        set
        {
            if (value > 30 && value < 40)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Error!!! age should be between 30 to 40.");
            }
        }
    }
    //Auto- implemented properties
    public string Address { get; set; }

    //Read-only 
    public string Name { get; }
}