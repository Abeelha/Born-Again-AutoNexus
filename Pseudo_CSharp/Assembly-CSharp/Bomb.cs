using System;
using Il2CppDummyDll;
using UnityEngine;
using Zero.Game.Shared;

// Token: 0x020001E0 RID: 480
[Token(Token = "0x20001E0")]
public class Bomb : AttackRepresentation
{
	// Token: 0x060009BE RID: 2494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BE")]
	[Address(RVA = "0x420CF0", Offset = "0x41FEF0", VA = "0x180420CF0", Slot = "4")]
	protected override void LateUpdate()
	{
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BF")]
	[Address(RVA = "0x420D10", Offset = "0x41FF10", VA = "0x180420D10", Slot = "5")]
	protected override void Live()
	{
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C0")]
	[Address(RVA = "0x421210", Offset = "0x420410", VA = "0x180421210", Slot = "7")]
	protected override void Setup()
	{
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x421140", Offset = "0x420340", VA = "0x180421140", Slot = "6")]
	protected override void Return()
	{
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x420790", Offset = "0x41F990", VA = "0x180420790")]
	private IBombEffect GetBombEffect()
	{
		return null;
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x000047E8 File Offset: 0x000029E8
	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x4208A0", Offset = "0x41FAA0", VA = "0x1804208A0")]
	private Vec2 GetCoordinates()
	{
		return default(Vec2);
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00004800 File Offset: 0x00002A00
	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x4209A0", Offset = "0x41FBA0", VA = "0x1804209A0")]
	private float GetHeight()
	{
		return 0f;
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00004818 File Offset: 0x00002A18
	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x420C90", Offset = "0x41FE90", VA = "0x180420C90")]
	private float GetRotation()
	{
		return 0f;
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x4217B0", Offset = "0x4209B0", VA = "0x1804217B0")]
	private void Show()
	{
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x421C50", Offset = "0x420E50", VA = "0x180421C50")]
	private void UpdateCoordinates()
	{
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Bomb()
	{
	}

	// Token: 0x04000905 RID: 2309
	[Token(Token = "0x4000905")]
	[FieldOffset(Offset = "0xB0")]
	public AnimationRunner AnimationRunner;

	// Token: 0x04000906 RID: 2310
	[Token(Token = "0x4000906")]
	[FieldOffset(Offset = "0xB8")]
	public SpriteRenderer SpriteRenderer;

	// Token: 0x04000907 RID: 2311
	[Token(Token = "0x4000907")]
	[FieldOffset(Offset = "0xC0")]
	public ParticleSystem ParticleSystem;

	// Token: 0x04000908 RID: 2312
	[Token(Token = "0x4000908")]
	[FieldOffset(Offset = "0xC8")]
	private Shadow _shadow;

	// Token: 0x04000909 RID: 2313
	[Token(Token = "0x4000909")]
	[FieldOffset(Offset = "0xD0")]
	private CircleIndicator _indicator;

	// Token: 0x0400090A RID: 2314
	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0xD8")]
	private float _startTime;
}
