using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200027F RID: 639
[Token(Token = "0x200027F")]
public abstract class TileChunkView : ChunkView<TileChunk>
{
	// Token: 0x06000CBB RID: 3259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBB")]
	[Address(RVA = "0x45B4F0", Offset = "0x45A6F0", VA = "0x18045B4F0")]
	protected TileChunkView(Vector2Int viewChunkSize, Vector2Int chunkSize)
	{
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBC")]
	[Address(RVA = "0x45AFF0", Offset = "0x45A1F0", VA = "0x18045AFF0")]
	public void SetMaterial(Material material)
	{
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x45B200", Offset = "0x45A400", VA = "0x18045B200")]
	public void SetSortingLayer(string name)
	{
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBE")]
	[Address(RVA = "0x45B410", Offset = "0x45A610", VA = "0x18045B410")]
	public void SetTexture(Texture texture)
	{
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBF")]
	[Address(RVA = "0x45AEC0", Offset = "0x45A0C0", VA = "0x18045AEC0")]
	protected void ApplyValues(TileChunk chunk)
	{
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0x45AF30", Offset = "0x45A130", VA = "0x18045AF30", Slot = "9")]
	protected override TileChunk CreateChunk()
	{
		return null;
	}

	// Token: 0x04000AF1 RID: 2801
	[Token(Token = "0x4000AF1")]
	[FieldOffset(Offset = "0x40")]
	private string _sortingLayer;

	// Token: 0x04000AF2 RID: 2802
	[Token(Token = "0x4000AF2")]
	[FieldOffset(Offset = "0x48")]
	private Material _material;
}
