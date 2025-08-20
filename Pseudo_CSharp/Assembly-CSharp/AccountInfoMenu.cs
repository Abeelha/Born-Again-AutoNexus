using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Api.Model.SignIn.Steam;
using TMPro;
using UnityEngine;

// Token: 0x020000D1 RID: 209
[Token(Token = "0x20000D1")]
public class AccountInfoMenu : Menu
{
	// Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039E")]
	[Address(RVA = "0x3BB740", Offset = "0x3BA940", VA = "0x1803BB740")]
	public void CancelDeleteAccount()
	{
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039F")]
	[Address(RVA = "0x3BB8F0", Offset = "0x3BAAF0", VA = "0x1803BB8F0")]
	public void ChangePassword()
	{
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x3BB9F0", Offset = "0x3BABF0", VA = "0x1803BB9F0")]
	public void DeleteAccount()
	{
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x3BBD40", Offset = "0x3BAF40", VA = "0x1803BBD40")]
	public void LinkSteam()
	{
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x3BBC40", Offset = "0x3BAE40", VA = "0x1803BBC40")]
	public void LanguageChanged()
	{
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x3BBED0", Offset = "0x3BB0D0", VA = "0x1803BBED0")]
	public void Logout()
	{
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x3BBFA0", Offset = "0x3BB1A0", VA = "0x1803BBFA0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x3BB670", Offset = "0x3BA870", VA = "0x1803BB670")]
	private Task CancelDeleteAccountAsync()
	{
		return null;
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x3BB9F0", Offset = "0x3BABF0", VA = "0x1803BB9F0")]
	private Task DeleteAccountAsync()
	{
		return null;
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x3BBFC0", Offset = "0x3BB1C0", VA = "0x1803BBFC0")]
	private void UpdateValues()
	{
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x3BBBC0", Offset = "0x3BADC0", VA = "0x1803BBBC0")]
	private IEnumerable<ValueTuple<GameObject, bool>> GetIntegrations()
	{
		return null;
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x3BB580", Offset = "0x3BA780", VA = "0x1803BB580")]
	private Task<int> AlertLogoutAsync()
	{
		return null;
	}

	// Token: 0x060003AA RID: 938 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x3BB490", Offset = "0x3BA690", VA = "0x1803BB490")]
	private Task<int> AlertGuestLogoutAsync()
	{
		return null;
	}

	// Token: 0x060003AB RID: 939 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x3BB820", Offset = "0x3BAA20", VA = "0x1803BB820")]
	private Task ChangePasswordAsync()
	{
		return null;
	}

	// Token: 0x060003AC RID: 940 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x3BBC50", Offset = "0x3BAE50", VA = "0x1803BBC50")]
	private Task LinkSteamAsync(long @override = 0L)
	{
		return null;
	}

	// Token: 0x060003AD RID: 941 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x3BBAD0", Offset = "0x3BACD0", VA = "0x1803BBAD0")]
	private Task ExistingAccountAsync(SteamLinkResponse response)
	{
		return null;
	}

	// Token: 0x060003AE RID: 942 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x3BBED0", Offset = "0x3BB0D0", VA = "0x1803BBED0")]
	private Task LogoutAsync()
	{
		return null;
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public AccountInfoMenu()
	{
	}

	// Token: 0x04000387 RID: 903
	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x90")]
	public TMP_Text EmailLabel;

	// Token: 0x04000388 RID: 904
	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x98")]
	public TMP_Text TimePlayedLabel;

	// Token: 0x04000389 RID: 905
	[Token(Token = "0x4000389")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject IntegrationsLabel;

	// Token: 0x0400038A RID: 906
	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject SteamIntegration;

	// Token: 0x0400038B RID: 907
	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject RegisterButton;

	// Token: 0x0400038C RID: 908
	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0xB8")]
	public TMP_Text DeletedAt;

	// Token: 0x0400038D RID: 909
	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject DeleteAccountTray;

	// Token: 0x0400038E RID: 910
	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject DeleteAccountButton;

	// Token: 0x0400038F RID: 911
	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject CancelDeleteButton;
}
