using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BE RID: 190
[Token(Token = "0x20000BE")]
public class LightFlicker : MonoBehaviour
{
	// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000343")]
	[Address(RVA = "0x3C5EC0", Offset = "0x3C50C0", VA = "0x1803C5EC0")]
	private void Awake()
	{
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000344")]
	[Address(RVA = "0x3C5F90", Offset = "0x3C5190", VA = "0x1803C5F90")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000345")]
	[Address(RVA = "0x3C6050", Offset = "0x3C5250", VA = "0x1803C6050")]
	private void NextFlicker()
	{
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000346")]
	[Address(RVA = "0x3C60C0", Offset = "0x3C52C0", VA = "0x1803C60C0")]
	public LightFlicker()
	{
	}

	// Token: 0x0400032E RID: 814
	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer SpriteRenderer;

	// Token: 0x0400032F RID: 815
	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x28")]
	public Color Color;

	// Token: 0x04000330 RID: 816
	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x38")]
	public float DurationMin;

	// Token: 0x04000331 RID: 817
	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x3C")]
	public float DurationMax;

	// Token: 0x04000332 RID: 818
	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x40")]
	public float DipMin;

	// Token: 0x04000333 RID: 819
	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x44")]
	public float DipMax;

	// Token: 0x04000334 RID: 820
	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x48")]
	private float _startTime;

	// Token: 0x04000335 RID: 821
	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x4C")]
	private float _endTime;

	// Token: 0x04000336 RID: 822
	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x50")]
	private float _dip;
}
