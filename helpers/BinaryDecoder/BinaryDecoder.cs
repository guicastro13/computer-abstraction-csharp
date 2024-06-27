namespace Pc.helpers
{
    public class BinaryDecoder4Bit
    {  
        public EBit[] Address = new EBit[4];
        private EBit[,] Memory = new EBit[4, 4];
        public void BinaryDecoder(EBit[] address, EBit readEnable, EBit writeEnable, EBit dataIn, EBit dataOut)
        {
            for (int i = 0; i < address.Length; i++)
            {
                Address[i] = address[i];
            }

        }
        private int BinaryToIndex(string binary)
        {
            return Convert.ToInt32(binary, 2);
        }
        public EBit GetMemoryValue(string binaryRow, string binaryColumn)
        {
            int rowIndex = BinaryToIndex(binaryRow);
            int columnIndex = BinaryToIndex(binaryColumn);
            return Memory[rowIndex, columnIndex];
        }
        
    }
}