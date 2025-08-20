using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020001BD RID: 445
[Token(Token = "0x20001BD")]
public class SliderFloatInput : MonoBehaviour
{
	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060008FD RID: 2301 RVA: 0x000043F8 File Offset: 0x000025F8
	[Token(Token = "0x170000DE")]
	public float Value
	{
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x41AC50", Offset = "0x419E50", VA = "0x18041AC50")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x060008FE RID: 2302 RVA: 0x00004410 File Offset: 0x00002610
	[Token(Token = "0x170000DF")]
	public float MinValue
	{
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x41AC30", Offset = "0x419E30", VA = "0x18041AC30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x060008FF RID: 2303 RVA: 0x00004428 File Offset: 0x00002628
	[Token(Token = "0x170000E0")]
	public float MaxValue
	{
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x41AC10", Offset = "0x419E10", VA = "0x18041AC10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000900")]
	[Address(RVA = "0x41AA00", Offset = "0x419C00", VA = "0x18041AA00")]
	public void OnSliderChanged(float value)
	{
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000901")]
	[Address(RVA = "0x41A7E0", Offset = "0x4199E0", VA = "0x18041A7E0")]
	public void OnCountChanged(string value)
	{
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000902")]
	[Address(RVA = "0x41AB00", Offset = "0x419D00", VA = "0x18041AB00")]
	public void SetValue(float value)
	{
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000903")]
	[Address(RVA = "0x41A8E0", Offset = "0x419AE0", VA = "0x18041A8E0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000904")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SliderFloatInput()
	{
	}

	// Token: 0x040008A6 RID: 2214
	[Token(Token = "0x40008A6")]
	[FieldOffset(Offset = "0x20")]
	public TMP_InputField InputField;

	// Token: 0x040008A7 RID: 2215
	[Token(Token = "0x40008A7")]
	[FieldOffset(Offset = "0x28")]
	public Slider Slider;

	// Token: 0x040008A8 RID: 2216
	[Token(Token = "0x40008A8")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent<float> OnChange;

	// Token: 0x040008A9 RID: 2217
	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0x38")]
	private float _sliderValue;
}
