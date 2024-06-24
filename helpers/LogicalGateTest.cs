using LogicalGate;

namespace LogicalGateTests
{
    [TestFixture]
    public class GatesTests
    {
        [Test]
        public void GateNot_ReturnsCorrectResult()
        {
            Bit a = Bit.One;
            Bit expected = Bit.Zero;

            Bit result = Gates.Not(a);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GateAnd_ReturnsCorrectResult()
        {
            Bit a = Bit.One;
            Bit b = Bit.One;
            Bit expected = a & b;

            Bit result = Gates.And(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Or_ReturnsCorrectResult()
        {
            Bit a = Bit.One;
            Bit b = Bit.Zero;
            Bit expected = a | b;

            Bit result = Gates.Or(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GateXor_ReturnsCorrectResult()
        {
            Bit a = Bit.One;
            Bit b = Bit.Zero;
            Bit expected = a ^ b;

            Bit result = Gates.Xor(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GateAnd_WithDifferentBits_ReturnsZero()
        {
            Bit a = Bit.One;
            Bit b = Bit.Zero;
            Bit expected = Bit.Zero;

            Bit result = Gates.And(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GateOr_WithDifferentBits_ReturnsOne()
        {
            Bit a = Bit.One;
            Bit b = Bit.Zero;
            Bit expected = Bit.One;

            Bit result = Gates.Or(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GateNot_WithZero_ReturnsOne()
        {
            Bit a = Bit.Zero;
            Bit expected = Bit.One;

            Bit result = Gates.Not(a);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GateNot_WithOne_ReturnsZero()
        {
            Bit a = Bit.One;
            Bit expected = Bit.Zero;

            Bit result = Gates.Not(a);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}