using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Ronin.Api.Model.Token;

// Token: 0x0200014D RID: 333
[Token(Token = "0x200014D")]
public static class Prefs
{
	// Token: 0x1700007B RID: 123
	// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00003870 File Offset: 0x00001A70
	// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007B")]
	public static bool AnalyticsConsent
	{
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x3F44F0", Offset = "0x3F36F0", VA = "0x1803F44F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x3F4890", Offset = "0x3F3A90", VA = "0x1803F4890")]
		set
		{
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007C")]
	public static string ApiUrl
	{
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x3F4530", Offset = "0x3F3730", VA = "0x1803F4530")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x3F48D0", Offset = "0x3F3AD0", VA = "0x1803F48D0")]
		set
		{
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700007D")]
	public static string ClientId
	{
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x3F4580", Offset = "0x3F3780", VA = "0x1803F4580")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00003888 File Offset: 0x00001A88
	// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007E")]
	public static long SelectedRegion
	{
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x3F4590", Offset = "0x3F3790", VA = "0x1803F4590")]
		get
		{
			return 0L;
		}
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x3F4A20", Offset = "0x3F3C20", VA = "0x1803F4A20")]
		set
		{
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x060005FA RID: 1530 RVA: 0x000038A0 File Offset: 0x00001AA0
	// (set) Token: 0x060005FB RID: 1531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007F")]
	public static bool ShownCredits
	{
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x3F4630", Offset = "0x3F3830", VA = "0x1803F4630")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x3F4AA0", Offset = "0x3F3CA0", VA = "0x1803F4AA0")]
		set
		{
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x060005FC RID: 1532 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000080")]
	public static string Token
	{
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x3F47A0", Offset = "0x3F39A0", VA = "0x1803F47A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x060005FD RID: 1533 RVA: 0x000038B8 File Offset: 0x00001AB8
	[Token(Token = "0x17000081")]
	public static DateTime TokenExpiration
	{
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x3F4670", Offset = "0x3F3870", VA = "0x1803F4670")]
		get
		{
			return default(DateTime);
		}
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x3F3D40", Offset = "0x3F2F40", VA = "0x1803F3D40")]
	public static void ClearToken()
	{
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x000038D0 File Offset: 0x00001AD0
	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x3F4170", Offset = "0x3F3370", VA = "0x1803F4170")]
	public static bool HasToken()
	{
		return default(bool);
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000600")]
	[Address(RVA = "0x3F4300", Offset = "0x3F3500", VA = "0x1803F4300")]
	public static void SetToken(CreateTokenResponse token)
	{
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x000038E8 File Offset: 0x00001AE8
	[Token(Token = "0x6000601")]
	[Address(RVA = "0x3F3FF0", Offset = "0x3F31F0", VA = "0x1803F3FF0")]
	private static DateTime GetDateTime(string key, [Optional] DateTime @default)
	{
		return default(DateTime);
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000602")]
	[Address(RVA = "0x3F3ED0", Offset = "0x3F30D0", VA = "0x1803F3ED0")]
	private static string GetApiPrefKey(string prefKey)
	{
		return null;
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000603")]
	[Address(RVA = "0x3F40B0", Offset = "0x3F32B0", VA = "0x1803F40B0")]
	private static string GetToken()
	{
		return null;
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000604")]
	[Address(RVA = "0x3F3290", Offset = "0x3F2490", VA = "0x1803F3290")]
	private static void Save()
	{
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000605")]
	[Address(RVA = "0x3F42A0", Offset = "0x3F34A0", VA = "0x1803F42A0")]
	private static void SetDateTime(string key, DateTime value)
	{
	}

	// Token: 0x0400068E RID: 1678
	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int? s_launchCount;

	// Token: 0x0400068F RID: 1679
	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, string> _apiPrefKeys;

	// Token: 0x04000690 RID: 1680
	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string _apiPrefix;
}
