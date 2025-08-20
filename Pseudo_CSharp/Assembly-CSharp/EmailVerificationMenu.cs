using System;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;

// Token: 0x02000108 RID: 264
[Token(Token = "0x2000108")]
public class EmailVerificationMenu : Menu
{
	// Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000476")]
	[Address(RVA = "0x3D4500", Offset = "0x3D3700", VA = "0x1803D4500")]
	public void ChangeEmail()
	{
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000477")]
	[Address(RVA = "0x3D4510", Offset = "0x3D3710", VA = "0x1803D4510")]
	public void Dismiss()
	{
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000478")]
	[Address(RVA = "0x3D49E0", Offset = "0x3D3BE0", VA = "0x1803D49E0")]
	public void Resend()
	{
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000479")]
	[Address(RVA = "0x3D46B0", Offset = "0x3D38B0", VA = "0x1803D46B0", Slot = "5")]
	protected override void OnEnter()
	{
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047A")]
	[Address(RVA = "0x3D48B0", Offset = "0x3D3AB0", VA = "0x1803D48B0", Slot = "6")]
	protected override void OnExit()
	{
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600047B")]
	[Address(RVA = "0x3D45C0", Offset = "0x3D37C0", VA = "0x1803D45C0")]
	private Task EmailVerifiedLoopAsync(CancellationToken token)
	{
		return null;
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600047C")]
	[Address(RVA = "0x3D4910", Offset = "0x3D3B10", VA = "0x1803D4910")]
	private Task ResendVerificationEmailAsync()
	{
		return null;
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047D")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public EmailVerificationMenu()
	{
	}

	// Token: 0x040004C8 RID: 1224
	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0x90")]
	public TextMeshProUGUI EmailLabel;

	// Token: 0x040004C9 RID: 1225
	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x98")]
	public RegisterMenu RegisterMenu;

	// Token: 0x040004CA RID: 1226
	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0xA0")]
	public AccountLoadMenu AccountLoadMenu;

	// Token: 0x040004CB RID: 1227
	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0xA8")]
	private CancellationTokenSource _cancellation;
}
