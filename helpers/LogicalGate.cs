
using Pc.helpers;

namespace LogicalGate
{
    static public class Gates
    {
        static public EBit Not(EBit a)
        {
            return a == EBit.Zero ? EBit.One : EBit.Zero;
        }
        static public EBit And(EBit a, EBit b)
        {
            return a == EBit.One && b == EBit.One ? EBit.One : EBit.Zero;
        }

        static public EBit Or(EBit a, EBit b)
        {
            return a == EBit.One || b == EBit.One ? EBit.One : EBit.Zero;
        }

        static public EBit Nand(EBit a, EBit b)
        {
            return Not(And(a, b));
        }

        static public EBit Nor(EBit a, EBit b)
        {
            return Not(Or(a, b));
        }

        static public EBit Xor(EBit a, EBit b)
        {
            return a != b ? EBit.One : EBit.Zero;
        }

        static public EBit Xnor(EBit a, EBit b)
        {
            return Not(Xor(a, b));
        }
    }
}