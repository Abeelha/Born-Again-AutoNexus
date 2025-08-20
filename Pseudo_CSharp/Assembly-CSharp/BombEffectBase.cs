using System;
using Il2CppDummyDll;
using Ronin.Model.Classes;
using Zero.Game.Shared;

// Token: 0x020001F6 RID: 502
[Token(Token = "0x20001F6")]
public abstract class BombEffectBase : BurstEffectBase, IBombEffect
{
	// Token: 0x06000A56 RID: 2646 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A56")]
	[Address(RVA = "0x420590", Offset = "0x41F790", VA = "0x180420590", Slot = "9")]
	public void Setup(World world, AttackDescriptor attackDescriptor, Vec2 finalCoordinates)
	{
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A57")]
	[Address(RVA = "0x420540", Offset = "0x41F740", VA = "0x180420540", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A58")]
	[Address(RVA = "0x41E680", Offset = "0x41D880", VA = "0x18041E680")]
	protected BombEffectBase()
	{
	}

	// Token: 0x04000993 RID: 2451
	[Token(Token = "0x4000993")]
	[FieldOffset(Offset = "0x50")]
	public float RadiusCountScalar;

	// Token: 0x04000994 RID: 2452
	[Token(Token = "0x4000994")]
	[FieldOffset(Offset = "0x54")]
	private float _speedScalar;
}
