namespace GatedLatchTests 
{
    [TestFixture]
    public class GatedLatchTests
    {
        [Test]
        public void GatedLatch_Data1Write1CorrectResult()
        {
            Bit data = Bit.One;
            Bit writeEnable = Bit.One;
            Bit expected = Bit.One;

            Bit result = GatedLatch.Latch(data, writeEnable);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GatedLatch_Data1Write1WrongtResult()
        {
            Bit data = Bit.One;
            Bit writeEnable = Bit.One;
            Bit expected = Bit.Zero;

            Bit result = GatedLatch.Latch(data, writeEnable);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void GatedLatch_Data1Write0CorrectResult()
        {
            Bit data = Bit.One;
            Bit writeEnable = Bit.Zero;
            Bit expected = Bit.Zero;

            Bit result = GatedLatch.Latch(data, writeEnable);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GatedLatch_Data1Write0WrongResult()
        {
            Bit data = Bit.One;
            Bit writeEnable = Bit.Zero;
            Bit expected = Bit.One;

            Bit result = GatedLatch.Latch(data, writeEnable);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        public void GatedLatch_Data0Write1CorrectResult()
        {
            Bit data = Bit.Zero;
            Bit writeEnable = Bit.One;
            Bit expected = Bit.Zero;

            Bit result = GatedLatch.Latch(data, writeEnable);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GatedLatch_Data0Write1WrongResult()
        {
            Bit data = Bit.Zero;
            Bit writeEnable = Bit.One;
            Bit expected = Bit.One;

            Bit result = GatedLatch.Latch(data, writeEnable);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
    }
}