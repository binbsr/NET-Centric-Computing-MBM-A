class AccessModifier
{
    public void DoSomething()
    {

    }

    void DoAnotherThing()
    {

    }
}

class ModifierDemo
{
    void DoSomething()
    {
        AccessModifier accessModifier = new AccessModifier();
        accessModifier.DoSomething();
        Person person = new Person();
        person.name = "Utsav Kuinkel";
        person.address = "Mulpani";
        person.Age = 31;
    }
}