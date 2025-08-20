using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000208 RID: 520
[Token(Token = "0x2000208")]
public class CloudEffect : EffectBase
{
	// Token: 0x06000A82 RID: 2690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A82")]
	[Address(RVA = "0x423A80", Offset = "0x422C80", VA = "0x180423A80", Slot = "7")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x4239B0", Offset = "0x422BB0", VA = "0x1804239B0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A84")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public CloudEffect()
	{
	}

	// Token: 0x0400099F RID: 2463
	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0x50")]
	public Sprite[] CloudSprites;

	// Token: 0x040009A0 RID: 2464
	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x58")]
	private bool _offset;
}
