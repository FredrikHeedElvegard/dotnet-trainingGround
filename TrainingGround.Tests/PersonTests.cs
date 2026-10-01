public class PersonTests
{
    [Fact]
    public void ParameterlessConstructor_CreatesPerson()
    {
        var p = new Person("hh");
    
        Assert.NotNull(p);
    }

    [Fact]
    public void ConstructorWithName_CreatesPerson()
    {
        var p =new Person("Fredrik");

        Assert.NotNull(p);
        Assert.Equal("Fredrik", p.Name);
    }

    [Fact]
    public void  ApersonBornIn1972_Is50_In2022()
    {
        var p = new Person();
        p.Birthyear = 1972; 
        //Hello from branch

        var age =p.GetAge(2022);

        Assert.Equal(50, age);
    }

}