using System;
internal class Person
{
    private byte age;
    int grade;
    public string name;
    DateTime dob;
    public byte Age 
    {
        get{ return age; }
        set
        {
            if(value > 20 && value < 40)
            {
                age = value;
            } 
        }
    }
    // Auto Implemented Properties

    public string Address {get; set; }
    //Read Only
    public string Name { get; set; }
    

}