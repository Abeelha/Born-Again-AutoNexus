using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;

// Token: 0x02000301 RID: 769
[Token(Token = "0x2000301")]
public class StatTooltipSource : TooltipSource
{
	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06001116 RID: 4374 RVA: 0x00006810 File Offset: 0x00004A10
	[Token(Token = "0x170001E2")]
	public override bool CanShow
	{
		[Token(Token = "0x6001116")]
		[Address(RVA = "0x3423A0", Offset = "0x3415A0", VA = "0x1803423A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001117")]
	[Address(RVA = "0x35E690", Offset = "0x35D890", VA = "0x18035E690", Slot = "5")]
	public override void Build(TooltipBuilder builder)
	{
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001118")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public StatTooltipSource()
	{
	}

	// Token: 0x04000E21 RID: 3617
	[Token(Token = "0x4000E21")]
	[FieldOffset(Offset = "0x28")]
	public StatType StatType;
}
