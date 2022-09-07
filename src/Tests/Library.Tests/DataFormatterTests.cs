using TestDateFormat;
namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormat()
    {
        string testDate = "12/11/1996";
        string fechaCambiada = DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual(fechaCambiada, "1996-11-12");

    }
    
    [Test]
    public void NotCorrectFormat()
    {
        string testDate = "12/1990/19";
        string fechaCambiada = DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual(fechaCambiada, "Formato inválido.");
    }
    [Test]
    public void BlankSpace()
    {
        string testDate = "";
        string fechaCambiada = DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual(fechaCambiada, "");
    }
}