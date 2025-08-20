using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Zero.Game.Shared;

// Token: 0x02000238 RID: 568
[Token(Token = "0x2000238")]
public class SpinnerEffect : EffectBase
{
	// Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC9")]
	[Address(RVA = "0x42FEE0", Offset = "0x42F0E0", VA = "0x18042FEE0", Slot = "4")]
	public override void HitBy(Attack attack, Vec2 attackCoordinates, bool isPlayer)
	{
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0x430140", Offset = "0x42F340", VA = "0x180430140", Slot = "7")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ACB")]
	[Address(RVA = "0x4301D0", Offset = "0x42F3D0", VA = "0x1804301D0")]
	private void Pause()
	{
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000ACC")]
	[Address(RVA = "0x42FE60", Offset = "0x42F060", VA = "0x18042FE60")]
	private IEnumerable<ParticleSystem> GetSpinnerParticlesSystems()
	{
		return null;
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ACD")]
	[Address(RVA = "0x4300F0", Offset = "0x42F2F0", VA = "0x1804300F0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ACE")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SpinnerEffect()
	{
	}

	// Token: 0x040009B5 RID: 2485
	[Token(Token = "0x40009B5")]
	[FieldOffset(Offset = "0x50")]
	public ParticleSystem ParticleSystem2;

	// Token: 0x040009B6 RID: 2486
	[Token(Token = "0x40009B6")]
	[FieldOffset(Offset = "0x58")]
	private bool _playing;

	// Token: 0x040009B7 RID: 2487
	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x5C")]
	private uint _seed;

	// Token: 0x040009B8 RID: 2488
	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x60")]
	private float _lifetime;
}
