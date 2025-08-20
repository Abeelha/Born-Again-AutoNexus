using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;

// Token: 0x02000243 RID: 579
[Token(Token = "0x2000243")]
public sealed class RainEffect : WeatherEffect
{
	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00004B18 File Offset: 0x00002D18
	[Token(Token = "0x17000102")]
	public override WeatherType WeatherType
	{
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x3423A0", Offset = "0x3415A0", VA = "0x1803423A0", Slot = "9")]
		get
		{
			return WeatherType.None;
		}
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00004B30 File Offset: 0x00002D30
	[Token(Token = "0x17000103")]
	public override float GlobalLightIntensity
	{
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x43E510", Offset = "0x43D710", VA = "0x18043E510", Slot = "10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0x43E500", Offset = "0x43D700", VA = "0x18043E500")]
	public RainEffect()
	{
	}
}
