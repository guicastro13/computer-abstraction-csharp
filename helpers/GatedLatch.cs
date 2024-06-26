using LogicalGate;
using Pc.helpers;

public class GatedLatch
{
    private EBit wire1 = EBit.Zero;
    private EBit wire2 = EBit.Zero;
    private EBit wire3 = EBit.Zero;
    private EBit wire4 = EBit.Zero;

    public EBit Access(EBit data = EBit.Zero, EBit write = EBit.Zero)
    {
        wire1 = Gates.And(data, write);
        wire2 = Gates.Not(Gates.And(Gates.Not(data), write));
        EBit previousWire3, previousWire4;
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