using System.Runtime.InteropServices;

namespace Bio.Win32;

[StructLayout(LayoutKind.Sequential)]
public struct POINT
{
    public int x;
    public int y;

    public override string ToString()
    {
        return $"X:{x} Y:{y}";
    }
}
