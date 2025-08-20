using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000079 RID: 121
[Token(Token = "0x2000079")]
public class LibraryFactory : MonoBehaviour, ILoadable
{
	// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000200")]
	[Address(RVA = "0x33CB70", Offset = "0x33BD70", VA = "0x18033CB70", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000201")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public LibraryFactory()
	{
	}

	// Token: 0x040001F0 RID: 496
	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x20")]
	public BackgroundLibrary Background;

	// Token: 0x040001F1 RID: 497
	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x28")]
	public ColorLibrary Color;

	// Token: 0x040001F2 RID: 498
	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x30")]
	public CursorLibrary Cursor;

	// Token: 0x040001F3 RID: 499
	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x38")]
	public EffectLibrary Effect;

	// Token: 0x040001F4 RID: 500
	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x40")]
	public FontLibrary Font;

	// Token: 0x040001F5 RID: 501
	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x48")]
	public IndicatorLibrary Indicator;

	// Token: 0x040001F6 RID: 502
	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x50")]
	public LightLibrary Light;

	// Token: 0x040001F7 RID: 503
	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x58")]
	public MapObjectLibrary MapObject;

	// Token: 0x040001F8 RID: 504
	[Token(Token = "0x40001F8")]
	[FieldOffset(Offset = "0x60")]
	public MaterialLibrary Material;

	// Token: 0x040001F9 RID: 505
	[Token(Token = "0x40001F9")]
	[FieldOffset(Offset = "0x68")]
	public MeshLibrary Mesh;

	// Token: 0x040001FA RID: 506
	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x70")]
	public MusicLibrary Music;

	// Token: 0x040001FB RID: 507
	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x78")]
	public ObjectLibrary Object;

	// Token: 0x040001FC RID: 508
	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x80")]
	public SfxLibrary Sfx;

	// Token: 0x040001FD RID: 509
	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x88")]
	public SpriteLibrary Sprite;
}
