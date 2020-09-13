using System;
class AccessModifier
{
    internal void DoSomething()
    {

    }
    public void DoAnotherThing()
    {

    }
}

class ModifierDemo
{
    void DoSomething()
    {
        Person person = new Person();
        person.Age = 24;
        person.Age = 45;
    }

   
}