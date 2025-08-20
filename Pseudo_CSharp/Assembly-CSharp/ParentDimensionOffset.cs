using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A3 RID: 419
[Token(Token = "0x20001A3")]
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
public class ParentDimensionOffset : MonoBehaviour
{
	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000876 RID: 2166 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000CE")]
	protected RectTransform RectTransform
	{
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x419380", Offset = "0x418580", VA = "0x180419380")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000877 RID: 2167 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000CF")]
	protected RectTransform ParentRectTransform
	{
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x419310", Offset = "0x418510", VA = "0x180419310")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00004248 File Offset: 0x00002448
	[Token(Token = "0x6000878")]
	[Address(RVA = "0x4190D0", Offset = "0x4182D0", VA = "0x1804190D0")]
	private float GetParentDimension()
	{
		return 0f;
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000879")]
	[Address(RVA = "0x419170", Offset = "0x418370", VA = "0x180419170")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600087A")]
	[Address(RVA = "0x4192B0", Offset = "0x4184B0", VA = "0x1804192B0")]
	public ParentDimensionOffset()
	{
	}

	// Token: 0x04000839 RID: 2105
	[Token(Token = "0x4000839")]
	[FieldOffset(Offset = "0x20")]
	public Dimension Dimension;

	// Token: 0x0400083A RID: 2106
	[Token(Token = "0x400083A")]
	[FieldOffset(Offset = "0x24")]
	public float RelativeOffset;

	// Token: 0x0400083B RID: 2107
	[Token(Token = "0x400083B")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 OffsetTransform;
}
