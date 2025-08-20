using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200014C RID: 332
[Token(Token = "0x200014C")]
internal static class PoolConfigurations
{
	// Token: 0x060005EC RID: 1516 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x3F39C0", Offset = "0x3F2BC0", VA = "0x1803F39C0")]
	public static IReadOnlyDictionary<Type, PoolConfiguration> GetOverride(string key)
	{
		return null;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005ED")]
	public static PoolConfiguration Get<T>()
	{
		return null;
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x3F3A60", Offset = "0x3F2C60", VA = "0x1803F3A60")]
	public static PoolConfiguration Get(Type type)
	{
		return null;
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x3F33A0", Offset = "0x3F25A0", VA = "0x1803F33A0")]
	private static Dictionary<Type, PoolConfiguration> BuildDefaultConfigurations()
	{
		return null;
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x3F3890", Offset = "0x3F2A90", VA = "0x1803F3890")]
	private static Dictionary<Type, PoolConfiguration> BuildIsland1Configuration()
	{
		return null;
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60005F1")]
	private static Dictionary<Type, PoolConfiguration> Configure<T>(this Dictionary<Type, PoolConfiguration> configs, int minCount, int maxRented = 2147483647)
	{
		return null;
	}

	// Token: 0x0400068B RID: 1675
	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<Type, PoolConfiguration> s_configurations;

	// Token: 0x0400068C RID: 1676
	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<Type, PoolConfiguration> s_island1Configurations;

	// Token: 0x0400068D RID: 1677
	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Dictionary<Type, PoolConfiguration> s_none;
}
