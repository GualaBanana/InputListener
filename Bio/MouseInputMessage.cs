//MIT License

//Copyright (c) 2022 GualaBanana

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System.Runtime.InteropServices;
using Bio.Win32;

namespace Bio;

/// <summary>
/// The managed wrapper for a low-level mouse input message.
/// </summary>
public class MouseInputMessage
{
    /// <summary>
    /// The identifier of the mouse message specifying the system action.
    /// </summary>
    public WM WM;
    /// <summary>
    /// The structure containing the mouse input data.
    /// </summary>
    public MSLLHOOKSTRUCT MSLLHOOKSTRUCT;

    /// <summary>
    /// Instantiates the wrapper for a low-level mouse input message.
    /// </summary>
    /// <param name="WM"><inheritdoc cref="WM"/></param>
    /// <param name="MSLLHOOKSTRUCT"><inheritdoc cref="MSLLHOOKSTRUCT"/></param>
    public MouseInputMessage(IntPtr WM, IntPtr MSLLHOOKSTRUCT) 
        : this((WM)WM, Marshal.PtrToStructure<MSLLHOOKSTRUCT>(MSLLHOOKSTRUCT))
    {
    }

    MouseInputMessage(WM WM, MSLLHOOKSTRUCT MSLLHOOKSTRUCT)
    {
        this.WM = WM;
        this.MSLLHOOKSTRUCT = MSLLHOOKSTRUCT;
    }

    public override string ToString()
    {
        return $"\r\nWM: {WM} {MSLLHOOKSTRUCT.ToString(WM)}";
    }
}
