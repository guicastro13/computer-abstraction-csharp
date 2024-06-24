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
        public void GateNot_ReturnsWrongResult()
        {
            Bit a = Bit.One;
            Bit expected = Bit.One;

            Bit result = Gates.Not(a);

            Assert.That(result, Is.Not.EqualTo(expected));
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
        public void GateAnd_ReturnWrongResult()
        {
            Bit a = Bit.One;
            Bit b = Bit.One;
            Bit expected = Bit.Zero;

            Bit result = Gates.And(a, b);

            Assert.That(result, Is.Not.EqualTo(expected));
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
        public void Or_ReturnsWrongResult()
        {
            Bit a = Bit.One;
            Bit b = Bit.Zero;
            Bit expected = Bit.Zero;

            Bit result = Gates.Or(a, b);

            Assert.That(result, Is.Not.EqualTo(expected));
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
        public void GateXor_ReturnsWrongResult()
        {
            Bit a = Bit.One;
            Bit b = Bit.Zero;
            Bit expected = Bit.Zero;

            Bit result = Gates.Xor(a, b);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void GateXnor_ReturnsCorrectResult()
        {
            Bit a = Bit.One;
            Bit b = Bit.Zero;
            Bit expected = Bit.Zero;

            Bit result = Gates.Xnor(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GateXnor_ReturnsWrongResult()
        {
            Bit a = Bit.One;
            Bit b = Bit.Zero;
            Bit expected = Bit.One;

            Bit result = Gates.Xnor(a, b);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void GateNand_ReturnsCorrectResult()
        {
            Bit a = Bit.One;
            Bit b = Bit.One;
            Bit expected = Bit.Zero;

            Bit result = Gates.Nand(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GateNand_ReturnsWrongResult()
        {
            Bit a = Bit.One;
            Bit b = Bit.One;
            Bit expected = Bit.One;

            Bit result = Gates.Nand(a, b);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void GateNor_ReturnsCorrectResult()
        {
            Bit a = Bit.One;
            Bit b = Bit.Zero;
            Bit expected = Bit.Zero;

            Bit result = Gates.Nor(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }  
        [Test]
        public void GateNor_ReturnsWrongResult()
        {
            Bit a = Bit.One;
            Bit b = Bit.Zero;
            Bit expected = Bit.One;

            Bit result = Gates.Nor(a, b);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
    }
}