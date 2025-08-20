using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000DF RID: 223
[Token(Token = "0x20000DF")]
public class AccountMenu : Menu
{
	// Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x3BD840", Offset = "0x3BCA40", VA = "0x1803BD840")]
	public void AccountInfo()
	{
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x3BD860", Offset = "0x3BCA60", VA = "0x1803BD860")]
	public void Logout()
	{
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x3BDAC0", Offset = "0x3BCCC0", VA = "0x1803BDAC0")]
	public void Servers()
	{
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x3BD8C0", Offset = "0x3BCAC0", VA = "0x1803BD8C0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x3BD8B0", Offset = "0x3BCAB0", VA = "0x1803BD8B0")]
	private void MoveToPreviousMenu()
	{
	}

	// Token: 0x060003DE RID: 990 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x3BDBD0", Offset = "0x3BCDD0", VA = "0x1803BDBD0")]
	private Task SetupAsync()
	{
		return null;
	}

	// Token: 0x060003DF RID: 991 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x3BDAE0", Offset = "0x3BCCE0", VA = "0x1803BDAE0")]
	private Task<ValueTuple<bool, bool>> SetupAccountAsync()
	{
		return null;
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x3BDCA0", Offset = "0x3BCEA0", VA = "0x1803BDCA0")]
	public AccountMenu()
	{
	}

	// Token: 0x040003DA RID: 986
	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x90")]
	public Menu EmailVerificationMenu;

	// Token: 0x040003DB RID: 987
	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0x98")]
	public Menu UsernameMenu;

	// Token: 0x040003DC RID: 988
	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0xA0")]
	public Menu CharactersMenu;

	// Token: 0x040003DD RID: 989
	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0xA8")]
	public Menu ServersMenu;

	// Token: 0x040003DE RID: 990
	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0xB0")]
	public Menu AccountInfoMenu;

	// Token: 0x040003DF RID: 991
	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject MapEditorButton;

	// Token: 0x040003E0 RID: 992
	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0xC0")]
	public TextMeshProUGUI UsernameLabel;

	// Token: 0x040003E1 RID: 993
	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0xC8")]
	public TextMeshProUGUI ServerLabel;

	// Token: 0x040003E2 RID: 994
	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0xD0")]
	public TextMeshProUGUI PrestigeLabel;

	// Token: 0x040003E3 RID: 995
	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0xD8")]
	private bool _reloadOnEnter;
}
