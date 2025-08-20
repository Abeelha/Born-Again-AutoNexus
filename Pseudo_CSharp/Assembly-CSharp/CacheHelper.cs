using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000025 RID: 37
[Token(Token = "0x2000025")]
public static class CacheHelper
{
	// Token: 0x060000D8 RID: 216 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x31B710", Offset = "0x31A910", VA = "0x18031B710")]
	public static List<Gizmo> GetGizmoList()
	{
		return null;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x31B850", Offset = "0x31AA50", VA = "0x18031B850")]
	public static HashSet<WorldObject> GetWorldObjectHashSet()
	{
		return null;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x31B990", Offset = "0x31AB90", VA = "0x18031B990")]
	public static void ReturnGizmoList(List<Gizmo> list)
	{
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x31BAA0", Offset = "0x31ACA0", VA = "0x18031BAA0")]
	public static void ReturnWorldObjectHashSet(HashSet<WorldObject> hashSet)
	{
	}

	// Token: 0x040000B8 RID: 184
	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly List<HashSet<uint>> s_uintHashSetList;

	// Token: 0x040000B9 RID: 185
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x8")]
	private static readonly List<HashSet<WorldObject>> s_worldObjectHashSetList;

	// Token: 0x040000BA RID: 186
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x10")]
	private static readonly List<List<Gizmo>> s_gizmoListList;
}
