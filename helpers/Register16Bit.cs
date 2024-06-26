using System.Text;

namespace Pc.helpers;
public class Register16Bit: Register
{
    public Register16Bit() 
        : base(16)
    {
        content = Enumerable.Range(0, content.Length).Select(_ => new GatedLatch()).ToArray();
    }

    public void WriteFromString(string _byte)
    {
        for (var bit = 0; bit < content.Length; bit++)
        {
            content[bit].Access(Bit.ParseCharToEBIT(_byte[bit]), EBit.One);
        }
    }

    public string Read()
    {
        var result = new StringBuilder();
        foreach(var bit in content)
        {
            result.Append(Bit.ParseEBITToChar(bit.Access()));
        }
        return result.ToString();
    }
}