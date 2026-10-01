public class PersonTests
{
    [Fact]
    public void ParameterlessConstructor_CreatesPerson()
    {
        var p = new Person();
    
        Assert.NotNull(p);
    }

    [Fact]
    public void ConstructorWithName_CreatesPerson()
    {
        var p =new Person("Fredrik", 0, 0);

        Assert.NotNull(p);
        Assert.Equal("Fredrik", p.Name);
    }

    [Theory]
    [InlineData(1972, 50, 2022)]
    [InlineData(2022,0,2022)]
    public void  ApersonBornInX_IsY_InZ(int X, int Y, int Z)
    {
        var p = new Person("", X, 0);        
        //Hello from branch

        var age =p.GetAge(Z);

        Assert.Equal(Y, age);
    }

}