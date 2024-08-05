using System.Runtime.InteropServices;

namespace Bio.Win32;

[StructLayout(LayoutKind.Sequential)]
public struct MSLLHOOKSTRUCT
{
    public POINT pt;
    public DWORD mouseData;
    public MSLLHOOKSTRUCTF flags;
    public uint time;
    public UIntPtr dwExtraInfo;

    public override string ToString()
    {
        return $"POINT: {pt} mouseData:{mouseData} FLAGS:{flags} time:{time} dwExtraInfo:{dwExtraInfo}";
    }

    public string ToString(WM? wm = WM.WM_MOUSEMOVE)
    {
        string strMouseData = mouseData.Value.ToString();
        switch (wm)
        {
            case WM.WM_MOUSEWHEEL:
                var delta = (short)mouseData.High;
                strMouseData = $"WHEEL_DELTA:{delta}";

                break;
            case WM.WM_XBUTTONDOWN:
            case WM.WM_XBUTTONUP:
            case WM.WM_XBUTTONDBLCLK:
            case WM.WM_NCXBUTTONDOWN:
            case WM.WM_NCXBUTTONUP:
            case WM.WM_NCXBUTTONDBLCLK:
                var xbutton = (MSLLHOOKSTRUCTM)mouseData.High;
                strMouseData = $"XB:{xbutton}";
                break;
        }
        return $"POINT: {pt} mouseData:{strMouseData} FLAGS:{flags} time:{time} dwExtraInfo:{dwExtraInfo}";
    }
}