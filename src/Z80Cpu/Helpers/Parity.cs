using OldBit.Z80Cpu.Registers;
using static OldBit.Z80Cpu.Registers.Flags;

namespace OldBit.Z80Cpu.Helpers;

/// <summary>
/// Contains parity lookup table for faster access instead of dynamic calculation.
/// </summary>
internal static class Parity
{
    /// <summary>
    /// Contains 256 pre-calculated even/odd parity flag value for each byte value (0-255).
    /// </summary>
    internal static readonly Flags[] Lookup =
    {
        P, 0, 0, P, 0, P, P, 0, 0, P, P, 0, P, 0, 0, P,
        0, P, P, 0, P, 0, 0, P, P, 0, 0, P, 0, P, P, 0,
        0, P, P, 0, P, 0, 0, P, P, 0, 0, P, 0, P, P, 0,
        P, 0, 0, P, 0, P, P, 0, 0, P, P, 0, P, 0, 0, P,
        0, P, P, 0, P, 0, 0, P, P, 0, 0, P, 0, P, P, 0,
        P, 0, 0, P, 0, P, P, 0, 0, P, P, 0, P, 0, 0, P,
        P, 0, 0, P, 0, P, P, 0, 0, P, P, 0, P, 0, 0, P,
        0, P, P, 0, P, 0, 0, P, P, 0, 0, P, 0, P, P, 0,
        0, P, P, 0, P, 0, 0, P, P, 0, 0, P, 0, P, P, 0,
        P, 0, 0, P, 0, P, P, 0, 0, P, P, 0, P, 0, 0, P,
        P, 0, 0, P, 0, P, P, 0, 0, P, P, 0, P, 0, 0, P,
        0, P, P, 0, P, 0, 0, P, P, 0, 0, P, 0, P, P, 0,
        P, 0, 0, P, 0, P, P, 0, 0, P, P, 0, P, 0, 0, P,
        0, P, P, 0, P, 0, 0, P, P, 0, 0, P, 0, P, P, 0,
        0, P, P, 0, P, 0, 0, P, P, 0, 0, P, 0, P, P, 0,
        P, 0, 0, P, 0, P, P, 0, 0, P, P, 0, P, 0, 0, P
    };
}