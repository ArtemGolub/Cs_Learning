namespace ConsoleLearning.Enums;

[Flags]
public enum BorderSide: byte
{
    None = 0,
    Left = 1,
    Right = 1<<1,
    Top = 1<<2,
    Bottom = 1<<3,
    All = Left | Right | Top | Bottom
}