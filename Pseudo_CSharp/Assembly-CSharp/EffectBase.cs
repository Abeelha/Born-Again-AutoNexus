using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using Zero.Game.Shared;

// Token: 0x020001F8 RID: 504
[Token(Token = "0x20001F8")]
public class EffectBase : MonoBehaviour
{
	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000FA")]
	public World World
	{
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x40CFC0", Offset = "0x40C1C0", VA = "0x18040CFC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x353100", Offset = "0x352300", VA = "0x180353100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "4")]
	public virtual void HitBy(Attack attack, Vec2 attackCoordinates, bool isPlayer)
	{
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x425250", Offset = "0x424450", VA = "0x180425250")]
	public void SetMask(Vector3 vector3)
	{
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A62")]
	[Address(RVA = "0x425280", Offset = "0x424480", VA = "0x180425280")]
	public void SetOffset(Vector3 vector3)
	{
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A63")]
	[Address(RVA = "0x4252B0", Offset = "0x4244B0", VA = "0x1804252B0")]
	public void SetOwner(WorldObject worldObject)
	{
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A64")]
	[Address(RVA = "0x425350", Offset = "0x424550", VA = "0x180425350")]
	public void SetTarget(Transform transform)
	{
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A65")]
	[Address(RVA = "0x353100", Offset = "0x352300", VA = "0x180353100", Slot = "5")]
	public virtual void SetWorld(World world)
	{
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x425160", Offset = "0x424360", VA = "0x180425160", Slot = "6")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A67")]
	[Address(RVA = "0x425240", Offset = "0x424440", VA = "0x180425240", Slot = "7")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A68")]
	[Address(RVA = "0x425370", Offset = "0x424570", VA = "0x180425370")]
	private void SetTiming()
	{
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A69")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public EffectBase()
	{
	}

	// Token: 0x04000995 RID: 2453
	[Token(Token = "0x4000995")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem ParticleSystem;

	// Token: 0x04000996 RID: 2454
	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem[] ParticleSystems;

	// Token: 0x04000997 RID: 2455
	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x30")]
	public ParticleTiming Timing;

	// Token: 0x04000998 RID: 2456
	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0x38")]
	public WorldObject Owner;

	// Token: 0x04000999 RID: 2457
	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x40")]
	private Follow _follow;
}
