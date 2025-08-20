using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200011C RID: 284
[Token(Token = "0x200011C")]
public class LoginMenu : Menu
{
	// Token: 0x17000058 RID: 88
	// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000058")]
	public string Email
	{
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x3DA3D0", Offset = "0x3D95D0", VA = "0x1803DA3D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000059")]
	public string Password
	{
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x3DA460", Offset = "0x3D9660", VA = "0x1803DA460")]
		get
		{
			return null;
		}
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x3D9AE0", Offset = "0x3D8CE0", VA = "0x1803D9AE0")]
	public void ForgotPassword()
	{
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x3D9E80", Offset = "0x3D9080", VA = "0x1803D9E80")]
	public void Login()
	{
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x3DA020", Offset = "0x3D9220", VA = "0x1803DA020", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x3D99E0", Offset = "0x3D8BE0", VA = "0x1803D99E0")]
	private Task ForgotPasswordAsync(string email)
	{
		return null;
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x3D9D60", Offset = "0x3D8F60", VA = "0x1803D9D60")]
	private Task LoginAsync(string email, string password)
	{
		return null;
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00003498 File Offset: 0x00001698
	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x3DA150", Offset = "0x3D9350", VA = "0x1803DA150")]
	private bool ValidateInput()
	{
		return default(bool);
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public LoginMenu()
	{
	}

	// Token: 0x0400053B RID: 1339
	[Token(Token = "0x400053B")]
	[FieldOffset(Offset = "0x90")]
	public TMP_InputField EmailInput;

	// Token: 0x0400053C RID: 1340
	[Token(Token = "0x400053C")]
	[FieldOffset(Offset = "0x98")]
	public TMP_InputField PasswordInput;

	// Token: 0x0400053D RID: 1341
	[Token(Token = "0x400053D")]
	[FieldOffset(Offset = "0xA0")]
	public RectTransform AppleSignIn;

	// Token: 0x0400053E RID: 1342
	[Token(Token = "0x400053E")]
	[FieldOffset(Offset = "0xA8")]
	public RectTransform GoogleSignIn;

	// Token: 0x0400053F RID: 1343
	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0xB0")]
	private Task _loginTask;

	// Token: 0x04000540 RID: 1344
	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0xB8")]
	private float? _defaultHeight;
}
