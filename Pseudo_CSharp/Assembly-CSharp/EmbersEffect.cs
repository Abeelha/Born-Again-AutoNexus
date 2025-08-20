using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;

// Token: 0x02000212 RID: 530
[Token(Token = "0x2000212")]
public class EmbersEffect : WeatherEffect
{
	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00004A88 File Offset: 0x00002C88
	[Token(Token = "0x170000FD")]
	public override WeatherType WeatherType
	{
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x425600", Offset = "0x424800", VA = "0x180425600", Slot = "9")]
		get
		{
			return WeatherType.None;
		}
	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A90")]
	[Address(RVA = "0x41EA00", Offset = "0x41DC00", VA = "0x18041EA00")]
	public EmbersEffect()
	{
	}
}
