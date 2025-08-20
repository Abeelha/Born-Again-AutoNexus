using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000214 RID: 532
[Token(Token = "0x2000214")]
public class ExpEffect : BurstEffectBase
{
	// Token: 0x06000A92 RID: 2706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x426580", Offset = "0x425780", VA = "0x180426580")]
	public void Setup(Vector2 source, Transform target, World world, uint experience)
	{
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A93")]
	[Address(RVA = "0x426340", Offset = "0x425540", VA = "0x180426340", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x00004AA0 File Offset: 0x00002CA0
	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x426400", Offset = "0x425600", VA = "0x180426400")]
	private static Vector2 CubicBezier(Vector2 startPoint, Vector2 startVector, Vector2 endPoint, Vector2 endVector, float time)
	{
		return default(Vector2);
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A95")]
	[Address(RVA = "0x426D40", Offset = "0x425F40", VA = "0x180426D40")]
	private void Update()
	{
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A96")]
	[Address(RVA = "0x426970", Offset = "0x425B70", VA = "0x180426970")]
	private void UpdateParticles()
	{
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A97")]
	[Address(RVA = "0x426D50", Offset = "0x425F50", VA = "0x180426D50")]
	public ExpEffect()
	{
	}

	// Token: 0x040009A1 RID: 2465
	[Token(Token = "0x40009A1")]
	[FieldOffset(Offset = "0x50")]
	public float VectorAngleOffset;

	// Token: 0x040009A2 RID: 2466
	[Token(Token = "0x40009A2")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 VectorMagnitudeRange;

	// Token: 0x040009A3 RID: 2467
	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x5C")]
	public EasingType EasingType;

	// Token: 0x040009A4 RID: 2468
	[Token(Token = "0x40009A4")]
	[FieldOffset(Offset = "0x60")]
	public string SfxLabel;

	// Token: 0x040009A5 RID: 2469
	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x68")]
	private ParticleSystem.Particle[] _particles;

	// Token: 0x040009A6 RID: 2470
	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 _start;

	// Token: 0x040009A7 RID: 2471
	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x7C")]
	private int _particleCount;

	// Token: 0x040009A8 RID: 2472
	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x80")]
	private Transform _target;

	// Token: 0x040009A9 RID: 2473
	[Token(Token = "0x40009A9")]
	[FieldOffset(Offset = "0x88")]
	private SfxClip _sfx;
}
