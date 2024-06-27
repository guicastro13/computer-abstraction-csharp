namespace Pc.helpers.register;
[TestFixture]
public class Register16BitTests
{
    [Test]
    public void Register16Bit_CorrectSize()
    {
        Register16Bit register = new Register16Bit();
        int expected = 16;

        int result = register.content.Length;

        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void Register16Bit_WrongSize()
    {
        Register16Bit register = new Register16Bit();
        int expected = 15;

        int result = register.content.Length;

        Assert.That(result, Is.Not.EqualTo(expected));
    }
    [Test]
    public void Register16Bit_CorrectContentRegister()
    {
        Register16Bit register = new Register16Bit();
        string _byte = "0101010001010100";
        register.WriteFromString(_byte);
        string expected = "0101010001010100";
        Assert.That(register.Read(), Is.EqualTo(expected));
    }
}