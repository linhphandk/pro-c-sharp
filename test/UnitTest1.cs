namespace test;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        String username = "1234";
        String password = "1234";
        User u = new(username, password);

    }
    [Fact]
    public void Test2()
    {
        Assert.Throws<UsernameException>(() => new User("", "1233456"));

    }

}
