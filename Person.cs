using System;

public abstract class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Person(string name)
    {
        Name = name;
    }

    public abstract void ShowInfo();
}