using System;
using Il2CppDummyDll;

// Token: 0x02000081 RID: 129
[Token(Token = "0x2000081")]
public static class OpenInFileBrowser
{
	// Token: 0x17000024 RID: 36
	// (get) Token: 0x0600022B RID: 555 RVA: 0x00002A48 File Offset: 0x00000C48
	[Token(Token = "0x17000024")]
	public static bool IsInMacOS
	{
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x341790", Offset = "0x340990", VA = "0x180341790")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600022C RID: 556 RVA: 0x00002A60 File Offset: 0x00000C60
	[Token(Token = "0x17000025")]
	public static bool IsInWinOS
	{
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x3417E0", Offset = "0x3409E0", VA = "0x1803417E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022D")]
	[Address(RVA = "0x3414D0", Offset = "0x3406D0", VA = "0x1803414D0")]
	public static void OpenInMac(string path)
	{
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022E")]
	[Address(RVA = "0x341650", Offset = "0x340850", VA = "0x180341650")]
	public static void OpenInWin(string path)
	{
	}

	// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022F")]
	[Address(RVA = "0x3416D0", Offset = "0x3408D0", VA = "0x1803416D0")]
	public static void Open(string path)
	{
	}
}
