using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using UnityEngine;

// Token: 0x020001EF RID: 495
[Token(Token = "0x20001EF")]
public class StatusEffectsGui : MonoBehaviour
{
	// Token: 0x06000A34 RID: 2612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A34")]
	[Address(RVA = "0x4283E0", Offset = "0x4275E0", VA = "0x1804283E0")]
	public void SetHeight(float height)
	{
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A35")]
	[Address(RVA = "0x430700", Offset = "0x42F900", VA = "0x180430700")]
	public void SetOpacity(float opacity)
	{
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A36")]
	[Address(RVA = "0x430880", Offset = "0x42FA80", VA = "0x180430880")]
	public void Setup(Transform target, StatusEffects statusEffects, float height)
	{
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A37")]
	[Address(RVA = "0x430420", Offset = "0x42F620", VA = "0x180430420")]
	private void ClearEffects(int startIndex)
	{
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000A38")]
	[Address(RVA = "0x4304C0", Offset = "0x42F6C0", VA = "0x1804304C0")]
	private SpriteRenderer GetEffect(int index)
	{
		return null;
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A39")]
	[Address(RVA = "0x430B80", Offset = "0x42FD80", VA = "0x180430B80")]
	public StatusEffectsGui()
	{
	}

	// Token: 0x04000975 RID: 2421
	[Token(Token = "0x4000975")]
	[FieldOffset(Offset = "0x20")]
	public Follow Follow;

	// Token: 0x04000976 RID: 2422
	[Token(Token = "0x4000976")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer EffectPrefab;

	// Token: 0x04000977 RID: 2423
	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<SpriteRenderer> _effects;
}
