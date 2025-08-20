using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;

// Token: 0x02000283 RID: 643
[Token(Token = "0x2000283")]
public class TileView : TileChunkView
{
	// Token: 0x06000CD7 RID: 3287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x45DA40", Offset = "0x45CC40", VA = "0x18045DA40")]
	public TileView(Vector2Int viewChunkSize, Vector2Int chunkSize, TileMap tileMap)
	{
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD8")]
	[Address(RVA = "0x45CF30", Offset = "0x45C130", VA = "0x18045CF30")]
	public void Reload()
	{
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x45D4A0", Offset = "0x45C6A0", VA = "0x18045D4A0")]
	public void SetTile(int x, int y, TileSprite sprite)
	{
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0x45D860", Offset = "0x45CA60", VA = "0x18045D860")]
	public void UpdateTileSprite(int x, int y)
	{
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0x45CA40", Offset = "0x45BC40", VA = "0x18045CA40", Slot = "9")]
	protected override TileChunk CreateChunk()
	{
		return null;
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0x45CB10", Offset = "0x45BD10", VA = "0x18045CB10", Slot = "10")]
	protected override void DestroyChunk(TileChunk chunk)
	{
	}

	// Token: 0x06000CDD RID: 3293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CDD")]
	[Address(RVA = "0x45CB90", Offset = "0x45BD90", VA = "0x18045CB90", Slot = "11")]
	protected override void LoadChunk(TileChunk chunk)
	{
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0x45D640", Offset = "0x45C840", VA = "0x18045D640", Slot = "12")]
	protected override void UnloadChunk(TileChunk chunk)
	{
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0x45D150", Offset = "0x45C350", VA = "0x18045D150")]
	private void RemoveEffect(Vector2Int worldCoordinates)
	{
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x45D220", Offset = "0x45C420", VA = "0x18045D220")]
	private void RemoveEffects(TileChunk chunk)
	{
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x45D650", Offset = "0x45C850", VA = "0x18045D650")]
	private void UpdateEffect(TileDefinition definition, Vector2Int worldCoordinates)
	{
	}

	// Token: 0x04000AFF RID: 2815
	[Token(Token = "0x4000AFF")]
	[FieldOffset(Offset = "0x50")]
	private readonly TileMap _tileMap;

	// Token: 0x04000B00 RID: 2816
	[Token(Token = "0x4000B00")]
	[FieldOffset(Offset = "0x58")]
	private readonly Dictionary<Vector2Int, EffectBase> _effects;
}
