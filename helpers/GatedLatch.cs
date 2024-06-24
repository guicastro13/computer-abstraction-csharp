using LogicalGate;

public static class GatedLatch
{
    private static Bit wire1 = Bit.Zero;
    private static Bit wire2 = Bit.Zero;
    private static Bit wire3 = Bit.Zero;
    private static Bit wire4 = Bit.Zero;

    public static Bit Latch(Bit data = Bit.Zero, Bit write = Bit.Zero)
    {
        wire1 = Gates.And(data, write);
        wire2 = Gates.Not(Gates.And(Gates.Not(data), write));
        Bit previousWire3, previousWire4;
        do
        {
            previousWire3 = wire3;
            previousWire4 = wire4;
            wire3 = Gates.Or(wire1, wire4);
            wire4 = Gates.And(wire3, wire2);
        } while (wire3 != previousWire3 || wire4 != previousWire4);

        return wire4;
    }
    
}