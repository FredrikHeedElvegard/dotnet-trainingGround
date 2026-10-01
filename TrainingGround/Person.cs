using System.Reflection.Metadata.Ecma335;

public class Person
{
    public Person(){}
    public Person(string name)
    {
        this.Name = name;
    }

    public string? Name {get;private set;}
    
    public int Birthyear;
    public double LengthInMeters;
}

