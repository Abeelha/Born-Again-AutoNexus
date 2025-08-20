using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007D RID: 125
[Token(Token = "0x200007D")]
public static class ObjectFactory
{
	// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000212")]
	[Address(RVA = "0x341030", Offset = "0x340230", VA = "0x180341030")]
	public static void AddNamedPrefab(string name, MonoBehaviour prefab)
	{
	}

	// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000213")]
	[Address(RVA = "0x341220", Offset = "0x340420", VA = "0x180341220")]
	public static void AddPrefabs(MonoBehaviour[] prefabs)
	{
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000214")]
	[Address(RVA = "0x341120", Offset = "0x340320", VA = "0x180341120")]
	public static void AddPrefab(MonoBehaviour prefab)
	{
	}

	// Token: 0x06000215 RID: 533 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000215")]
	public static T Get<T>() where T : MonoBehaviour
	{
		return null;
	}

	// Token: 0x06000216 RID: 534 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000216")]
	public static T Get<T>(Type type) where T : MonoBehaviour
	{
		return null;
	}

	// Token: 0x06000217 RID: 535 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000217")]
	public static T Get<T>(string name) where T : MonoBehaviour
	{
		return null;
	}

	// Token: 0x06000218 RID: 536 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000218")]
	public static T Return<T>(T obj) where T : MonoBehaviour
	{
		return null;
	}

	// Token: 0x06000219 RID: 537 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000219")]
	public static T Return<T>(string name, T obj) where T : MonoBehaviour
	{
		return null;
	}

	// Token: 0x0600021A RID: 538 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600021A")]
	public static T ReturnBase<T>(T obj) where T : MonoBehaviour
	{
		return null;
	}

	// Token: 0x0600021B RID: 539 RVA: 0x000029E8 File Offset: 0x00000BE8
	[Token(Token = "0x600021B")]
	public static bool TryGet<T>(out T component) where T : MonoBehaviour
	{
		return default(bool);
	}

	// Token: 0x04000205 RID: 517
	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<Type, GameObjectPool> s_pools;

	// Token: 0x04000206 RID: 518
	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<string, GameObjectPool> s_namedPools;
}
