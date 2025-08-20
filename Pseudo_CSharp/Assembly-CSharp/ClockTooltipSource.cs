using System;
using Il2CppDummyDll;

// Token: 0x020002FC RID: 764
[Token(Token = "0x20002FC")]
public class ClockTooltipSource : TooltipSource
{
	// Token: 0x170001DD RID: 477
	// (get) Token: 0x06001105 RID: 4357 RVA: 0x00006798 File Offset: 0x00004998
	[Token(Token = "0x170001DD")]
	public override bool CanShow
	{
		[Token(Token = "0x6001105")]
		[Address(RVA = "0x3423A0", Offset = "0x3415A0", VA = "0x1803423A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001106")]
	[Address(RVA = "0x34E0F0", Offset = "0x34D2F0", VA = "0x18034E0F0", Slot = "5")]
	public override void Build(TooltipBuilder builder)
	{
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001107")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ClockTooltipSource()
	{
	}

	// Token: 0x04000E16 RID: 3606
	[Token(Token = "0x4000E16")]
	[FieldOffset(Offset = "0x28")]
	public Clock Clock;
}
