using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200026C RID: 620
[Token(Token = "0x200026C")]
public class CeilingView : TileChunkView
{
	// Token: 0x06000BED RID: 3053 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BED")]
	[Address(RVA = "0x436C10", Offset = "0x435E10", VA = "0x180436C10")]
	public CeilingView(Vector2Int viewChunkSize, Vector2Int chunkSize, TileMap tileMap)
	{
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0x4359B0", Offset = "0x434BB0", VA = "0x1804359B0", Slot = "5")]
	public override void GenerateChunks()
	{
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BEF")]
	[Address(RVA = "0x435DE0", Offset = "0x434FE0", VA = "0x180435DE0")]
	public void SetRevealPosition(Vector2 revealPosition, bool force = false)
	{
	}

	// Token: 0x06000BF0 RID: 3056 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0x436B90", Offset = "0x435D90", VA = "0x180436B90")]
	public void UpdateCeilingSprite(int x, int y)
	{
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000BF1")]
	[Address(RVA = "0x4358C0", Offset = "0x434AC0", VA = "0x1804358C0", Slot = "9")]
	protected override TileChunk CreateChunk()
	{
		return null;
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0x435940", Offset = "0x434B40", VA = "0x180435940", Slot = "10")]
	protected override void DestroyChunk(TileChunk chunk)
	{
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF3")]
	[Address(RVA = "0x435A70", Offset = "0x434C70", VA = "0x180435A70", Slot = "11")]
	protected override void LoadChunk(TileChunk chunk)
	{
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF4")]
	[Address(RVA = "0x436940", Offset = "0x435B40", VA = "0x180436940", Slot = "12")]
	protected override void UnloadChunk(TileChunk chunk)
	{
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0x436730", Offset = "0x435930", VA = "0x180436730")]
	private void SetSprite(int x, int y, TileSprite sprite)
	{
	}

	// Token: 0x04000A93 RID: 2707
	[Token(Token = "0x4000A93")]
	[FieldOffset(Offset = "0x50")]
	private readonly TileMap _tileMap;

	// Token: 0x04000A94 RID: 2708
	[Token(Token = "0x4000A94")]
	[FieldOffset(Offset = "0x58")]
	private readonly CeilingReveal _ceilingReveal;

	// Token: 0x04000A95 RID: 2709
	[Token(Token = "0x4000A95")]
	[FieldOffset(Offset = "0x60")]
	private Vector2 _revealPosition;
}
