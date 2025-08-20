using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022A RID: 554
[Token(Token = "0x200022A")]
public class QuestEffect : EffectBase
{
	// Token: 0x06000AB5 RID: 2741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0x428020", Offset = "0x427220", VA = "0x180428020", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0x428240", Offset = "0x427440", VA = "0x180428240")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AB7")]
	[Address(RVA = "0x41E680", Offset = "0x41D880", VA = "0x18041E680")]
	public QuestEffect()
	{
	}

	// Token: 0x040009AF RID: 2479
	[Token(Token = "0x40009AF")]
	[FieldOffset(Offset = "0x50")]
	public float Speed;

	// Token: 0x040009B0 RID: 2480
	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x58")]
	public SpriteRenderer SpriteRenderer;
}
