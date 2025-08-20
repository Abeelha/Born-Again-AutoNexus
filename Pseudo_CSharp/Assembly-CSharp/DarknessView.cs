using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000276 RID: 630
[Token(Token = "0x2000276")]
public class DarknessView : TileChunkView
{
	// Token: 0x06000C50 RID: 3152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x434BB0", Offset = "0x433DB0", VA = "0x180434BB0")]
	public DarknessView(Vector2Int viewChunkSize, Vector2Int chunkSize, TileMap tileMap)
	{
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x437D50", Offset = "0x436F50", VA = "0x180437D50", Slot = "5")]
	public override void GenerateChunks()
	{
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x438200", Offset = "0x437400", VA = "0x180438200")]
	public void UpdateDarkness(int x, int y)
	{
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x437C60", Offset = "0x436E60", VA = "0x180437C60", Slot = "9")]
	protected override TileChunk CreateChunk()
	{
		return null;
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C54")]
	[Address(RVA = "0x437CE0", Offset = "0x436EE0", VA = "0x180437CE0", Slot = "10")]
	protected override void DestroyChunk(TileChunk chunk)
	{
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x437E10", Offset = "0x437010", VA = "0x180437E10", Slot = "11")]
	protected override void LoadChunk(TileChunk chunk)
	{
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x316090", Offset = "0x315290", VA = "0x180316090", Slot = "12")]
	protected override void UnloadChunk(TileChunk chunk)
	{
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C57")]
	[Address(RVA = "0x438100", Offset = "0x437300", VA = "0x180438100")]
	private void SetDarkness(int x, int y, byte darkness)
	{
	}

	// Token: 0x04000AB3 RID: 2739
	[Token(Token = "0x4000AB3")]
	[FieldOffset(Offset = "0x50")]
	private readonly TileMap _tileMap;
}
