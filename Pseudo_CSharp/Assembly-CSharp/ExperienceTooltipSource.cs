using System;
using Il2CppDummyDll;

// Token: 0x020002FD RID: 765
[Token(Token = "0x20002FD")]
public class ExperienceTooltipSource : TooltipSource
{
	// Token: 0x170001DE RID: 478
	// (get) Token: 0x06001108 RID: 4360 RVA: 0x000067B0 File Offset: 0x000049B0
	[Token(Token = "0x170001DE")]
	public override bool CanShow
	{
		[Token(Token = "0x6001108")]
		[Address(RVA = "0x34E7C0", Offset = "0x34D9C0", VA = "0x18034E7C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001109 RID: 4361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001109")]
	[Address(RVA = "0x34E6F0", Offset = "0x34D8F0", VA = "0x18034E6F0", Slot = "5")]
	public override void Build(TooltipBuilder builder)
	{
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110A")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ExperienceTooltipSource()
	{
	}

	// Token: 0x04000E17 RID: 3607
	[Token(Token = "0x4000E17")]
	[FieldOffset(Offset = "0x28")]
	public ExperienceContainer Experience;

	// Token: 0x04000E18 RID: 3608
	[Token(Token = "0x4000E18")]
	[FieldOffset(Offset = "0x30")]
	public ExperienceOrbs Orbs;
}
