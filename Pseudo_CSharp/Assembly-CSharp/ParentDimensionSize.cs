using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A4 RID: 420
[Token(Token = "0x20001A4")]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class ParentDimensionSize : MonoBehaviour
{
	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x0600087B RID: 2171 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000D0")]
	protected RectTransform RectTransform
	{
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x419720", Offset = "0x418920", VA = "0x180419720")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x0600087C RID: 2172 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x170000D1")]
	protected RectTransform ParentRectTransform
	{
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x4196B0", Offset = "0x4188B0", VA = "0x1804196B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x00004260 File Offset: 0x00002460
	[Token(Token = "0x600087D")]
	[Address(RVA = "0x4193E0", Offset = "0x4185E0", VA = "0x1804193E0")]
	private float GetParentDimension()
	{
		return 0f;
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600087E")]
	[Address(RVA = "0x419480", Offset = "0x418680", VA = "0x180419480")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600087F")]
	[Address(RVA = "0x419640", Offset = "0x418840", VA = "0x180419640")]
	public ParentDimensionSize()
	{
	}

	// Token: 0x0400083C RID: 2108
	[Token(Token = "0x400083C")]
	[FieldOffset(Offset = "0x20")]
	public Dimension Dimension;

	// Token: 0x0400083D RID: 2109
	[Token(Token = "0x400083D")]
	[FieldOffset(Offset = "0x24")]
	public float RelativeSize;

	// Token: 0x0400083E RID: 2110
	[Token(Token = "0x400083E")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 OffsetTransform;

	// Token: 0x0400083F RID: 2111
	[Token(Token = "0x400083F")]
	[FieldOffset(Offset = "0x30")]
	public bool SetHeight;

	// Token: 0x04000840 RID: 2112
	[Token(Token = "0x4000840")]
	[FieldOffset(Offset = "0x31")]
	public bool SetWidth;
}
