namespace Pc.helpers;

public static class Bit
{
    public static EBit ParseCharToEBIT(char c)
    {
        return c == '0' ? EBit.Zero : EBit.One;
    }

    public static char ParseEBITToChar(EBit bit)
    {
        return bit == EBit.Zero ? '0' : '1';
    }
}
public enum EBit {
    Zero = 0,
    One = 1,
}