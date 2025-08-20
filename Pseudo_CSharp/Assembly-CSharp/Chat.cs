using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Data;
using Ronin.Model.Enums;

// Token: 0x02000178 RID: 376
[Token(Token = "0x2000178")]
public struct Chat
{
	// Token: 0x06000765 RID: 1893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000765")]
	[Address(RVA = "0x40D020", Offset = "0x40C220", VA = "0x18040D020")]
	public Chat(ChatType type, string message, BadgeType badge, int? prestige, ChatOwnerData? owner, ChatIdData? id, RankType rank)
	{
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000766 RID: 1894 RVA: 0x00003DB0 File Offset: 0x00001FB0
	[Token(Token = "0x170000AD")]
	public ChatType Type
	{
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x3ECB70", Offset = "0x3EBD70", VA = "0x1803ECB70")]
		[CompilerGenerated]
		get
		{
			return ChatType.WorldChat;
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000767 RID: 1895 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000AE")]
	public string Message
	{
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x405350", Offset = "0x404550", VA = "0x180405350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000768 RID: 1896 RVA: 0x00003DC8 File Offset: 0x00001FC8
	[Token(Token = "0x170000AF")]
	public BadgeType Badge
	{
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x329390", Offset = "0x328590", VA = "0x180329390")]
		[CompilerGenerated]
		get
		{
			return BadgeType.None;
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06000769 RID: 1897 RVA: 0x00003DE0 File Offset: 0x00001FE0
	[Token(Token = "0x170000B0")]
	public ChatOwnerData? Owner
	{
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x40D0A0", Offset = "0x40C2A0", VA = "0x18040D0A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x0600076A RID: 1898 RVA: 0x00003DF8 File Offset: 0x00001FF8
	[Token(Token = "0x170000B1")]
	public ChatIdData? Id
	{
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x40D090", Offset = "0x40C290", VA = "0x18040D090")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x0600076B RID: 1899 RVA: 0x00003E10 File Offset: 0x00002010
	[Token(Token = "0x170000B2")]
	public RankType Rank
	{
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x3AE880", Offset = "0x3ADA80", VA = "0x1803AE880")]
		[CompilerGenerated]
		get
		{
			return RankType.Guest;
		}
	}
}
