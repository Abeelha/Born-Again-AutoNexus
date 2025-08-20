using System;
using System.Threading.Tasks;
using AnimateInternal;
using Il2CppDummyDll;
using TMPro;

// Token: 0x020002BB RID: 699
[Token(Token = "0x20002BB")]
public class DeathNoteMenu : Menu
{
	// Token: 0x06000EFA RID: 3834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EFA")]
	[Address(RVA = "0x4693E0", Offset = "0x4685E0", VA = "0x1804693E0", Slot = "4")]
	public override void Show()
	{
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EFB")]
	[Address(RVA = "0x469170", Offset = "0x468370", VA = "0x180469170")]
	public void Send()
	{
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000EFC")]
	[Address(RVA = "0x469310", Offset = "0x468510", VA = "0x180469310")]
	private Task ShowAsync()
	{
		return null;
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EFD")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public DeathNoteMenu()
	{
	}

	// Token: 0x04000C5B RID: 3163
	[Token(Token = "0x4000C5B")]
	[FieldOffset(Offset = "0x90")]
	private AnimateTask _showTask;

	// Token: 0x04000C5C RID: 3164
	[Token(Token = "0x4000C5C")]
	[FieldOffset(Offset = "0x98")]
	public TMP_InputField MessageInput;

	// Token: 0x04000C5D RID: 3165
	[Token(Token = "0x4000C5D")]
	[FieldOffset(Offset = "0xA0")]
	public World World;
}
