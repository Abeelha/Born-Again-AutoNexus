using System;
using Il2CppDummyDll;
using Ronin.Model.Structs;
using UnityEngine;

// Token: 0x02000280 RID: 640
[Token(Token = "0x2000280")]
public class TileMap
{
	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00005388 File Offset: 0x00003588
	[Token(Token = "0x17000146")]
	public Vector2Int Size
	{
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x3328E0", Offset = "0x331AE0", VA = "0x1803328E0")]
		get
		{
			return default(Vector2Int);
		}
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x45BF80", Offset = "0x45B180", VA = "0x18045BF80")]
	public TileMap(Vector2Int size)
	{
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x000053A0 File Offset: 0x000035A0
	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0x45BB30", Offset = "0x45AD30", VA = "0x18045BB30")]
	public TileSprite GetCeilingSprite(int x, int y)
	{
		return default(TileSprite);
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x000053B8 File Offset: 0x000035B8
	[Token(Token = "0x6000CC4")]
	[Address(RVA = "0x45BE90", Offset = "0x45B090", VA = "0x18045BE90")]
	public Tile GetTile(int x, int y)
	{
		return default(Tile);
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x000053D0 File Offset: 0x000035D0
	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x45BCE0", Offset = "0x45AEE0", VA = "0x18045BCE0")]
	public TileSprite GetTileSprite(int x, int y)
	{
		return default(TileSprite);
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x45BF00", Offset = "0x45B100", VA = "0x18045BF00")]
	public void SetTile(CoordTile coordTile)
	{
	}

	// Token: 0x04000AF3 RID: 2803
	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0x10")]
	private readonly Vector2Int _size;

	// Token: 0x04000AF4 RID: 2804
	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0x18")]
	private readonly Tile[,] _tileMap;
}
