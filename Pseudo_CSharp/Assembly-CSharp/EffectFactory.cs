using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Enums;

// Token: 0x02000072 RID: 114
[Token(Token = "0x2000072")]
public static class EffectFactory
{
	// Token: 0x060001D5 RID: 469 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x3385B0", Offset = "0x3377B0", VA = "0x1803385B0")]
	public static EffectBase Get(string name)
	{
		return null;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001D6")]
	public static T Get<T>() where T : EffectBase
	{
		return null;
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x339F80", Offset = "0x339180", VA = "0x180339F80")]
	public static EffectBase Get(StatusEffects type)
	{
		return null;
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x3384C0", Offset = "0x3376C0", VA = "0x1803384C0")]
	public static WeatherEffect GetWeather(WeatherType weatherType)
	{
		return null;
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x33A120", Offset = "0x339320", VA = "0x18033A120")]
	public static void RegisterWeather(EffectBase effect)
	{
	}

	// Token: 0x060001DA RID: 474 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x33A220", Offset = "0x339420", VA = "0x18033A220")]
	public static EffectBase ReturnBase(EffectBase effect)
	{
		return null;
	}

	// Token: 0x060001DB RID: 475 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60001DB")]
	public static T Return<T>(T effect) where T : EffectBase
	{
		return null;
	}

	// Token: 0x060001DC RID: 476 RVA: 0x000028F8 File Offset: 0x00000AF8
	[Token(Token = "0x60001DC")]
	public static bool TryGet<T>(out T value) where T : EffectBase
	{
		return default(bool);
	}

	// Token: 0x040001D3 RID: 467
	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<StatusEffects, string> s_statusEffectNames;

	// Token: 0x040001D4 RID: 468
	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<WeatherType, Type> s_weatherTypes;
}
