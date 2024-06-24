
namespace LogicalGate
{
    static public class Gates
    {
        static public Bit Not(Bit a)
        {
            return a == Bit.Zero ? Bit.One : Bit.Zero;
        }
        static public Bit And(Bit a, Bit b)
        {
            return a == Bit.One && b == Bit.One ? Bit.One : Bit.Zero;
        }

        static public Bit Or(Bit a, Bit b)
        {
            return a == Bit.One || b == Bit.One ? Bit.One : Bit.Zero;
        }

        static public Bit Nand(Bit a, Bit b)
        {
            return Not(And(a, b));
        }

        static public Bit Nor(Bit a, Bit b)
        {
            return Not(Or(a, b));
        }

        static public Bit Xor(Bit a, Bit b)
        {
            return a != b ? Bit.One : Bit.Zero;
        }

        static public Bit Xnor(Bit a, Bit b)
        {
            return Not(Xor(a, b));
        }
    }
}