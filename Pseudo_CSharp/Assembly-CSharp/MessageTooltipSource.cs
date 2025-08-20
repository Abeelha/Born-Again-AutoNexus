using System;
using Il2CppDummyDll;

// Token: 0x020002FF RID: 767
[Token(Token = "0x20002FF")]
public class MessageTooltipSource : TooltipSource
{
	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x0600110E RID: 4366 RVA: 0x000067E0 File Offset: 0x000049E0
	[Token(Token = "0x170001E0")]
	public override bool CanShow
	{
		[Token(Token = "0x600110E")]
		[Address(RVA = "0x351160", Offset = "0x350360", VA = "0x180351160", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110F")]
	[Address(RVA = "0x350FC0", Offset = "0x3501C0", VA = "0x180350FC0", Slot = "5")]
	public override void Build(TooltipBuilder builder)
	{
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001110")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public MessageTooltipSource()
	{
	}

	// Token: 0x04000E1B RID: 3611
	[Token(Token = "0x4000E1B")]
	[FieldOffset(Offset = "0x28")]
	public string Icon;

	// Token: 0x04000E1C RID: 3612
	[Token(Token = "0x4000E1C")]
	[FieldOffset(Offset = "0x30")]
	public string Message;

	// Token: 0x04000E1D RID: 3613
	[Token(Token = "0x4000E1D")]
	[FieldOffset(Offset = "0x38")]
	public bool LocalizedKey;
}
