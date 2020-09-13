using System;
internal class Properties{
byte age;
int grade;
public String name;
public String address;
DateTime dob;

public byte Age{
    get{
        return age;
    }
    set{
        if(value>30 && value<40)
        age=value;
    }
}
}