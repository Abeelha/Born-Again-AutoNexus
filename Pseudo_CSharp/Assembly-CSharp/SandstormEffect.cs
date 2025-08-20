using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;

// Token: 0x02000232 RID: 562
[Token(Token = "0x2000232")]
public class SandstormEffect : WeatherEffect
{
	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00004AB8 File Offset: 0x00002CB8
	[Token(Token = "0x170000FE")]
	public override WeatherType WeatherType
	{
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x42EA70", Offset = "0x42DC70", VA = "0x18042EA70", Slot = "9")]
		get
		{
			return WeatherType.None;
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00004AD0 File Offset: 0x00002CD0
	[Token(Token = "0x170000FF")]
	public override float GlobalLightIntensity
	{
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x42EA60", Offset = "0x42DC60", VA = "0x18042EA60", Slot = "10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC1")]
	[Address(RVA = "0x41EA00", Offset = "0x41DC00", VA = "0x18041EA00")]
	public SandstormEffect()
	{
	}
}
