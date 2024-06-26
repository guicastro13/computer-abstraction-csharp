namespace Pc.helpers;
    [TestFixture]
    public class RegisterTests
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
            string _byte = "01010101";
            register.WriteFromString(_byte);
            Console.WriteLine(register.ParseMemory());
        }
    }