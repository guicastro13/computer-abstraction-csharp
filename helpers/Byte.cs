namespace Pc.helpers;
class Byte {
    public EBit[] _Byte { get; set; }
    public Byte() {
        _Byte = new EBit[8];
        for (int i = 0; i < 8; i++) {
            _Byte[i] = new EBit();
        }
    }
}