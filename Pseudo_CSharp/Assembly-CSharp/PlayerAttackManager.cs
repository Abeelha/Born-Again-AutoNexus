using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Classes;
using Ronin.Model.GameActions;

// Token: 0x0200025B RID: 603
[Token(Token = "0x200025B")]
public class PlayerAttackManager : Manager
{
	// Token: 0x06000B5D RID: 2909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0x43C620", Offset = "0x43B820", VA = "0x18043C620", Slot = "4")]
	public override void NetworkInputUpdate()
	{
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x00004D58 File Offset: 0x00002F58
	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0x43BB40", Offset = "0x43AD40", VA = "0x18043BB40")]
	private ValueTuple<bool, float> GetAttackAngle(Entity controlledEntity, IEnumerable<ValueTuple<AttackGameAction, AttackDescriptor>> attacks)
	{
		return default(ValueTuple<bool, float>);
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x43BEC0", Offset = "0x43B0C0", VA = "0x18043BEC0")]
	private static WorldObject GetTargetClosest(Entity controlledEntity, IEnumerable<WorldObject> hittables)
	{
		return null;
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x43C270", Offset = "0x43B470", VA = "0x18043C270")]
	private static WorldObject GetTargetStrongest(Entity controlledEntity, IEnumerable<WorldObject> hittables)
	{
		return null;
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x43BAC0", Offset = "0x43ACC0", VA = "0x18043BAC0")]
	private void Awake()
	{
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public PlayerAttackManager()
	{
	}

	// Token: 0x04000A15 RID: 2581
	[Token(Token = "0x4000A15")]
	[FieldOffset(Offset = "0x28")]
	public ControlManager ControlManager;

	// Token: 0x04000A16 RID: 2582
	[Token(Token = "0x4000A16")]
	[FieldOffset(Offset = "0x30")]
	public World World;

	// Token: 0x04000A17 RID: 2583
	[Token(Token = "0x4000A17")]
	[FieldOffset(Offset = "0x38")]
	private Option _attackTargetingOption;

	// Token: 0x04000A18 RID: 2584
	[Token(Token = "0x4000A18")]
	[FieldOffset(Offset = "0x40")]
	private Option _autoFireOption;
}
