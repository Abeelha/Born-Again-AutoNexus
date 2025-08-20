using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007B RID: 123
[Token(Token = "0x200007B")]
public static class MapFactory
{
	// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000204")]
	[Address(RVA = "0x33F4D0", Offset = "0x33E6D0", VA = "0x18033F4D0")]
	public static void AddPrefabs(GameObject[] prefabs)
	{
	}

	// Token: 0x06000205 RID: 517 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000205")]
	[Address(RVA = "0x33F650", Offset = "0x33E850", VA = "0x18033F650")]
	public static GameObject Get(WorldObjectType type)
	{
		return null;
	}

	// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000206")]
	[Address(RVA = "0x33F700", Offset = "0x33E900", VA = "0x18033F700")]
	public static void Return(WorldObjectType type, GameObject gameObject)
	{
	}

	// Token: 0x040001FE RID: 510
	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<WorldObjectType, GameObjectPool> s_pools;
}
