using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200021E RID: 542
[Token(Token = "0x200021E")]
public class InformationEffect : EffectBase
{
	// Token: 0x06000AA6 RID: 2726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0x428020", Offset = "0x427220", VA = "0x180428020", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0x428240", Offset = "0x427440", VA = "0x180428240")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0x41E680", Offset = "0x41D880", VA = "0x18041E680")]
	public InformationEffect()
	{
	}

	// Token: 0x040009AC RID: 2476
	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x50")]
	public float Speed;

	// Token: 0x040009AD RID: 2477
	[Token(Token = "0x40009AD")]
	[FieldOffset(Offset = "0x58")]
	public SpriteRenderer SpriteRenderer;
}
