using System;
using Il2CppDummyDll;
using Ronin.Model.Classes;
using Zero.Game.Shared;

// Token: 0x020001FB RID: 507
[Token(Token = "0x20001FB")]
public class AoeEffect : BurstEffectBase, IBombEffect
{
	// Token: 0x06000A72 RID: 2674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A72")]
	[Address(RVA = "0x41EB80", Offset = "0x41DD80", VA = "0x18041EB80", Slot = "9")]
	public void Setup(World world, AttackDescriptor attackDescriptor, Vec2 finalCoordinates)
	{
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A73")]
	[Address(RVA = "0x41EA70", Offset = "0x41DC70", VA = "0x18041EA70")]
	public void Setup(World world, float radius, Vec2 coordinates)
	{
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A74")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public AoeEffect()
	{
	}

	// Token: 0x0400099D RID: 2461
	[Token(Token = "0x400099D")]
	private const float SpeedModifierScalar = 5.714286f;
}
