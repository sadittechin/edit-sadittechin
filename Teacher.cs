using System;

public class Teacher : Person
{
    public Teacher(string name) : base(name)
    {
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Teacher: " + Name);
    }
}