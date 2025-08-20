using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A7 RID: 423
[Token(Token = "0x20001A7")]
[ExecuteInEditMode]
public class ScreenSizeMax : MonoBehaviour
{
	// Token: 0x0600088A RID: 2186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600088A")]
	[Address(RVA = "0x41A480", Offset = "0x419680", VA = "0x18041A480")]
	private void Awake()
	{
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600088B")]
	[Address(RVA = "0x41A570", Offset = "0x419770", VA = "0x18041A570")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600088C")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ScreenSizeMax()
	{
	}

	// Token: 0x04000845 RID: 2117
	[Token(Token = "0x4000845")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform RectTransform;

	// Token: 0x04000846 RID: 2118
	[Token(Token = "0x4000846")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 Margin;

	// Token: 0x04000847 RID: 2119
	[Token(Token = "0x4000847")]
	[FieldOffset(Offset = "0x30")]
	public bool RetainOriginalDimenions;

	// Token: 0x04000848 RID: 2120
	[Token(Token = "0x4000848")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 _originalDimensions;

	// Token: 0x04000849 RID: 2121
	[Token(Token = "0x4000849")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 _size;
}
