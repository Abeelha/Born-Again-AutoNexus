using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002E3 RID: 739
[Token(Token = "0x20002E3")]
public class MedallionShop : MonoBehaviour
{
	// Token: 0x06001019 RID: 4121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001019")]
	[Address(RVA = "0x350B40", Offset = "0x34FD40", VA = "0x180350B40")]
	public void LanguageChanged()
	{
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101A")]
	[Address(RVA = "0x350BD0", Offset = "0x34FDD0", VA = "0x180350BD0")]
	public void SetPending(bool pending)
	{
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101B")]
	[Address(RVA = "0x350D50", Offset = "0x34FF50", VA = "0x180350D50")]
	public void SetPriceString(string priceString)
	{
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101C")]
	[Address(RVA = "0x350B50", Offset = "0x34FD50", VA = "0x180350B50")]
	public void Purchase()
	{
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101D")]
	[Address(RVA = "0x350B40", Offset = "0x34FD40", VA = "0x180350B40")]
	private void Awake()
	{
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101E")]
	[Address(RVA = "0x350DE0", Offset = "0x34FFE0", VA = "0x180350DE0")]
	private void UpdateAmountLabel()
	{
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101F")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public MedallionShop()
	{
	}

	// Token: 0x04000D75 RID: 3445
	[Token(Token = "0x4000D75")]
	[FieldOffset(Offset = "0x20")]
	public MedallionShopMenu Menu;

	// Token: 0x04000D76 RID: 3446
	[Token(Token = "0x4000D76")]
	[FieldOffset(Offset = "0x28")]
	public string ProductId;

	// Token: 0x04000D77 RID: 3447
	[Token(Token = "0x4000D77")]
	[FieldOffset(Offset = "0x30")]
	public int Amount;

	// Token: 0x04000D78 RID: 3448
	[Token(Token = "0x4000D78")]
	[FieldOffset(Offset = "0x34")]
	public int Bonus;

	// Token: 0x04000D79 RID: 3449
	[Token(Token = "0x4000D79")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI AmountLabel;

	// Token: 0x04000D7A RID: 3450
	[Token(Token = "0x4000D7A")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI PriceLabel;

	// Token: 0x04000D7B RID: 3451
	[Token(Token = "0x4000D7B")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI PendingLabel;

	// Token: 0x04000D7C RID: 3452
	[Token(Token = "0x4000D7C")]
	[FieldOffset(Offset = "0x50")]
	public Button PurchaseButton;

	// Token: 0x04000D7D RID: 3453
	[Token(Token = "0x4000D7D")]
	[FieldOffset(Offset = "0x58")]
	public Button BackgroundButton;
}
