using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x020001AF RID: 431
[Token(Token = "0x20001AF")]
public struct AlertButtonDescriptor
{
	// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x4054D0", Offset = "0x4046D0", VA = "0x1804054D0")]
	public AlertButtonDescriptor(AlertButtonType type, string text)
	{
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x060008A2 RID: 2210 RVA: 0x000042F0 File Offset: 0x000024F0
	[Token(Token = "0x170000D4")]
	public AlertButtonType Type
	{
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x4054F0", Offset = "0x4046F0", VA = "0x1804054F0")]
		[CompilerGenerated]
		get
		{
			return AlertButtonType.Normal;
		}
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000D5")]
	public string Text
	{
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x405350", Offset = "0x404550", VA = "0x180405350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x00004308 File Offset: 0x00002508
	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x405500", Offset = "0x404700", VA = "0x180405500")]
	public static implicit operator AlertButtonDescriptor(string text)
	{
		return default(AlertButtonDescriptor);
	}
}
