using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020001BB RID: 443
[Token(Token = "0x20001BB")]
public class PurchaseOptions : MonoBehaviour
{
	// Token: 0x170000DD RID: 221
	// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000DD")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x419E80", Offset = "0x419080", VA = "0x180419E80")]
		get
		{
			return null;
		}
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x419A50", Offset = "0x418C50", VA = "0x180419A50")]
	public void PurchaseHonor()
	{
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x419AA0", Offset = "0x418CA0", VA = "0x180419AA0")]
	public void PurchaseMedallions()
	{
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x419AF0", Offset = "0x418CF0", VA = "0x180419AF0")]
	public void SetPrice(int honor, int medallions, int regularHonor = -1)
	{
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x000043C8 File Offset: 0x000025C8
	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x419A10", Offset = "0x418C10", VA = "0x180419A10")]
	private int GetCount(int honor, int medallions)
	{
		return 0;
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x000043E0 File Offset: 0x000025E0
	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x419A30", Offset = "0x418C30", VA = "0x180419A30")]
	private float GetWidth(int count)
	{
		return 0f;
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x419E50", Offset = "0x419050", VA = "0x180419E50")]
	public PurchaseOptions()
	{
	}

	// Token: 0x0400089B RID: 2203
	[Token(Token = "0x400089B")]
	[FieldOffset(Offset = "0x20")]
	public float Spacing;

	// Token: 0x0400089C RID: 2204
	[Token(Token = "0x400089C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HonorButton;

	// Token: 0x0400089D RID: 2205
	[Token(Token = "0x400089D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject MedallionsButton;

	// Token: 0x0400089E RID: 2206
	[Token(Token = "0x400089E")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI HonorLabel;

	// Token: 0x0400089F RID: 2207
	[Token(Token = "0x400089F")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI MedallionsLabel;

	// Token: 0x040008A0 RID: 2208
	[Token(Token = "0x40008A0")]
	[FieldOffset(Offset = "0x48")]
	public UnityEvent<CurrencyType> OnPurchase;

	// Token: 0x040008A1 RID: 2209
	[Token(Token = "0x40008A1")]
	[FieldOffset(Offset = "0x50")]
	private int _honor;

	// Token: 0x040008A2 RID: 2210
	[Token(Token = "0x40008A2")]
	[FieldOffset(Offset = "0x54")]
	private int _regularHonor;

	// Token: 0x040008A3 RID: 2211
	[Token(Token = "0x40008A3")]
	[FieldOffset(Offset = "0x58")]
	private int _medallions;
}
