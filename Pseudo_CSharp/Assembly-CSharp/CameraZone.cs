using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000284 RID: 644
[Token(Token = "0x2000284")]
public class CameraZone
{
	// Token: 0x06000CE2 RID: 3298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x4507E0", Offset = "0x44F9E0", VA = "0x1804507E0")]
	public CameraZone(Vector2Int point)
	{
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00005448 File Offset: 0x00003648
	[Token(Token = "0x1700014D")]
	public RectInt Bounds
	{
		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x450860", Offset = "0x44FA60", VA = "0x180450860")]
		get
		{
			return default(RectInt);
		}
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE4")]
	[Address(RVA = "0x450530", Offset = "0x44F730", VA = "0x180450530")]
	public void Add(Vector2Int point)
	{
	}

	// Token: 0x04000B01 RID: 2817
	[Token(Token = "0x4000B01")]
	[FieldOffset(Offset = "0x10")]
	private RectInt _bounds;
}
