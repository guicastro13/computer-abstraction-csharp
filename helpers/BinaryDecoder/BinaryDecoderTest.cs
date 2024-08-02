using Pc.helpers;

namespace BinaryDecoderTest
{
    [TestFixture]
    public class BinaryDecoderTests
    {
        [Test]
        public void BinaryDecoder4Bit_AddressIsCorrect()
        {
            EBit[] address = new EBit[4] { EBit.Zero, EBit.One, EBit.Zero, EBit.One };
            EBit readEnable = EBit.One;
            EBit writeEnable = EBit.Zero;
            EBit dataIn = EBit.Zero;
            EBit dataOut = EBit.Zero;
            var decoder = new BinaryDecoder4Bit();
            decoder.BinaryDecoder(address, readEnable, writeEnable, dataIn, dataOut);

            Assert.That(decoder.Address, Is.EqualTo(address));
        }

        [Test]
        public void BinaryDecoder4Bit_GetMemoryValueIsCorrect()
        {
            EBit[] address = new EBit[4] { EBit.Zero, EBit.One, EBit.Zero, EBit.One };
            EBit readEnable = EBit.One;
            EBit writeEnable = EBit.Zero;
            EBit dataIn = EBit.Zero;
            EBit dataOut = EBit.Zero;
            var decoder = new BinaryDecoder4Bit();
            decoder.BinaryDecoder(address, readEnable, writeEnable, dataIn, dataOut);

            EBit expected = EBit.Zero;
            EBit result = decoder.GetMemoryValue("00", "00");

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}