using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002E2 RID: 738
[Token(Token = "0x20002E2")]
public class BundleDisplay : MonoBehaviour
{
	// Token: 0x06001012 RID: 4114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001012")]
	[Address(RVA = "0x34D040", Offset = "0x34C240", VA = "0x18034D040")]
	public void LanguageChanged()
	{
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001013")]
	[Address(RVA = "0x34D240", Offset = "0x34C440", VA = "0x18034D240")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001014")]
	[Address(RVA = "0x34D380", Offset = "0x34C580", VA = "0x18034D380")]
	private void OnEnable()
	{
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001015")]
	[Address(RVA = "0x34D850", Offset = "0x34CA50", VA = "0x18034D850")]
	private void UpdateEndsIn()
	{
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001016")]
	[Address(RVA = "0x34D6C0", Offset = "0x34C8C0", VA = "0x18034D6C0")]
	private void SetPurchased(bool purchased)
	{
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001017")]
	[Address(RVA = "0x34DB90", Offset = "0x34CD90", VA = "0x18034DB90")]
	private void UpdatePrice()
	{
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001018")]
	[Address(RVA = "0x34DCC0", Offset = "0x34CEC0", VA = "0x18034DCC0")]
	public BundleDisplay()
	{
	}

	// Token: 0x04000D6B RID: 3435
	[Token(Token = "0x4000D6B")]
	[FieldOffset(Offset = "0x20")]
	public int BundleId;

	// Token: 0x04000D6C RID: 3436
	[Token(Token = "0x4000D6C")]
	[FieldOffset(Offset = "0x24")]
	public int Value;

	// Token: 0x04000D6D RID: 3437
	[Token(Token = "0x4000D6D")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI ValueLabel;

	// Token: 0x04000D6E RID: 3438
	[Token(Token = "0x4000D6E")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI PriceLabel;

	// Token: 0x04000D6F RID: 3439
	[Token(Token = "0x4000D6F")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI PurchasedLabel;

	// Token: 0x04000D70 RID: 3440
	[Token(Token = "0x4000D70")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI EndsInLabel;

	// Token: 0x04000D71 RID: 3441
	[Token(Token = "0x4000D71")]
	[FieldOffset(Offset = "0x48")]
	public Button PurchaseButton;

	// Token: 0x04000D72 RID: 3442
	[Token(Token = "0x4000D72")]
	[FieldOffset(Offset = "0x50")]
	public Button BackgroundButton;

	// Token: 0x04000D73 RID: 3443
	[Token(Token = "0x4000D73")]
	[FieldOffset(Offset = "0x58")]
	private bool _purchased;

	// Token: 0x04000D74 RID: 3444
	[Token(Token = "0x4000D74")]
	[FieldOffset(Offset = "0x60")]
	private long _timeRemaining;
}
