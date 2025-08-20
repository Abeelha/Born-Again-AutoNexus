using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000272 RID: 626
[Token(Token = "0x2000272")]
public abstract class ChunkView
{
	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06000C26 RID: 3110 RVA: 0x000050E8 File Offset: 0x000032E8
	[Token(Token = "0x1700012B")]
	public Vector2Int ViewChunkSize
	{
		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x3328E0", Offset = "0x331AE0", VA = "0x1803328E0")]
		get
		{
			return default(Vector2Int);
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00005100 File Offset: 0x00003300
	[Token(Token = "0x1700012C")]
	public Vector2Int ChunkSize
	{
		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x32A4B0", Offset = "0x3296B0", VA = "0x18032A4B0")]
		get
		{
			return default(Vector2Int);
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06000C28 RID: 3112 RVA: 0x00005118 File Offset: 0x00003318
	[Token(Token = "0x1700012D")]
	public Vector2Int ViewPosition
	{
		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x3328F0", Offset = "0x331AF0", VA = "0x1803328F0")]
		get
		{
			return default(Vector2Int);
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00005130 File Offset: 0x00003330
	// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012E")]
	public bool Active
	{
		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x436E80", Offset = "0x436080", VA = "0x180436E80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x436D50", Offset = "0x435F50", VA = "0x180436D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x436E40", Offset = "0x436040", VA = "0x180436E40")]
	public ChunkView(Vector2Int viewChunkSize, Vector2Int chunkSize)
	{
	}

	// Token: 0x06000C2C RID: 3116
	[Token(Token = "0x6000C2C")]
	public abstract void Destroy();

	// Token: 0x06000C2D RID: 3117
	[Token(Token = "0x6000C2D")]
	public abstract void GenerateChunks();

	// Token: 0x06000C2E RID: 3118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0x436D50", Offset = "0x435F50", VA = "0x180436D50", Slot = "6")]
	public virtual void SetActive(bool active)
	{
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x436D60", Offset = "0x435F60", VA = "0x180436D60", Slot = "7")]
	public virtual void SetViewChunkSize(Vector2Int viewChunkSize)
	{
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x436E10", Offset = "0x436010", VA = "0x180436E10", Slot = "8")]
	public virtual void SetViewPosition(Vector2 vecPosition)
	{
	}

	// Token: 0x04000AA8 RID: 2728
	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x10")]
	private Vector2Int _viewChunkSize;

	// Token: 0x04000AA9 RID: 2729
	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x18")]
	private readonly Vector2Int _chunkSize;

	// Token: 0x04000AAA RID: 2730
	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x20")]
	private Vector2Int _viewPosition;
}
