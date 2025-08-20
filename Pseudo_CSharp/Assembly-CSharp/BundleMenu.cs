using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Ronin.Api.Model.Bundle;

// Token: 0x020002B9 RID: 697
[Token(Token = "0x20002B9")]
public class BundleMenu : Menu
{
	// Token: 0x06000EF4 RID: 3828 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EF4")]
	[Address(RVA = "0x463C90", Offset = "0x462E90", VA = "0x180463C90")]
	public void Purchase(BundleDisplay display)
	{
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EF5")]
	[Address(RVA = "0x463960", Offset = "0x462B60", VA = "0x180463960")]
	private void OnEnable()
	{
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000EF6")]
	[Address(RVA = "0x463B90", Offset = "0x462D90", VA = "0x180463B90")]
	private Task PurchaseAsync(GetBundleResponse bundle)
	{
		return null;
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EF7")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public BundleMenu()
	{
	}

	// Token: 0x04000C54 RID: 3156
	[Token(Token = "0x4000C54")]
	[FieldOffset(Offset = "0x90")]
	public GameObjectGallery Gallery;
}
