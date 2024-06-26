namespace Pc.helpers;
public class Register(int size)
{
    public GatedLatch[] content = new GatedLatch[size];
}

