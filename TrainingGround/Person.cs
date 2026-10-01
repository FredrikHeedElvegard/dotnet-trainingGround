using System.Reflection.Metadata.Ecma335;

public class Person
{
    public Person(){}
    public Person(string name, int birthYear, double lengthInMeters)
    {
        Name=name;
        Birthyear=birthYear;
        LengthInMeters = lengthInMeters;
    }

    public string? Name {get;private set;}
    
    public int Birthyear {get; private set;}
    public double LengthInMeters {get; private set;}

    public int GetAge(int currentYear)
    {
        return currentYear -Birthyear;
    }
}

