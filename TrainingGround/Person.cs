using System.Reflection.Metadata.Ecma335;

public class Person
{
    public Person(){}
    public Person(string name)
    {
        this.Name = name;
    }

    string testingMerge = "hhh";

    private string _name;
    public string Name {get=> _name ; set
        {
            if(value.Length > 5)
            _name= value;
        }
    }
    
    public int Birthyear;
    public double LengthInMeters;
}

