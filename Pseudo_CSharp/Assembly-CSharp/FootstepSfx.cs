using System;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using Ronin.Model.Simulation.Components;
using UnityEngine;

// Token: 0x0200016B RID: 363
[Token(Token = "0x200016B")]
public struct FootstepSfx
{
	// Token: 0x06000729 RID: 1833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000729")]
	[Address(RVA = "0x3EEC10", Offset = "0x3EDE10", VA = "0x1803EEC10")]
	public void Setup(Entity entity)
	{
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072A")]
	[Address(RVA = "0x3EEC60", Offset = "0x3EDE60", VA = "0x1803EEC60")]
	public void UpdateGround(GroundDefinition groundDefinition)
	{
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072B")]
	[Address(RVA = "0x3EEFA0", Offset = "0x3EE1A0", VA = "0x1803EEFA0")]
	public void Update(ref EntityState state)
	{
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072C")]
	[Address(RVA = "0x3EED40", Offset = "0x3EDF40", VA = "0x1803EED40")]
	private void UpdatePosition(ref EntityState state)
	{
	}

	// Token: 0x0400071D RID: 1821
	[Token(Token = "0x400071D")]
	[FieldOffset(Offset = "0x0")]
	public Entity Entity;

	// Token: 0x0400071E RID: 1822
	[Token(Token = "0x400071E")]
	[FieldOffset(Offset = "0x8")]
	private GroundDefinition _groundDefinition;

	// Token: 0x0400071F RID: 1823
	[Token(Token = "0x400071F")]
	[FieldOffset(Offset = "0x10")]
	private SfxClip _footstepSfx;

	// Token: 0x04000720 RID: 1824
	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x18")]
	private float _footstepDistance;

	// Token: 0x04000721 RID: 1825
	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x1C")]
	private Vector2 _lastPosition;

	// Token: 0x04000722 RID: 1826
	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0x24")]
	private bool _inAir;

	// Token: 0x04000723 RID: 1827
	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0x25")]
	private bool _stopped;
}
