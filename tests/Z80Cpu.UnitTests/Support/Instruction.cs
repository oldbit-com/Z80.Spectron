using System.Collections.Immutable;

namespace OldBit.Z80Cpu.UnitTests.Support;

internal class Instruction
{
    public Instruction(string code)
    {
        var (mnemonic, operand) = GetMnemonic(code);
        Mnemonic = mnemonic.ToUpperInvariant();
        Operands = operand
            .Split(",")
            .Select(x => x.Trim())
            .ToImmutableArray();
    }

    private static (string Mnemonic, string Operand) GetMnemonic(string code)
    {
        var spacePos = code.Trim().IndexOf(' ');
        return spacePos == -1 ?
            (code, string.Empty) :
            (code[0..spacePos], code[spacePos..].Trim());
    }

    internal string Mnemonic { get; }

    internal ImmutableArray<string> Operands { get; }
}