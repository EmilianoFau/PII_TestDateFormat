namespace TestDateFormat;

public class DateFormatterTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestCorrectFormat()
    {
        string testDate = DateFormatter.ChangeFormat("11/12/2012");
        Assert.AreEqual(testDate, "2012-12-11");
    }

    [Test]
    public void TestIncorrectFormat()
    {
        string testDate = DateFormatter.ChangeFormat("11.12.2012");
        Assert.AreEqual(testDate, "2012-12-11");
    }

    [Test]
    public void TestBlank()
    {
        string testDate = DateFormatter.ChangeFormat("");
        Assert.AreEqual(testDate, "");
    }
}