using System;
using System.IO;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000040 RID: 64
[Token(Token = "0x2000040")]
public class DiscoveryTexture
{
	// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x31FE80", Offset = "0x31F080", VA = "0x18031FE80")]
	private DiscoveryTexture(string mapFileName, Vector2Int mapSize)
	{
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000151")]
	[Address(RVA = "0x31F850", Offset = "0x31EA50", VA = "0x18031F850")]
	public static DiscoveryTexture Load(string mapFileName, Vector2Int size)
	{
		return null;
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000152")]
	[Address(RVA = "0x31F960", Offset = "0x31EB60", VA = "0x18031F960")]
	private void OnChange(Option option)
	{
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x31F3A0", Offset = "0x31E5A0", VA = "0x18031F3A0")]
	public void Assign()
	{
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x31F5A0", Offset = "0x31E7A0", VA = "0x18031F5A0")]
	public void DiscoverArea(Vector2 coordinates)
	{
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x31F670", Offset = "0x31E870", VA = "0x18031F670")]
	public void Discovered(int x, int y)
	{
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000156")]
	[Address(RVA = "0x31F750", Offset = "0x31E950", VA = "0x18031F750")]
	public void Dispose()
	{
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x31FA50", Offset = "0x31EC50", VA = "0x18031FA50")]
	public void Save()
	{
	}

	// Token: 0x06000158 RID: 344 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x31F970", Offset = "0x31EB70", VA = "0x18031F970")]
	public Task SaveAsync()
	{
		return null;
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000159")]
	[Address(RVA = "0x31FCC0", Offset = "0x31EEC0", VA = "0x18031FCC0")]
	public void Update()
	{
	}

	// Token: 0x04000126 RID: 294
	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x10")]
	private string _mapFileName;

	// Token: 0x04000127 RID: 295
	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x18")]
	private Vector2Int _mapSize;

	// Token: 0x04000128 RID: 296
	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x20")]
	private Vector2Int _textureSize;

	// Token: 0x04000129 RID: 297
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x28")]
	private Texture2D _texture;

	// Token: 0x0400012A RID: 298
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x30")]
	private bool[] _discovered;

	// Token: 0x0400012B RID: 299
	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x38")]
	private Color32[] _colors;

	// Token: 0x0400012C RID: 300
	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x40")]
	private bool _dirty;

	// Token: 0x0400012D RID: 301
	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x48")]
	private Option _enabledOption;

	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	private struct DiscoveryFile
	{
		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x31F2B0", Offset = "0x31E4B0", VA = "0x18031F2B0")]
		public void Write(BinaryWriter writer)
		{
		}

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x0")]
		public Vector2Int Size;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x8")]
		public bool[] Discovered;
	}
}
