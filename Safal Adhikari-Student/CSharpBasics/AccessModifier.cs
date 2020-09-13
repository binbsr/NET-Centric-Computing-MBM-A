//public can be used outside project
//internal can be used within the project only
//private can be used within the same class only.

class AccessModifier       //when there is none access modifier is mentioned in class then it is "internal"
{
    internal void DoSomething()
    {

    }

    public void DoAnotherThing()
    {
        DoSomething();
    }
}

class ModifierDemo
{
    /*void DoSomething() //when none access modifier is used in function, it is "private"
    {
       Person person = new Person();
       person.Age = 34;
       person.Age = 45;

    }*/
}