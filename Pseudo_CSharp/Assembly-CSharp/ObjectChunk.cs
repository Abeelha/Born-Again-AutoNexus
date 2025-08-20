using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Interfaces;
using UnityEngine;

// Token: 0x0200027A RID: 634
[Token(Token = "0x200027A")]
public class ObjectChunk : IChunk
{
	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00005268 File Offset: 0x00003468
	// (set) Token: 0x06000C81 RID: 3201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000138")]
	public Vector2Int Index
	{
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x3328F0", Offset = "0x331AF0", VA = "0x1803328F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x34E4C0", Offset = "0x34D6C0", VA = "0x18034E4C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00005280 File Offset: 0x00003480
	// (set) Token: 0x06000C83 RID: 3203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000139")]
	public Vector2Int Position
	{
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x3328D0", Offset = "0x331AD0", VA = "0x1803328D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x459F60", Offset = "0x459160", VA = "0x180459F60", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00005298 File Offset: 0x00003498
	// (set) Token: 0x06000C85 RID: 3205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700013A")]
	public Vector2Int Size
	{
		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x3A3060", Offset = "0x3A2260", VA = "0x1803A3060")]
		[CompilerGenerated]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x3A3070", Offset = "0x3A2270", VA = "0x1803A3070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06000C86 RID: 3206 RVA: 0x000052B0 File Offset: 0x000034B0
	// (set) Token: 0x06000C87 RID: 3207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700013B")]
	public Vector2Int Zone
	{
		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x3944E0", Offset = "0x3936E0", VA = "0x1803944E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x459F70", Offset = "0x459170", VA = "0x180459F70", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x459F20", Offset = "0x459120", VA = "0x180459F20")]
	public ObjectChunk(World world)
	{
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C89")]
	[Address(RVA = "0x459960", Offset = "0x458B60", VA = "0x180459960", Slot = "9")]
	public void Create(Vector2Int size)
	{
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0x4598E0", Offset = "0x458AE0", VA = "0x1804598E0")]
	public IEnumerable<WorldObject> AllObjects()
	{
		return null;
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0x4599E0", Offset = "0x458BE0", VA = "0x1804599E0", Slot = "10")]
	public void SetActive(bool active)
	{
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C8C")]
	[Address(RVA = "0x459C50", Offset = "0x458E50", VA = "0x180459C50")]
	public void SetObject(Vector2Int relativeCoord, ushort type, IOverride @override)
	{
	}

	// Token: 0x04000AD3 RID: 2771
	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0x10")]
	private WorldObject[,] _objects;

	// Token: 0x04000AD4 RID: 2772
	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0x18")]
	private readonly World _world;
}
