namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    [Fact]
    public void FalseisFalseAndStringIsEmpty()
    {
        //this was stupid
        Assert.True(!false);
        Assert.False(!true);
        Assert.Empty(new string[0]);
    }
    
}
