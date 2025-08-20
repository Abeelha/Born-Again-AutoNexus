using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200018A RID: 394
[Token(Token = "0x200018A")]
public class GalleryArrow : MonoBehaviour
{
	// Token: 0x060007E7 RID: 2023 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x411550", Offset = "0x410750", VA = "0x180411550")]
	private void Awake()
	{
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x411550", Offset = "0x410750", VA = "0x180411550")]
	private void GetGraphic()
	{
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x411650", Offset = "0x410850", VA = "0x180411650")]
	private void LateUpdate()
	{
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x411660", Offset = "0x410860", VA = "0x180411660")]
	private void UpdateAlpha()
	{
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x00003FA8 File Offset: 0x000021A8
	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x4115A0", Offset = "0x4107A0", VA = "0x1804115A0")]
	private float GetAlphaIndex()
	{
		return 0f;
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x00003FC0 File Offset: 0x000021C0
	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x4115F0", Offset = "0x4107F0", VA = "0x1804115F0")]
	private float GetIndexOrigin()
	{
		return 0f;
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x00003FD8 File Offset: 0x000021D8
	[Token(Token = "0x60007ED")]
	[Address(RVA = "0x411630", Offset = "0x410830", VA = "0x180411630")]
	private float GetRelativeDifference(float alphaValue, float indexValue)
	{
		return 0f;
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007EE")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public GalleryArrow()
	{
	}

	// Token: 0x040007CA RID: 1994
	[Token(Token = "0x40007CA")]
	[FieldOffset(Offset = "0x20")]
	public Gallery Gallery;

	// Token: 0x040007CB RID: 1995
	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0x28")]
	public float RelativeStartIndex;

	// Token: 0x040007CC RID: 1996
	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x2C")]
	public Origin RelativeTo;

	// Token: 0x040007CD RID: 1997
	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x30")]
	public float AlphaBuffer;

	// Token: 0x040007CE RID: 1998
	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x34")]
	public Comparison AlphaComparison;

	// Token: 0x040007CF RID: 1999
	[Token(Token = "0x40007CF")]
	[FieldOffset(Offset = "0x38")]
	public float MaxAlpha;

	// Token: 0x040007D0 RID: 2000
	[Token(Token = "0x40007D0")]
	[FieldOffset(Offset = "0x40")]
	private Graphic _graphic;
}
