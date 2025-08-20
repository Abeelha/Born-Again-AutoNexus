using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000285 RID: 645
[Token(Token = "0x2000285")]
public class Blessing : Entity
{
	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x00005460 File Offset: 0x00003660
	[Token(Token = "0x1700014E")]
	public override WorldObjectType Type
	{
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x3BB380", Offset = "0x3BA580", VA = "0x1803BB380", Slot = "13")]
		get
		{
			return (WorldObjectType)0;
		}
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0x44EFE0", Offset = "0x44E1E0", VA = "0x18044EFE0", Slot = "34")]
	protected override void SetTransformPosition(Vector3 position)
	{
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0x44F050", Offset = "0x44E250", VA = "0x18044F050")]
	public Blessing()
	{
	}
}
