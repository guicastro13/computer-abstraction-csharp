using LogicalGate;

namespace Pc.helpers;
public class SingleMemory 
{
    private GatedLatch gated = new GatedLatch();
    public EBit Access(EBit data ,EBit readEneble, EBit writeEneble)
    {
        EBit write = Gates.And(data, writeEneble);
        return gated.Access(data, write);
    }
}