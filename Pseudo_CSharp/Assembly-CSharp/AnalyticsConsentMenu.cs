using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

// Token: 0x020000E2 RID: 226
[Token(Token = "0x20000E2")]
public class AnalyticsConsentMenu : Menu
{
	// Token: 0x060003E5 RID: 997 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x3BDCB0", Offset = "0x3BCEB0", VA = "0x1803BDCB0")]
	public void Accept()
	{
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x3BDDF0", Offset = "0x3BCFF0", VA = "0x1803BDDF0")]
	public void Decline()
	{
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x3BDCC0", Offset = "0x3BCEC0", VA = "0x1803BDCC0")]
	private void Consent(bool consent)
	{
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x3BDE00", Offset = "0x3BD000", VA = "0x1803BDE00")]
	private Task UpdateConsentAsync(bool consent)
	{
		return null;
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public AnalyticsConsentMenu()
	{
	}
}
