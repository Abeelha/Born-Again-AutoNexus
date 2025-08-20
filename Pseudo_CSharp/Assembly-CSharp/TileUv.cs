using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000282 RID: 642
[Token(Token = "0x2000282")]
public struct TileUv
{
	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00005430 File Offset: 0x00003630
	// (set) Token: 0x06000CCE RID: 3278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700014C")]
	public int SpriteCount
	{
		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x3F3370", Offset = "0x3F2570", VA = "0x1803F3370")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x3F3380", Offset = "0x3F2580", VA = "0x1803F3380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0x45CA00", Offset = "0x45BC00", VA = "0x18045CA00")]
	public TileUv(Vector2[] uv, Vector2 noneUv)
	{
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0x45C0C0", Offset = "0x45B2C0", VA = "0x18045C0C0")]
	public void ApplyUv(Mesh mesh)
	{
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0x45C080", Offset = "0x45B280", VA = "0x18045C080")]
	public void ApplyUv2(Mesh mesh)
	{
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0x45C3E0", Offset = "0x45B5E0", VA = "0x18045C3E0")]
	public void Insert(Vector2 uv, int tileIndex)
	{
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0x45C100", Offset = "0x45B300", VA = "0x18045C100")]
	public void Insert(Sprite sprite, int tileIndex)
	{
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0x45C4D0", Offset = "0x45B6D0", VA = "0x18045C4D0")]
	public void Insert(TileSprite tileSprite, int tileIndex)
	{
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x45C8C0", Offset = "0x45BAC0", VA = "0x18045C8C0")]
	public void Remove(int tileIndex)
	{
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x45C9F0", Offset = "0x45BBF0", VA = "0x18045C9F0")]
	public void SetDirty()
	{
	}

	// Token: 0x04000AFA RID: 2810
	[Token(Token = "0x4000AFA")]
	private const float TexelOffset = 0.01f;

	// Token: 0x04000AFB RID: 2811
	[Token(Token = "0x4000AFB")]
	[FieldOffset(Offset = "0x0")]
	private readonly Vector2[] _uv;

	// Token: 0x04000AFC RID: 2812
	[Token(Token = "0x4000AFC")]
	[FieldOffset(Offset = "0x8")]
	private bool _dirty;

	// Token: 0x04000AFD RID: 2813
	[Token(Token = "0x4000AFD")]
	[FieldOffset(Offset = "0xC")]
	private readonly Vector2 _noneUv;
}
