using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
class Register {
    [FieldOffset(0)]
    public byte L;
    [FieldOffset(1)]
    public byte H;
    [FieldOffset(0)]
    public ushort HL;
}