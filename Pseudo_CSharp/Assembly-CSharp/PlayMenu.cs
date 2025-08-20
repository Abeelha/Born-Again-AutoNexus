using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AppleAuth;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000120 RID: 288
[Token(Token = "0x2000120")]
public class PlayMenu : Menu
{
	// Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x3D4500", Offset = "0x3D3700", VA = "0x1803D4500")]
	public void Login()
	{
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x3DAA40", Offset = "0x3D9C40", VA = "0x1803DAA40")]
	public void PlayNow()
	{
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x3DABC0", Offset = "0x3D9DC0", VA = "0x1803DABC0")]
	public void Register()
	{
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x3DACB0", Offset = "0x3D9EB0", VA = "0x1803DACB0")]
	public void SignInApple()
	{
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x3DAEE0", Offset = "0x3DA0E0", VA = "0x1803DAEE0")]
	public void SignInGoogle()
	{
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x3DB160", Offset = "0x3DA360", VA = "0x1803DB160")]
	public void SignInSteam()
	{
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x3DA8C0", Offset = "0x3D9AC0", VA = "0x1803DA8C0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x3DA630", Offset = "0x3D9830", VA = "0x1803DA630")]
	private Task AuthenticateGoogleAsync(string code)
	{
		return null;
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x3DA730", Offset = "0x3D9930", VA = "0x1803DA730")]
	private void LateUpdate()
	{
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x3DA7B0", Offset = "0x3D99B0", VA = "0x1803DA7B0")]
	private void OnEnable()
	{
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x3DA970", Offset = "0x3D9B70", VA = "0x1803DA970")]
	private Task PlayAsGuestAsync()
	{
		return null;
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x3DABD0", Offset = "0x3D9DD0", VA = "0x1803DABD0")]
	private Task SignInAppleAsync()
	{
		return null;
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x3DADE0", Offset = "0x3D9FE0", VA = "0x1803DADE0")]
	private Task SignInGoogleAsync([Optional] CancellationToken cancellationToken)
	{
		return null;
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000500")]
	[Address(RVA = "0x3DB080", Offset = "0x3DA280", VA = "0x1803DB080")]
	public Task SignInSteamAsync()
	{
		return null;
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000501")]
	[Address(RVA = "0x3DA7B0", Offset = "0x3D99B0", VA = "0x1803DA7B0")]
	private void UpdateSignInOptions()
	{
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000502")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public PlayMenu()
	{
	}

	// Token: 0x04000550 RID: 1360
	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject PlayAsGuest;

	// Token: 0x04000551 RID: 1361
	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Menu LoginMenu;

	// Token: 0x04000552 RID: 1362
	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Menu RegisterMenu;

	// Token: 0x04000553 RID: 1363
	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Menu SessionMenu;

	// Token: 0x04000554 RID: 1364
	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject SteamSignIn;

	// Token: 0x04000555 RID: 1365
	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject GoogleSignIn;

	// Token: 0x04000556 RID: 1366
	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject AppleSignIn;

	// Token: 0x04000557 RID: 1367
	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private AppleAuthManager _appleAuthManager;
}
