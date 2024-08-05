using System.Runtime.InteropServices;

namespace Bio.Win32;

[StructLayout(LayoutKind.Explicit)]
public struct DWORD
{
    [FieldOffset(0)]
    public uint Value;

    [FieldOffset(0)]
    public ushort Low;

    [FieldOffset(2)]
    public ushort High;
}