namespace Pc.helpers.register;
public class Register(int size)
{
    public GatedLatch[] content = new GatedLatch[size];
}

