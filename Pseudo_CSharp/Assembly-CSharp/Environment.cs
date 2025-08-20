using System;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;
using Zero.Game.Shared;

// Token: 0x0200028B RID: 651
[Token(Token = "0x200028B")]
public class Environment : WorldObject
{
	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00005988 File Offset: 0x00003B88
	[Token(Token = "0x1700017B")]
	public override Vec2 HitPosition
	{
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x458D40", Offset = "0x457F40", VA = "0x180458D40", Slot = "9")]
		get
		{
			return default(Vec2);
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06000D94 RID: 3476 RVA: 0x000059A0 File Offset: 0x00003BA0
	[Token(Token = "0x1700017C")]
	public override WorldObjectType Type
	{
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x424260", Offset = "0x423460", VA = "0x180424260", Slot = "13")]
		get
		{
			return (WorldObjectType)0;
		}
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x457BB0", Offset = "0x456DB0", VA = "0x180457BB0", Slot = "15")]
	public override void AddToWorld(World world)
	{
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x000059B8 File Offset: 0x00003BB8
	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x4580B0", Offset = "0x4572B0", VA = "0x1804580B0", Slot = "18")]
	public override int HitBy(Attack attack, Vec2 attackCoordinates, bool isPlayer)
	{
		return 0;
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D97")]
	[Address(RVA = "0x458240", Offset = "0x457440", VA = "0x180458240", Slot = "25")]
	public override void Load(ObjectDefinition definition)
	{
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D98")]
	[Address(RVA = "0x4588A0", Offset = "0x457AA0", VA = "0x1804588A0", Slot = "26")]
	public override void RemoveFromWorld()
	{
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D99")]
	[Address(RVA = "0x458B70", Offset = "0x457D70", VA = "0x180458B70", Slot = "28")]
	public override void Unload()
	{
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D9A")]
	[Address(RVA = "0x457C50", Offset = "0x456E50", VA = "0x180457C50", Slot = "30")]
	protected override void Awake()
	{
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0x458910", Offset = "0x457B10", VA = "0x180458910", Slot = "34")]
	protected override void SetTransformPosition(Vector3 position)
	{
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x458BF0", Offset = "0x457DF0", VA = "0x180458BF0", Slot = "35")]
	protected override void Update()
	{
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x000059D0 File Offset: 0x00003BD0
	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x457E50", Offset = "0x457050", VA = "0x180457E50")]
	private float GetOpacity()
	{
		return 0f;
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x000059E8 File Offset: 0x00003BE8
	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x457CF0", Offset = "0x456EF0", VA = "0x180457CF0")]
	private Vector2 GetOpacityDimensions()
	{
		return default(Vector2);
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x457BA0", Offset = "0x456DA0", VA = "0x180457BA0")]
	public Environment()
	{
	}

	// Token: 0x04000B34 RID: 2868
	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0xF0")]
	private EffectBase _effect;

	// Token: 0x04000B35 RID: 2869
	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0xF8")]
	private EnvironmentDefinition _environmentDefinition;

	// Token: 0x04000B36 RID: 2870
	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0x100")]
	private SpriteRig _spriteRig;

	// Token: 0x04000B37 RID: 2871
	[Token(Token = "0x4000B37")]
	[FieldOffset(Offset = "0x108")]
	private bool _nearTranparency;

	// Token: 0x04000B38 RID: 2872
	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0x109")]
	private bool _hittable;

	// Token: 0x04000B39 RID: 2873
	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x10A")]
	private bool _interactable;
}
