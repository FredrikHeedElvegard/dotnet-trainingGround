using System.Reflection.Metadata.Ecma335;
using TrainingGround;

public class Person
{
    public Person(){}
    public Person(string name, int birthYear, double lengthInMeters)
    {
        Name=name;
        Birthyear=birthYear;
        LengthInMeters = lengthInMeters;
    }

    public Address Address {get;private set;}
    public string? Name {get;private set;}
    
    public int Birthyear {get; private set;}
    public double LengthInMeters {get; private set;}

    public int GetAge(int currentYear)
    {
        return currentYear -Birthyear;
    }
}

