namespace Pc.helpers.register;
    [TestFixture]
    public class Register8BitTests
    {
        [Test]
        public void Register8Bit_CorrectSize()
        {
            Register8Bit register = new Register8Bit();
            int expected = 8;

            int result = register.content.Length;

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Register8Bit_WrongSize()
        {
            Register8Bit register = new Register8Bit();
            int expected = 7;

            int result = register.content.Length;

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void Register8Bit_CorrectContentRegister()
        {
            Register8Bit register = new Register8Bit();
            string _byte = "01010100";
            register.WriteFromString(_byte);
            string expected = "01010100";
            Assert.That(register.Read(), Is.EqualTo(expected));
        }
    }