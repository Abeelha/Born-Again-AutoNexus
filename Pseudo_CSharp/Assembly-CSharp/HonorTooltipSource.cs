using System;
using Il2CppDummyDll;

// Token: 0x020002FE RID: 766
[Token(Token = "0x20002FE")]
public class HonorTooltipSource : TooltipSource
{
	// Token: 0x170001DF RID: 479
	// (get) Token: 0x0600110B RID: 4363 RVA: 0x000067C8 File Offset: 0x000049C8
	[Token(Token = "0x170001DF")]
	public override bool CanShow
	{
		[Token(Token = "0x600110B")]
		[Address(RVA = "0x34FE20", Offset = "0x34F020", VA = "0x18034FE20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110C")]
	[Address(RVA = "0x34FD50", Offset = "0x34EF50", VA = "0x18034FD50", Slot = "5")]
	public override void Build(TooltipBuilder builder)
	{
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110D")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public HonorTooltipSource()
	{
	}

	// Token: 0x04000E19 RID: 3609
	[Token(Token = "0x4000E19")]
	[FieldOffset(Offset = "0x28")]
	public ExperienceContainer Experience;

	// Token: 0x04000E1A RID: 3610
	[Token(Token = "0x4000E1A")]
	[FieldOffset(Offset = "0x30")]
	public ExperienceOrbs Orbs;
}
