using System;
using Il2CppDummyDll;

// Token: 0x020002F9 RID: 761
[Token(Token = "0x20002F9")]
public sealed class BlessingTooltipSource : TooltipSource
{
	// Token: 0x170001DA RID: 474
	// (get) Token: 0x060010FB RID: 4347 RVA: 0x00006750 File Offset: 0x00004950
	[Token(Token = "0x170001DA")]
	public override bool CanShow
	{
		[Token(Token = "0x60010FB")]
		[Address(RVA = "0x34CFE0", Offset = "0x34C1E0", VA = "0x18034CFE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010FC")]
	[Address(RVA = "0x34CE90", Offset = "0x34C090", VA = "0x18034CE90", Slot = "5")]
	public override void Build(TooltipBuilder builder)
	{
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010FD")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public BlessingTooltipSource()
	{
	}

	// Token: 0x04000E13 RID: 3603
	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0x28")]
	public BlessingIcon BlessingIcon;
}
