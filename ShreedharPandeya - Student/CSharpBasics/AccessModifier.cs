using System;

class AccessModifier
{
public void DoSomething() //Access MOdifier for class in by default Internal(meaning can be used within project but while in functions by default it is private and needs tobe made internal or public)
{


}

void DoAnothetThing()
{
Person per = new Person();
per.addess = "Lalmatiya";
per.Age = 34;






}





}

class ModifierDemo{

    void DoSomething()
    {
        AccessModifier aM = new AccessModifier();
        aM.DoSomething();

    }
}