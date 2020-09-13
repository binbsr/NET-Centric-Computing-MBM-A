using System;
namespace EnumsAndProperties
{
    internal class Person
{
    private int age;
    private int grade;
    public string name;
    public string address;
    private DateTime dob;
    //


    //getter setter
    public byte Age
    {
        get { return Age; }
        set
        {
            if (value > 30 && value < 40)
            {
                Age = value;
            }
        }
    }
    //Auto implemented Properties
    public string Address { get; set; }
    public string Name { get; }
    //read Only


}

}
