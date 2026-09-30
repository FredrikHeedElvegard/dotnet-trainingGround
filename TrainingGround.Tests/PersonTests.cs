public class PersonTests
{
    [Fact]
    public void ParameterlessConstructor_CreatesPerson()
    {
        var p = new Person("hh");
    
        Assert.NotNull(p);
    }

    public void ConstructorWithName_CreatesPerson()
    {
        var p =new Person("Fredrik");

        Assert.NotNull(p);
        Assert.Equal("Fredrik", p.Name);
    }
}