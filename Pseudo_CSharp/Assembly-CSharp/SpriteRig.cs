using System;
using Il2CppDummyDll;
using Ronin.Model.Files.Animation;
using UnityEngine;

// Token: 0x02000151 RID: 337
[Token(Token = "0x2000151")]
public class SpriteRig : MonoBehaviour, IAnimatedObject
{
	// Token: 0x0600062C RID: 1580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600062C")]
	[Address(RVA = "0x3FBC30", Offset = "0x3FAE30", VA = "0x1803FBC30", Slot = "4")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600062D")]
	[Address(RVA = "0x3FBEB0", Offset = "0x3FB0B0", VA = "0x1803FBEB0", Slot = "7")]
	public void SetFlipped(bool value)
	{
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600062E")]
	[Address(RVA = "0x3FBED0", Offset = "0x3FB0D0", VA = "0x1803FBED0", Slot = "5")]
	public void SetLayer(int layer)
	{
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600062F")]
	[Address(RVA = "0x3FBF10", Offset = "0x3FB110", VA = "0x1803FBF10", Slot = "6")]
	public void SetSprite(AnimationFrame frame)
	{
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000630")]
	[Address(RVA = "0x3FBB10", Offset = "0x3FAD10", VA = "0x1803FBB10")]
	public void Set3d(bool flat)
	{
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000631")]
	[Address(RVA = "0x3FBC60", Offset = "0x3FAE60", VA = "0x1803FBC60")]
	public void SetFlat(bool flat)
	{
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000632")]
	[Address(RVA = "0x3FBEF0", Offset = "0x3FB0F0", VA = "0x1803FBEF0")]
	private void SetSortingGroup(int layerId)
	{
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000633")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public SpriteRig()
	{
	}

	// Token: 0x040006A6 RID: 1702
	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0x0")]
	private static int s_shadowLayerId;

	// Token: 0x040006A7 RID: 1703
	[Token(Token = "0x40006A7")]
	[FieldOffset(Offset = "0x4")]
	private static int s_entitiesLayerId;

	// Token: 0x040006A8 RID: 1704
	[Token(Token = "0x40006A8")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer SpriteRenderer;
}
