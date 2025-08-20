using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000142 RID: 322
[Token(Token = "0x2000142")]
public static class Options
{
	// Token: 0x060005BB RID: 1467 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x3F30A0", Offset = "0x3F22A0", VA = "0x1803F30A0")]
	public static Option GetOption(OptionType optionType)
	{
		return null;
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x3F3290", Offset = "0x3F2490", VA = "0x1803F3290")]
	public static void Save()
	{
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x3F2F90", Offset = "0x3F2190", VA = "0x1803F2F90")]
	private static Option CreateOption(OptionType optionType)
	{
		return null;
	}

	// Token: 0x0400061A RID: 1562
	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<OptionType, Option> _options;
}
