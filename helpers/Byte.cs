class Byte {
    public Bit[] _byte { get; set; }
    public Byte() {
        _byte = new Bit[8];
        for (int i = 0; i < 8; i++) {
            _byte[i] = new Bit();
        }
    }
}