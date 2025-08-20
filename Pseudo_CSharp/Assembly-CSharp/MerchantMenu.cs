using System;
using Il2CppDummyDll;
using TMPro;

// Token: 0x020002C1 RID: 705
[Token(Token = "0x20002C1")]
public class MerchantMenu : Menu
{
	// Token: 0x06000F12 RID: 3858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F12")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090")]
	public void Purchase(int index)
	{
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F13")]
	[Address(RVA = "0x46F6E0", Offset = "0x46E8E0", VA = "0x18046F6E0")]
	public void Setup(Entity merchant)
	{
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F14")]
	[Address(RVA = "0x46F680", Offset = "0x46E880", VA = "0x18046F680")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F15")]
	[Address(RVA = "0x3BC980", Offset = "0x3BBB80", VA = "0x1803BC980")]
	public MerchantMenu()
	{
	}

	// Token: 0x04000C7A RID: 3194
	[Token(Token = "0x4000C7A")]
	[FieldOffset(Offset = "0x90")]
	public World World;

	// Token: 0x04000C7B RID: 3195
	[Token(Token = "0x4000C7B")]
	[FieldOffset(Offset = "0x98")]
	public MerchantSlot[] Slots;

	// Token: 0x04000C7C RID: 3196
	[Token(Token = "0x4000C7C")]
	[FieldOffset(Offset = "0xA0")]
	public TMP_Text MerchantName;

	// Token: 0x04000C7D RID: 3197
	[Token(Token = "0x4000C7D")]
	[FieldOffset(Offset = "0xA8")]
	private uint _merchantId;
}
