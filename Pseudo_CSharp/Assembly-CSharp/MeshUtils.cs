using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D6 RID: 470
[Token(Token = "0x20001D6")]
public static class MeshUtils
{
	// Token: 0x06000972 RID: 2418 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000972")]
	[Address(RVA = "0x428510", Offset = "0x427710", VA = "0x180428510")]
	public static Mesh ApplyTimeAndColors(Mesh mesh, Color32 color, float time)
	{
		return null;
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000973")]
	[Address(RVA = "0x4286B0", Offset = "0x4278B0", VA = "0x1804286B0")]
	public static Mesh CreateArcMesh(int spread)
	{
		return null;
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00004608 File Offset: 0x00002808
	[Token(Token = "0x6000974")]
	[Address(RVA = "0x429720", Offset = "0x428920", VA = "0x180429720")]
	private static Vector2 RotateVector(Vector2 vector, float angle)
	{
		return default(Vector2);
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000975")]
	[Address(RVA = "0x429180", Offset = "0x428380", VA = "0x180429180")]
	public static Mesh CreateTiled(int width, int height, Vector2 noneUv)
	{
		return null;
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000976")]
	[Address(RVA = "0x428DA0", Offset = "0x427FA0", VA = "0x180428DA0")]
	public static int[] CreateTiledIndices(int meshWidth, int meshHeight)
	{
		return null;
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000977")]
	[Address(RVA = "0x428EA0", Offset = "0x4280A0", VA = "0x180428EA0")]
	public static Vector2[] CreateTiledUvs(int meshWidth, int meshHeight, Vector2 noneUv)
	{
		return null;
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000978")]
	[Address(RVA = "0x428F80", Offset = "0x428180", VA = "0x180428F80")]
	public static Vector3[] CreateTiledVertices(int meshWidth, int meshHeight, float vertexOffset = 0f)
	{
		return null;
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000979")]
	[Address(RVA = "0x4293F0", Offset = "0x4285F0", VA = "0x1804293F0")]
	public static Mesh MapUvsToSprite(this Mesh mesh, Sprite sprite)
	{
		return null;
	}

	// Token: 0x040008EA RID: 2282
	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<int, Mesh> s_arcMeshes;
}
