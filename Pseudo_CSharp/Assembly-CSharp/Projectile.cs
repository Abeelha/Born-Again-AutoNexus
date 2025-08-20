using System;
using Il2CppDummyDll;
using UnityEngine;
using Zero.Game.Shared;

// Token: 0x020001E1 RID: 481
[Token(Token = "0x20001E1")]
public class Projectile : AttackRepresentation
{
	// Token: 0x060009C9 RID: 2505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x42D490", Offset = "0x42C690", VA = "0x18042D490", Slot = "4")]
	protected override void LateUpdate()
	{
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x42D4D0", Offset = "0x42C6D0", VA = "0x18042D4D0", Slot = "5")]
	protected override void Live()
	{
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009CB")]
	[Address(RVA = "0x42D680", Offset = "0x42C880", VA = "0x18042D680", Slot = "7")]
	protected override void Setup()
	{
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x42D560", Offset = "0x42C760", VA = "0x18042D560", Slot = "6")]
	protected override void Return()
	{
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x00004830 File Offset: 0x00002A30
	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x42D200", Offset = "0x42C400", VA = "0x18042D200")]
	private Vec2 GetCoordinates()
	{
		return default(Vec2);
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x00004848 File Offset: 0x00002A48
	[Token(Token = "0x60009CE")]
	[Address(RVA = "0x42D3E0", Offset = "0x42C5E0", VA = "0x18042D3E0")]
	private float GetRotation()
	{
		return 0f;
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x00004860 File Offset: 0x00002A60
	[Token(Token = "0x60009CF")]
	[Address(RVA = "0x42D2F0", Offset = "0x42C4F0", VA = "0x18042D2F0")]
	private float GetHeight()
	{
		return 0f;
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D0")]
	[Address(RVA = "0x42DE80", Offset = "0x42D080", VA = "0x18042DE80")]
	private void Show()
	{
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D1")]
	[Address(RVA = "0x42E6E0", Offset = "0x42D8E0", VA = "0x18042E6E0")]
	private void UpdateCoordinates()
	{
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D2")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public Projectile()
	{
	}

	// Token: 0x0400090B RID: 2315
	[Token(Token = "0x400090B")]
	[FieldOffset(Offset = "0x0")]
	private static int s_shadowLayerId;

	// Token: 0x0400090C RID: 2316
	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0x4")]
	private static int s_entitiesLayerId;

	// Token: 0x0400090D RID: 2317
	[Token(Token = "0x400090D")]
	[FieldOffset(Offset = "0xB0")]
	public AnimationRunner AnimationRunner;

	// Token: 0x0400090E RID: 2318
	[Token(Token = "0x400090E")]
	[FieldOffset(Offset = "0xB8")]
	public SpriteRenderer SpriteRenderer;

	// Token: 0x0400090F RID: 2319
	[Token(Token = "0x400090F")]
	[FieldOffset(Offset = "0xC0")]
	private LineIndicator _indicator;

	// Token: 0x04000910 RID: 2320
	[Token(Token = "0x4000910")]
	[FieldOffset(Offset = "0xC8")]
	private Shadow _shadow;

	// Token: 0x04000911 RID: 2321
	[Token(Token = "0x4000911")]
	[FieldOffset(Offset = "0xD0")]
	private EffectBase _effect;

	// Token: 0x04000912 RID: 2322
	[Token(Token = "0x4000912")]
	[FieldOffset(Offset = "0xD8")]
	private float _startTime;
}
