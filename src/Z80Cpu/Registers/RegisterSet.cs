using OldBit.Z80Cpu.Extensions;
using OldBit.Z80Cpu.Helpers;

namespace OldBit.Z80Cpu.Registers;

/// <summary>
/// Represents Z80 CPU registers.
/// </summary>
public sealed class RegisterSet : StandardRegisterSet
{
    internal RegisterContext Context { get; set; }

    /// <summary>
    /// Gets or sets the value of the I register.
    /// </summary>
    public byte I { get; set; }

    /// <summary>
    /// Gets or sets the value of the R register.
    /// </summary>
    public byte R { get; set; }

    /// <summary>
    /// Gets a alternative (prime) registers set.
    /// </summary>
    public StandardRegisterSet Prime { get; } = new();

    /// <summary>
    /// Gets or sets undocumented IXL register which is a low byte of the IX register.
    /// </summary>
    public byte IXL { get; set; }

    /// <summary>
    /// Gets or sets undocumented IXH register which is a high byte of the IX register.
    /// </summary>
    public byte IXH { get; set; }

    /// <summary>
    /// Gets or sets undocumented IYL register which is a low byte of the IY register.
    /// </summary>
    public byte IYL { get; set; }

    /// <summary>
    /// Gets or sets undocumented IYH register which is a high byte of the IY register.
    /// </summary>
    public byte IYH { get; set; }

    /// <summary>
    /// Gets or sets the value of the IX index register.
    /// </summary>
    public Word IX
    {
        get => Converter.ToWord(IXH, IXL);
        set => (IXH, IXL) = value;
    }

    /// <summary>
    /// Gets or sets the value of the IY index register.
    /// </summary>
    public Word IY
    {
        get => Converter.ToWord(IYH, IYL);
        set => (IYH, IYL) = value;
    }

    /// <summary>
    /// Gets or sets the value of the Program Counter register.
    /// </summary>
    public Word PC { get; set; }

    /// <summary>
    /// Gets or sets the value of the Stack Pointer register.
    /// </summary>
    public Word SP { get; set; }

    /// <summary>
    /// Gets or sets a value of either HL, IX or IY register depending on the current context.
    /// </summary>
    internal Word XHL
    {
        get => Context switch
        {
            RegisterContext.IX => IX,
            RegisterContext.IY => IY,
            _ => HL
        };
        set
        {
            switch (Context)
            {
                case RegisterContext.IX:
                    IX = value;
                    break;
                case RegisterContext.IY:
                    IY = value;
                    break;
                case RegisterContext.HL:
                default:
                    HL = value;
                    break;
            }
        }
    }

    /// <summary>
    /// Gets or sets a value either H, IXH or IYH register depending on the current context.
    /// </summary>
    internal byte XH
    {
        get => Context switch
        {
            RegisterContext.IX => IXH,
            RegisterContext.IY => IYH,
            _ => H
        };
        set
        {
            switch (Context)
            {
                case RegisterContext.IX:
                    IXH = value;
                    break;
                case RegisterContext.IY:
                    IYH = value;
                    break;
                case RegisterContext.HL:
                default:
                    H = value;
                    break;
            }
        }
    }

    /// <summary>
    /// Gets or sets a value either L, IXL or IYL register depending on the current context.
    /// </summary>
    internal byte XL
    {
        get => Context switch
        {
            RegisterContext.IX => IXL,
            RegisterContext.IY => IYL,
            _ => L
        };
        set
        {
            switch (Context)
            {
                case RegisterContext.IX:
                    IXL = value;
                    break;
                case RegisterContext.IY:
                    IYL = value;
                    break;
                case RegisterContext.HL:
                default:
                    L = value;
                    break;
            }
        }
    }

    /// <summary>
    /// Gets the value of the virtual IR register.
    /// </summary>
    internal Word IR => Converter.ToWord(I, R);

    /// <summary>
    /// Indicates whether IX or IY index register is in the current context.
    /// </summary>
    internal bool UseIndexRegister => Context is RegisterContext.IX or RegisterContext.IY;
}