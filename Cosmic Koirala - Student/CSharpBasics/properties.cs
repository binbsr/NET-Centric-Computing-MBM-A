using System;

internal class Person
{
    private byte age;
    private int grade;
    private DateTime dob;

    //getter
    public byte Age
    {
        get { return age;}
        set
        {
            if(value > 30 && value < 40)
            {
                age = value;
            }
        }
    }
    
    // Auto-inplemented properties

    public string Address{get;set;}

    //Read Only
    public string Name { get;  }
}