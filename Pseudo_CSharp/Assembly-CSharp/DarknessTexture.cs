using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BB RID: 187
[Token(Token = "0x20000BB")]
public class DarknessTexture
{
	// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000333")]
	[Address(RVA = "0x3C2B50", Offset = "0x3C1D50", VA = "0x1803C2B50")]
	public void Reset(int width, int height)
	{
	}

	// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000334")]
	[Address(RVA = "0x3C2D10", Offset = "0x3C1F10", VA = "0x1803C2D10")]
	public void SetDarkness(int x, int y, byte darkness)
	{
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000335")]
	[Address(RVA = "0x3C2DA0", Offset = "0x3C1FA0", VA = "0x1803C2DA0")]
	public void SetRect(Rect rect)
	{
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000336")]
	[Address(RVA = "0x3C2E60", Offset = "0x3C2060", VA = "0x1803C2E60")]
	public void Update()
	{
	}

	// Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000337")]
	[Address(RVA = "0x316100", Offset = "0x315300", VA = "0x180316100")]
	public DarknessTexture()
	{
	}

	// Token: 0x0400031F RID: 799
	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x10")]
	private Texture2D _texture;

	// Token: 0x04000320 RID: 800
	[Token(Token = "0x4000320")]
	[FieldOffset(Offset = "0x18")]
	private Color32[] _colors;

	// Token: 0x04000321 RID: 801
	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0x20")]
	private bool _dirty;

	// Token: 0x04000322 RID: 802
	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x24")]
	private Rect _rect;
}
