using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200026B RID: 619
[Token(Token = "0x200026B")]
public class BlendView : TileChunkView
{
	// Token: 0x06000BE4 RID: 3044 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x434BB0", Offset = "0x433DB0", VA = "0x180434BB0")]
	public BlendView(Vector2Int viewChunkSize, Vector2Int chunkSize, TileMap tileMap)
	{
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BE5")]
	[Address(RVA = "0x4342F0", Offset = "0x4334F0", VA = "0x1804342F0", Slot = "5")]
	public override void GenerateChunks()
	{
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x434B00", Offset = "0x433D00", VA = "0x180434B00")]
	public void UpdateBlend(int x, int y)
	{
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0x4341D0", Offset = "0x4333D0", VA = "0x1804341D0", Slot = "9")]
	protected override TileChunk CreateChunk()
	{
		return null;
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x434280", Offset = "0x433480", VA = "0x180434280", Slot = "10")]
	protected override void DestroyChunk(TileChunk chunk)
	{
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x434570", Offset = "0x433770", VA = "0x180434570", Slot = "11")]
	protected override void LoadChunk(TileChunk chunk)
	{
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x00004F98 File Offset: 0x00003198
	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0x4343D0", Offset = "0x4335D0", VA = "0x1804343D0")]
	private ValueTuple<int[], int> GetBlend(int x, int y)
	{
		return default(ValueTuple<int[], int>);
	}

	// Token: 0x06000BEB RID: 3051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0x434790", Offset = "0x433990", VA = "0x180434790")]
	private void UpdateBlendSprite(int x, int y, TileChunk chunk)
	{
	}

	// Token: 0x06000BEC RID: 3052 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "12")]
	protected override void UnloadChunk(TileChunk chunk)
	{
	}

	// Token: 0x04000A92 RID: 2706
	[Token(Token = "0x4000A92")]
	[FieldOffset(Offset = "0x50")]
	private readonly TileMap _tileMap;
}
