using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000060 RID: 96
[Token(Token = "0x2000060")]
public static class ColorExtensions
{
	// Token: 0x06000187 RID: 391 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x332900", Offset = "0x331B00", VA = "0x180332900")]
	public static string ToHexHtml(this Color color)
	{
		return null;
	}

	// Token: 0x040001C4 RID: 452
	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<Color, string> s_hexCache;

	// Token: 0x040001C5 RID: 453
	[Token(Token = "0x40001C5")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<Color32, string> s_hex32Cache;
}
