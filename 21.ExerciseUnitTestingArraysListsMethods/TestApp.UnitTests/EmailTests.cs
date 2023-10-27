using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        string validEmail = "test@example.com";

        bool result = Email.IsValidEmail(validEmail);

        Assert.IsTrue(result);

    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        string invalidEmail = "alabala.com";

        bool result = Email.IsValidEmail(invalidEmail);

        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        string? nullInput = null;

        bool result = Email.IsValidEmail(nullInput);

        Assert.That(result, Is.False);
    }
}
