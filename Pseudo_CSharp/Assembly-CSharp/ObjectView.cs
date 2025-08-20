using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Interfaces;
using UnityEngine;

// Token: 0x0200027C RID: 636
[Token(Token = "0x200027C")]
public class ObjectView : ChunkView<ObjectChunk>
{
	// Token: 0x06000C96 RID: 3222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x45A780", Offset = "0x459980", VA = "0x18045A780")]
	public ObjectView(Vector2Int viewChunkSize, Vector2Int chunkSize, TileMap tileMap, World world, Func<Vector2Int, IOverride> overrideGetter)
	{
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C97")]
	[Address(RVA = "0x45A550", Offset = "0x459750", VA = "0x18045A550")]
	public void SetObject(int x, int y, ushort type, IOverride @override)
	{
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x45A5F0", Offset = "0x4597F0", VA = "0x18045A5F0")]
	public void UpdateObject(int x, int y)
	{
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x45A1D0", Offset = "0x4593D0", VA = "0x18045A1D0")]
	public IEnumerable<WorldObject> GetObjects()
	{
		return null;
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x459F80", Offset = "0x459180", VA = "0x180459F80", Slot = "9")]
	protected override ObjectChunk CreateChunk()
	{
		return null;
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x459FF0", Offset = "0x4591F0", VA = "0x180459FF0", Slot = "10")]
	protected override void DestroyChunk(ObjectChunk chunk)
	{
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x45A250", Offset = "0x459450", VA = "0x18045A250", Slot = "11")]
	protected override void LoadChunk(ObjectChunk chunk)
	{
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "12")]
	protected override void UnloadChunk(ObjectChunk chunk)
	{
	}

	// Token: 0x04000ADE RID: 2782
	[Token(Token = "0x4000ADE")]
	[FieldOffset(Offset = "0x40")]
	private readonly TileMap _tileMap;

	// Token: 0x04000ADF RID: 2783
	[Token(Token = "0x4000ADF")]
	[FieldOffset(Offset = "0x48")]
	private readonly World _world;

	// Token: 0x04000AE0 RID: 2784
	[Token(Token = "0x4000AE0")]
	[FieldOffset(Offset = "0x50")]
	private readonly Func<Vector2Int, IOverride> _overrideGetter;
}
