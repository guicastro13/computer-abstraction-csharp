using Pc.helpers;

namespace GatedLatchTests 
{
    [TestFixture]
    public class GatedLatchTests
    {
        [Test]
        public void GatedLatch_Data1Write1CorrectResult()
        {
            EBit data = EBit.One;
            EBit writeEnable = EBit.One;
            EBit expected = EBit.One;
            var letch = new GatedLatch();
            EBit result = letch.Access(data, writeEnable);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GatedLatch_Data1Write1WrongtResult()
        {
            EBit data = EBit.One;
            EBit writeEnable = EBit.One;
            EBit expected = EBit.Zero;
            var letch = new GatedLatch();
            EBit result = letch.Access(data, writeEnable);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void GatedLatch_Data1Write0CorrectResult()
        {
            EBit data = EBit.One;
            EBit writeEnable = EBit.Zero;
            EBit expected = EBit.Zero;
            var letch = new GatedLatch();
            EBit result = letch.Access(data, writeEnable);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GatedLatch_Data1Write0WrongResult()
        {
            EBit data = EBit.One;
            EBit writeEnable = EBit.Zero;
            EBit expected = EBit.One;
            var letch = new GatedLatch();
            EBit result = letch.Access(data, writeEnable);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        public void GatedLatch_Data0Write1CorrectResult()
        {
            EBit data = EBit.Zero;
            EBit writeEnable = EBit.One;
            EBit expected = EBit.Zero;
            var letch = new GatedLatch();
            EBit result = letch.Access(data, writeEnable);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GatedLatch_Data0Write1WrongResult()
        {
            EBit data = EBit.Zero;
            EBit writeEnable = EBit.One;
            EBit expected = EBit.One;
            var letch = new GatedLatch();
            EBit result = letch.Access(data, writeEnable);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void GetedLatch_handleMultipleAccess()
        {
            var letch = new GatedLatch();
            EBit result1 = letch.Access(EBit.One, EBit.One);
            Assert.That(result1, Is.EqualTo(EBit.One));
            EBit result2 = letch.Access(EBit.Zero, EBit.Zero);
            Assert.That(result2, Is.EqualTo(EBit.One));
            EBit result3 = letch.Access(EBit.Zero, EBit.One);
            Assert.That(result3, Is.EqualTo(EBit.Zero));
            EBit result4 = letch.Access(EBit.One, EBit.Zero);
            Assert.That(result4, Is.EqualTo(EBit.Zero));
        }
    }
}