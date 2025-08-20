using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

// Token: 0x020001D7 RID: 471
[Token(Token = "0x20001D7")]
public static class StringBuilderCache
{
	// Token: 0x0600097B RID: 2427 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600097B")]
	[Address(RVA = "0x430D40", Offset = "0x42FF40", VA = "0x180430D40")]
	public static string Consume(this StringBuilder builder)
	{
		return null;
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600097C")]
	[Address(RVA = "0x430C00", Offset = "0x42FE00", VA = "0x180430C00")]
	public static string Complete(StringBuilder builder)
	{
		return null;
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600097D")]
	[Address(RVA = "0x430D90", Offset = "0x42FF90", VA = "0x180430D90")]
	public static StringBuilder Get()
	{
		return null;
	}

	// Token: 0x040008EB RID: 2283
	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly List<StringBuilder> s_builders;
}
