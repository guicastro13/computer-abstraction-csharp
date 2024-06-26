using LogicalGate;

namespace Pc.helpers
{
    [TestFixture]
    public class GatesTests
    {
        [Test]
        public void GateNot_ReturnsCorrectResult()
        {
            EBit a = EBit.One;
            EBit expected = EBit.Zero;

            EBit result = Gates.Not(a);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GateNot_ReturnsWrongResult()
        {
            EBit a = EBit.One;
            EBit expected = EBit.One;

            EBit result = Gates.Not(a);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void GateAnd_ReturnsCorrectResult()
        {
            EBit a = EBit.One;
            EBit b = EBit.One;
            EBit expected = a & b;

            EBit result = Gates.And(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GateAnd_ReturnWrongResult()
        {
            EBit a = EBit.One;
            EBit b = EBit.One;
            EBit expected = EBit.Zero;

            EBit result = Gates.And(a, b);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void Or_ReturnsCorrectResult()
        {
            EBit a = EBit.One;
            EBit b = EBit.Zero;
            EBit expected = a | b;

            EBit result = Gates.Or(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Or_ReturnsWrongResult()
        {
            EBit a = EBit.One;
            EBit b = EBit.Zero;
            EBit expected = EBit.Zero;

            EBit result = Gates.Or(a, b);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void GateXor_ReturnsCorrectResult()
        {
            EBit a = EBit.One;
            EBit b = EBit.Zero;
            EBit expected = a ^ b;

            EBit result = Gates.Xor(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GateXor_ReturnsWrongResult()
        {
            EBit a = EBit.One;
            EBit b = EBit.Zero;
            EBit expected = EBit.Zero;

            EBit result = Gates.Xor(a, b);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void GateXnor_ReturnsCorrectResult()
        {
            EBit a = EBit.One;
            EBit b = EBit.Zero;
            EBit expected = EBit.Zero;

            EBit result = Gates.Xnor(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GateXnor_ReturnsWrongResult()
        {
            EBit a = EBit.One;
            EBit b = EBit.Zero;
            EBit expected = EBit.One;

            EBit result = Gates.Xnor(a, b);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void GateNand_ReturnsCorrectResult()
        {
            EBit a = EBit.One;
            EBit b = EBit.One;
            EBit expected = EBit.Zero;

            EBit result = Gates.Nand(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GateNand_ReturnsWrongResult()
        {
            EBit a = EBit.One;
            EBit b = EBit.One;
            EBit expected = EBit.One;

            EBit result = Gates.Nand(a, b);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
        [Test]
        public void GateNor_ReturnsCorrectResult()
        {
            EBit a = EBit.One;
            EBit b = EBit.Zero;
            EBit expected = EBit.Zero;

            EBit result = Gates.Nor(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }  
        [Test]
        public void GateNor_ReturnsWrongResult()
        {
            EBit a = EBit.One;
            EBit b = EBit.Zero;
            EBit expected = EBit.One;

            EBit result = Gates.Nor(a, b);

            Assert.That(result, Is.Not.EqualTo(expected));
        }
    }
}