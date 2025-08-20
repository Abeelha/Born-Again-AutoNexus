using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;

// Token: 0x02000299 RID: 665
[Token(Token = "0x2000299")]
public class BossUI : MonoBehaviour
{
	// Token: 0x06000E4A RID: 3658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E4A")]
	[Address(RVA = "0x44F4E0", Offset = "0x44E6E0", VA = "0x18044F4E0")]
	public void SetBosses(IEnumerable<Entity> bosses)
	{
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0x44F4B0", Offset = "0x44E6B0", VA = "0x18044F4B0")]
	private void Awake()
	{
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0x44FC70", Offset = "0x44EE70", VA = "0x18044FC70")]
	public BossUI()
	{
	}

	// Token: 0x04000B93 RID: 2963
	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x20")]
	public BossHealth BossHealthPrefab;

	// Token: 0x04000B94 RID: 2964
	[Token(Token = "0x4000B94")]
	[FieldOffset(Offset = "0x28")]
	public World World;

	// Token: 0x04000B95 RID: 2965
	[Token(Token = "0x4000B95")]
	[FieldOffset(Offset = "0x30")]
	public float Spacing;

	// Token: 0x04000B96 RID: 2966
	[Token(Token = "0x4000B96")]
	[FieldOffset(Offset = "0x34")]
	public float MultiSizeIncrease;

	// Token: 0x04000B97 RID: 2967
	[Token(Token = "0x4000B97")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<ValueTuple<ObjectDefinition, BossHealth>> _healths;
}
