using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000CF RID: 207
[Token(Token = "0x20000CF")]
public class ZoneObj : MonoBehaviour
{
	// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039A")]
	[Address(RVA = "0x3D3630", Offset = "0x3D2830", VA = "0x1803D3630")]
	public void Setup(Vector2Int coordinates)
	{
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039B")]
	[Address(RVA = "0x31CC80", Offset = "0x31BE80", VA = "0x18031CC80")]
	public ZoneObj()
	{
	}

	// Token: 0x04000383 RID: 899
	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer SpriteRenderer;

	// Token: 0x04000384 RID: 900
	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x28")]
	public TMP_Text Label;
}
