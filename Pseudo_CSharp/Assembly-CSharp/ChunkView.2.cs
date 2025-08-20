using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000273 RID: 627
[Token(Token = "0x2000273")]
public abstract class ChunkView<T> : ChunkView where T : IChunk
{
	// Token: 0x06000C31 RID: 3121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C31")]
	public ChunkView(Vector2Int viewChunkSize, Vector2Int chunkSize)
	{
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C32")]
	public override void Destroy()
	{
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C33")]
	public override void GenerateChunks()
	{
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C34")]
	public override void SetActive(bool active)
	{
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C35")]
	public override void SetViewPosition(Vector2 vecPosition)
	{
	}

	// Token: 0x06000C36 RID: 3126 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C36")]
	protected IEnumerable<T> AllChunks()
	{
		return null;
	}

	// Token: 0x06000C37 RID: 3127
	[Token(Token = "0x6000C37")]
	protected abstract T CreateChunk();

	// Token: 0x06000C38 RID: 3128
	[Token(Token = "0x6000C38")]
	protected abstract void DestroyChunk(T chunk);

	// Token: 0x06000C39 RID: 3129
	[Token(Token = "0x6000C39")]
	protected abstract void LoadChunk(T chunk);

	// Token: 0x06000C3A RID: 3130
	[Token(Token = "0x6000C3A")]
	protected abstract void UnloadChunk(T chunk);

	// Token: 0x06000C3B RID: 3131 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000C3B")]
	protected T GetChunkFor(int x, int y)
	{
		return null;
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x00005148 File Offset: 0x00003348
	[Token(Token = "0x6000C3C")]
	private Vector2Int GetChunkIndex(int x, int y)
	{
		return default(Vector2Int);
	}

	// Token: 0x06000C3D RID: 3133 RVA: 0x00005160 File Offset: 0x00003360
	[Token(Token = "0x6000C3D")]
	private Vector2Int GetChunkPosition(Vector2Int chunkZone, Vector2Int chunkIndex)
	{
		return default(Vector2Int);
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x00005178 File Offset: 0x00003378
	[Token(Token = "0x6000C3E")]
	private Vector2Int GetChunkZone(int viewX, int viewY, Vector2Int chunkIndex)
	{
		return default(Vector2Int);
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C3F")]
	private void MoveChunk(T chunk, Vector2Int chunkZone)
	{
	}

	// Token: 0x04000AAC RID: 2732
	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x0")]
	private Vector2Int _min;

	// Token: 0x04000AAD RID: 2733
	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x0")]
	private T[,] _chunks;
}
