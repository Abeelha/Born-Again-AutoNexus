using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x020001B4 RID: 436
[Token(Token = "0x20001B4")]
public struct AlertInputDescriptor
{
	// Token: 0x060008B3 RID: 2227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x406710", Offset = "0x405910", VA = "0x180406710")]
	public AlertInputDescriptor(bool enabled, string placeholder, string defaultText)
	{
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00004320 File Offset: 0x00002520
	[Token(Token = "0x170000D6")]
	public bool Enabled
	{
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x3ECB70", Offset = "0x3EBD70", VA = "0x1803ECB70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x060008B5 RID: 2229 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000D7")]
	public string Placeholder
	{
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x405350", Offset = "0x404550", VA = "0x180405350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000D8")]
	public string DefaultText
	{
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x3328E0", Offset = "0x331AE0", VA = "0x1803328E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x00004338 File Offset: 0x00002538
	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x406750", Offset = "0x405950", VA = "0x180406750")]
	public static implicit operator AlertInputDescriptor(bool enabled)
	{
		return default(AlertInputDescriptor);
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00004350 File Offset: 0x00002550
	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x4067D0", Offset = "0x4059D0", VA = "0x1804067D0")]
	public static implicit operator AlertInputDescriptor(string placeholder)
	{
		return default(AlertInputDescriptor);
	}
}
