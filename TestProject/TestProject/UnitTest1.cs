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
        Assert.False(!true);
        Assert.Empty(new string[0]);
    }
    
}