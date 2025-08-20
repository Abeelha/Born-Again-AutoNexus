using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Ronin.Model.Definitions;
using UnityEngine;

// Token: 0x02000281 RID: 641
[Token(Token = "0x2000281")]
public struct TileSprite
{
	// Token: 0x06000CC7 RID: 3271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x45C000", Offset = "0x45B200", VA = "0x18045C000")]
	public TileSprite(TileDefinition definition, Sprite sprite, int rotation, bool mirrorX, bool mirrorY)
	{
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000147")]
	public TileDefinition Definition
	{
		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x405340", Offset = "0x404540", VA = "0x180405340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000148")]
	public Sprite Sprite
	{
		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x405350", Offset = "0x404550", VA = "0x180405350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06000CCA RID: 3274 RVA: 0x000053E8 File Offset: 0x000035E8
	[Token(Token = "0x17000149")]
	public int Rotation
	{
		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x329390", Offset = "0x328590", VA = "0x180329390")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00005400 File Offset: 0x00003600
	[Token(Token = "0x1700014A")]
	public bool MirrorX
	{
		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x45C060", Offset = "0x45B260", VA = "0x18045C060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00005418 File Offset: 0x00003618
	[Token(Token = "0x1700014B")]
	public bool MirrorY
	{
		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x45C070", Offset = "0x45B270", VA = "0x18045C070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}
}
