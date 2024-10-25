namespace OldBit.Z80Cpu.OpCodes;

/// <summary>
/// Provides a mapping of Z80 opcodes to their respective byte values.
/// </summary>
internal static class OpCodesMapping
{
    internal static int GetCode(string opCode) => Map[opCode];

    private static readonly Dictionary<string, int> Map = new(StringComparer.OrdinalIgnoreCase)
    {
        // Primary instructions
        { "NOP", 0x00 }, { "LD BC,nn", 0x01 }, { "LD (BC),A", 0x02 }, { "INC BC", 0x03 }, { "INC B", 0x04 }, { "DEC B", 0x05 }, { "LD B,n", 0x06 }, { "RLCA", 0x07 },
        { "EX AF,AF", 0x08 }, { "ADD HL,BC", 0x09 }, { "LD A,(BC)", 0x0A }, { "DEC BC", 0x0B }, { "INC C", 0x0C }, { "DEC C", 0x0D }, { "LD C,n", 0x0E }, { "RRCA", 0x0F },
        { "DJNZ", 0x10 }, { "LD DE,nn", 0x11 }, { "LD (DE),A", 0x12 }, { "INC DE", 0x13 }, { "INC D", 0x14 }, { "DEC D", 0x15 }, { "LD D,n", 0x16 }, { "RLA", 0x17 },
        { "JR e", 0x18 }, { "ADD HL,DE", 0x19 }, { "LD A,(DE)", 0x1A }, { "DEC DE", 0x1B }, { "INC E", 0x1C }, { "DEC E", 0x1D }, { "LD E,n", 0x1E }, { "RRA", 0x1F },
        { "JR NZ,e", 0x20 }, { "LD HL,nn", 0x21 }, { "LD (nn),HL", 0x22 }, { "INC HL", 0x23 }, { "INC H", 0x24 }, { "DEC H", 0x25 }, { "LD H,n", 0x26 }, { "DAA", 0x27 },
        { "JR Z,e", 0x28 }, { "ADD HL,HL", 0x29 }, { "LD HL,(nn)", 0x2A }, { "DEC HL", 0x2B }, { "INC L", 0x2C }, { "DEC L", 0x2D }, { "LD L,n", 0x2E }, { "CPL", 0x2F },
        { "JR NC,e", 0x30 }, { "LD SP,nn", 0x31 }, { "LD (nn),A", 0x32 }, { "INC SP", 0x33 }, { "INC (HL)", 0x34 }, { "DEC (HL)", 0x35 }, { "LD (HL),n", 0x36 }, { "SCF", 0x37 },
        { "JR C,e", 0x38 }, { "ADD HL,SP", 0x39 }, { "LD A,(nn)", 0x3A }, { "DEC SP", 0x3B }, { "INC A", 0x3C }, { "DEC A", 0x3D }, { "LD A,n", 0x3E }, { "CCF", 0x3F },
        { "LD B,B", 0x40 }, { "LD B,C", 0x41 }, { "LD B,D", 0x42 }, { "LD B,E", 0x43 }, { "LD B,H", 0x44 }, { "LD B,L", 0x45 }, { "LD B,(HL)", 0x46 }, { "LD B,A", 0x47 },
        { "LD C,B", 0x48 }, { "LD C,C", 0x49 }, { "LD C,D", 0x4A }, { "LD C,E", 0x4B }, { "LD C,H", 0x4C }, { "LD C,L", 0x4D }, { "LD C,(HL)", 0x4E }, { "LD C,A", 0x4F },
        { "LD D,B", 0x50 }, { "LD D,C", 0x51 }, { "LD D,D", 0x52 }, { "LD D,E", 0x53 }, { "LD D,H", 0x54 }, { "LD D,L", 0x55 }, { "LD D,(HL)", 0x56 }, { "LD D,A", 0x57 },
        { "LD E,B", 0x58 }, { "LD E,C", 0x59 }, { "LD E,D", 0x5A }, { "LD E,E", 0x5B }, { "LD E,H", 0x5C }, { "LD E,L", 0x5D }, { "LD E,(HL)", 0x5E }, { "LD E,A", 0x5F },
        { "LD H,B", 0x60 }, { "LD H,C", 0x61 }, { "LD H,D", 0x62 }, { "LD H,E", 0x63 }, { "LD H,H", 0x64 }, { "LD H,L", 0x65 }, { "LD H,(HL)", 0x66 }, { "LD H,A", 0x67 },
        { "LD L,B", 0x68 }, { "LD L,C", 0x69 }, { "LD L,D", 0x6A }, { "LD L,E", 0x6B }, { "LD L,H", 0x6C }, { "LD L,L", 0x6D }, { "LD L,(HL)", 0x6E }, { "LD L,A", 0x6F },
        { "LD (HL),B", 0x70 }, { "LD (HL),C", 0x71 }, { "LD (HL),D", 0x72 }, { "LD (HL),E", 0x73 }, { "LD (HL),H", 0x74 }, { "LD (HL),L", 0x75 }, { "HALT", 0x76 }, { "LD (HL),A", 0x77 },
        { "LD A,B", 0x78 }, { "LD A,C", 0x79 }, { "LD A,D", 0x7A }, { "LD A,E", 0x7B }, { "LD A,H", 0x7C }, { "LD A,L", 0x7D }, { "LD A,(HL)", 0x7E }, { "LD A,A", 0x7F },
        { "ADD A,B", 0x80 }, { "ADD A,C", 0x81 }, { "ADD A,D", 0x82 }, { "ADD A,E", 0x83 }, { "ADD A,H", 0x84 }, { "ADD A,L", 0x85 }, { "ADD A,(HL)", 0x86 }, { "ADD A,A", 0x87 },
        { "ADC A,B", 0x88 }, { "ADC A,C", 0x89 }, { "ADC A,D", 0x8A }, { "ADC A,E", 0x8B }, { "ADC A,H", 0x8C }, { "ADC A,L", 0x8D }, { "ADC A,(HL)", 0x8E }, { "ADC A,A", 0x8F },
        { "SUB B", 0x90 }, { "SUB C", 0x91 }, { "SUB D", 0x92 }, { "SUB E", 0x93 }, { "SUB H", 0x94 }, { "SUB L", 0x95 }, { "SUB (HL)", 0x96 }, { "SUB A", 0x97 },
        { "SBC A,B", 0x98 }, { "SBC A,C", 0x99 }, { "SBC A,D", 0x9A }, { "SBC A,E", 0x9B }, { "SBC A,H", 0x9C }, { "SBC A,L", 0x9D }, { "SBC A,(HL)", 0x9E }, { "SBC A,A", 0x9F },
        { "AND B", 0xA0 }, { "AND C", 0xA1 }, { "AND D", 0xA2 }, { "AND E", 0xA3 }, { "AND H", 0xA4 }, { "AND L", 0xA5 }, { "AND (HL)", 0xA6 }, { "AND A", 0xA7 },
        { "XOR B", 0xA8 }, { "XOR C", 0xA9 }, { "XOR D", 0xAA }, { "XOR E", 0xAB }, { "XOR H", 0xAC }, { "XOR L", 0xAD }, { "XOR (HL)", 0xAE }, { "XOR A", 0xAF },
        { "OR B", 0xB0 }, { "OR C", 0xB1 }, { "OR D", 0xB2 }, { "OR E", 0xB3 }, { "OR H", 0xB4 }, { "OR L", 0xB5 }, { "OR (HL)", 0xB6 }, { "OR A", 0xB7 },
        { "CP B", 0xB8 }, { "CP C", 0xB9 }, { "CP D", 0xBA }, { "CP E", 0xBB }, { "CP H", 0xBC }, { "CP L", 0xBD }, { "CP (HL)", 0xBE }, { "CP A", 0xBF },
        { "RET NZ", 0xC0 }, { "POP BC", 0xC1 }, { "JP NZ,nn", 0xC2 }, { "JP nn", 0xC3 }, { "CALL NZ,nn", 0xC4 }, { "PUSH BC", 0xC5 }, { "ADD A,n", 0xC6 }, { "RST 00h", 0xC7 },
        { "RET Z", 0xC8 }, { "RET", 0xC9 }, { "JP Z,nn", 0xCA }, { "CB PREFIX", 0xCB }, { "CALL Z,nn", 0xCC }, { "CALL nn", 0xCD }, { "ADC A,n", 0xCE }, { "RST 08h", 0xCF },
        { "RET NC", 0xD0 }, { "POP DE", 0xD1 }, { "JP NC,nn", 0xD2 }, { "OUT (n),A", 0xD3 }, { "CALL NC,nn", 0xD4 }, { "PUSH DE", 0xD5 }, { "SUB n", 0xD6 }, { "RST 10h", 0xD7 },
        { "RET C", 0xD8 }, { "EXX", 0xD9 }, { "JP C,nn", 0xDA }, { "IN A,(n)", 0xDB }, { "CALL C,nn", 0xDC }, { "IX PREFIX", 0xDD }, { "SBC A,n", 0xDE }, { "RST 18h", 0xDF },
        { "RET PO", 0xE0 }, { "POP HL", 0xE1 }, { "JP PO,nn", 0xE2 }, { "EX (SP),HL", 0xE3 }, { "CALL PO,nn", 0xE4 }, { "PUSH HL", 0xE5 }, { "AND n", 0xE6 }, { "RST 20h", 0xE7 },
        { "RET PE", 0xE8 }, { "JP (HL)", 0xE9 }, { "JP PE,nn", 0xEA }, { "EX DE,HL", 0xEB }, { "CALL PE,nn", 0xEC }, { "ED PREFIX", 0xED }, { "XOR n", 0xEE }, { "RST 28h", 0xEF },
        { "RET P", 0xF0 }, { "POP AF", 0xF1 }, { "JP P,nn", 0xF2 }, { "DI", 0xF3 }, { "CALL P,nn", 0xF4 }, { "PUSH AF", 0xF5 }, { "OR n", 0xF6 }, { "RST 30h", 0xF7 },
        { "RET M", 0xF8 }, { "LD SP,HL", 0xF9 }, { "JP M,nn", 0xFA }, { "EI", 0xFB }, { "CALL M,nn", 0xFC }, { "IY PREFIX", 0xFD }, { "CP n", 0xFE }, { "RST 38h", 0xFF },

        // ED prefixed instructions
        { "IN B,(C)", 0xED40 }, { "OUT (C),B", 0xED41 }, { "SBC HL,BC", 0xED42 }, { "LD (nn),BC", 0xED43 }, { "NEG", 0xED44 }, { "RETN", 0xED45 }, { "IM 0", 0xED46 }, { "LD I,A", 0xED47 },
        { "IN C,(C)", 0xED48 }, { "OUT (C),C", 0xED49 }, { "ADC HL,BC", 0xED4A }, { "LD BC,(nn)", 0xED4B }, { "RETI", 0xED4D }, { "LD R,A", 0xED4F },
        { "IN D,(C)", 0xED50 }, { "OUT (C),D", 0xED51 }, { "SBC HL,DE", 0xED52 }, { "LD (nn),DE", 0xED53 }, { "IM 1", 0xED56 }, { "LD A,I", 0xED57 },
        { "IN E,(C)", 0xED58 }, { "OUT (C),E", 0xED59 }, { "ADC HL,DE", 0xED5A }, { "LD DE,(nn)", 0xED5B }, { "IM 2", 0xED5E }, { "LD A,R", 0xED5F },
        { "IN H,(C)", 0xED60 }, { "OUT (C),H", 0xED61 }, { "SBC HL,HL", 0xED62 }, { "ED LD (nn),HL", 0xED63 }, { "RRD", 0xED67 },
        { "IN L,(C)", 0xED68 }, { "OUT (C),L", 0xED69 }, { "ADC HL,HL", 0xED6A }, { "ED LD HL,(nn)", 0xED6B }, { "RLD", 0xED6F },
        { "IN F,(C)", 0xED70 }, { "OUT (C),F", 0xED71 }, { "SBC HL,SP", 0xED72 }, { "LD (nn),SP", 0xED73 },
        { "IN A,(C)", 0xED78 }, { "OUT (C),A", 0xED79 }, { "ADC HL,SP", 0xED7A },
        { "LD SP,(nn)", 0xED7B },
        { "LDI", 0xEDA0 }, { "CPI", 0xEDA1 }, { "INI", 0xEDA2 }, { "OUTI", 0xEDA3 },
        { "LDD", 0xEDA8 }, { "CPD", 0xEDA9 }, { "IND", 0xEDAA }, { "OUTD", 0xEDAB },
        { "LDIR", 0xEDB0 }, { "CPIR", 0xEDB1 }, { "INIR", 0xEDB2 }, { "OTIR", 0xEDB3 },
        { "LDDR", 0xEDB8 }, { "CPDR", 0xEDB9 }, { "INDR", 0xEDBA }, { "OTDR", 0xEDBB },

        // CB prefixed instructions
        { "RLC B",   0xCB00 }, { "RLC C",   0xCB01 }, { "RLC D",   0xCB02 }, { "RLC E",   0xCB03 }, { "RLC H",   0xCB04 }, { "RLC L",   0xCB05 }, { "RLC (HL)",   0xCB06 }, { "RLC A",   0xCB07 },
        { "RRC B",   0xCB08 }, { "RRC C",   0xCB09 }, { "RRC D",   0xCB0A }, { "RRC E",   0xCB0B }, { "RRC H",   0xCB0C }, { "RRC L",   0xCB0D }, { "RRC (HL)",   0xCB0E }, { "RRC A",   0xCB0F },
        { "RL B",    0xCB10 }, { "RL C",    0xCB11 }, { "RL D",    0xCB12 }, { "RL E",    0xCB13 }, { "RL H",    0xCB14 }, { "RL L",    0xCB15 }, { "RL (HL)",    0xCB16 }, { "RL A",    0xCB17 },
        { "RR B",    0xCB18 }, { "RR C",    0xCB19 }, { "RR D",    0xCB1A }, { "RR E",    0xCB1B }, { "RR H",    0xCB1C }, { "RR L",    0xCB1D }, { "RR (HL)",    0xCB1E }, { "RR A",    0xCB1F },
        { "SLA B",   0xCB20 }, { "SLA C",   0xCB21 }, { "SLA D",   0xCB22 }, { "SLA E",   0xCB23 }, { "SLA H",   0xCB24 }, { "SLA L",   0xCB25 }, { "SLA (HL)",   0xCB26 }, { "SLA A",   0xCB27 },
        { "SRA B",   0xCB28 }, { "SRA C",   0xCB29 }, { "SRA D",   0xCB2A }, { "SRA E",   0xCB2B }, { "SRA H",   0xCB2C }, { "SRA L",   0xCB2D }, { "SRA (HL)",   0xCB2E }, { "SRA A",   0xCB2F },
        { "SLL B",   0xCB30 }, { "SLL C",   0xCB31 }, { "SLL D",   0xCB32 }, { "SLL E",   0xCB33 }, { "SLL H",   0xCB34 }, { "SLL L",   0xCB35 }, { "SLL (HL)",   0xCB36 }, { "SLL A",   0xCB37 },
        { "SRL B",   0xCB38 }, { "SRL C",   0xCB39 }, { "SRL D",   0xCB3A }, { "SRL E",   0xCB3B }, { "SRL H",   0xCB3C }, { "SRL L",   0xCB3D }, { "SRL (HL)",   0xCB3E }, { "SRL A",   0xCB3F },

        { "BIT 0,B", 0xCB40 }, { "BIT 0,C", 0xCB41 }, { "BIT 0,D", 0xCB42 }, { "BIT 0,E", 0xCB43 }, { "BIT 0,H", 0xCB44 }, { "BIT 0,L", 0xCB45 }, { "BIT 0,(HL)", 0xCB46 }, { "BIT 0,A", 0xCB47 },
        { "BIT 1,B", 0xCB48 }, { "BIT 1,C", 0xCB49 }, { "BIT 1,D", 0xCB4A }, { "BIT 1,E", 0xCB4B }, { "BIT 1,H", 0xCB4C }, { "BIT 1,L", 0xCB4D }, { "BIT 1,(HL)", 0xCB4E }, { "BIT 1,A", 0xCB4F },
        { "BIT 2,B", 0xCB50 }, { "BIT 2,C", 0xCB51 }, { "BIT 2,D", 0xCB52 }, { "BIT 2,E", 0xCB53 }, { "BIT 2,H", 0xCB54 }, { "BIT 2,L", 0xCB55 }, { "BIT 2,(HL)", 0xCB56 }, { "BIT 2,A", 0xCB57 },
        { "BIT 3,B", 0xCB58 }, { "BIT 3,C", 0xCB59 }, { "BIT 3,D", 0xCB5A }, { "BIT 3,E", 0xCB5B }, { "BIT 3,H", 0xCB5C }, { "BIT 3,L", 0xCB5D }, { "BIT 3,(HL)", 0xCB5E }, { "BIT 3,A", 0xCB5F },
        { "BIT 4,B", 0xCB60 }, { "BIT 4,C", 0xCB61 }, { "BIT 4,D", 0xCB62 }, { "BIT 4,E", 0xCB63 }, { "BIT 4,H", 0xCB64 }, { "BIT 4,L", 0xCB65 }, { "BIT 4,(HL)", 0xCB66 }, { "BIT 4,A", 0xCB67 },
        { "BIT 5,B", 0xCB68 }, { "BIT 5,C", 0xCB69 }, { "BIT 5,D", 0xCB6A }, { "BIT 5,E", 0xCB6B }, { "BIT 5,H", 0xCB6C }, { "BIT 5,L", 0xCB6D }, { "BIT 5,(HL)", 0xCB6E }, { "BIT 5,A", 0xCB6F },
        { "BIT 6,B", 0xCB70 }, { "BIT 6,C", 0xCB71 }, { "BIT 6,D", 0xCB72 }, { "BIT 6,E", 0xCB73 }, { "BIT 6,H", 0xCB74 }, { "BIT 6,L", 0xCB75 }, { "BIT 6,(HL)", 0xCB76 }, { "BIT 6,A", 0xCB77 },
        { "BIT 7,B", 0xCB78 }, { "BIT 7,C", 0xCB79 }, { "BIT 7,D", 0xCB7A }, { "BIT 7,E", 0xCB7B }, { "BIT 7,H", 0xCB7C }, { "BIT 7,L", 0xCB7D }, { "BIT 7,(HL)", 0xCB7E }, { "BIT 7,A", 0xCB7F },

        { "RES 0,B", 0xCB80 }, { "RES 0,C", 0xCB81 }, { "RES 0,D", 0xCB82 }, { "RES 0,E", 0xCB83 }, { "RES 0,H", 0xCB84 }, { "RES 0,L", 0xCB85 }, { "RES 0,(HL)", 0xCB86 }, { "RES 0,A", 0xCB87 },
        { "RES 1,B", 0xCB88 }, { "RES 1,C", 0xCB89 }, { "RES 1,D", 0xCB8A }, { "RES 1,E", 0xCB8B }, { "RES 1,H", 0xCB8C }, { "RES 1,L", 0xCB8D }, { "RES 1,(HL)", 0xCB8E }, { "RES 1,A", 0xCB8F },
        { "RES 2,B", 0xCB90 }, { "RES 2,C", 0xCB91 }, { "RES 2,D", 0xCB92 }, { "RES 2,E", 0xCB93 }, { "RES 2,H", 0xCB94 }, { "RES 2,L", 0xCB95 }, { "RES 2,(HL)", 0xCB96 }, { "RES 2,A", 0xCB97 },
        { "RES 3,B", 0xCB98 }, { "RES 3,C", 0xCB99 }, { "RES 3,D", 0xCB9A }, { "RES 3,E", 0xCB9B }, { "RES 3,H", 0xCB9C }, { "RES 3,L", 0xCB9D }, { "RES 3,(HL)", 0xCB9E }, { "RES 3,A", 0xCB9F },
        { "RES 4,B", 0xCBA0 }, { "RES 4,C", 0xCBA1 }, { "RES 4,D", 0xCBA2 }, { "RES 4,E", 0xCBA3 }, { "RES 4,H", 0xCBA4 }, { "RES 4,L", 0xCBA5 }, { "RES 4,(HL)", 0xCBA6 }, { "RES 4,A", 0xCBA7 },
        { "RES 5,B", 0xCBA8 }, { "RES 5,C", 0xCBA9 }, { "RES 5,D", 0xCBAA }, { "RES 5,E", 0xCBAB }, { "RES 5,H", 0xCBAC }, { "RES 5,L", 0xCBAD }, { "RES 5,(HL)", 0xCBAE }, { "RES 5,A", 0xCBAF },
        { "RES 6,B", 0xCBB0 }, { "RES 6,C", 0xCBB1 }, { "RES 6,D", 0xCBB2 }, { "RES 6,E", 0xCBB3 }, { "RES 6,H", 0xCBB4 }, { "RES 6,L", 0xCBB5 }, { "RES 6,(HL)", 0xCBB6 }, { "RES 6,A", 0xCBB7 },
        { "RES 7,B", 0xCBB8 }, { "RES 7,C", 0xCBB9 }, { "RES 7,D", 0xCBBA }, { "RES 7,E", 0xCBBB }, { "RES 7,H", 0xCBBC }, { "RES 7,L", 0xCBBD }, { "RES 7,(HL)", 0xCBBE }, { "RES 7,A", 0xCBBF },

        { "SET 0,B", 0xCBC0 }, { "SET 0,C", 0xCBC1 }, { "SET 0,D", 0xCBC2 }, { "SET 0,E", 0xCBC3 }, { "SET 0,H", 0xCBC4 }, { "SET 0,L", 0xCBC5 }, { "SET 0,(HL)", 0xCBC6 }, { "SET 0,A", 0xCBC7 },
        { "SET 1,B", 0xCBC8 }, { "SET 1,C", 0xCBC9 }, { "SET 1,D", 0xCBCA }, { "SET 1,E", 0xCBCB }, { "SET 1,H", 0xCBCC }, { "SET 1,L", 0xCBCD }, { "SET 1,(HL)", 0xCBCE }, { "SET 1,A", 0xCBCF },
        { "SET 2,B", 0xCBD0 }, { "SET 2,C", 0xCBD1 }, { "SET 2,D", 0xCBD2 }, { "SET 2,E", 0xCBD3 }, { "SET 2,H", 0xCBD4 }, { "SET 2,L", 0xCBD5 }, { "SET 2,(HL)", 0xCBD6 }, { "SET 2,A", 0xCBD7 },
        { "SET 3,B", 0xCBD8 }, { "SET 3,C", 0xCBD9 }, { "SET 3,D", 0xCBDA }, { "SET 3,E", 0xCBDB }, { "SET 3,H", 0xCBDC }, { "SET 3,L", 0xCBDD }, { "SET 3,(HL)", 0xCBDE }, { "SET 3,A", 0xCBDF },
        { "SET 4,B", 0xCBE0 }, { "SET 4,C", 0xCBE1 }, { "SET 4,D", 0xCBE2 }, { "SET 4,E", 0xCBE3 }, { "SET 4,H", 0xCBE4 }, { "SET 4,L", 0xCBE5 }, { "SET 4,(HL)", 0xCBE6 }, { "SET 4,A", 0xCBE7 },
        { "SET 5,B", 0xCBE8 }, { "SET 5,C", 0xCBE9 }, { "SET 5,D", 0xCBEA }, { "SET 5,E", 0xCBEB }, { "SET 5,H", 0xCBEC }, { "SET 5,L", 0xCBED }, { "SET 5,(HL)", 0xCBEE }, { "SET 5,A", 0xCBEF },
        { "SET 6,B", 0xCBF0 }, { "SET 6,C", 0xCBF1 }, { "SET 6,D", 0xCBF2 }, { "SET 6,E", 0xCBF3 }, { "SET 6,H", 0xCBF4 }, { "SET 6,L", 0xCBF5 }, { "SET 6,(HL)", 0xCBF6 }, { "SET 6,A", 0xCBF7 },
        { "SET 7,B", 0xCBF8 }, { "SET 7,C", 0xCBF9 }, { "SET 7,D", 0xCBFA }, { "SET 7,E", 0xCBFB }, { "SET 7,H", 0xCBFC }, { "SET 7,L", 0xCBFD }, { "SET 7,(HL)", 0xCBFE }, { "SET 7,A", 0xCBFF },
    };
}
