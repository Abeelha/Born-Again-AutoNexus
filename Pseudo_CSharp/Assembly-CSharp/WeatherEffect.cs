using System;
using Il2CppDummyDll;
using Ronin.Model.Enums;
using UnityEngine;

// Token: 0x020001F9 RID: 505
[Token(Token = "0x20001F9")]
public abstract class WeatherEffect : AmbientEffect
{
	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000A6A RID: 2666
	[Token(Token = "0x170000FB")]
	public abstract WeatherType WeatherType { [Token(Token = "0x6000A6A")] get; }

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00004A70 File Offset: 0x00002C70
	[Token(Token = "0x170000FC")]
	public virtual float GlobalLightIntensity
	{
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x4328A0", Offset = "0x431AA0", VA = "0x1804328A0", Slot = "10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A6C")]
	[Address(RVA = "0x4327F0", Offset = "0x4319F0", VA = "0x1804327F0", Slot = "11")]
	public virtual void SetIntensity(float intensity)
	{
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A6D")]
	[Address(RVA = "0x432300", Offset = "0x431500", VA = "0x180432300", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A6E")]
	[Address(RVA = "0x4323F0", Offset = "0x4315F0", VA = "0x1804323F0", Slot = "8")]
	protected override void LateUpdate()
	{
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A6F")]
	[Address(RVA = "0x4326C0", Offset = "0x4318C0", VA = "0x1804326C0")]
	private void ScaleToScreenSize()
	{
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A70")]
	[Address(RVA = "0x41EA00", Offset = "0x41DC00", VA = "0x18041EA00")]
	protected WeatherEffect()
	{
	}

	// Token: 0x0400099B RID: 2459
	[Token(Token = "0x400099B")]
	[FieldOffset(Offset = "0x68")]
	private float[] _rateOverTime;

	// Token: 0x0400099C RID: 2460
	[Token(Token = "0x400099C")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 _syncedSize;
}
