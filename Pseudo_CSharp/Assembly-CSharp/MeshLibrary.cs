using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AC RID: 172
[Token(Token = "0x20000AC")]
public class MeshLibrary : ScriptableObject, ILoadable
{
	// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x340640", Offset = "0x33F840", VA = "0x180340640")]
	public void Add(string model, Mesh mesh, Sprite sprite)
	{
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x3407A0", Offset = "0x33F9A0", VA = "0x1803407A0")]
	public void Clear()
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x340930", Offset = "0x33FB30", VA = "0x180340930")]
	public Mesh GetRaw(string name)
	{
		return null;
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x3409C0", Offset = "0x33FBC0", VA = "0x1803409C0")]
	public Mesh Get(Sprite sprite)
	{
		return null;
	}

	// Token: 0x060002FA RID: 762 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x340830", Offset = "0x33FA30", VA = "0x180340830")]
	public MeshMetaData GetMetaData(Sprite sprite)
	{
		return null;
	}

	// Token: 0x060002FB RID: 763 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x3408B0", Offset = "0x33FAB0", VA = "0x1803408B0")]
	public MeshMetaData GetMetaData(string model)
	{
		return null;
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x340B60", Offset = "0x33FD60", VA = "0x180340B60", Slot = "4")]
	public void Load()
	{
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x340C90", Offset = "0x33FE90", VA = "0x180340C90")]
	public MeshLibrary()
	{
	}

	// Token: 0x040002E5 RID: 741
	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x18")]
	public Mesh[] Meshes;

	// Token: 0x040002E6 RID: 742
	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x20")]
	private readonly Dictionary<Sprite, Mesh> _spriteMap;

	// Token: 0x040002E7 RID: 743
	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x28")]
	private readonly Dictionary<Sprite, MeshMetaData> _spriteMapMetaData;

	// Token: 0x040002E8 RID: 744
	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x30")]
	private readonly Dictionary<string, MeshMetaData> _modelMapMetaData;

	// Token: 0x040002E9 RID: 745
	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<string, Mesh> _meshes;
}
