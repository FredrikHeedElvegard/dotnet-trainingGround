using System.Reflection.Metadata.Ecma335;

public class Person
{
    public Person(){}
    public Person(string name) => Name=name;

    public Person(string name, int birthYear)
    {
        Name= name;
        Birthyear=birthYear;
    }

    public string? Name {get;private set;}
    
    public int Birthyear {get; private set;}
    public double LengthInMeters;

    public int GetAge(int currentYear)
    {
        return currentYear -Birthyear;
    }
}

