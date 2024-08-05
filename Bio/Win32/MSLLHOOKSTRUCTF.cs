namespace Bio.Win32;

[Flags]
public enum MSLLHOOKSTRUCTF : uint
{
    LLMHF_INJECTED = 0x01,
    LLMHF_LOWER_IL_INJECTED = 0x02,
}