using System.Text;

namespace Pc.helpers;
public class Register(int size)
{
    public GatedLatch[] content = new GatedLatch[size];
}

public class Register8Bit : Register
{
    public Register8Bit() 
        : base(8)
    {
        content = Enumerable.Repeat(new GatedLatch(), content.Length).ToArray();
        Console.WriteLine();
    }

    public StringBuilder ParseMemory() {
        var result = new StringBuilder();
        foreach(var bit in content)
        {
            result.Append(Bit.ParseEBITToChar(bit.Access()));
        }
        return result;
    }

    public void WriteFromString(string _byte)
    {
        for (var bit = 0; bit < _byte.Length; bit++)
        {
            content[bit].Access(Bit.ParseCharToEBIT(_byte[bit]), EBit.One);
        }
    }
}