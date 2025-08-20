using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200021D RID: 541
[Token(Token = "0x200021D")]
public class HomeEffect : EffectBase
{
	// Token: 0x06000AA2 RID: 2722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA2")]
	[Address(RVA = "0x428230", Offset = "0x427430", VA = "0x180428230")]
	public void StartEffect()
	{
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA3")]
	[Address(RVA = "0x428020", Offset = "0x427220", VA = "0x180428020", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA4")]
	[Address(RVA = "0x428070", Offset = "0x427270", VA = "0x180428070")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public HomeEffect()
	{
	}

	// Token: 0x040009AA RID: 2474
	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x50")]
	private float _progress;

	// Token: 0x040009AB RID: 2475
	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0x58")]
	public SpriteRenderer SpriteRenderer;
}
