using System;

internal class Person
{
    byte age;
    private int grade;
    public string name;
    public string addess;
    private DateTime dateOfBirth;

    public byte Age{
        get { return age;}
        set{
            if(value > 30 && value < 40)
            {
                age = value;
            }
        }
    }

    //Auto Implemented properties
    public string Address{get; set;}

    public string Name { get; }



}