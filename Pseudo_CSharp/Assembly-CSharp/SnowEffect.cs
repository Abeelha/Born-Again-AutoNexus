using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;

// Token: 0x02000244 RID: 580
[Token(Token = "0x2000244")]
public class SnowEffect : WeatherEffect
{
	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00004B48 File Offset: 0x00002D48
	[Token(Token = "0x17000104")]
	public override WeatherType WeatherType
	{
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x4403E0", Offset = "0x43F5E0", VA = "0x1804403E0", Slot = "9")]
		get
		{
			return WeatherType.None;
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00004B60 File Offset: 0x00002D60
	[Token(Token = "0x17000105")]
	public override float GlobalLightIntensity
	{
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x42EA60", Offset = "0x42DC60", VA = "0x18042EA60", Slot = "10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AE8")]
	[Address(RVA = "0x43E500", Offset = "0x43D700", VA = "0x18043E500")]
	public SnowEffect()
	{
	}
}
