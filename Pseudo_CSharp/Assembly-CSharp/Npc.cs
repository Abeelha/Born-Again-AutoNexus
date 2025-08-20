using System;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using Ronin.Model.Files.Animation;
using Ronin.Model.Structs;
using UnityEngine;

// Token: 0x0200028F RID: 655
[Token(Token = "0x200028F")]
public class Npc : Entity
{
	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x00005A90 File Offset: 0x00003C90
	[Token(Token = "0x17000182")]
	public override WorldObjectType Type
	{
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x4598D0", Offset = "0x458AD0", VA = "0x1804598D0", Slot = "13")]
		get
		{
			return (WorldObjectType)0;
		}
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0x459280", Offset = "0x458480", VA = "0x180459280", Slot = "15")]
	public override void AddToWorld(World world)
	{
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x00005AA8 File Offset: 0x00003CA8
	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0x459390", Offset = "0x458590", VA = "0x180459390", Slot = "20")]
	public override float GetSpriteHeightCurrent()
	{
		return 0f;
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x00005AC0 File Offset: 0x00003CC0
	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0x4594D0", Offset = "0x4586D0", VA = "0x1804594D0", Slot = "22")]
	public override float GetSpriteHeightStill()
	{
		return 0f;
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x00005AD8 File Offset: 0x00003CD8
	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0x4594F0", Offset = "0x4586F0", VA = "0x1804594F0", Slot = "23")]
	public override float GetSpriteWidthCurrent()
	{
		return 0f;
	}

	// Token: 0x06000DBA RID: 3514 RVA: 0x00005AF0 File Offset: 0x00003CF0
	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0x459590", Offset = "0x458790", VA = "0x180459590", Slot = "24")]
	public override float GetSpriteWidthStill()
	{
		return 0f;
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x00005B08 File Offset: 0x00003D08
	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x459430", Offset = "0x458630", VA = "0x180459430", Slot = "21")]
	public override float GetSpriteHeightFirst()
	{
		return 0f;
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0x459630", Offset = "0x458830", VA = "0x180459630", Slot = "25")]
	public override void Load(ObjectDefinition definition)
	{
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x459330", Offset = "0x458530", VA = "0x180459330", Slot = "31")]
	protected override AnimationSwitch GetAnimationForIndex(int index)
	{
		return null;
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x4598A0", Offset = "0x458AA0", VA = "0x1804598A0", Slot = "32")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "63")]
	protected override void SetAppearance(Appearance appearance)
	{
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x44F050", Offset = "0x44E250", VA = "0x18044F050")]
	public Npc()
	{
	}

	// Token: 0x04000B42 RID: 2882
	[Token(Token = "0x4000B42")]
	[FieldOffset(Offset = "0x200")]
	public GameObject[] RigObjects;

	// Token: 0x04000B43 RID: 2883
	[Token(Token = "0x4000B43")]
	[FieldOffset(Offset = "0x208")]
	private bool _usingRig;

	// Token: 0x04000B44 RID: 2884
	[Token(Token = "0x4000B44")]
	[FieldOffset(Offset = "0x20A")]
	private Appearance _appearance;
}
