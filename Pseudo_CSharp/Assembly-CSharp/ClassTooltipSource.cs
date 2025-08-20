using System;
using Il2CppDummyDll;

// Token: 0x020002FB RID: 763
[Token(Token = "0x20002FB")]
public class ClassTooltipSource : TooltipSource
{
	// Token: 0x170001DC RID: 476
	// (get) Token: 0x06001102 RID: 4354 RVA: 0x00006780 File Offset: 0x00004980
	[Token(Token = "0x170001DC")]
	public override bool CanShow
	{
		[Token(Token = "0x6001102")]
		[Address(RVA = "0x34E0D0", Offset = "0x34D2D0", VA = "0x18034E0D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001103")]
	[Address(RVA = "0x34E0A0", Offset = "0x34D2A0", VA = "0x18034E0A0", Slot = "5")]
	public override void Build(TooltipBuilder builder)
	{
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001104")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ClassTooltipSource()
	{
	}

	// Token: 0x04000E15 RID: 3605
	[Token(Token = "0x4000E15")]
	[FieldOffset(Offset = "0x28")]
	public ushort ClassType;
}
