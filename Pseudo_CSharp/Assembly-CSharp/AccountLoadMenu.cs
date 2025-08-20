using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000DB RID: 219
[Token(Token = "0x20000DB")]
public class AccountLoadMenu : Menu
{
	// Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x3BC990", Offset = "0x3BBB90", VA = "0x1803BC990")]
	public void DisableNextLoad()
	{
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x3BC9A0", Offset = "0x3BBBA0", VA = "0x1803BC9A0")]
	public void EnableNextLoad()
	{
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x3BC9B0", Offset = "0x3BBBB0", VA = "0x1803BC9B0")]
	public void LanguageChanged()
	{
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x3BC9D0", Offset = "0x3BBBD0", VA = "0x1803BC9D0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x060003CC RID: 972 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x3BCD10", Offset = "0x3BBF10", VA = "0x1803BCD10")]
	private Task SetupAsync()
	{
		return null;
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x3BCDF0", Offset = "0x3BBFF0", VA = "0x1803BCDF0")]
	private void SetupInformation()
	{
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x3BD290", Offset = "0x3BC490", VA = "0x1803BD290")]
	private void SetupSelectedServer()
	{
	}

	// Token: 0x060003CF RID: 975 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x3BCC40", Offset = "0x3BBE40", VA = "0x1803BCC40")]
	private Task RetryLaterAsync()
	{
		return null;
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x3BD440", Offset = "0x3BC640", VA = "0x1803BD440")]
	private void UpdateRegisterWarning()
	{
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public AccountLoadMenu()
	{
	}

	// Token: 0x040003BF RID: 959
	[Token(Token = "0x40003BF")]
	[FieldOffset(Offset = "0x90")]
	public Menu EmailVerificationMenu;

	// Token: 0x040003C0 RID: 960
	[Token(Token = "0x40003C0")]
	[FieldOffset(Offset = "0x98")]
	public Menu UsernameMenu;

	// Token: 0x040003C1 RID: 961
	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0xA0")]
	public Menu CharactersMenu;

	// Token: 0x040003C2 RID: 962
	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0xA8")]
	public Menu SessionMenu;

	// Token: 0x040003C3 RID: 963
	[Token(Token = "0x40003C3")]
	[FieldOffset(Offset = "0xB0")]
	public Menu AnalyticsConsentMenu;

	// Token: 0x040003C4 RID: 964
	[Token(Token = "0x40003C4")]
	[FieldOffset(Offset = "0xB8")]
	public TextMeshProUGUI UsernameLabel;

	// Token: 0x040003C5 RID: 965
	[Token(Token = "0x40003C5")]
	[FieldOffset(Offset = "0xC0")]
	public TextMeshProUGUI PrestigeLabel;

	// Token: 0x040003C6 RID: 966
	[Token(Token = "0x40003C6")]
	[FieldOffset(Offset = "0xC8")]
	public TextMeshProUGUI SelectedServerLabel;

	// Token: 0x040003C7 RID: 967
	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject RegisterGroup;

	// Token: 0x040003C8 RID: 968
	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0xD8")]
	public TextMeshProUGUI RegisterWarning;

	// Token: 0x040003C9 RID: 969
	[Token(Token = "0x40003C9")]
	[FieldOffset(Offset = "0xE0")]
	public Color ServerColor;

	// Token: 0x040003CA RID: 970
	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0xF0")]
	public Color NoServerColor;

	// Token: 0x040003CB RID: 971
	[Token(Token = "0x40003CB")]
	[FieldOffset(Offset = "0x100")]
	private bool _disabledLoad;
}
