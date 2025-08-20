using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020001BE RID: 446
[Token(Token = "0x20001BE")]
public class SliderInput : MonoBehaviour
{
	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000905 RID: 2309 RVA: 0x00004440 File Offset: 0x00002640
	[Token(Token = "0x170000E1")]
	public long Value
	{
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x3944E0", Offset = "0x3936E0", VA = "0x1803944E0")]
		get
		{
			return 0L;
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06000906 RID: 2310 RVA: 0x00004458 File Offset: 0x00002658
	// (set) Token: 0x06000907 RID: 2311 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000E2")]
	public long MinValue
	{
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x41B0C0", Offset = "0x41A2C0", VA = "0x18041B0C0")]
		get
		{
			return 0L;
		}
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x41B120", Offset = "0x41A320", VA = "0x18041B120")]
		set
		{
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x06000908 RID: 2312 RVA: 0x00004470 File Offset: 0x00002670
	// (set) Token: 0x06000909 RID: 2313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000E3")]
	public long MaxValue
	{
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x41B090", Offset = "0x41A290", VA = "0x18041B090")]
		get
		{
			return 0L;
		}
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x41B0F0", Offset = "0x41A2F0", VA = "0x18041B0F0")]
		set
		{
		}
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600090A")]
	[Address(RVA = "0x41AEB0", Offset = "0x41A0B0", VA = "0x18041AEB0")]
	public void OnSliderChanged(float value)
	{
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600090B")]
	[Address(RVA = "0x41AC60", Offset = "0x419E60", VA = "0x18041AC60")]
	public void OnCountChanged(string value)
	{
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600090C")]
	[Address(RVA = "0x41AFA0", Offset = "0x41A1A0", VA = "0x18041AFA0")]
	public void SetValue(long value)
	{
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600090D")]
	[Address(RVA = "0x41ADA0", Offset = "0x419FA0", VA = "0x18041ADA0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600090E")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SliderInput()
	{
	}

	// Token: 0x040008AA RID: 2218
	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0x20")]
	public TMP_InputField InputField;

	// Token: 0x040008AB RID: 2219
	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0x28")]
	public Slider Slider;

	// Token: 0x040008AC RID: 2220
	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent<long> OnChange;

	// Token: 0x040008AD RID: 2221
	[Token(Token = "0x40008AD")]
	[FieldOffset(Offset = "0x38")]
	private long _sliderValue;
}
