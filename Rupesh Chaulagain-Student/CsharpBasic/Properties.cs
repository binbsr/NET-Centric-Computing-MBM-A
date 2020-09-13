using System;
internal class Person
{
    private byte age;
    int grade;
    public string name;
    public string adress;
    DateTime Dob;

    //getter-setter
    public byte Age
    {
        get {return age; }
        set
        {
            if(value > 30 && value<40)
            {
                age=value;
            }
        }
    }

    //Auto-Implemented Properties

    public string Address {get ; set;}

    // Read-Only
    public string Name{get; }
}
